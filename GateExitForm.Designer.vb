Partial Class GateExitForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.dataMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dataKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxCamera = New System.Windows.Forms.PictureBox()
        Me.PictureBoxEntryPhoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTicketNo = New System.Windows.Forms.TextBox()
        Me.TextBoxPlateNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxEntryTime = New System.Windows.Forms.TextBox()
        Me.TextBoxDuration = New System.Windows.Forms.TextBox()
        Me.TextBoxFee = New System.Windows.Forms.TextBox()
        Me.ButtonScan = New System.Windows.Forms.Button()
        Me.ButtonProcess = New System.Windows.Forms.Button()
        Me.chkAutoScan = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonManualOverride = New System.Windows.Forms.Button()
        Me.ButtonSearchPlate = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxPayment = New System.Windows.Forms.GroupBox()
        Me.ComboBoxPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.LabelPaymentMethod = New System.Windows.Forms.Label()
        Me.LabelReference = New System.Windows.Forms.Label()
        Me.TextBoxReference = New System.Windows.Forms.TextBox()
        Me.LabelDiscount = New System.Windows.Forms.Label()
        Me.ComboBoxDiscount = New System.Windows.Forms.ComboBox()
        Me.LabelFee = New System.Windows.Forms.Label()
        Me.LabelDiscountAmount = New System.Windows.Forms.Label()
        Me.TextBoxDiscount = New System.Windows.Forms.TextBox()
        Me.LabelFinalAmount = New System.Windows.Forms.Label()
        Me.TextBoxFinalAmount = New System.Windows.Forms.TextBox()
        Me.ButtonComparePhotos = New System.Windows.Forms.Button()
        Me.ButtonVerifyPhotos = New System.Windows.Forms.Button()
        Me.GroupBoxPhotoVerification = New System.Windows.Forms.GroupBox()
        Me.picCameraPreview = New System.Windows.Forms.PictureBox()
        Me.picEntryPhoto = New System.Windows.Forms.PictureBox()
        Me.picExitPhoto = New System.Windows.Forms.PictureBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnOpenGate = New System.Windows.Forms.Button()
        Me.txtTicketNumber = New System.Windows.Forms.TextBox()
        Me.lblTicketNumber = New System.Windows.Forms.Label()
        Me.btnVerifyTicket = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.grpVehicleInfo = New System.Windows.Forms.GroupBox()
        Me.lblPlateNumber = New System.Windows.Forms.Label()
        Me.lblEntryTime = New System.Windows.Forms.Label()
        Me.lblVehicleType = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.menuStrip1.SuspendLayout()
        CType(Me.PictureBoxCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEntryPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBoxPayment.SuspendLayout()
        Me.GroupBoxPhotoVerification.SuspendLayout()
        CType(Me.picCameraPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEntryPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExitPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVehicleInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dataMasukToolStripMenuItem, Me.dataKeluarToolStripMenuItem, Me.logoutToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "menuStrip1"
        '
        'dataMasukToolStripMenuItem
        '
        Me.dataMasukToolStripMenuItem.Name = "dataMasukToolStripMenuItem"
        Me.dataMasukToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.dataMasukToolStripMenuItem.Text = "Data Masuk"
        '
        'dataKeluarToolStripMenuItem
        '
        Me.dataKeluarToolStripMenuItem.Name = "dataKeluarToolStripMenuItem"
        Me.dataKeluarToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.dataKeluarToolStripMenuItem.Text = "Data Keluar"
        '
        'logoutToolStripMenuItem
        '
        Me.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem"
        Me.logoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.logoutToolStripMenuItem.Text = "Logout"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'PictureBoxCamera
        '
        Me.PictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxCamera.Location = New System.Drawing.Point(15, 30)
        Me.PictureBoxCamera.Name = "PictureBoxCamera"
        Me.PictureBoxCamera.Size = New System.Drawing.Size(320, 240)
        Me.PictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCamera.TabIndex = 1
        Me.PictureBoxCamera.TabStop = False
        '
        'PictureBoxEntryPhoto
        '
        Me.PictureBoxEntryPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxEntryPhoto.Location = New System.Drawing.Point(15, 30)
        Me.PictureBoxEntryPhoto.Name = "PictureBoxEntryPhoto"
        Me.PictureBoxEntryPhoto.Size = New System.Drawing.Size(320, 240)
        Me.PictureBoxEntryPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEntryPhoto.TabIndex = 2
        Me.PictureBoxEntryPhoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GATE EXIT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ticket No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Plate Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Entry Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Duration:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(353, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Fee:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(353, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 9
        '
        'TextBoxTicketNo
        '
        Me.TextBoxTicketNo.Location = New System.Drawing.Point(432, 117)
        Me.TextBoxTicketNo.Name = "TextBoxTicketNo"
        Me.TextBoxTicketNo.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxTicketNo.TabIndex = 10
        '
        'TextBoxPlateNumber
        '
        Me.TextBoxPlateNumber.Location = New System.Drawing.Point(432, 147)
        Me.TextBoxPlateNumber.Name = "TextBoxPlateNumber"
        Me.TextBoxPlateNumber.ReadOnly = True
        Me.TextBoxPlateNumber.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxPlateNumber.TabIndex = 11
        '
        'TextBoxEntryTime
        '
        Me.TextBoxEntryTime.Location = New System.Drawing.Point(432, 177)
        Me.TextBoxEntryTime.Name = "TextBoxEntryTime"
        Me.TextBoxEntryTime.ReadOnly = True
        Me.TextBoxEntryTime.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxEntryTime.TabIndex = 12
        '
        'TextBoxDuration
        '
        Me.TextBoxDuration.Location = New System.Drawing.Point(432, 207)
        Me.TextBoxDuration.Name = "TextBoxDuration"
        Me.TextBoxDuration.ReadOnly = True
        Me.TextBoxDuration.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxDuration.TabIndex = 13
        '
        'TextBoxFee
        '
        Me.TextBoxFee.Location = New System.Drawing.Point(432, 237)
        Me.TextBoxFee.Name = "TextBoxFee"
        Me.TextBoxFee.ReadOnly = True
        Me.TextBoxFee.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxFee.TabIndex = 14
        '
        'ButtonScan
        '
        Me.ButtonScan.Location = New System.Drawing.Point(588, 115)
        Me.ButtonScan.Name = "ButtonScan"
        Me.ButtonScan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonScan.TabIndex = 15
        Me.ButtonScan.Text = "Scan"
        Me.ButtonScan.UseVisualStyleBackColor = True
        '
        'ButtonProcess
        '
        Me.ButtonProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProcess.Location = New System.Drawing.Point(432, 280)
        Me.ButtonProcess.Name = "ButtonProcess"
        Me.ButtonProcess.Size = New System.Drawing.Size(150, 40)
        Me.ButtonProcess.TabIndex = 16
        Me.ButtonProcess.Text = "Process Payment"
        Me.ButtonProcess.UseVisualStyleBackColor = True
        '
        'chkAutoScan
        '
        Me.chkAutoScan.AutoSize = True
        Me.chkAutoScan.Location = New System.Drawing.Point(588, 147)
        Me.chkAutoScan.Name = "chkAutoScan"
        Me.chkAutoScan.Size = New System.Drawing.Size(77, 17)
        Me.chkAutoScan.TabIndex = 17
        Me.chkAutoScan.Text = "Auto Scan"
        Me.chkAutoScan.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(850, 40)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(51, 16)
        Me.lblTime.TabIndex = 18
        Me.lblTime.Text = "Time: "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(850, 60)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 16)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "Date: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Current Camera"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(670, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Entry Photo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBoxCamera)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 280)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Live Camera"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBoxEntryPhoto)
        Me.GroupBox2.Location = New System.Drawing.Point(622, 310)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 280)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entry Photo"
        '
        'ButtonManualOverride
        '
        Me.ButtonManualOverride.Location = New System.Drawing.Point(15, 25)
        Me.ButtonManualOverride.Name = "ButtonManualOverride"
        Me.ButtonManualOverride.Size = New System.Drawing.Size(120, 30)
        Me.ButtonManualOverride.TabIndex = 24
        Me.ButtonManualOverride.Text = "Lost Ticket"
        Me.ButtonManualOverride.UseVisualStyleBackColor = True
        '
        'ButtonSearchPlate
        '
        Me.ButtonSearchPlate.Location = New System.Drawing.Point(15, 65)
        Me.ButtonSearchPlate.Name = "ButtonSearchPlate"
        Me.ButtonSearchPlate.Size = New System.Drawing.Size(120, 30)
        Me.ButtonSearchPlate.TabIndex = 25
        Me.ButtonSearchPlate.Text = "Search by Plate"
        Me.ButtonSearchPlate.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(15, 105)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(120, 30)
        Me.ButtonReset.TabIndex = 26
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonReport
        '
        Me.ButtonReport.Location = New System.Drawing.Point(15, 145)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(120, 30)
        Me.ButtonReport.TabIndex = 27
        Me.ButtonReport.Text = "Daily Report"
        Me.ButtonReport.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonManualOverride)
        Me.GroupBox3.Controls.Add(Me.ButtonReport)
        Me.GroupBox3.Controls.Add(Me.ButtonSearchPlate)
        Me.GroupBox3.Controls.Add(Me.ButtonReset)
        Me.GroupBox3.Location = New System.Drawing.Point(400, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 190)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'GroupBoxPayment
        '
        Me.GroupBoxPayment.Text = "Payment Details"
        Me.GroupBoxPayment.Location = New System.Drawing.Point(12, 350)
        Me.GroupBoxPayment.Size = New System.Drawing.Size(400, 180)
        '
        'ComboBoxPaymentMethod
        '
        Me.ComboBoxPaymentMethod.Location = New System.Drawing.Point(120, 30)
        Me.ComboBoxPaymentMethod.Size = New System.Drawing.Size(200, 24)
        '
        'LabelPaymentMethod
        '
        Me.LabelPaymentMethod.Text = "Payment Method:"
        Me.LabelPaymentMethod.Location = New System.Drawing.Point(10, 33)
        '
        'LabelReference
        '
        Me.LabelReference.Text = "Reference No:"
        Me.LabelReference.Location = New System.Drawing.Point(10, 63)
        Me.LabelReference.Visible = False
        '
        'TextBoxReference
        '
        Me.TextBoxReference.Location = New System.Drawing.Point(120, 60)
        Me.TextBoxReference.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxReference.Visible = False
        '
        'LabelDiscount
        '
        Me.LabelDiscount.Text = "Discount:"
        Me.LabelDiscount.Location = New System.Drawing.Point(10, 93)
        '
        'ComboBoxDiscount
        '
        Me.ComboBoxDiscount.Location = New System.Drawing.Point(120, 90)
        Me.ComboBoxDiscount.Size = New System.Drawing.Size(200, 24)
        '
        'LabelFee
        '
        Me.LabelFee.Text = "Base Fee:"
        Me.LabelFee.Location = New System.Drawing.Point(10, 123)
        '
        'LabelDiscountAmount
        '
        Me.LabelDiscountAmount.Text = "Discount Amount:"
        Me.LabelDiscountAmount.Location = New System.Drawing.Point(10, 153)
        '
        'TextBoxDiscount
        '
        Me.TextBoxDiscount.Location = New System.Drawing.Point(120, 150)
        Me.TextBoxDiscount.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxDiscount.ReadOnly = True
        '
        'LabelFinalAmount
        '
        Me.LabelFinalAmount.Text = "Final Amount:"
        Me.LabelFinalAmount.Location = New System.Drawing.Point(10, 183)
        '
        'TextBoxFinalAmount
        '
        Me.TextBoxFinalAmount.Location = New System.Drawing.Point(120, 180)
        Me.TextBoxFinalAmount.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxFinalAmount.ReadOnly = True
        '
        'ButtonComparePhotos
        '
        Me.ButtonComparePhotos.Location = New System.Drawing.Point(15, 25)
        Me.ButtonComparePhotos.Name = "ButtonComparePhotos"
        Me.ButtonComparePhotos.Size = New System.Drawing.Size(120, 30)
        Me.ButtonComparePhotos.Text = "Compare Photos"
        Me.ButtonComparePhotos.UseVisualStyleBackColor = True
        Me.ButtonComparePhotos.Enabled = False
        '
        'ButtonVerifyPhotos
        '
        Me.ButtonVerifyPhotos.Location = New System.Drawing.Point(15, 60)
        Me.ButtonVerifyPhotos.Name = "ButtonVerifyPhotos"
        Me.ButtonVerifyPhotos.Size = New System.Drawing.Size(120, 30)
        Me.ButtonVerifyPhotos.Text = "Verify Photos"
        Me.ButtonVerifyPhotos.UseVisualStyleBackColor = True
        '
        'GroupBoxPhotoVerification
        '
        Me.GroupBoxPhotoVerification.Text = "Photo Verification"
        Me.GroupBoxPhotoVerification.Location = New System.Drawing.Point(400, 450)
        Me.GroupBoxPhotoVerification.Size = New System.Drawing.Size(150, 100)
        '
        'picCameraPreview
        '
        Me.picCameraPreview.Location = New System.Drawing.Point(12, 40)
        Me.picCameraPreview.Size = New System.Drawing.Size(320, 240)
        Me.picCameraPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCameraPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        'picEntryPhoto
        '
        Me.picEntryPhoto.Location = New System.Drawing.Point(12, 290)
        Me.picEntryPhoto.Size = New System.Drawing.Size(320, 240)
        Me.picEntryPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEntryPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        'picExitPhoto
        '
        Me.picExitPhoto.Location = New System.Drawing.Point(338, 290)
        Me.picExitPhoto.Size = New System.Drawing.Size(320, 240)
        Me.picExitPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExitPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        'btnCapture
        '
        Me.btnCapture.Text = "Capture Photo"
        Me.btnCapture.Location = New System.Drawing.Point(12, 540)
        Me.btnCapture.Size = New System.Drawing.Size(120, 30)
        '
        'btnCompare
        '
        Me.btnCompare.Text = "Compare Photos"
        Me.btnCompare.Location = New System.Drawing.Point(138, 540)
        Me.btnCompare.Size = New System.Drawing.Size(120, 30)
        Me.btnCompare.Enabled = False
        '
        'btnOpenGate
        '
        Me.btnOpenGate.Text = "Open Gate"
        Me.btnOpenGate.Location = New System.Drawing.Point(538, 540)
        Me.btnOpenGate.Size = New System.Drawing.Size(120, 30)
        Me.btnOpenGate.Enabled = False
        '
        'txtTicketNumber
        '
        Me.txtTicketNumber.Location = New System.Drawing.Point(338, 65)
        Me.txtTicketNumber.Size = New System.Drawing.Size(200, 22)
        '
        'lblTicketNumber
        '
        Me.lblTicketNumber.Text = "Ticket Number:"
        Me.lblTicketNumber.Location = New System.Drawing.Point(338, 43)
        Me.lblTicketNumber.AutoSize = True
        '
        'btnVerifyTicket
        '
        Me.btnVerifyTicket.Text = "Verify Ticket"
        Me.btnVerifyTicket.Location = New System.Drawing.Point(544, 64)
        Me.btnVerifyTicket.Size = New System.Drawing.Size(100, 25)
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(12, 580)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Text = "Ready"
        '
        'grpVehicleInfo
        '
        Me.grpVehicleInfo.Text = "Vehicle Information"
        Me.grpVehicleInfo.Location = New System.Drawing.Point(338, 100)
        Me.grpVehicleInfo.Size = New System.Drawing.Size(320, 180)
        Me.grpVehicleInfo.Controls.Add(Me.lblPlateNumber)
        Me.grpVehicleInfo.Controls.Add(Me.lblEntryTime)
        Me.grpVehicleInfo.Controls.Add(Me.lblVehicleType)
        Me.grpVehicleInfo.Controls.Add(Me.lblAmount)
        '
        'lblPlateNumber
        '
        Me.lblPlateNumber.Location = New System.Drawing.Point(10, 30)
        Me.lblPlateNumber.AutoSize = True
        Me.lblPlateNumber.Text = "Plate Number: -"
        '
        'lblEntryTime
        '
        Me.lblEntryTime.Location = New System.Drawing.Point(10, 60)
        Me.lblEntryTime.AutoSize = True
        Me.lblEntryTime.Text = "Entry Time: -"
        '
        'lblVehicleType
        '
        Me.lblVehicleType.Location = New System.Drawing.Point(10, 90)
        Me.lblVehicleType.AutoSize = True
        Me.lblVehicleType.Text = "Vehicle Type: -"
        '
        'lblAmount
        '
        Me.lblAmount.Location = New System.Drawing.Point(10, 120)
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Text = "Amount: -"
        '
        'GateExitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.GroupBoxPhotoVerification)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.chkAutoScan)
        Me.Controls.Add(Me.ButtonProcess)
        Me.Controls.Add(Me.ButtonScan)
        Me.Controls.Add(Me.TextBoxFee)
        Me.Controls.Add(Me.TextBoxDuration)
        Me.Controls.Add(Me.TextBoxEntryTime)
        Me.Controls.Add(Me.TextBoxPlateNumber)
        Me.Controls.Add(Me.TextBoxTicketNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.GroupBoxPayment)
        Me.Controls.Add(Me.picCameraPreview)
        Me.Controls.Add(Me.picEntryPhoto)
        Me.Controls.Add(Me.picExitPhoto)
        Me.Controls.Add(Me.txtTicketNumber)
        Me.Controls.Add(Me.lblTicketNumber)
        Me.Controls.Add(Me.btnVerifyTicket)
        Me.Controls.Add(Me.grpVehicleInfo)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.btnOpenGate)
        Me.Controls.Add(Me.lblStatus)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "GateExitForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gate Exit System"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.PictureBoxCamera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEntryPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBoxPayment.ResumeLayout(False)
        Me.GroupBoxPhotoVerification.ResumeLayout(False)
        CType(Me.picCameraPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEntryPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExitPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVehicleInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip1 As MenuStrip
    Friend WithEvents dataMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dataKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents logoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxCamera As PictureBox
    Friend WithEvents PictureBoxEntryPhoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxTicketNo As TextBox
    Friend WithEvents TextBoxPlateNumber As TextBox
    Friend WithEvents TextBoxEntryTime As TextBox
    Friend WithEvents TextBoxDuration As TextBox
    Friend WithEvents TextBoxFee As TextBox
    Friend WithEvents ButtonScan As Button
    Friend WithEvents ButtonProcess As Button
    Friend WithEvents chkAutoScan As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonManualOverride As Button
    Friend WithEvents ButtonSearchPlate As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBoxPayment As GroupBox
    Friend WithEvents ComboBoxPaymentMethod As ComboBox
    Friend WithEvents LabelPaymentMethod As Label
    Friend WithEvents LabelReference As Label
    Friend WithEvents TextBoxReference As TextBox
    Friend WithEvents LabelDiscount As Label
    Friend WithEvents ComboBoxDiscount As ComboBox
    Friend WithEvents LabelFee As Label
    Friend WithEvents LabelDiscountAmount As Label
    Friend WithEvents TextBoxDiscount As TextBox
    Friend WithEvents LabelFinalAmount As Label
    Friend WithEvents TextBoxFinalAmount As TextBox
    Friend WithEvents ButtonComparePhotos As Button
    Friend WithEvents ButtonVerifyPhotos As Button
    Friend WithEvents GroupBoxPhotoVerification As GroupBox
    Friend WithEvents picCameraPreview As PictureBox
    Friend WithEvents picEntryPhoto As PictureBox
    Friend WithEvents picExitPhoto As PictureBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnOpenGate As Button
    Friend WithEvents txtTicketNumber As TextBox
    Friend WithEvents lblTicketNumber As Label
    Friend WithEvents btnVerifyTicket As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents grpVehicleInfo As GroupBox
    Friend WithEvents lblPlateNumber As Label
    Friend WithEvents lblEntryTime As Label
    Friend WithEvents lblVehicleType As Label
    Friend WithEvents lblAmount As Label
End Class 