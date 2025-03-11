Public Class BatchOperationsForm
    Private selectedRows As List(Of DataGridViewRow)
    Private connectionString As String = "Server=localhost;Database=db_parkir;Uid=root;Pwd=;"

    Public Sub New(rows As List(Of DataGridViewRow))
        InitializeComponent()
        selectedRows = rows
        InitializeForm()
    End Sub

    Private Sub InitializeForm()
        lblSelectedCount.Text = $"Selected Transactions: {selectedRows.Count}"
        
        ' Load operators for reassignment
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT DISTINCT operator_name FROM transactions WHERE operator_name IS NOT NULL", conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                cboOperator.Items.Add("(No Change)")
                For Each row As DataRow In dt.Rows
                    cboOperator.Items.Add(row("operator_name").ToString())
                Next
                cboOperator.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading operators: " & ex.Message)
        End Try

        ' Initialize verification status options
        cboVerificationStatus.Items.AddRange({"(No Change)", "Mark as Verified", "Mark as Unverified"})
        cboVerificationStatus.SelectedIndex = 0
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If selectedRows.Count = 0 Then
            MessageBox.Show("No transactions selected!")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Prepare update command
                        Dim updateFields As New List(Of String)
                        Dim parameters As New List(Of MySqlParameter)

                        ' Add operator update if selected
                        If cboOperator.SelectedIndex > 0 Then
                            updateFields.Add("operator_name = @OperatorName")
                            parameters.Add(New MySqlParameter("@OperatorName", cboOperator.SelectedItem.ToString()))
                        End If

                        ' Add verification status update if selected
                        If cboVerificationStatus.SelectedIndex > 0 Then
                            updateFields.Add("photo_verified = @PhotoVerified")
                            parameters.Add(New MySqlParameter("@PhotoVerified", cboVerificationStatus.SelectedIndex = 1))
                        End If

                        ' Add notes update if provided
                        If Not String.IsNullOrEmpty(txtNotes.Text.Trim()) Then
                            updateFields.Add("notes = @Notes")
                            parameters.Add(New MySqlParameter("@Notes", txtNotes.Text.Trim()))
                        End If

                        If updateFields.Count = 0 Then
                            MessageBox.Show("No changes selected to apply!")
                            Return
                        End If

                        ' Build update query
                        Dim query As String = "UPDATE transactions SET " & String.Join(", ", updateFields) & _
                                           " WHERE transaction_id = @TransactionID"

                        ' Apply updates to each selected transaction
                        For Each row As DataGridViewRow In selectedRows
                            Using cmd As New MySqlCommand(query, conn, transaction)
                                ' Add common parameters
                                For Each param In parameters
                                    cmd.Parameters.Add(param.Clone())
                                Next

                                ' Add transaction ID parameter
                                cmd.Parameters.AddWithValue("@TransactionID", row.Cells("TransactionId").Value)
                                cmd.ExecuteNonQuery()
                            End Using
                        Next

                        ' Commit transaction
                        transaction.Commit()
                        MessageBox.Show($"Successfully updated {selectedRows.Count} transaction(s)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DialogResult = DialogResult.OK
                        Close()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error applying batch updates: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim preview As String = "The following changes will be applied to " & selectedRows.Count & " transaction(s):" & Environment.NewLine & Environment.NewLine

        If cboOperator.SelectedIndex > 0 Then
            preview &= $"• Change operator to: {cboOperator.SelectedItem}" & Environment.NewLine
        End If

        If cboVerificationStatus.SelectedIndex > 0 Then
            preview &= $"• Set verification status to: {cboVerificationStatus.SelectedItem}" & Environment.NewLine
        End If

        If Not String.IsNullOrEmpty(txtNotes.Text.Trim()) Then
            preview &= $"• Add notes: {txtNotes.Text.Trim()}" & Environment.NewLine
        End If

        If cboOperator.SelectedIndex = 0 AndAlso cboVerificationStatus.SelectedIndex = 0 AndAlso String.IsNullOrEmpty(txtNotes.Text.Trim()) Then
            preview &= "No changes selected!"
        End If

        MessageBox.Show(preview, "Preview Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class 