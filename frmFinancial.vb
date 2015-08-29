Public Class frmFinancial
    Public dblSum As Double = 0 ' Summing varible for running totals
    Public intCnt As Integer = 0 ' Counts the number of items 
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each txtI In tlpFinancial.Controls.OfType(Of TextBox)()
            txtI.Clear()
        Next
        txtComments.Clear()
        txtInterest.Clear()
        txtAddAmt.Clear()
        If chkResults.Checked = False Then
            lstFinancialOut.Items.Clear()
        End If
        txtItem1.Focus()
    End Sub

  
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        Dim strComments As String
        Dim sngIntPerc As Single = 0
        Dim sngAddAmt As Single = 0
        Dim dblTotPlusPerc As Double = 0
        Dim dblTotPercAddAmt As Double = 0
        Dim dblFinalTotal As Double = 0
        Dim bolIsValid As Double = 0

        If chkResults.Checked = False Then
            lstFinancialOut.Items.Clear()
        End If

        strComments = txtComments.Text ' Puts text in comments box into string variable for use in list box
        lstFinancialOut.Items.Add(strComments) ' Adds the initial commentary to the top of the listbox

        For j As Integer = 0 To tlpFinancial.RowCount - 1
            Dim itemName As String
            Dim sngCost As Single = 0
            Dim sngQty As Single = 0
            Dim dblTotal As Double = 0 ' Variable for totaling each line

            itemName = tlpFinancial.GetControlFromPosition(0, j).Text

            If itemName.Trim <> "" Then
                Dim itemCost As String
                itemCost = tlpFinancial.GetControlFromPosition(1, j).Text
                bolIsValid = Single.TryParse(tlpFinancial.GetControlFromPosition(1, j).Text, sngCost)
                If bolIsValid = False Then
                    MsgBox("Error! You must input a valid numeric entry for the Cost")
                    tlpFinancial.GetControlFromPosition(1, j).Text = ""
                    tlpFinancial.GetControlFromPosition(1, j).Focus()
                    Exit Sub
                End If

                Dim itemQty As String
                itemQty = tlpFinancial.GetControlFromPosition(2, j).Text
                bolIsValid = Single.TryParse(tlpFinancial.GetControlFromPosition(2, j).Text, sngQty)
                If bolIsValid = False Then
                    MsgBox("Error! You must input a valid numeric entry for the Quantity")
                    tlpFinancial.GetControlFromPosition(2, j).Text = ""
                    tlpFinancial.GetControlFromPosition(2, j).Focus()
                    Exit Sub
                End If

                intCnt += 1
                dblTotal = (sngCost * sngQty)
                dblSum = (dblSum + dblTotal)
                lstFinancialOut.Items.Add("The cost for " & itemName & " is " & dblTotal.ToString("C") & ".")
            End If
        Next


        ' Begin writing final totals to list box
        lstFinancialOut.Items.Add("The total for the " & intCnt.ToString & " item(s) you entered is " & dblSum.ToString("C") & ".")

        If txtInterest.Text <> String.Empty Then ' Only adds this line if an interest % is given
            bolIsValid = Single.TryParse(txtInterest.Text, sngIntPerc)
            If bolIsValid = False Then
                MsgBox("Error, you must input a valid numeric entry for the Interest")
                txtInterest.Clear()
                txtInterest.Focus()
                Exit Sub
            End If

            dblTotPlusPerc = (dblSum * (1 + sngIntPerc)) 'only does math if value is given
            lstFinancialOut.Items.Add("The total for all the items (" & dblSum.ToString("C") & ") plus the interest percentage you")
            lstFinancialOut.Items.Add(" chose is " & dblTotPlusPerc.ToString("C") & ".")
        End If

        If txtAddAmt.Text <> String.Empty Then ' Only adds this line if additional amount is also given
            bolIsValid = Single.TryParse(txtAddAmt.Text, sngAddAmt)
            If bolIsValid = False Then
                MsgBox("Error, you must input a valid numeric entry for the Additional Amount")
                txtAddAmt.Clear()
                txtAddAmt.Focus()
                Exit Sub
            End If

            dblTotPercAddAmt = (dblTotPlusPerc + sngAddAmt) ' only does math if value is given
            lstFinancialOut.Items.Add("The total for all items (" & dblSum.ToString("C") & ") plus the interest percentage total")
            lstFinancialOut.Items.Add(" of " & dblTotPlusPerc.ToString("C") & ") plus the additional amount you entered is " & dblTotPercAddAmt.ToString("C") & ".")
        End If

        lstFinancialOut.Items.Add("______________________________________________")
        lstFinancialOut.Items.Add("")

    End Sub


    Private Sub btnWriteTo_Click(sender As Object, e As EventArgs) Handles btnWriteTo.Click
        If intCnt < 1 Then
            MsgBox("Error! You must do at least one calculation before you write to a text file, otherwise the file would be blank!  Do a calculation (or as many as needed) and try again!", vbOKOnly, "Error")
            Exit Sub

        Else
            Dim swMaterials As IO.StreamWriter = IO.File.AppendText("C:/Users/Chris/Desktop/Materials.txt")

            For Each swListItems As String In lstFinancialOut.Items
                swMaterials.WriteLine(swListItems)

            Next
            swMaterials.Close()
            MsgBox("Your text file with the materials list should be located on your desktop now!", vbOKOnly, "Confirmation")
        End If
    End Sub

    Private Sub btnTips_Click(sender As Object, e As EventArgs) Handles btnTips.Click
        frmFinancialTips.Show()
    End Sub
End Class