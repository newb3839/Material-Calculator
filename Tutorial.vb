Public Class frmTutorial

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmTutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = btnClose
    End Sub
End Class