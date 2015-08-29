Public Class frmRectangles


    Private Sub frmRectangles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtHeight
        lstRecInfo.Items.Clear()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblHeight As Double = 0
        Dim dblWidth As Double = 0
        Dim dblDepth As Double = 0
        Dim dblArea As Double = 0
        Dim dblPerimeter As Double = 0
        Dim dbl3DSArea As Double = 0
        Dim dbl3DPerim As Double = 0
        Dim dblVolume As Double = 0
        Dim dblHypotenuse As Double = 0
        Dim dblBoardLength As Double = 0
        Dim dblBoardDist As Double = 0
        Dim strComments As String
        Dim bolIsValid As Boolean = False



        If txtDepth.Text = "" Then 'Uses 2 Dimensional checking and formulas

            ' Error checks for non numeric entries and values less than zero
            bolIsValid = Double.TryParse(txtHeight.Text, dblHeight) ' Error checks Height (non numeric)
            If bolIsValid = False Then
                MsgBox("Error, Please enter a numeric value for the Height", vbOKOnly, "Input Error")
                txtHeight.Clear()
                txtHeight.Focus()
                Exit Sub
            ElseIf dblHeight <= 0 Then ' Error checks values less than or equal to 0
                MsgBox("Error, I'm sorry you must input a positive value for the Height", vbOKOnly, "Input Error")
            End If

            bolIsValid = Double.TryParse(txtWidth.Text, dblWidth) ' Error checks Width (non numeric)
            If bolIsValid = False Then
                MsgBox("Error, Please enter a numeric value for the Width", vbOKOnly, "Input Error")
                txtWidth.Clear()
                txtWidth.Focus()
                Exit Sub
            ElseIf dblWidth <= 0 Then ' Error checks values less than or equal to 0
                MsgBox("Error, I'm sorry you must input a positive value for the Width", vbOKOnly, "Input Error")
            End If

            ' Does all the math using the formulas located on FormulaCalc module
            dblArea = Rect_Area(dblWidth, dblHeight)
            dblPerimeter = Rect_Perim(dblWidth, dblHeight)
            dblBoardLength = (2 * dblHeight) + (2 * (dblWidth + 3.0))

            ' Convert to strings for display on form
            txtArea.Text = dblArea.ToString("N2")
            txtPerimeter.Text = dblPerimeter.ToString("N2")
            strComments = txtComments.Text


            ' Does math for hypotenuse(for additional info list box)
            dblHypotenuse = Rect_Hypo(dblWidth, dblHeight)

            If chkResults.Checked = False Then
                lstRecInfo.Items.Clear()
            End If

            ' Adds additional information to the list box 
            lstRecInfo.Items.Add(strComments)
            lstRecInfo.Items.Add("The area of this rectangle is " & dblArea & " square units.")
            lstRecInfo.Items.Add("The perimeter of the rectangle is " & dblPerimeter & " units long, (2 dimensional rectangle).")
            lstRecInfo.Items.Add("From corner to corner (FOR SQUARING) the distance is " & dblHypotenuse.ToString("N2") & " units across.")
            lstRecInfo.Items.Add("If you're using standard 2 X __ boards for a simple square your total board length will be " & dblBoardLength & " units long.")
            lstRecInfo.Items.Add("__________________________________________")

        Else ' Uses all 3 entries for 3 dimensional output

            ' Error checks for non numeric entries and values less than zero
            bolIsValid = Double.TryParse(txtHeight.Text, dblHeight) ' Error checks Height (non numeric)
            If bolIsValid = False Then
                MsgBox("Error, Please enter a numeric value for the Height", vbOKOnly, "Input Error")
                txtHeight.Clear()
                txtHeight.Focus()
                Exit Sub
            ElseIf dblHeight <= 0 Then ' Error checks values less than or equal to 0
                MsgBox("Error, I'm sorry you must input a positive value for the Height", vbOKOnly, "Input Error")
            End If

            bolIsValid = Double.TryParse(txtWidth.Text, dblWidth) ' Error checks Width (non numeric)
            If bolIsValid = False Then
                MsgBox("Error, Please enter a numeric value for the Width", vbOKOnly, "Input Error")
                txtWidth.Clear()
                txtWidth.Focus()
                Exit Sub
            ElseIf dblWidth <= 0 Then ' Error checks values less than or equal to 0
                MsgBox("Error, I'm sorry you must input a positive value for the Width", vbOKOnly, "Input Error")
            End If

            bolIsValid = Double.TryParse(txtDepth.Text, dblDepth) ' Error checks Depth (non numeric)
            If bolIsValid = False Then
                MsgBox("Error, Please enter a numeric value for the Depth", vbOKOnly, "Input Error")
                txtDepth.Clear()
                txtDepth.Focus()
                Exit Sub
            End If

            ' Does all the math using the formulas located on FormulaCalc module
            dblArea = Rect_Area(dblWidth, dblHeight)
            dblPerimeter = Rect_Perim(dblWidth, dblHeight)
            dbl3DSArea = Cube_Surface(dblWidth, dblHeight, dblDepth)
            dblVolume = Cube_Vol(dblWidth, dblHeight, dblDepth)
            dbl3DPerim = Cube_Perim(dblWidth, dblHeight, dblDepth)
            dblBoardLength = (2 * dblHeight) + (2 * (dblWidth + 3.0))

            ' Performs additional math for use in the list box
            dblHypotenuse = Math.Sqrt((dblWidth ^ 2) + (dblHeight ^ 2))

            ' Convert to strings for display on form
            txtArea.Text = dblArea.ToString("N2")
            txtPerimeter.Text = dblPerimeter.ToString("N2")
            txt3DSurfArea.Text = dbl3DSArea.ToString("N2")
            txtVolume.Text = dblVolume.ToString("N2")
            txt3DPerim.Text = dbl3DPerim.ToString("N2")
            strComments = txtComments.Text
            ' Displays additional information in the list box

            If chkResults.Checked = False Then
                lstRecInfo.Items.Clear()
            End If

            ' Displays additional information in the list box
            lstRecInfo.Items.Add(strComments)
            lstRecInfo.Items.Add("The area of this rectangle is " & dblArea & " square units.")
            lstRecInfo.Items.Add("The perimeter of the rectangle is " & dblPerimeter & " units long, (2 dimensional rectangle).")
            lstRecInfo.Items.Add("From corner to corner (FOR SQUARING) the distance is " & dblHypotenuse.ToString("N2") & " units across.")
            lstRecInfo.Items.Add("The 3-Dimension total surface area is " & dbl3DSArea & " square units.")
            lstRecInfo.Items.Add("The total volume of the 3-D rectangle is " & dblVolume & " cubic units")
            lstRecInfo.Items.Add("The total perimeter of all 3 dimensions " & dbl3DPerim & " units long.")
            lstRecInfo.Items.Add("If you're using standard 2 X __ boards for a simple square your total board length will be " & dblBoardLength & " units long.")
            lstRecInfo.Items.Add("__________________________________________")
        End If

    End Sub

    ' Clears all entries from the the text boxes and returns the focus to the Height text entry box
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHeight.Clear()
        txtWidth.Clear()
        txtDepth.Clear()
        txtArea.Clear()
        txtPerimeter.Clear()
        txt3DSurfArea.Clear()
        txtVolume.Clear()
        txt3DPerim.Clear()
        txtComments.Clear()
        If chkResults.Checked = False Then
            lstRecInfo.Items.Clear()
        End If
        txtHeight.Focus()
    End Sub


    Private Sub btnTips_Click(sender As Object, e As EventArgs) Handles btnTips.Click
        frmRectTips.Show()
    End Sub

    Private Sub btnWriteTo_Click(sender As Object, e As EventArgs) Handles btnWriteTo.Click
        If txtArea.Text = "" Then
            MsgBox("Error! You must do at least one calculation before you write to a text file, otherwise the file would be blank!  Do a calculation (or as many as needed) and try again!", vbOKOnly, "Error")
            Exit Sub
        Else

            Dim swMaterials As IO.StreamWriter = IO.File.AppendText("C:/Users/Chris/Desktop/Materials.txt")

            For Each swListItems As String In lstRecInfo.Items
                swMaterials.WriteLine(swListItems)

            Next
            swMaterials.Close()
            MsgBox("Your text file with the materials list should be located on your desktop now!", vbOKOnly, "Confirmation")
        End If

    End Sub
End Class