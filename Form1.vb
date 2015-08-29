Public Class frmMatCalc

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'NEEDS WORK --- MSGBOXSTYLE.YESNO <---- NEEDS TO BE FINISHED
    End Sub

    Private Sub frmMatCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTutorial_Click(sender As Object, e As EventArgs) Handles btnTutorial.Click
        frmTutorial.Show()
    End Sub

    Private Sub btnRectangle_Click(sender As Object, e As EventArgs) Handles btnRectangle.Click
        frmRectangles.Show()
    End Sub

    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click
        frmTriangles.Show()
    End Sub

    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click
        frmCircles.Show()
    End Sub

    Private Sub btnFinancial_Click(sender As Object, e As EventArgs) Handles btnFinancial.Click
        frmFinancial.Show()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        frmConvert.Show()
    End Sub
End Class
