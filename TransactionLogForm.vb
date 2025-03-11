Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop.Excel
Imports System.Drawing.Printing
Imports System.Linq

Public Class TransactionLogForm
    Private connectionString As String = "Server=localhost;Database=db_parkir;Uid=root;Pwd=;"
    Private advancedFilters As New Dictionary(Of String, Object)
    Private currentPage As Integer = 1
    Private pageSize As Integer = 50
    Private currentTransaction As DataRow = Nothing
    Private photoViewerForm As Form = Nothing

    ' Add new class members for advanced features
    Private WithEvents btnAdvancedFilters As New Button()
    Private WithEvents btnBatchOperations As New Button()
    Private WithEvents btnStatistics As New Button()
    Private WithEvents chkSelectAll As New CheckBox()
    Private chartForm As Form = Nothing

    Public Sub New()
        InitializeComponent()
        InitializeControls()
        LoadData()
    End Sub

    Private Sub InitializeControls()
        ' Set default dates
        dtpStartDate.Value = DateTime.Today.AddDays(-7)
        dtpEndDate.Value = DateTime.Today

        ' Initialize payment method combo
        cboPaymentMethod.Items.AddRange({"All", "Cash", "Credit Card", "Debit Card", "E-Wallet"})
        cboPaymentMethod.SelectedIndex = 0

        ' Initialize verification status combo
        cboVerificationStatus.Items.AddRange({"All", "Verified", "Unverified"})
        cboVerificationStatus.SelectedIndex = 0

        ' Set up DataGridView
        SetupDataGridView()

        ' Add buttons for actions
        AddHandler btnSearch.Click, AddressOf btnSearch_Click
        AddHandler btnExport.Click, AddressOf btnExport_Click
        AddHandler dgvTransactions.CellClick, AddressOf DataGridView_CellClick

        ' Add checkbox column for batch operations
        Dim chkColumn As New DataGridViewCheckBoxColumn()
        chkColumn.Name = "Select"
        chkColumn.HeaderText = "Select"
        chkColumn.Width = 50
        dgvTransactions.Columns.Insert(0, chkColumn)

        ' Initialize new buttons
        btnAdvancedFilters.Text = "Advanced Filters"
        btnAdvancedFilters.Width = 120
        btnAdvancedFilters.Height = 30
        btnAdvancedFilters.Location = New Point(GroupBoxFilters.Left + 10, btnSearch.Top)

        btnBatchOperations.Text = "Batch Operations"
        btnBatchOperations.Width = 120
        btnBatchOperations.Height = 30
        btnBatchOperations.Location = New Point(btnAdvancedFilters.Right + 10, btnSearch.Top)

        btnStatistics.Text = "Statistics"
        btnStatistics.Width = 120
        btnStatistics.Height = 30
        btnStatistics.Location = New Point(btnBatchOperations.Right + 10, btnSearch.Top)

        ' Initialize select all checkbox
        chkSelectAll.Text = "Select All"
        chkSelectAll.Location = New Point(dgvTransactions.Left, dgvTransactions.Top - 25)
        chkSelectAll.AutoSize = True

        ' Add new controls to form
        Me.Controls.Add(btnAdvancedFilters)
        Me.Controls.Add(btnBatchOperations)
        Me.Controls.Add(btnStatistics)
        Me.Controls.Add(chkSelectAll)
    End Sub

    Private Sub SetupDataGridView()
        With dgvTransactions
            .AutoGenerateColumns = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .MultiSelect = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            ' Add columns
            .Columns.Add(New DataGridViewCheckBoxColumn() With {
                .Name = "Select",
                .HeaderText = "",
                .Width = 30
            })
            .Columns.Add("TransactionId", "Transaction ID")
            .Columns.Add("ExitTime", "Exit Time")
            .Columns.Add("PlateNumber", "Plate Number")
            .Columns.Add("Amount", "Amount")
            .Columns.Add("PaymentMethod", "Payment Method")
            .Columns.Add("PhotoVerified", "Photo Verified")
            .Columns.Add("OperatorName", "Operator")
        End With
    End Sub

    Private Sub LoadData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand(BuildQuery(), conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgvTransactions.Rows.Clear()
                For Each row As DataRow In dt.Rows
                    Dim index = dgvTransactions.Rows.Add()
                    With dgvTransactions.Rows(index)
                        .Cells("Select").Value = False
                        .Cells("TransactionId").Value = row("transaction_id")
                        .Cells("ExitTime").Value = row("exit_time")
                        .Cells("PlateNumber").Value = row("no_kendaraan")
                        .Cells("Amount").Value = String.Format("Rp {0:N0}", row("amount"))
                        .Cells("PaymentMethod").Value = row("payment_method")
                        .Cells("PhotoVerified").Value = If(row("photo_verified"), "Yes", "No")
                        .Cells("OperatorName").Value = row("operator_name")
                    End With
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function BuildQuery() As String
        Dim query As New StringBuilder()
        query.Append("SELECT t.*, p.no_kendaraan FROM transactions t ")
        query.Append("LEFT JOIN parkir_masuk p ON t.parking_id = p.no_masuk ")
        query.Append("WHERE 1=1 ")

        ' Date range filter
        query.Append("AND t.exit_time BETWEEN @StartDate AND @EndDate ")

        ' Payment method filter
        If cboPaymentMethod.SelectedIndex > 0 Then
            query.Append("AND t.payment_method = @PaymentMethod ")
        End If

        ' Verification status filter
        If cboVerificationStatus.SelectedIndex > 0 Then
            query.Append("AND t.photo_verified = @PhotoVerified ")
        End If

        ' Add advanced filters
        For Each filter In advancedFilters
            Select Case filter.Key
                Case "MinAmount"
                    query.Append("AND t.amount >= @MinAmount ")
                Case "MaxAmount"
                    query.Append("AND t.amount <= @MaxAmount ")
                Case "VehicleType"
                    query.Append("AND p.id_kendaraan = @VehicleType ")
                Case "OperatorName"
                    query.Append("AND t.operator_name = @OperatorName ")
                Case "IsLostTicket"
                    query.Append("AND p.is_lost_ticket = @IsLostTicket ")
            End Select
        Next

        query.Append("ORDER BY t.exit_time DESC ")
        query.Append("LIMIT @PageSize OFFSET @Offset")

        Return query.ToString()
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        currentPage = 1
        LoadData()
    End Sub

    Private Sub btnAdvancedFilters_Click(sender As Object, e As EventArgs) Handles btnAdvancedFilters.Click
        Using frm As New AdvancedFiltersForm()
            If frm.ShowDialog() = DialogResult.OK Then
                advancedFilters.Clear()
                If frm.MinAmount.HasValue Then advancedFilters.Add("MinAmount", frm.MinAmount)
                If frm.MaxAmount.HasValue Then advancedFilters.Add("MaxAmount", frm.MaxAmount)
                If Not String.IsNullOrEmpty(frm.VehicleType) Then advancedFilters.Add("VehicleType", frm.VehicleType)
                If Not String.IsNullOrEmpty(frm.OperatorName) Then advancedFilters.Add("OperatorName", frm.OperatorName)
                If frm.IsLostTicket.HasValue Then advancedFilters.Add("IsLostTicket", frm.IsLostTicket)
                LoadData()
            End If
        End Using
    End Sub

    Private Sub btnBatchOperations_Click(sender As Object, e As EventArgs) Handles btnBatchOperations.Click
        Dim selectedRows = (From row In dgvTransactions.Rows.Cast(Of DataGridViewRow)()
                          Where CBool(row.Cells("Select").Value) = True
                          Select row).ToList()

        If selectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one transaction.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using frm As New BatchOperationsForm(selectedRows)
            If frm.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
            saveDialog.FileName = $"TransactionLog_{DateTime.Now:yyyyMMdd}"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using excel As New Microsoft.Office.Interop.Excel.Application()
                    Dim workbook = excel.Workbooks.Add()
                    Dim worksheet = workbook.ActiveSheet

                    ' Add headers
                    For i As Integer = 1 To dgvTransactions.Columns.Count - 1
                        worksheet.Cells(1, i) = dgvTransactions.Columns(i).HeaderText
                    Next

                    ' Add data
                    For i As Integer = 0 To dgvTransactions.Rows.Count - 1
                        For j As Integer = 1 To dgvTransactions.Columns.Count - 1
                            worksheet.Cells(i + 2, j) = dgvTransactions.Rows(i).Cells(j).Value
                        Next
                    Next

                    ' Format worksheet
                    worksheet.Range("A1", "H1").Font.Bold = True
                    worksheet.UsedRange.Columns.AutoFit()

                    ' Save and close
                    workbook.SaveAs(saveDialog.FileName)
                    workbook.Close()
                    excel.Quit()

                    MessageBox.Show("Export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvTransactions.Columns("ViewDetails").Index Then
            Dim transactionId As Integer = CInt(dgvTransactions.Rows(e.RowIndex).Cells("TransactionId").Value)
            ShowTransactionDetails(transactionId)
        End If
    End Sub

    Private Sub ShowTransactionDetails(transactionId As Integer)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                    SELECT t.*, pm.*, d.discount_name, d.discount_percentage
                    FROM transactions t
                    INNER JOIN parkir_masuk pm ON t.parking_id = pm.no_masuk
                    LEFT JOIN discounts d ON t.discount_id = d.discount_id
                    WHERE t.transaction_id = @TransactionId"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TransactionId", transactionId)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim details As New Form()
                            details.Text = $"Transaction Details - ID: {transactionId}"
                            details.Size = New Size(600, 800)
                            details.StartPosition = FormStartPosition.CenterParent

                            ' Create controls to display transaction details
                            Dim panel As New TableLayoutPanel()
                            panel.Dock = DockStyle.Fill
                            panel.AutoScroll = True
                            panel.ColumnCount = 2
                            panel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30))
                            panel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70))

                            AddDetailRow(panel, "Transaction ID:", reader("transaction_id").ToString())
                            AddDetailRow(panel, "Exit Time:", CDate(reader("exit_time")).ToString("dd/MM/yyyy HH:mm:ss"))
                            AddDetailRow(panel, "Plate Number:", reader("no_kendaraan").ToString())
                            AddDetailRow(panel, "Amount:", String.Format("Rp {0:N0}", reader("amount")))
                            AddDetailRow(panel, "Payment Method:", reader("payment_method").ToString())
                            AddDetailRow(panel, "Payment Reference:", If(reader("payment_reference") IsNot DBNull.Value, reader("payment_reference").ToString(), "N/A"))
                            AddDetailRow(panel, "Discount:", If(reader("discount_name") IsNot DBNull.Value, $"{reader("discount_name")} ({reader("discount_percentage")}%)", "None"))
                            AddDetailRow(panel, "Verification Status:", If(reader("photo_verified"), "Verified", "Not Verified"))
                            AddDetailRow(panel, "Verified By:", If(reader("photo_verified_by") IsNot DBNull.Value, reader("photo_verified_by").ToString(), "N/A"))
                            AddDetailRow(panel, "Verification Time:", If(reader("photo_verified_at") IsNot DBNull.Value, CDate(reader("photo_verified_at")).ToString("dd/MM/yyyy HH:mm:ss"), "N/A"))

                            ' Add buttons to view photos
                            Dim btnViewPhotos As New Button()
                            btnViewPhotos.Text = "View Photos"
                            btnViewPhotos.Dock = DockStyle.Bottom
                            AddHandler btnViewPhotos.Click, Sub()
                                ShowPhotos(reader("entry_photo").ToString(), reader("exit_photo").ToString())
                            End Sub

                            details.Controls.Add(panel)
                            details.Controls.Add(btnViewPhotos)
                            details.ShowDialog()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error showing transaction details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddDetailRow(panel As TableLayoutPanel, label As String, value As String)
        Dim lbl As New Label()
        lbl.Text = label
        lbl.Dock = DockStyle.Fill
        lbl.Font = New Font(lbl.Font, FontStyle.Bold)

        Dim val As New Label()
        val.Text = value
        val.Dock = DockStyle.Fill

        Dim rowIndex As Integer = panel.RowCount
        panel.RowCount += 1
        panel.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        panel.Controls.Add(lbl, 0, rowIndex)
        panel.Controls.Add(val, 1, rowIndex)
    End Sub

    Private Sub ShowPhotos(entryPhotoPath As String, exitPhotoPath As String)
        Try
            If photoViewerForm IsNot Nothing AndAlso Not photoViewerForm.IsDisposed Then
                photoViewerForm.Close()
            End If

            photoViewerForm = New Form()
            photoViewerForm.Text = "Entry and Exit Photos"
            photoViewerForm.Size = New Size(800, 400)
            photoViewerForm.StartPosition = FormStartPosition.CenterParent

            Dim tableLayout As New TableLayoutPanel()
            tableLayout.Dock = DockStyle.Fill
            tableLayout.ColumnCount = 2
            tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))
            tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))

            ' Entry photo
            Dim entryPhoto As New PictureBox()
            entryPhoto.Dock = DockStyle.Fill
            entryPhoto.SizeMode = PictureBoxSizeMode.Zoom
            If File.Exists(entryPhotoPath) Then
                entryPhoto.Image = Image.FromFile(entryPhotoPath)
            End If

            ' Exit photo
            Dim exitPhoto As New PictureBox()
            exitPhoto.Dock = DockStyle.Fill
            exitPhoto.SizeMode = PictureBoxSizeMode.Zoom
            If File.Exists(exitPhotoPath) Then
                exitPhoto.Image = Image.FromFile(exitPhotoPath)
            End If

            tableLayout.Controls.Add(entryPhoto, 0, 0)
            tableLayout.Controls.Add(exitPhoto, 1, 0)

            Dim lblEntry As New Label()
            lblEntry.Text = "Entry Photo"
            lblEntry.Dock = DockStyle.Top
            lblEntry.TextAlign = ContentAlignment.MiddleCenter

            Dim lblExit As New Label()
            lblExit.Text = "Exit Photo"
            lblExit.Dock = DockStyle.Top
            lblExit.TextAlign = ContentAlignment.MiddleCenter

            tableLayout.Controls.Add(lblEntry, 0, 1)
            tableLayout.Controls.Add(lblExit, 1, 1)

            photoViewerForm.Controls.Add(tableLayout)
            photoViewerForm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing photos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged
        For Each row As DataGridViewRow In dgvTransactions.Rows
            row.Cells("Select").Value = chkSelectAll.Checked
        Next
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT COUNT(*) as TotalCount, " & _
                                          "SUM(amount) as TotalAmount, " & _
                                          "AVG(amount) as AvgAmount, " & _
                                          "SUM(CASE WHEN photo_verified = 1 THEN 1 ELSE 0 END) as VerifiedCount " & _
                                          "FROM transactions", conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim stats As String = $"Transaction Statistics:{Environment.NewLine}{Environment.NewLine}" & _
                                           $"Total Transactions: {reader("TotalCount")}{Environment.NewLine}" & _
                                           $"Total Amount: Rp {Convert.ToDecimal(reader("TotalAmount")):N0}{Environment.NewLine}" & _
                                           $"Average Amount: Rp {Convert.ToDecimal(reader("AvgAmount")):N0}{Environment.NewLine}" & _
                                           $"Verified Transactions: {reader("VerifiedCount")}"
                        MessageBox.Show(stats, "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading statistics: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class 