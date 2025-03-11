Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System.IO.Ports
Imports System.Drawing.Imaging
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports AForge.Imaging
Imports AForge.Imaging.Filters
Imports AForge.Math

Public Class GateExitForm
    Private videoDevice As VideoCaptureDevice
    Private barcodeReader As BarcodeReader
    Private serialPort As New SerialPort("COM1", 9600) 'untuk gate barrier
    Private currentParkingData As ParkingData
    Private connectionString As String = "Server=localhost;Database=db_parkir;Uid=root;Pwd=;"
    Private dailyTransactions As New List(Of ParkingTransaction)
    Private isManualOverride As Boolean = False
    Private lostTicketFee As Decimal = 50000 ' Default fee for lost tickets
    Private entryImage As Bitmap
    Private exitImage As Bitmap
    Private ticketData As DataRow = Nothing
    Private photoVerified As Boolean = False

    ' Struktur data untuk menyimpan informasi parkir
    Private Class ParkingData
        Public ParkingID As Integer
        Public TicketNo As String
        Public PlateNumber As String
        Public EntryTime As DateTime
        Public VehicleTypeID As Integer
        Public EntryPhoto As String
        Public ParkingFee As Decimal
        Public IsLostTicket As Boolean = False
    End Class

    ' Struktur data untuk menyimpan transaksi
    Private Class ParkingTransaction
        Public TransactionID As Integer
        Public ParkingID As Integer
        Public ExitTime As DateTime
        Public ParkingFee As Decimal
        Public OperatorName As String
        Public PaymentMethod As String
    End Class

    ' Add new class members
    Private Class PaymentInfo
        Public Method As String
        Public Amount As Decimal
        Public DiscountAmount As Decimal
        Public FinalAmount As Decimal
        Public Reference As String
    End Class

    Private currentPayment As PaymentInfo
    Private discountTypes As New Dictionary(Of String, Decimal)
    Private currentExitPhoto As String
    Private photoComparisonActive As Boolean = False

    ' Add new class members for photo comparison
    Private Class ComparisonResult
        Public HistogramScore As Double
        Public FeatureMatchScore As Double
        Public StructuralScore As Double
        Public OverallScore As Double
        Public IsMatch As Boolean
    End Class

    Private Const HISTOGRAM_WEIGHT As Double = 0.4
    Private Const FEATURE_WEIGHT As Double = 0.3
    Private Const STRUCTURAL_WEIGHT As Double = 0.3
    Private Const MATCH_THRESHOLD As Double = 0.7 ' 70% similarity required for a match

    ' Form Load
    Private Sub GateExitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeCamera()
        InitializeBarcodeReader()
        LoadSettings()
        
        ' Tampilkan waktu dan tanggal
        Timer1.Start()
        lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy")
        lblTime.Text = DateTime.Now.ToString("H:mm tt")
        
        ' Load daily transactions
        LoadDailyTransactions()
        
        ' Initialize discount types
        LoadDiscountTypes()
        
        ' Initialize payment methods combo box
        ComboBoxPaymentMethod.Items.AddRange({"Cash", "Credit Card", "Debit Card", "E-Wallet"})
        ComboBoxPaymentMethod.SelectedIndex = 0
        
        ' Initialize discount combo box
        ComboBoxDiscount.Items.Add("No Discount")
        For Each discount In discountTypes
            ComboBoxDiscount.Items.Add(discount.Key)
        Next
        ComboBoxDiscount.SelectedIndex = 0
    End Sub

    ' Load Settings
    Private Sub LoadSettings()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT SettingValue FROM Settings WHERE SettingName = 'LostTicketFee'", conn)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    lostTicketFee = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception
            ' Use default value if settings can't be loaded
        End Try
    End Sub

    ' Load Daily Transactions
    Private Sub LoadDailyTransactions()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM parkir_masuk WHERE tanggal_keluar = CONVERT(date, GETDATE())", conn)
                
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim transaction As New ParkingTransaction With {
                            .ParkingID = Convert.ToInt32(reader("no_masuk")),
                            .ExitTime = Convert.ToDateTime(reader("tanggal_keluar").ToString() & " " & reader("jam_keluar").ToString()),
                            .ParkingFee = If(reader("Tarif") IsNot DBNull.Value, Convert.ToDecimal(reader("Tarif")), 0)
                        }
                        dailyTransactions.Add(transaction)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading daily transactions: " & ex.Message)
        End Try
    End Sub

    ' Inisialisasi Kamera
    Private Sub InitializeCamera()
        Try
            Dim videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            If videoDevices.Count = 0 Then
                MessageBox.Show("No camera found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            videoDevice = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler videoDevice.NewFrame, AddressOf VideoDevice_NewFrame
            videoDevice.Start()
            UpdateStatus("Camera initialized")
        Catch ex As Exception
            MessageBox.Show("Error initializing camera: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler untuk frame baru dari kamera
    Private Sub VideoDevice_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            If picCameraPreview.Image IsNot Nothing Then
                picCameraPreview.Image.Dispose()
            End If
            picCameraPreview.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        Catch ex As Exception
            ' Handle cross-thread operation if needed
        End Try
    End Sub

    ' Inisialisasi Barcode Reader
    Private Sub InitializeBarcodeReader()
        barcodeReader = New BarcodeReader()
        barcodeReader.Options.PossibleFormats = New List(Of BarcodeFormat) From {BarcodeFormat.CODE_128}
        barcodeReader.Options.TryHarder = True
    End Sub

    ' Cari Tiket
    Private Sub SearchTicket()
        Try
            If isManualOverride Then
                ' For manual override, just use the plate number to search
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    
                    Dim cmd As New MySqlCommand("SELECT p.no_masuk AS ParkingID, p.no_kendaraan AS PlateNumber, " & _
                                            "p.tanggal_masuk AS EntryDate, p.jam_masuk AS EntryTime, " & _
                                            "p.id_kendaraan AS VehicleTypeID, " & _
                                            "b.Tarif AS BaseRate " & _
                                            "FROM parkir_masuk p " & _
                                            "JOIN biaya_parkir b ON p.id_kendaraan = b.id_kendaraan " & _
                                            "WHERE p.no_kendaraan = @PlateNumber AND p.tanggal_keluar IS NULL", conn)
                    
                    cmd.Parameters.AddWithValue("@PlateNumber", TextBoxPlateNumber.Text)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ProcessParkingData(reader)
                        Else
                            ' If no record found, this might be a lost ticket
                            HandleLostTicket()
                        End If
                    End Using
                End Using
            Else
                ' Normal ticket search by ticket number
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    
                    Dim cmd As New MySqlCommand("SELECT p.no_masuk AS ParkingID, p.no_kendaraan AS PlateNumber, " & _
                                            "p.tanggal_masuk AS EntryDate, p.jam_masuk AS EntryTime, " & _
                                            "p.id_kendaraan AS VehicleTypeID, " & _
                                            "b.Tarif AS BaseRate " & _
                                            "FROM parkir_masuk p " & _
                                            "JOIN biaya_parkir b ON p.id_kendaraan = b.id_kendaraan " & _
                                            "WHERE p.no_masuk = @TicketNo AND p.tanggal_keluar IS NULL", conn)
                    
                    cmd.Parameters.AddWithValue("@TicketNo", TextBoxTicketNo.Text)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ProcessParkingData(reader)
                        Else
                            MessageBox.Show("Tiket tidak ditemukan atau sudah keluar!")
                            ClearForm()
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching ticket: " & ex.Message)
        End Try
    End Sub

    ' Process parking data from database
    Private Sub ProcessParkingData(reader As MySqlDataReader)
        currentParkingData = New ParkingData With {
            .ParkingID = Convert.ToInt32(reader("ParkingID")),
            .TicketNo = reader("ParkingID").ToString(),
            .PlateNumber = reader("PlateNumber").ToString(),
            .EntryTime = Convert.ToDateTime(reader("EntryDate").ToString() & " " & reader("EntryTime").ToString()),
            .VehicleTypeID = Convert.ToInt32(reader("VehicleTypeID")),
            .ParkingFee = Convert.ToDecimal(reader("BaseRate")),
            .IsLostTicket = isManualOverride
        }

        ' Hitung biaya parkir berdasarkan durasi
        Dim duration As TimeSpan = DateTime.Now - currentParkingData.EntryTime
        Dim hours As Integer = Math.Ceiling(duration.TotalHours)
        
        ' Jika lebih dari 1 jam, tambahkan biaya per jam
        If hours > 1 Then
            ' Ambil tarif per jam dari database
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using hourlyCmd As New MySqlCommand("SELECT Tarif FROM biaya_parkir WHERE id_kendaraan = @VehicleTypeID", conn)
                    hourlyCmd.Parameters.AddWithValue("@VehicleTypeID", currentParkingData.VehicleTypeID)
                    Dim hourlyRate As Decimal = Convert.ToDecimal(hourlyCmd.ExecuteScalar())
                    
                    ' Hitung total biaya: Biaya dasar + (jam tambahan * tarif per jam)
                    currentParkingData.ParkingFee += (hours - 1) * hourlyRate
                End Using
            End Using
        End If

        ' Apply lost ticket fee if applicable
        If currentParkingData.IsLostTicket Then
            currentParkingData.ParkingFee += lostTicketFee
        End If

        ' Initialize payment after setting parking fee
        currentPayment = New PaymentInfo With {
            .Method = ComboBoxPaymentMethod.SelectedItem.ToString(),
            .Amount = currentParkingData.ParkingFee,
            .DiscountAmount = 0,
            .FinalAmount = currentParkingData.ParkingFee
        }
        
        CalculatePayment()

        ' Tampilkan data
        DisplayParkingData()

        ' Load entry photo if available
        Try
            Using photoCmd As New MySqlCommand("SELECT entry_photo FROM parkir_masuk WHERE no_masuk = @ParkingID", conn)
                photoCmd.Parameters.AddWithValue("@ParkingID", currentParkingData.ParkingID)
                Dim photoPath = Convert.ToString(photoCmd.ExecuteScalar())
                If Not String.IsNullOrEmpty(photoPath) AndAlso File.Exists(photoPath) Then
                    currentParkingData.EntryPhoto = photoPath
                    picEntryPhoto.Image = Image.FromFile(photoPath)
                    ButtonComparePhotos.Enabled = True
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading entry photo: " & ex.Message)
        End Try
    End Sub

    ' Handle lost ticket
    Private Sub HandleLostTicket()
        If String.IsNullOrEmpty(TextBoxPlateNumber.Text) Then
            MessageBox.Show("Masukkan nomor plat kendaraan untuk tiket yang hilang!")
            Return
        End If

        ' Create a new parking data for lost ticket
        currentParkingData = New ParkingData With {
            .ParkingID = 0, ' Will be assigned when saved
            .TicketNo = "LOST-" & DateTime.Now.ToString("yyyyMMddHHmmss"),
            .PlateNumber = TextBoxPlateNumber.Text,
            .EntryTime = DateTime.Now.AddHours(-24), ' Assume 24 hours for lost tickets
            .VehicleTypeID = 1, ' Default to first vehicle type
            .ParkingFee = lostTicketFee,
            .IsLostTicket = True
        }

        ' Initialize payment for lost ticket
        currentPayment = New PaymentInfo With {
            .Method = ComboBoxPaymentMethod.SelectedItem.ToString(),
            .Amount = lostTicketFee,
            .DiscountAmount = 0,
            .FinalAmount = lostTicketFee
        }
        
        CalculatePayment()

        ' Display data
        DisplayParkingData()
    End Sub

    ' Tampilkan Data Parkir
    Private Sub DisplayParkingData()
        TextBoxPlateNumber.Text = currentParkingData.PlateNumber
        TextBoxEntryTime.Text = currentParkingData.EntryTime.ToString("dd/MM/yyyy HH:mm:ss")
        TextBoxDuration.Text = CalculateDuration()
        TextBoxFee.Text = FormatCurrency(currentPayment.Amount)
        TextBoxDiscount.Text = FormatCurrency(currentPayment.DiscountAmount)
        TextBoxFinalAmount.Text = FormatCurrency(currentPayment.FinalAmount)

        ' Show lost ticket indicator if applicable
        If currentParkingData.IsLostTicket Then
            Label7.Text = "TIKET HILANG"
            Label7.ForeColor = Color.Red
        Else
            Label7.Text = ""
        End If

        ' Tampilkan foto masuk jika ada
        If Not String.IsNullOrEmpty(currentParkingData.EntryPhoto) AndAlso File.Exists(currentParkingData.EntryPhoto) Then
            picEntryPhoto.Image = Image.FromFile(currentParkingData.EntryPhoto)
        End If
    End Sub

    ' Hitung Durasi Parkir
    Private Function CalculateDuration() As String
        Dim duration As TimeSpan = DateTime.Now - currentParkingData.EntryTime
        Return $"{Math.Floor(duration.TotalHours)} jam {duration.Minutes} menit"
    End Function

    ' Proses Pembayaran
    Private Sub ButtonProcess_Click(sender As Object, e As EventArgs) Handles ButtonProcess.Click
        Try
            If currentParkingData Is Nothing Then
                MessageBox.Show("Tidak ada data parkir yang aktif!")
                Return
            End If
            
            ' Check if photos are verified
            If Not photoVerified Then
                MessageBox.Show("Please verify vehicle photos before processing payment!")
                Return
            End If
            
            ' Validate payment reference for non-cash payments
            If currentPayment.Method <> "Cash" AndAlso String.IsNullOrEmpty(currentPayment.Reference) Then
                MessageBox.Show("Please enter payment reference number!")
                Return
            End If

            ' Ambil foto keluar
            Dim exitPhotoPath As String = CaptureExitPhoto()

            ' Update database
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                
                If currentParkingData.IsLostTicket AndAlso currentParkingData.ParkingID = 0 Then
                    ' For lost tickets without existing record, create a new entry and immediately mark it as exited
                    Dim cmd As New MySqlCommand("INSERT INTO parkir_masuk " & _
                        "(no_kendaraan, id_kendaraan, tanggal_masuk, jam_masuk, tanggal_keluar, jam_keluar, Tarif) " & _
                        "VALUES (@PlateNumber, @VehicleTypeID, @EntryDate, @EntryTime, @ExitDate, @ExitTime, @ParkingFee)", conn)

                    cmd.Parameters.AddWithValue("@PlateNumber", currentParkingData.PlateNumber)
                    cmd.Parameters.AddWithValue("@VehicleTypeID", currentParkingData.VehicleTypeID)
                    cmd.Parameters.AddWithValue("@EntryDate", currentParkingData.EntryTime.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@EntryTime", currentParkingData.EntryTime.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@ExitDate", DateTime.Now.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ExitTime", DateTime.Now.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@ParkingFee", currentPayment.Amount)

                    cmd.ExecuteNonQuery()
                    
                    ' Get the ID of the newly inserted record
                    cmd = New MySqlCommand("SELECT MAX(no_masuk) FROM parkir_masuk WHERE no_kendaraan = @PlateNumber", conn)
                    cmd.Parameters.AddWithValue("@PlateNumber", currentParkingData.PlateNumber)
                    currentParkingData.ParkingID = Convert.ToInt32(cmd.ExecuteScalar())
                Else
                    ' For normal tickets, just update the exit information
                    Dim cmd As New MySqlCommand("UPDATE parkir_masuk SET " & _
                        "tanggal_keluar = @ExitDate, " & _
                        "jam_keluar = @ExitTime, " & _
                        "Tarif = @ParkingFee " & _
                        "WHERE no_masuk = @ParkingID", conn)

                    cmd.Parameters.AddWithValue("@ExitDate", DateTime.Now.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ExitTime", DateTime.Now.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@ParkingFee", currentPayment.Amount)
                    cmd.Parameters.AddWithValue("@ParkingID", currentParkingData.ParkingID)

                    cmd.ExecuteNonQuery()
                End If
                
                ' Record the transaction
                Dim transCmd As New MySqlCommand("INSERT INTO transactions " & _
                    "(parking_id, exit_time, amount, discount_amount, final_amount, payment_method, payment_reference, operator_name) " & _
                    "VALUES (@ParkingID, @ExitTime, @Amount, @DiscountAmount, @FinalAmount, @PaymentMethod, @PaymentReference, @OperatorName)", conn)
                
                transCmd.Parameters.AddWithValue("@ParkingID", currentParkingData.ParkingID)
                transCmd.Parameters.AddWithValue("@ExitTime", DateTime.Now)
                transCmd.Parameters.AddWithValue("@Amount", currentPayment.Amount)
                transCmd.Parameters.AddWithValue("@DiscountAmount", currentPayment.DiscountAmount)
                transCmd.Parameters.AddWithValue("@FinalAmount", currentPayment.FinalAmount)
                transCmd.Parameters.AddWithValue("@PaymentMethod", currentPayment.Method)
                transCmd.Parameters.AddWithValue("@PaymentReference", If(String.IsNullOrEmpty(currentPayment.Reference), DBNull.Value, currentPayment.Reference))
                transCmd.Parameters.AddWithValue("@OperatorName", "Operator") ' Default operator name
                
                Try
                    transCmd.ExecuteNonQuery()
                Catch ex As Exception
                    ' If transactions table doesn't exist, ignore the error
                End Try
            End Using

            ' Add to daily transactions
            Dim transaction As New ParkingTransaction With {
                .ParkingID = currentParkingData.ParkingID,
                .ExitTime = DateTime.Now,
                .ParkingFee = currentPayment.Amount,
                .PaymentMethod = currentPayment.Method,
                .OperatorName = "Operator"
            }
            dailyTransactions.Add(transaction)

            ' Cetak struk
            PrintReceipt()

            ' Buka gate
            OpenGate()

            ' Save exit photo path to database
            If Not String.IsNullOrEmpty(exitPhotoPath) Then
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim photoCmd As New MySqlCommand("UPDATE parkir_masuk SET exit_photo = @ExitPhoto WHERE no_masuk = @ParkingID", conn)
                    photoCmd.Parameters.AddWithValue("@ExitPhoto", exitPhotoPath)
                    photoCmd.Parameters.AddWithValue("@ParkingID", currentParkingData.ParkingID)
                    photoCmd.ExecuteNonQuery()
                End Using
            End If

            MessageBox.Show("Pembayaran berhasil! Silakan keluar.")
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error processing payment: " & ex.Message)
        End Try
    End Sub

    ' Ambil Foto Keluar
    Private Function CaptureExitPhoto() As String
        Try
            Dim photosDir As String = "Photos"
            If Not Directory.Exists(photosDir) Then
                Directory.CreateDirectory(photosDir)
            End If
            
            Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
            Dim filename As String = $"exit_{currentParkingData.ParkingID}_{timestamp}.jpg"
            Dim path As String = Path.Combine(photosDir, filename)

            If picCameraPreview.Image IsNot Nothing Then
                ' Save in higher resolution
                Dim currentFrame As Bitmap = DirectCast(picCameraPreview.Image, Bitmap)
                Using highResImage As New Bitmap(currentFrame, New Size(1920, 1080))
                    highResImage.Save(path, Imaging.ImageFormat.Jpeg)
                End Using
                Return path
            End If
        Catch ex As Exception
            MessageBox.Show("Error capturing exit photo: " & ex.Message)
        End Try
        Return String.Empty
    End Function

    ' Cetak Struk
    Private Sub PrintReceipt()
        Try
            Dim printDoc As New PrintDocument()
            AddHandler printDoc.PrintPage, Sub(sender, e)
                                             Dim font As New Font("Arial", 10)
                                             Dim boldFont As New Font("Arial", 12, FontStyle.Bold)
                                             Dim smallFont As New Font("Arial", 8)
                                             Dim brush As New SolidBrush(Color.Black)
                                             Dim y As Single = 10

                                             ' Header
                                             e.Graphics.DrawString("PARKING RECEIPT", boldFont, brush, 10, y)
                                             y += 30

                                             ' Receipt details
                                             e.Graphics.DrawString("Ticket No: " & currentParkingData.TicketNo, font, brush, 10, y)
                                             y += 20
                                             e.Graphics.DrawString("Plate No: " & currentParkingData.PlateNumber, font, brush, 10, y)
                                             y += 20
                                             e.Graphics.DrawString("Entry Time: " & currentParkingData.EntryTime.ToString(), font, brush, 10, y)
                                             y += 20
                                             e.Graphics.DrawString("Exit Time: " & DateTime.Now.ToString(), font, brush, 10, y)
                                             y += 20
                                             e.Graphics.DrawString("Duration: " & CalculateDuration(), font, brush, 10, y)
                                             y += 20
                                             
                                             ' Show lost ticket fee if applicable
                                             If currentParkingData.IsLostTicket Then
                                                 e.Graphics.DrawString("Lost Ticket Fee: " & FormatCurrency(lostTicketFee), font, brush, 10, y)
                                                 y += 20
                                             End If
                                             
                                             ' Add payment details
                                             e.Graphics.DrawString("Payment Method: " & currentPayment.Method, font, brush, 10, y)
                                             y += 20
                                             If currentPayment.Method <> "Cash" Then
                                                 e.Graphics.DrawString("Reference: " & currentPayment.Reference, font, brush, 10, y)
                                                 y += 20
                                             End If
                                             If currentPayment.DiscountAmount > 0 Then
                                                 e.Graphics.DrawString("Discount: " & FormatCurrency(currentPayment.DiscountAmount), font, brush, 10, y)
                                                 y += 20
                                             End If
                                             e.Graphics.DrawString("Final Amount: " & FormatCurrency(currentPayment.FinalAmount), boldFont, brush, 10, y)
                                             
                                             e.Graphics.DrawString("Fee: " & FormatCurrency(currentPayment.Amount), boldFont, brush, 10, y)
                                             y += 40
                                             e.Graphics.DrawString("Thank you for using our parking service!", font, brush, 10, y)
                                             y += 20
                                             e.Graphics.DrawString("Date: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), smallFont, brush, 10, y)
                                         End Sub

            ' Tampilkan print preview
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDoc
            printPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error printing receipt: " & ex.Message)
        End Try
    End Sub

    ' Kontrol Gate Barrier
    Private Sub OpenGate()
        Try
            If Not serialPort.IsOpen Then
                serialPort.Open()
            End If
            serialPort.Write("OPEN") ' Sesuaikan dengan protokol gate barrier
            System.Threading.Thread.Sleep(1000)
            serialPort.Close()
        Catch ex As Exception
            MessageBox.Show("Error opening gate: " & ex.Message)
        End Try
    End Sub

    ' Clear Form
    Private Sub ClearForm()
        TextBoxTicketNo.Clear()
        TextBoxPlateNumber.Clear()
        TextBoxEntryTime.Clear()
        TextBoxDuration.Clear()
        TextBoxFee.Clear()
        TextBoxDiscount.Clear()
        TextBoxFinalAmount.Clear()
        picEntryPhoto.Image = Nothing
        currentParkingData = Nothing
        currentPayment = Nothing
        Label7.Text = ""
        isManualOverride = False
        photoVerified = False
        currentExitPhoto = Nothing
        ButtonVerifyPhotos.Enabled = True
        ButtonVerifyPhotos.Text = "Verify Photos"
        ButtonVerifyPhotos.BackColor = SystemColors.Control
        ButtonComparePhotos.Enabled = False
        
        If photoComparisonActive Then
            ButtonComparePhotos_Click(Nothing, Nothing)
        End If
    End Sub

    ' Scan Barcode Button
    Private Sub ButtonScan_Click(sender As Object, e As EventArgs) Handles ButtonScan.Click
        If picCameraPreview.Image IsNot Nothing Then
            Dim result = barcodeReader.Decode(DirectCast(picCameraPreview.Image, Bitmap))
            If result IsNot Nothing Then
                TextBoxTicketNo.Text = result.Text
                SearchTicket()
            Else
                MessageBox.Show("No barcode found. Please try again.")
            End If
        End If
    End Sub

    ' Timer untuk update waktu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("H:mm:ss tt")
    End Sub

    ' Form Closing
    Private Sub GateExitForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If videoDevice IsNot Nothing AndAlso videoDevice.IsRunning Then
            videoDevice.SignalToStop()
            videoDevice.WaitForStop()
        End If
        If serialPort.IsOpen Then
            serialPort.Close()
        End If
    End Sub

    ' Menu navigation
    Private Sub dataMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles dataMasukToolStripMenuItem.Click
        Me.Hide()
        Dim masukForm As New Masuk()
        masukForm.Show()
    End Sub

    Private Sub dataKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles dataKeluarToolStripMenuItem.Click
        Me.Hide()
        Dim keluarForm As New Keluar()
        keluarForm.Show()
    End Sub

    Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logoutToolStripMenuItem.Click
        Me.Hide()
        Dim loginForm As New Form1()
        loginForm.Show()
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        DialogResult result = MessageBox.Show("Anda yakin ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Manual Override Button
    Private Sub ButtonManualOverride_Click(sender As Object, e As EventArgs) Handles ButtonManualOverride.Click
        isManualOverride = True
        TextBoxTicketNo.Text = "LOST TICKET"
        TextBoxTicketNo.Enabled = False
        TextBoxPlateNumber.ReadOnly = False
        TextBoxPlateNumber.Focus()
        Label7.Text = "TIKET HILANG - MASUKKAN NOMOR PLAT"
        Label7.ForeColor = Color.Red
    End Sub

    ' Search by Plate Button
    Private Sub ButtonSearchPlate_Click(sender As Object, e As EventArgs) Handles ButtonSearchPlate.Click
        If String.IsNullOrEmpty(TextBoxPlateNumber.Text) Then
            MessageBox.Show("Masukkan nomor plat kendaraan!")
            Return
        End If
        
        SearchTicket()
    End Sub

    ' Reset Button
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ClearForm()
        TextBoxTicketNo.Enabled = True
        TextBoxPlateNumber.ReadOnly = True
    End Sub

    ' Daily Report Button
    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click
        ' Open the transaction log viewer
        Dim logViewer As New TransactionLogForm()
        logViewer.Show()
    End Sub

    ' Add new methods for payment and discount handling
    Private Sub LoadDiscountTypes()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT discount_name, discount_percentage FROM discounts", conn)
                
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        discountTypes.Add(reader("discount_name").ToString(), Convert.ToDecimal(reader("discount_percentage")))
                    End While
                End Using
            End Using
        Catch ex As Exception
            ' If table doesn't exist, add default discounts
            discountTypes.Add("Member", 10D)    ' 10% discount
            discountTypes.Add("VIP", 20D)       ' 20% discount
            discountTypes.Add("Special", 15D)   ' 15% discount
        End Try
    End Sub

    Private Sub ComboBoxPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaymentMethod.SelectedIndexChanged
        If ComboBoxPaymentMethod.SelectedItem.ToString() <> "Cash" Then
            TextBoxReference.Enabled = True
            LabelReference.Visible = True
            TextBoxReference.Visible = True
        Else
            TextBoxReference.Enabled = False
            LabelReference.Visible = False
            TextBoxReference.Visible = False
        End If
        
        CalculatePayment()
    End Sub

    Private Sub ComboBoxDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDiscount.SelectedIndexChanged
        CalculatePayment()
    End Sub

    Private Sub CalculatePayment()
        If currentParkingData Is Nothing Then Return
        
        currentPayment = New PaymentInfo()
        currentPayment.Method = ComboBoxPaymentMethod.SelectedItem.ToString()
        currentPayment.Amount = currentParkingData.ParkingFee
        
        ' Calculate discount if applicable
        If ComboBoxDiscount.SelectedIndex > 0 Then
            Dim discountName As String = ComboBoxDiscount.SelectedItem.ToString()
            Dim discountPercentage As Decimal = discountTypes(discountName)
            currentPayment.DiscountAmount = Math.Round(currentPayment.Amount * (discountPercentage / 100), 2)
        Else
            currentPayment.DiscountAmount = 0
        End If
        
        currentPayment.FinalAmount = currentPayment.Amount - currentPayment.DiscountAmount
        currentPayment.Reference = TextBoxReference.Text
        
        ' Update display
        TextBoxFee.Text = FormatCurrency(currentPayment.Amount)
        TextBoxDiscount.Text = FormatCurrency(currentPayment.DiscountAmount)
        TextBoxFinalAmount.Text = FormatCurrency(currentPayment.FinalAmount)
    End Sub

    ' Add new methods for photo verification
    Private Sub ButtonComparePhotos_Click(sender As Object, e As EventArgs) Handles ButtonComparePhotos.Click
        If photoComparisonActive Then
            ' Switch back to normal view
            photoComparisonActive = False
            ButtonComparePhotos.Text = "Compare Photos"
            picCameraPreview.Size = New Size(320, 240)
            picEntryPhoto.Size = New Size(320, 240)
            GroupBox1.Size = New Size(350, 280)
            GroupBox2.Size = New Size(350, 280)
        Else
            ' Switch to comparison view
            photoComparisonActive = True
            ButtonComparePhotos.Text = "Normal View"
            picCameraPreview.Size = New Size(480, 360)
            picEntryPhoto.Size = New Size(480, 360)
            GroupBox1.Size = New Size(500, 400)
            GroupBox2.Size = New Size(500, 400)
        End If
    End Sub

    ' Enhanced photo comparison method
    Private Function ComparePhotos() As ComparisonResult
        If String.IsNullOrEmpty(currentParkingData.EntryPhoto) OrElse String.IsNullOrEmpty(currentExitPhoto) Then
            Return Nothing
        End If
        
        Try
            Dim result As New ComparisonResult()
            
            Using entryImage As New Bitmap(currentParkingData.EntryPhoto)
                Using exitImage As New Bitmap(currentExitPhoto)
                    ' Resize images to same dimensions for comparison
                    Dim size As New Size(800, 600)
                    Using normalizedEntry As Bitmap = ResizeImage(entryImage, size)
                        Using normalizedExit As Bitmap = ResizeImage(exitImage, size)
                            ' Calculate histogram similarity
                            result.HistogramScore = CompareHistograms(normalizedEntry, normalizedExit)
                            
                            ' Calculate feature matching score
                            result.FeatureMatchScore = CompareFeatures(normalizedEntry, normalizedExit)
                            
                            ' Calculate structural similarity
                            result.StructuralScore = CompareStructural(normalizedEntry, normalizedExit)
                            
                            ' Calculate weighted average
                            result.OverallScore = (result.HistogramScore * HISTOGRAM_WEIGHT) + 
                                                (result.FeatureMatchScore * FEATURE_WEIGHT) + 
                                                (result.StructuralScore * STRUCTURAL_WEIGHT)
                            
                            result.IsMatch = result.OverallScore >= MATCH_THRESHOLD
                        End Using
                    End Using
                End Using
            End Using
            
            Return result
        Catch ex As Exception
            MessageBox.Show("Error comparing photos: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Resize image while maintaining aspect ratio
    Private Function ResizeImage(image As Bitmap, size As Size) As Bitmap
        Dim ratioX As Double = size.Width / image.Width
        Dim ratioY As Double = size.Height / image.Height
        Dim ratio As Double = Math.Min(ratioX, ratioY)
        
        Dim newWidth As Integer = CInt(image.Width * ratio)
        Dim newHeight As Integer = CInt(image.Height * ratio)
        
        Dim resized As New Bitmap(newWidth, newHeight)
        Using g As Graphics = Graphics.FromImage(resized)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        
        Return resized
    End Function

    ' Compare image histograms
    Private Function CompareHistograms(img1 As Bitmap, img2 As Bitmap) As Double
        Try
            ' Convert to grayscale for histogram comparison
            Dim grayscale As New Grayscale(0.2125, 0.7154, 0.0721)
            Dim gray1 As Bitmap = grayscale.Apply(img1)
            Dim gray2 As Bitmap = grayscale.Apply(img2)
            
            ' Calculate histograms
            Dim hist1 As New ImageStatistics(gray1)
            Dim hist2 As New ImageStatistics(gray2)
            
            ' Compare histograms using correlation
            Dim correlation As Double = 0
            For i As Integer = 0 To 255
                correlation += Math.Min(hist1.Gray.Values(i), hist2.Gray.Values(i))
            Next
            
            Return correlation / 255.0
        Catch ex As Exception
            UpdateStatus("Error in histogram comparison: " & ex.Message)
            Return 0
        End Try
    End Function

    ' Compare image features
    Private Function CompareFeatures(img1 As Bitmap, img2 As Bitmap) As Double
        Try
            ' Edge detection for feature comparison
            Dim sobel As New SobelEdgeDetector()
            Dim edges1 As Bitmap = sobel.Apply(img1)
            Dim edges2 As Bitmap = sobel.Apply(img2)
            
            ' Compare edge features
            Dim matchCount As Integer = 0
            Dim totalPixels As Integer = edges1.Width * edges1.Height
            
            For x As Integer = 0 To edges1.Width - 1
                For y As Integer = 0 To edges1.Height - 1
                    If edges1.GetPixel(x, y).GetBrightness() > 0.5 AndAlso 
                       edges2.GetPixel(x, y).GetBrightness() > 0.5 Then
                        matchCount += 1
                    End If
                Next
            Next
            
            Return matchCount / (totalPixels * 0.1) ' Normalize score
        Catch ex As Exception
            UpdateStatus("Error in feature comparison: " & ex.Message)
            Return 0
        End Try
    End Function

    ' Compare structural similarity
    Private Function CompareStructural(img1 As Bitmap, img2 As Bitmap) As Double
        Try
            ' Convert to grayscale
            Dim grayscale As New Grayscale(0.2125, 0.7154, 0.0721)
            Dim gray1 As Bitmap = grayscale.Apply(img1)
            Dim gray2 As Bitmap = grayscale.Apply(img2)
            
            ' Calculate mean squared error
            Dim mse As Double = 0
            For x As Integer = 0 To gray1.Width - 1
                For y As Integer = 0 To gray1.Height - 1
                    Dim diff As Double = gray1.GetPixel(x, y).GetBrightness() - gray2.GetPixel(x, y).GetBrightness()
                    mse += diff * diff
                Next
            Next
            
            mse /= (gray1.Width * gray1.Height)
            
            ' Convert MSE to similarity score (1 = identical, 0 = completely different)
            Return 1 / (1 + mse)
        Catch ex As Exception
            UpdateStatus("Error in structural comparison: " & ex.Message)
            Return 0
        End Try
    End Function

    ' Update ButtonVerifyPhotos_Click to use new comparison
    Private Sub ButtonVerifyPhotos_Click(sender As Object, e As EventArgs) Handles ButtonVerifyPhotos.Click
        If currentParkingData Is Nothing Then
            MessageBox.Show("No active parking data to verify!")
            Return
        End If
        
        ' Capture current frame as exit photo
        currentExitPhoto = CaptureExitPhoto()
        If String.IsNullOrEmpty(currentExitPhoto) Then
            MessageBox.Show("Failed to capture exit photo!")
            Return
        End If
        
        ' Compare photos
        Dim comparison As ComparisonResult = ComparePhotos()
        If comparison Is Nothing Then
            MessageBox.Show("Error comparing photos!")
            Return
        End If
        
        ' Update UI with comparison results
        Dim resultMessage As String = $"Photo Comparison Results:{Environment.NewLine}" & _
                                    $"Histogram Similarity: {comparison.HistogramScore:P}{Environment.NewLine}" & _
                                    $"Feature Match Score: {comparison.FeatureMatchScore:P}{Environment.NewLine}" & _
                                    $"Structural Similarity: {comparison.StructuralScore:P}{Environment.NewLine}" & _
                                    $"Overall Match Score: {comparison.OverallScore:P}{Environment.NewLine}{Environment.NewLine}"
        
        If comparison.IsMatch Then
            resultMessage &= "MATCH VERIFIED"
            photoVerified = True
            ButtonVerifyPhotos.Enabled = False
            ButtonVerifyPhotos.Text = "Photos Verified"
            ButtonVerifyPhotos.BackColor = Color.LightGreen
            ButtonProcess.Enabled = True
        Else
            resultMessage &= "MATCH FAILED - Please verify manually or try again"
            ButtonVerifyPhotos.BackColor = Color.LightPink
        End If
        
        MessageBox.Show(resultMessage, "Photo Verification Results", 
                       If(comparison.IsMatch, MessageBoxButtons.OK, MessageBoxButtons.RetryCancel), 
                       If(comparison.IsMatch, MessageBoxIcon.Information, MessageBoxIcon.Warning))
        
        UpdateStatus($"Photo verification: {If(comparison.IsMatch, "Successful", "Failed")} - Score: {comparison.OverallScore:P}")
    End Sub

    Private Sub UpdateStatus(message As String)
        lblStatus.Text = $"Status: {message} - {DateTime.Now:HH:mm:ss}"
    End Sub
End Class 