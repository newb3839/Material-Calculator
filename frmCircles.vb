Public Class frmCircles

    Private Sub frmCircles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtRadius
        lstCircInfo.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnTips_Click(sender As Object, e As EventArgs) Handles btnTips.Click
        frmCirclesTips.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRadius.Clear()
        txtDiameter.Clear()
        txtCircum.Clear()
        txtRadOut.Clear()
        txtDiamOut.Clear()
        txtCircumOut.Clear()
        txtAreaOut.Clear()
        txtVolOut.Clear()
        txtLength.Clear()
        txtVolCylOut.Clear()
        txtComments.Clear()
        If chkResults.Checked = False Then
            lstCircInfo.Items.Clear()
        End If
        txtRadius.Focus()
    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblRadius As Double = 0
        Dim dblDiameter As Double = 0
        Dim dblCircumference As Double = 0
        Dim dblVolume As Double = 0
        Dim dblArea As Double = 0
        Dim dblLength As Double = 0
        Dim dblCylVol As Double = 0
        Dim dblCylSA As Double = 0
        Dim dblHalfCir As Double = 0
        Dim dblQtrCir As Double = 0
        Dim dblEndArea As Double = 0
        Dim strComments As String
        Dim bolIsValid As Boolean = False


        ' ========================================================================================================
        ' THIS SECTION COVERS THE BASIC CIRCLE USAGE PORTION - NOT CYLINDER - JUST CIRCLE/SPHERE
        ' ========================================================================================================

        ' ADD CYLINDER SURFACE AREA

        If txtRadius.Text = "" And txtDiameter.Text = "" And txtCircum.Text = "" And txtLength.Text = "" Then
            MsgBox("Error! You must enter a value(s) before you can calculate")
            txtRadius.Focus()
            Exit Sub

        ElseIf Not txtRadius.Text = "" And txtDiameter.Text = "" And txtCircum.Text = "" And txtLength.Text = "" Then ' Assumes ONLY radius is given
        
            bolIsValid = Double.TryParse(txtRadius.Text, dblRadius)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Radius", vbOKOnly, "Input Error")
                txtRadius.Clear()
                txtRadius.Focus()
                Exit Sub
            End If

            ' Call functions
            dblDiameter = Circ_Diam(dblRadius) ' Diameter function
            dblCircumference = Circ_Circum(dblRadius) ' Circumference function
            dblArea = Circ_Area(dblRadius) ' Area function
            dblVolume = Circ_Sph_Vol(dblRadius) ' Volume function
            dblQtrCir = (dblCircumference / 4)
            dblHalfCir = (dblCircumference / 2)

            ' Format data for output
            txtRadOut.Text = dblRadius.ToString("N3") ' Moves radius value from a variable to the radius output
            txtDiamOut.Text = dblDiameter.ToString("N3")
            txtCircumOut.Text = dblCircumference.ToString("N3")
            txtAreaOut.Text = dblArea.ToString("N3")
            txtVolOut.Text = dblVolume.ToString("N3")
            strComments = txtComments.Text

            If chkResults.Checked = False Then
                lstCircInfo.Items.Clear()
            End If
            lstCircInfo.Items.Add(strComments)
            lstCircInfo.Items.Add("The radius you entered was" & dblRadius.ToString("N3") & ".")
            lstCircInfo.Items.Add("The diameter of the circle is " & dblDiameter.ToString("N3") & ".")
            lstCircInfo.Items.Add("The circumrference of the circle is " & dblCircumference.ToString("N3") & ".")
            lstCircInfo.Items.Add("The area of the circle is " & dblArea.ToString("N3") & ".")
            lstCircInfo.Items.Add("The volume of the circle (as a sphere) is " & dblVolume.ToString("N3") & ".")
            lstCircInfo.Items.Add("One quarter of your circumference would be " & dblQtrCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("One half of your circumference would be " & dblHalfCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("__________________________________________")


        ElseIf Not txtDiameter.Text = "" And txtRadius.Text = "" And txtCircum.Text = "" And txtLength.Text = "" Then ' Assumes ONLY diameter is given

            bolIsValid = Double.TryParse(txtDiameter.Text, dblDiameter)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Diameter", vbOKOnly, "Input Error")
                txtDiameter.Clear()
                txtDiameter.Focus()
                Exit Sub
            End If

            ' Call functions
            dblRadius = Circ_Diam_Rad(dblDiameter) ' Gets radius from diameter
            dblCircumference = Circ_Circum(dblRadius) ' Circumference function
            dblArea = Circ_Area(dblRadius) ' Area function
            dblVolume = Circ_Sph_Vol(dblRadius) ' Volume function
            dblQtrCir = (dblCircumference / 4)
            dblHalfCir = (dblCircumference / 2)

            ' Formats output
            txtRadOut.Text = dblRadius.ToString("N3") ' Outputs radius
            txtDiamOut.Text = dblDiameter.ToString("N3") ' Sends diameter to output (straight across)
            txtCircumOut.Text = dblCircumference.ToString("N3")
            txtAreaOut.Text = dblArea.ToString("N3")
            txtVolOut.Text = dblVolume.ToString("N3")
            strComments = txtComments.Text

            If chkResults.Checked = False Then
                lstCircInfo.Items.Clear()
            End If

            lstCircInfo.Items.Add(strComments)
            lstCircInfo.Items.Add("The radius of the circle is" & dblRadius.ToString("N3") & ".")
            lstCircInfo.Items.Add("The diameter of the circle you entered is " & dblDiameter.ToString("N3") & ".")
            lstCircInfo.Items.Add("The circumrference of the circle is " & dblCircumference.ToString("N3") & ".")
            lstCircInfo.Items.Add("The area of the circle is " & dblArea.ToString("N3") & ".")
            lstCircInfo.Items.Add("The volume of the circle (as a sphere) is " & dblVolume.ToString("N3") & ".")
            lstCircInfo.Items.Add("One quarter of your circumference would be " & dblQtrCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("One half of your circumference would be " & dblHalfCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("__________________________________________")

        ElseIf Not txtCircum.Text = "" And txtRadius.Text = "" And txtDiameter.Text = "" And txtLength.Text = "" Then ' Assumes ONLY circumference is given

            bolIsValid = Double.TryParse(txtCircum.Text, dblCircumference)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Circumference", vbOKOnly, "Input Error")
                txtCircum.Clear()
                txtCircum.Focus()
                Exit Sub
            End If

            dblRadius = Circ_Circum_Rad(dblCircumference)
            dblDiameter = Circ_Diam(dblRadius) ' Diameter function
            dblArea = Circ_Area(dblRadius) ' Area function
            dblVolume = Circ_Sph_Vol(dblRadius) ' Volume function
            dblQtrCir = (dblCircumference / 4)
            dblHalfCir = (dblCircumference / 2)


            txtRadOut.Text = dblRadius.ToString("N3") ' Outputs radius
            txtDiamOut.Text = dblDiameter.ToString("N3") ' Sends diameter to output (straight across)
            txtCircumOut.Text = dblCircumference.ToString("N3")
            txtAreaOut.Text = dblArea.ToString("N3")
            txtVolOut.Text = dblVolume.ToString("N3")
            strComments = txtComments.Text

            If chkResults.Checked = False Then
                lstCircInfo.Items.Clear()
            End If

            lstCircInfo.Items.Add(strComments)
            lstCircInfo.Items.Add("The radius of the circle is" & dblRadius.ToString("N3") & ".")
            lstCircInfo.Items.Add("The diameter of the circle is " & dblDiameter.ToString("N3") & ".")
            lstCircInfo.Items.Add("The circumrference of the circle you entered is " & dblCircumference.ToString("N3") & ".")
            lstCircInfo.Items.Add("The area of the circle is " & dblArea.ToString("N3") & ".")
            lstCircInfo.Items.Add("The volume of the circle (as a sphere) is " & dblVolume.ToString("N3") & ".")
            lstCircInfo.Items.Add("One quarter of your circumference would be " & dblQtrCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("One half of your circumference would be " & dblHalfCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("__________________________________________")

            ' ========================================================================================================
            ' THIS SECTION COVERS THE CYLINDER USAGE PORTION
            ' ========================================================================================================


        ElseIf Not txtRadius.Text = "" And Not txtLength.Text = "" And txtDiameter.Text = "" And txtCircum.Text = "" Then ' Assumes Radius, Length given for Cylinder Volume

            bolIsValid = Double.TryParse(txtRadius.Text, dblRadius)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Radius", vbOKOnly, "Input Error")
                txtRadius.Clear()
                txtRadius.Focus()
                Exit Sub
            End If

            bolIsValid = Double.TryParse(txtLength.Text, dblLength)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Length", vbOKOnly, "Input Error")
                txtLength.Clear()
                txtLength.Focus()
                Exit Sub
            End If

            ' Calls functions
            dblDiameter = Circ_Diam(dblRadius) ' Diameter function
            dblCircumference = Circ_Circum(dblRadius) ' Circumference function
            dblArea = Circ_Area(dblRadius) ' Area function
            dblCylVol = Circ_Cyl_Vol(dblRadius, dblLength) ' Cylinder volume function
            dblCylSA = Circ_Cyl_SurfArea(dblRadius, dblLength) ' Cylinder surface area
            dblQtrCir = (dblCircumference / 4)
            dblHalfCir = (dblCircumference / 2)
            dblEndArea = (2 * dblArea) + (dblCylSA)

            ' Formats data for output
            txtRadOut.Text = dblRadius.ToString("N3")
            txtDiamOut.Text = dblDiameter.ToString("N3")
            txtCircumOut.Text = dblCircumference.ToString("N3")
            txtAreaOut.Text = dblArea.ToString("N3")
            txtVolCylOut.Text = dblCylVol.ToString("N3")
            strComments = txtComments.Text

            If chkResults.Checked = False Then
                lstCircInfo.Items.Clear()
            End If

            lstCircInfo.Items.Add(strComments)
            lstCircInfo.Items.Add("The radius you entered was" & dblRadius.ToString("N3") & ".")
            lstCircInfo.Items.Add("The diameter of the circle is " & dblDiameter.ToString("N3") & ".")
            lstCircInfo.Items.Add("The circumrference of the circle is " & dblCircumference.ToString("N3") & ".")
            lstCircInfo.Items.Add("The area of the circle is " & dblArea.ToString("N3") & ".")
            lstCircInfo.Items.Add("The volume of the cylinder) is " & dblCylVol.ToString("N3") & ".")
            lstCircInfo.Items.Add("The total surface area(does not include ends) is" & dblCylSA & ".")
            lstCircInfo.Items.Add("One quarter of your circumference would be " & dblQtrCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("One half of your circumference would be " & dblHalfCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("The total surface area PLUS the area of the two ends is " & dblEndArea.ToString("N3") & " units.")
            lstCircInfo.Items.Add("__________________________________________")



        ElseIf Not txtDiameter.Text = "" And Not txtLength.Text = "" And txtRadius.Text = "" And txtCircum.Text = "" Then ' Assumes Diam, Length are given (Cyl Vol)

            bolIsValid = Double.TryParse(txtDiameter.Text, dblDiameter)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Diameter", vbOKOnly, "Input Error")
                txtDiameter.Clear()
                txtDiameter.Focus()
                Exit Sub
            End If

            bolIsValid = Double.TryParse(txtLength.Text, dblLength)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Length", vbOKOnly, "Input Error")
                txtLength.Clear()
                txtLength.Focus()
                Exit Sub
            End If

            ' Call Functions
            dblRadius = Circ_Diam_Rad(dblDiameter) ' Gets radius from diameter
            dblCircumference = Circ_Circum(dblRadius) ' Circumference function
            dblArea = Circ_Area(dblRadius) ' Area function
            dblCylVol = Circ_Cyl_Vol(dblRadius, dblLength) ' Cylinder volume function
            dblCylSA = Circ_Cyl_SurfArea(dblRadius, dblLength) ' Cylinder surface area
            dblQtrCir = (dblCircumference / 4)
            dblHalfCir = (dblCircumference / 2)
            dblEndArea = (2 * dblArea) + (dblCylSA)

            'Formats output for display
            txtRadOut.Text = dblRadius.ToString("N3")
            txtDiamOut.Text = dblDiameter.ToString("N3") ' Sends diameter to output (straight across)
            txtCircumOut.Text = dblCircumference.ToString("N3")
            txtAreaOut.Text = dblArea.ToString("N3")
            txtVolCylOut.Text = dblCylVol.ToString("N3")
            strComments = txtComments.Text

            If chkResults.Checked = False Then
                lstCircInfo.Items.Clear()
            End If

            lstCircInfo.Items.Add(strComments)
            lstCircInfo.Items.Add("The radius of the cylinder is" & dblRadius.ToString("N3") & ".")
            lstCircInfo.Items.Add("The diameter of the cylinder you entered is " & dblDiameter.ToString("N3") & ".")
            lstCircInfo.Items.Add("The circumrference of the cylinder is " & dblCircumference.ToString("N3") & ".")
            lstCircInfo.Items.Add("The area of the cylinder (on the end) is " & dblArea.ToString("N3") & ".")
            lstCircInfo.Items.Add("The volume of the cylinder) is " & dblCylVol.ToString("N3") & ".")
            lstCircInfo.Items.Add("The total surface area(does not include ends) is" & dblCylSA & ".")
            lstCircInfo.Items.Add("One quarter of your circumference would be " & dblQtrCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("One half of your circumference would be " & dblHalfCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("The total surface area PLUS the area of the two ends is " & dblEndArea.ToString("N3") & " units.")
            lstCircInfo.Items.Add("__________________________________________")


        ElseIf Not txtCircum.Text = "" And Not txtLength.Text = "" And txtRadius.Text = "" And txtDiameter.Text = "" Then ' Assumes only Circ, Len are given (Cyl Vol)

            bolIsValid = Double.TryParse(txtCircum.Text, dblCircumference)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Circumference", vbOKOnly, "Input Error")
                txtCircum.Clear()
                txtCircum.Focus()
                Exit Sub
            End If

            bolIsValid = Double.TryParse(txtLength.Text, dblLength)
            If bolIsValid = False Then
                MsgBox("Error! You must enter a numeric value for the Length", vbOKOnly, "Input Error")
                txtLength.Clear()
                txtLength.Focus()
                Exit Sub
            End If

            ' Calls functions
            dblRadius = Circ_Circum_Rad(dblCircumference) ' Gets radius from circumference
            dblDiameter = Circ_Diam(dblRadius) ' Diameter function
            dblArea = Circ_Area(dblRadius) ' Area function
            dblCylVol = Circ_Cyl_Vol(dblRadius, dblLength) ' Cylinder volume function
            dblCylSA = Circ_Cyl_SurfArea(dblRadius, dblLength) ' Cylinder surface area
            dblQtrCir = (dblCircumference / 4)
            dblHalfCir = (dblCircumference / 2)
            dblEndArea = (2 * dblArea) + (dblCylSA)

            'Formats output for display
            txtRadOut.Text = dblRadius.ToString("N3")
            txtDiamOut.Text = dblDiameter.ToString("N3") ' Sends diameter to output (straight across)
            txtCircumOut.Text = dblCircumference.ToString("N3")
            txtAreaOut.Text = dblArea.ToString("N3")
            txtVolCylOut.Text = dblCylVol.ToString("N3")
            strComments = txtComments.Text

            If chkResults.Checked = False Then
                lstCircInfo.Items.Clear()
            End If

            lstCircInfo.Items.Add(strComments)
            lstCircInfo.Items.Add("The radius of the cylinder is" & dblRadius.ToString("N3") & ".")
            lstCircInfo.Items.Add("The diameter of the cylinder is " & dblDiameter.ToString("N3") & ".")
            lstCircInfo.Items.Add("The circumrference of the cylinder you entered is " & dblCircumference.ToString("N3") & ".")
            lstCircInfo.Items.Add("The area of the cylinder (on the end) is " & dblArea.ToString("N3") & ".")
            lstCircInfo.Items.Add("The volume of the cylinder is " & dblCylVol.ToString("N3") & ".")
            lstCircInfo.Items.Add("The total surface area(does not include ends) is" & dblCylSA & ".")
            lstCircInfo.Items.Add("One quarter of your circumference would be " & dblQtrCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("One half of your circumference would be " & dblHalfCir.ToString("N3") & " units.")
            lstCircInfo.Items.Add("The total surface area PLUS the area of the two ends is " & dblEndArea.ToString("N3") & " units.")
            lstCircInfo.Items.Add("__________________________________________")


        ElseIf Not txtLength.Text = "" And txtRadius.Text = "" And txtDiameter.Text = "" And txtCircum.Text = "" Then 'Error if only Length input
            MsgBox("Error! You need a Rad/Diam/Circ value along with the Length to get a cylinder volume", vbOKOnly, "Input Error")
            txtRadius.Focus()
            Exit Sub


            ' ========================================================================================================
            ' THIS SECTION COVERS MISCELLANEOUS INPUT ERRORS OR ERROR COMBINATIONS NOT SPECIFIED ABOVE
            ' ========================================================================================================


        Else ' Catches all other miscellaneous input errors, clears entire form
            MsgBox("Error! You may only input EITHER a Radius,a Diameter or Circumrference by themselves for the general circle tools use, or one of the aforementioned three AND a length to calculate Cylinder values. For more information on use of this tool please click on the 'Tips' button on the Circle tools form. ", vbOKOnly, "General Input Error")
            txtRadius.Clear()
            txtDiameter.Clear()
            txtCircum.Clear()
            txtRadOut.Clear()
            txtDiamOut.Clear()
            txtCircumOut.Clear()
            txtAreaOut.Clear()
            txtVolOut.Clear()
            txtLength.Clear()
            txtVolCylOut.Clear()
            txtComments.Clear()
            lstCircInfo.Items.Clear()
            txtRadius.Focus()
            Exit Sub

        End If
    End Sub


    Private Sub btnWriteTo_Click(sender As Object, e As EventArgs) Handles btnWriteTo.Click
        If txtRadOut.Text = "" Then
            MsgBox("Error! You must do at least one calculation before you write to a text file, otherwise the file would be blank!  Do a calculation (or as many as needed) and try again!", vbOKOnly, "Error")
            Exit Sub

        Else
            Dim swMaterials As IO.StreamWriter = IO.File.AppendText("C:/Users/Chris/Desktop/Materials.txt")

            For Each swListItems As String In lstCircInfo.Items
                swMaterials.WriteLine(swListItems)

            Next
            swMaterials.Close()
            MsgBox("Your text file with the materials list should be located on your desktop now!", vbOKOnly, "Confirmation")
        End If

    End Sub
End Class