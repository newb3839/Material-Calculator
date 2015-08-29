Public Class frmTriangles

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtSmallA.Clear()
        txtSmallB.Clear()
        txtSmallC.Clear()
        lstTriInfo.Items.Clear()
        txtComments.Clear()
        If chkResults.Checked = False Then
            lstTriInfo.Items.Clear()
        End If
    End Sub

    Private Sub btnTips_Click(sender As Object, e As EventArgs) Handles btnTips.Click
        frmTriangleTips.Show()
    End Sub


    Private Sub btnWriteTo_Click(sender As Object, e As EventArgs) Handles btnWriteTo.Click
        If lstTriInfo.Items.Count = 0 Then
            MsgBox("Error! You must do at least one calculation before you write to a text file, otherwise the file would be blank!  Do a calculation (or as many as needed) and try again!", vbOKOnly, "Error")
            Exit Sub
        Else
            Dim swMaterials As IO.StreamWriter = IO.File.AppendText("C:/Users/Chris/Desktop/Materials.txt")

            For Each swListItems As String In lstTriInfo.Items
                swMaterials.WriteLine(swListItems)
            Next
            swMaterials.Close()
            MsgBox("Your text file with the materials list should be located on your desktop now!", vbOKOnly, "Confirmation")
        End If

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        frmConvert.Show()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)

        Dim bolIsValid As Boolean = False
        Dim dblAngleSum As Double = 0
        Dim dblA As Double = 0 ' 3 Angle variables
        Dim dblB As Double = 0
        Dim dblC As Double = 0
        Dim sngSideA As Single = 0 ' 3 Side variables
        Dim sngSideB As Single = 0
        Dim sngSideC As Single = 0
        Dim strComments As String ' string variable for comments box

        If chkResults.Checked = False Then 'clears previous entries if show previous results is not checked
            lstTriInfo.Items.Clear()
        End If

        strComments = txtComments.Text ' puts comments box into a string variable

        If Not txtA.Text = "" Then
            bolIsValid = Double.TryParse(txtA.Text, dblA)
            If bolIsValid = False Then
                MsgBox("Error, you must enter a numeric value for the angle in this textbox")
                txtA.Clear()
                txtA.Focus()
            End If
            If dblA <= 0 Or dblA > 179.9998 Then
                MsgBox("Error, you have entered an invalid angle reenter an angle and try again ")
                txtA.Clear()
                txtA.Focus()
            End If
        End If

        If Not txtB.Text = "" Then
            bolIsValid = Double.TryParse(txtB.Text, dblB)
            If bolIsValid = False Then
                MsgBox("Error, you must enter a numeric value for the angle in this textbox")
                txtB.Clear()
                txtB.Focus()
            End If
            If dblB <= 0 Or dblB > 179.9998 Then
                MsgBox("Error, you have entered an invalid angle reenter an angle and try again ")
                txtB.Clear()
                txtB.Focus()
            End If
        End If

        If Not txtC.Text = "" Then
            bolIsValid = Double.TryParse(txtC.Text, dblC)
            If bolIsValid = False Then
                MsgBox("Error, you must enter a numeric value for the angle in this textbox")
                txtC.Clear()
                txtC.Focus()
            End If
            If dblC <= 0 Or dblC > 179.9998 Then
                MsgBox("Error, you have entered an invalid angle reenter an angle and try again ")
                txtC.Clear()
                txtC.Focus()
            End If
        End If

        If dblA + dblB + dblC >= 180 Then
            MsgBox("Error, there can only be 180 total degrees of angles inside a triangle")
            txtA.Clear()
            txtB.Clear()
            txtC.Clear()
            txtA.Focus()
        End If

        dblAngleSum = dblA + dblB + dblC

        '=========================================================================




        '=========================================================================

        lstTriInfo.Items.Add(strComments)
        lstTriInfo.Items.Add("")
    End Sub
End Class