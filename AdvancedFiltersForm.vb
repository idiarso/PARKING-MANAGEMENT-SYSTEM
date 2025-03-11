Public Class AdvancedFiltersForm
    Public Property MinAmount As Decimal?
    Public Property MaxAmount As Decimal?
    Public Property VehicleType As String
    Public Property OperatorName As String
    Public Property IsLostTicket As Boolean?

    Public Sub New()
        InitializeComponent()
        LoadVehicleTypes()
        LoadOperators()
    End Sub

    Private Sub LoadVehicleTypes()
        Try
            Using conn As New MySqlConnection("Server=localhost;Database=db_parkir;Uid=root;Pwd=;")
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT DISTINCT id_kendaraan, jenis_kendaraan FROM biaya_parkir", conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                cboVehicleType.Items.Add("All")
                For Each row As DataRow In dt.Rows
                    cboVehicleType.Items.Add(row("jenis_kendaraan").ToString())
                Next
                cboVehicleType.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading vehicle types: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadOperators()
        Try
            Using conn As New MySqlConnection("Server=localhost;Database=db_parkir;Uid=root;Pwd=;")
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT DISTINCT operator_name FROM transactions WHERE operator_name IS NOT NULL", conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                cboOperator.Items.Add("All")
                For Each row As DataRow In dt.Rows
                    cboOperator.Items.Add(row("operator_name").ToString())
                Next
                cboOperator.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading operators: " & ex.Message)
        End Try
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        ' Validate amount range
        If Not String.IsNullOrEmpty(txtMinAmount.Text) Then
            If Not Decimal.TryParse(txtMinAmount.Text, MinAmount) Then
                MessageBox.Show("Invalid minimum amount")
                Return
            End If
        End If

        If Not String.IsNullOrEmpty(txtMaxAmount.Text) Then
            If Not Decimal.TryParse(txtMaxAmount.Text, MaxAmount) Then
                MessageBox.Show("Invalid maximum amount")
                Return
            End If
        End If

        ' Set vehicle type
        If cboVehicleType.SelectedIndex > 0 Then
            VehicleType = cboVehicleType.SelectedItem.ToString()
        End If

        ' Set operator
        If cboOperator.SelectedIndex > 0 Then
            OperatorName = cboOperator.SelectedItem.ToString()
        End If

        ' Set lost ticket filter
        If chkLostTicket.CheckState <> CheckState.Indeterminate Then
            IsLostTicket = chkLostTicket.Checked
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtMinAmount.Clear()
        txtMaxAmount.Clear()
        cboVehicleType.SelectedIndex = 0
        cboOperator.SelectedIndex = 0
        chkLostTicket.CheckState = CheckState.Indeterminate
        MinAmount = Nothing
        MaxAmount = Nothing
        VehicleType = Nothing
        OperatorName = Nothing
        IsLostTicket = Nothing
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinAmount.KeyPress, txtMaxAmount.KeyPress
        ' Allow only numbers, decimal point, and control characters
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class 