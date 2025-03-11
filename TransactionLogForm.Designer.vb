Partial Class TransactionLogForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboVerificationStatus = New System.Windows.Forms.ComboBox()
        Me.cboPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnAdvancedFilters = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBatchOperations = New System.Windows.Forms.ToolStripButton()
        Me.btnExport = New System.Windows.Forms.ToolStripButton()
        Me.btnStatistics = New System.Windows.Forms.ToolStripButton()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)

        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()

        ' GroupBox1
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "Date Range"

        ' dtpEndDate
        Me.dtpEndDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(89, 58)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpEndDate.TabIndex = 3

        ' dtpStartDate
        Me.dtpStartDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(89, 25)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpStartDate.TabIndex = 2

        ' Label2
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "End Date"

        ' Label1
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Date"

        ' GroupBox2
        Me.GroupBox2.Controls.Add(Me.cboVerificationStatus)
        Me.GroupBox2.Controls.Add(Me.cboPaymentMethod)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Text = "Filters"

        ' cboVerificationStatus
        Me.cboVerificationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVerificationStatus.FormattingEnabled = True
        Me.cboVerificationStatus.Location = New System.Drawing.Point(89, 58)
        Me.cboVerificationStatus.Name = "cboVerificationStatus"
        Me.cboVerificationStatus.Size = New System.Drawing.Size(200, 21)
        Me.cboVerificationStatus.TabIndex = 3

        ' cboPaymentMethod
        Me.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentMethod.FormattingEnabled = True
        Me.cboPaymentMethod.Location = New System.Drawing.Point(89, 25)
        Me.cboPaymentMethod.Name = "cboPaymentMethod"
        Me.cboPaymentMethod.Size = New System.Drawing.Size(200, 21)
        Me.cboPaymentMethod.TabIndex = 2

        ' Label4
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Photo Verified"

        ' Label3
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Payment Method"

        ' ToolStrip1
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me.btnSearch,
            Me.btnAdvancedFilters,
            Me.ToolStripSeparator1,
            Me.btnBatchOperations,
            Me.btnExport,
            Me.btnStatistics})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip1.TabIndex = 2

        ' btnSearch
        Me.btnSearch.Image = My.Resources.search
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 22)
        Me.btnSearch.Text = "Search"

        ' btnAdvancedFilters
        Me.btnAdvancedFilters.Image = My.Resources.filter
        Me.btnAdvancedFilters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdvancedFilters.Name = "btnAdvancedFilters"
        Me.btnAdvancedFilters.Size = New System.Drawing.Size(108, 22)
        Me.btnAdvancedFilters.Text = "Advanced Filters"

        ' ToolStripSeparator1
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)

        ' btnBatchOperations
        Me.btnBatchOperations.Image = My.Resources.batch
        Me.btnBatchOperations.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBatchOperations.Name = "btnBatchOperations"
        Me.btnBatchOperations.Size = New System.Drawing.Size(116, 22)
        Me.btnBatchOperations.Text = "Batch Operations"

        ' btnExport
        Me.btnExport.Image = My.Resources.export
        Me.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(61, 22)
        Me.btnExport.Text = "Export"

        ' btnStatistics
        Me.btnStatistics.Image = My.Resources.chart
        Me.btnStatistics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(73, 22)
        Me.btnStatistics.Text = "Statistics"

        ' dgvTransactions
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        Me.dgvTransactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Location = New System.Drawing.Point(12, 134)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.Size = New System.Drawing.Size(960, 382)
        Me.dgvTransactions.TabIndex = 3

        ' StatusStrip1
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 4

        ' lblStatus
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 17)
        Me.lblStatus.Text = "Ready"

        ' chkSelectAll
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Location = New System.Drawing.Point(12, 519)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(70, 17)
        Me.chkSelectAll.TabIndex = 5
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True

        ' Timer1
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000

        ' TransactionLogForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "TransactionLogForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Log"

        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboVerificationStatus As ComboBox
    Friend WithEvents cboPaymentMethod As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSearch As ToolStripButton
    Friend WithEvents btnAdvancedFilters As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnBatchOperations As ToolStripButton
    Friend WithEvents btnExport As ToolStripButton
    Friend WithEvents btnStatistics As ToolStripButton
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents chkSelectAll As CheckBox
    Friend WithEvents Timer1 As Timer
End Class 