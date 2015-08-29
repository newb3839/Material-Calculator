Public Class frmConvert
    Private Sub frmConvert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtDecimal
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        frmTable.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDecimal.Clear()
        txtInch.Clear()
        txtDecimal.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim bolIsValid As Boolean = False
        Dim dblInput As Double = 0
        Dim strOutput As String

        If txtDecimal.Text = "" Then
            MsgBox("You must enter a value before you can calculate its SAE fraction!")
            txtDecimal.Focus()
            Exit Sub
        Else
            bolIsValid = Double.TryParse(txtDecimal.Text, dblInput)
            If bolIsValid = False Then
                MsgBox("You must enter an appropriate numeric entry to run this conversion.")
                txtDecimal.Clear()
                txtDecimal.Focus()
                Exit Sub
            End If
            If dblInput >= 1 Then
                MsgBox("You must enter a value greater than 0 but less than 1 inch")
                txtDecimal.Clear()
                txtDecimal.Focus()
                Exit Sub
            End If

        End If
        strOutput = Dec_To_Inch(dblInput)
        txtInch.Text = strOutput.ToString
    End Sub


End Class