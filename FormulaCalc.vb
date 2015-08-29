Module FormulaCalc
    'Functions for Rectangle/Cube calculations, Cube indicates 3 dimensional, Rect indicates 2 Dimensions
    'Area(single side), Perimeter (SS - single side), Volume, Surface Area, Cube perimeter

    '=================================================================================================================
    ' RECTANGLE FUNCTIONABILITY
    '=================================================================================================================
    Public Function Rect_Area(ByVal dblWidth As Double, ByVal dblHeight As Double) As Double

        Dim dblArea As Double = 0 'Area variable needed for return value

        dblArea = (dblWidth * dblHeight) 'Area of a rectangle

        Return dblArea

    End Function

    Public Function Rect_Perim(ByVal dblWidth As Double, ByVal dblHeight As Double) As Double

        Dim dblPerim As Double = 0

        dblPerim = (dblWidth * 2) + (dblHeight * 2) 'Perimeter of a 2 dimensional square

        Return dblPerim

    End Function

    Public Function Rect_Hypo(ByVal dblWidth As Double, ByVal dblHeight As Double) As Double

        Dim dblHypotenuse As Double = 0

        dblHypotenuse = Math.Sqrt((dblWidth ^ 2) + (dblHeight ^ 2)) 'Gets hypotenuse (3rd side of the triangle)

        Return dblHypotenuse

    End Function

    Public Function Cube_Vol(ByVal dblWidth As Double, ByVal dblHeight As Double, ByVal dblDepth As Double) As Double

        Dim dblVolume As Double = 0

        dblVolume = (dblWidth * dblHeight * dblDepth) 'Volume of a rectangle (cube)

        Return dblVolume

    End Function

    Public Function Cube_Surface(ByVal dblWidth As Double, ByVal dblHeight As Double, ByVal dblDepth As Double) As Double

        Dim dblSurfArea As Double = 0

        dblSurfArea = ((dblWidth * dblHeight) * 2) + ((dblWidth * dblDepth) * 2) + ((dblHeight * dblDepth) * 2) 'Cube S.A.

        Return dblSurfArea

    End Function

    Public Function Cube_Perim(ByVal dblWidth As Double, ByVal dblHeight As Double, ByVal dblDepth As Double) As Double

        Dim dblCubeSA As Double = 0

        dblCubeSA = (dblWidth * 4) + (dblHeight * 4) + (dblDepth * 4) 'Perimeter of a cube (12 sides)

        Return dblCubeSA

    End Function
    '=================================================================================================================
    ' CIRCLE FUNCTIONABILITY
    '=================================================================================================================
    Public Function Circ_Area(ByVal dblRadius As Double) As Double

        Dim dblArea As Double = 0

        dblArea = (Math.PI * (dblRadius ^ 2)) ' Area of a circle

        Return dblArea

    End Function

    Public Function Circ_Circum(ByVal dblRadius As Double) As Double

        Dim dblCircum As Double = 0

        dblCircum = (2 * Math.PI * dblRadius) ' Circumference of a circle

        Return dblCircum

    End Function

    Public Function Circ_Diam(ByVal dblRadius As Double) As Double

        Dim dblDiam As Double = 0

        dblDiam = (2 * dblRadius) ' Diameter of a circle, given its radius

        Return dblDiam

    End Function

    Public Function Circ_Diam_Rad(ByVal dblDiameter As Double) As Double

        Dim dblRadius As Double = 0

        dblRadius = (dblDiameter / 2) ' Radius of a circle, given its diameter

        Return dblRadius
    End Function

    Public Function Circ_Sph_Vol(ByVal dblRadius As Double) As Double

        Dim dblVol As Double = 0

        dblVol = (4 / 3) * Math.PI * (dblRadius ^ 3) ' Volume of a sphere

        Return dblVol

    End Function

    Public Function Circ_Circum_Rad(ByVal dblCircum As Double) As Double

        Dim dblRadius As Double = 0

        dblRadius = ((dblCircum) / (2 * Math.PI)) ' Get radius, given the circumference

        Return dblRadius

    End Function

    Public Function Circ_Cyl_Vol(ByVal dblRadius As Double, ByVal dblLength As Double) As Double

        Dim dblCylVol As Double = 0

        dblCylVol = (Math.PI * (dblRadius ^ 2) * dblLength)

        Return dblCylVol

    End Function

    Public Function Circ_Cyl_SurfArea(ByVal dblRadius As Double, ByVal dblLength As Double) As Double

        Dim dblCylSA As Double = 0

        dblCylSA = (2 * Math.PI * dblRadius) * (dblLength)

        Return dblCylSA

    End Function

    '=========Function for conversion Decimal to SAE fractional Equivelancy =======
    Public Function Dec_To_Inch(ByVal dblValue As Double) As String

        Dim str1 As String = "1/16"
        Dim str2 As String = "1/8"
        Dim str3 As String = "3/16"
        Dim str4 As String = "1/4"
        Dim str5 As String = "5/16"
        Dim str6 As String = "3/8"
        Dim str7 As String = "7/16"
        Dim str8 As String = "1/2"
        Dim str9 As String = "9/16"
        Dim str10 As String = "5/8"
        Dim str11 As String = "11/16"
        Dim str12 As String = "3/4"
        Dim str13 As String = "13/16"
        Dim str14 As String = "7/8"
        Dim str15 As String = "15/16"


        If dblValue > 0 And dblValue <= 0.0625 Then
            Return str1
        ElseIf dblValue > 0.0625 And dblValue <= 0.125 Then
            Return str2
        ElseIf dblValue > 0.125 And dblValue <= 0.1875 Then
            Return str3
        ElseIf dblValue > 0.1875 And dblValue <= 0.025 Then
            Return str4
        ElseIf dblValue > 0.25 And dblValue <= 0.3125 Then
            Return str5
        ElseIf dblValue > 0.3125 And dblValue <= 0.375 Then
            Return str6
        ElseIf dblValue > 0.375 And dblValue <= 0.4375 Then
            Return str7
        ElseIf dblValue > 0.04375 And dblValue <= 0.5 Then
            Return str8
        ElseIf dblValue > 0.5 And dblValue <= 0.5625 Then
            Return str9
        ElseIf dblValue > 0.5625 And dblValue <= 0.625 Then
            Return str10
        ElseIf dblValue > 0.625 And dblValue <= 0.6875 Then
            Return str11
        ElseIf dblValue > 0.6875 And dblValue <= 0.75 Then
            Return str12
        ElseIf dblValue > 0.75 And dblValue <= 0.8125 Then
            Return str13
        ElseIf dblValue > 0.8125 And dblValue <= 0.875 Then
            Return str14
        ElseIf dblValue > 0.875 And dblValue <= 0.9375 Then
            Return str15
        End If

    End Function



End Module
