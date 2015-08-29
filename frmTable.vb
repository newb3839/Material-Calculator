Public Class frmTable
    Private Sub frmTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = btnClose
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class