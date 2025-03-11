Partial Class BatchOperationsForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSelectedCount = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboOperator = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboVerificationStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()

        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()

        ' GroupBox1
        Me.GroupBox1.Controls.Add(Me.lblSelectedCount)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "Selection"

        ' lblSelectedCount
        Me.lblSelectedCount.AutoSize = True
        Me.lblSelectedCount.Location = New System.Drawing.Point(6, 20)
        Me.lblSelectedCount.Name = "lblSelectedCount"
        Me.lblSelectedCount.Size = New System.Drawing.Size(116, 13)
        Me.lblSelectedCount.TabIndex = 0
        Me.lblSelectedCount.Text = "Selected Transactions: 0"

        ' GroupBox2
        Me.GroupBox2.Controls.Add(Me.cboOperator)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Text = "Operator Assignment"

        ' cboOperator
        Me.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperator.FormattingEnabled = True
        Me.cboOperator.Location = New System.Drawing.Point(89, 22)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.Size = New System.Drawing.Size(250, 21)
        Me.cboOperator.TabIndex = 1

        ' Label1
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assign Operator"

        ' GroupBox3
        Me.GroupBox3.Controls.Add(Me.cboVerificationStatus)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 60)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.Text = "Verification Status"

        ' cboVerificationStatus
        Me.cboVerificationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVerificationStatus.FormattingEnabled = True
        Me.cboVerificationStatus.Location = New System.Drawing.Point(89, 22)
        Me.cboVerificationStatus.Name = "cboVerificationStatus"
        Me.cboVerificationStatus.Size = New System.Drawing.Size(250, 21)
        Me.cboVerificationStatus.TabIndex = 1

        ' Label2
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Update Status"

        ' GroupBox4
        Me.GroupBox4.Controls.Add(Me.txtNotes)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.Text = "Additional Notes"

        ' txtNotes
        Me.txtNotes.Location = New System.Drawing.Point(6, 19)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(348, 75)
        Me.txtNotes.TabIndex = 0

        ' btnPreview
        Me.btnPreview.Location = New System.Drawing.Point(93, 306)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True

        ' btnApply
        Me.btnApply.Location = New System.Drawing.Point(174, 306)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 5
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True

        ' btnCancel
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(255, 306)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True

        ' BatchOperationsForm
        Me.AcceptButton = Me.btnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(384, 341)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BatchOperationsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Batch Operations"

        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSelectedCount As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboOperator As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboVerificationStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
End Class 