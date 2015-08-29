<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinancial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinancial))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstFinancialOut = New System.Windows.Forms.ListBox()
        Me.lblIntPerc = New System.Windows.Forms.Label()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.lblAddAmt = New System.Windows.Forms.Label()
        Me.txtAddAmt = New System.Windows.Forms.TextBox()
        Me.chkResults = New System.Windows.Forms.CheckBox()
        Me.btnWriteTo = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnTips = New System.Windows.Forms.Button()
        Me.txtItem12 = New System.Windows.Forms.TextBox()
        Me.txtQty9 = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.txtQnty9 = New System.Windows.Forms.TextBox()
        Me.txtQnty1 = New System.Windows.Forms.TextBox()
        Me.txtQnty2 = New System.Windows.Forms.TextBox()
        Me.txtQnty3 = New System.Windows.Forms.TextBox()
        Me.txtQnty4 = New System.Windows.Forms.TextBox()
        Me.txtQnty5 = New System.Windows.Forms.TextBox()
        Me.txtQnty6 = New System.Windows.Forms.TextBox()
        Me.txtQnty7 = New System.Windows.Forms.TextBox()
        Me.txtQnty8 = New System.Windows.Forms.TextBox()
        Me.txtQnty10 = New System.Windows.Forms.TextBox()
        Me.txtPrice10 = New System.Windows.Forms.TextBox()
        Me.txtPrice9 = New System.Windows.Forms.TextBox()
        Me.txtPrice8 = New System.Windows.Forms.TextBox()
        Me.txtPrice7 = New System.Windows.Forms.TextBox()
        Me.txtPrice6 = New System.Windows.Forms.TextBox()
        Me.txtPrice5 = New System.Windows.Forms.TextBox()
        Me.txtPrice4 = New System.Windows.Forms.TextBox()
        Me.txtPrice3 = New System.Windows.Forms.TextBox()
        Me.txtPrice2 = New System.Windows.Forms.TextBox()
        Me.txtPrice1 = New System.Windows.Forms.TextBox()
        Me.txtItem10 = New System.Windows.Forms.TextBox()
        Me.txtItem9 = New System.Windows.Forms.TextBox()
        Me.txtItem8 = New System.Windows.Forms.TextBox()
        Me.txtItem7 = New System.Windows.Forms.TextBox()
        Me.txtItem6 = New System.Windows.Forms.TextBox()
        Me.txtItem5 = New System.Windows.Forms.TextBox()
        Me.txtItem4 = New System.Windows.Forms.TextBox()
        Me.txtItem3 = New System.Windows.Forms.TextBox()
        Me.txtItem2 = New System.Windows.Forms.TextBox()
        Me.txtItem1 = New System.Windows.Forms.TextBox()
        Me.tlpFinancial = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpFinancial.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1185, 715)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(160, 61)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(599, 715)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 61)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstFinancialOut
        '
        Me.lstFinancialOut.FormattingEnabled = True
        Me.lstFinancialOut.ItemHeight = 20
        Me.lstFinancialOut.Location = New System.Drawing.Point(751, 52)
        Me.lstFinancialOut.Name = "lstFinancialOut"
        Me.lstFinancialOut.Size = New System.Drawing.Size(593, 584)
        Me.lstFinancialOut.TabIndex = 53
        '
        'lblIntPerc
        '
        Me.lblIntPerc.AutoSize = True
        Me.lblIntPerc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntPerc.Location = New System.Drawing.Point(23, 662)
        Me.lblIntPerc.Name = "lblIntPerc"
        Me.lblIntPerc.Size = New System.Drawing.Size(228, 29)
        Me.lblIntPerc.TabIndex = 54
        Me.lblIntPerc.Text = "Interest Percentage:"
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(257, 665)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(165, 26)
        Me.txtInterest.TabIndex = 2
        '
        'lblAddAmt
        '
        Me.lblAddAmt.AutoSize = True
        Me.lblAddAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddAmt.Location = New System.Drawing.Point(524, 662)
        Me.lblAddAmt.Name = "lblAddAmt"
        Me.lblAddAmt.Size = New System.Drawing.Size(213, 29)
        Me.lblAddAmt.TabIndex = 56
        Me.lblAddAmt.Text = "Additional Amount:"
        '
        'txtAddAmt
        '
        Me.txtAddAmt.Location = New System.Drawing.Point(743, 665)
        Me.txtAddAmt.Name = "txtAddAmt"
        Me.txtAddAmt.Size = New System.Drawing.Size(165, 26)
        Me.txtAddAmt.TabIndex = 3
        '
        'chkResults
        '
        Me.chkResults.AutoSize = True
        Me.chkResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResults.Location = New System.Drawing.Point(1058, 658)
        Me.chkResults.Name = "chkResults"
        Me.chkResults.Size = New System.Drawing.Size(286, 33)
        Me.chkResults.TabIndex = 4
        Me.chkResults.Text = "Show Previous Results"
        Me.chkResults.UseVisualStyleBackColor = True
        '
        'btnWriteTo
        '
        Me.btnWriteTo.Location = New System.Drawing.Point(892, 715)
        Me.btnWriteTo.Name = "btnWriteTo"
        Me.btnWriteTo.Size = New System.Drawing.Size(160, 61)
        Me.btnWriteTo.TabIndex = 6
        Me.btnWriteTo.Text = "&Write To"
        Me.btnWriteTo.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(306, 715)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(160, 61)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnTips
        '
        Me.btnTips.Location = New System.Drawing.Point(13, 715)
        Me.btnTips.Name = "btnTips"
        Me.btnTips.Size = New System.Drawing.Size(160, 61)
        Me.btnTips.TabIndex = 39
        Me.btnTips.Text = "&Tips"
        Me.btnTips.UseVisualStyleBackColor = True
        '
        'txtItem12
        '
        Me.txtItem12.Location = New System.Drawing.Point(3, -87)
        Me.txtItem12.Name = "txtItem12"
        Me.txtItem12.Size = New System.Drawing.Size(165, 26)
        Me.txtItem12.TabIndex = 33
        '
        'txtQty9
        '
        Me.txtQty9.Location = New System.Drawing.Point(3, -67)
        Me.txtQty9.Name = "txtQty9"
        Me.txtQty9.Size = New System.Drawing.Size(165, 26)
        Me.txtQty9.TabIndex = 26
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(63, 23)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(136, 29)
        Me.lblItemName.TabIndex = 58
        Me.lblItemName.Text = "Item Name:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(348, 23)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(75, 29)
        Me.lblPrice.TabIndex = 59
        Me.lblPrice.Text = "Price:"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(568, 23)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(106, 29)
        Me.lblQty.TabIndex = 60
        Me.lblQty.Text = "Quantity:"
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(12, 562)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(135, 29)
        Me.lblComments.TabIndex = 61
        Me.lblComments.Text = "Comments:"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(153, 556)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(565, 80)
        Me.txtComments.TabIndex = 1
        '
        'txtQnty9
        '
        Me.txtQnty9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty9.Location = New System.Drawing.Point(504, 395)
        Me.txtQnty9.Name = "txtQnty9"
        Me.txtQnty9.Size = New System.Drawing.Size(201, 26)
        Me.txtQnty9.TabIndex = 26
        '
        'txtQnty1
        '
        Me.txtQnty1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty1.Location = New System.Drawing.Point(503, 11)
        Me.txtQnty1.Name = "txtQnty1"
        Me.txtQnty1.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty1.TabIndex = 2
        '
        'txtQnty2
        '
        Me.txtQnty2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty2.Location = New System.Drawing.Point(503, 59)
        Me.txtQnty2.Name = "txtQnty2"
        Me.txtQnty2.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty2.TabIndex = 5
        '
        'txtQnty3
        '
        Me.txtQnty3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty3.Location = New System.Drawing.Point(503, 107)
        Me.txtQnty3.Name = "txtQnty3"
        Me.txtQnty3.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty3.TabIndex = 8
        '
        'txtQnty4
        '
        Me.txtQnty4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty4.Location = New System.Drawing.Point(503, 155)
        Me.txtQnty4.Name = "txtQnty4"
        Me.txtQnty4.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty4.TabIndex = 11
        '
        'txtQnty5
        '
        Me.txtQnty5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty5.Location = New System.Drawing.Point(503, 203)
        Me.txtQnty5.Name = "txtQnty5"
        Me.txtQnty5.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty5.TabIndex = 14
        '
        'txtQnty6
        '
        Me.txtQnty6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty6.Location = New System.Drawing.Point(503, 251)
        Me.txtQnty6.Name = "txtQnty6"
        Me.txtQnty6.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty6.TabIndex = 17
        '
        'txtQnty7
        '
        Me.txtQnty7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty7.Location = New System.Drawing.Point(503, 299)
        Me.txtQnty7.Name = "txtQnty7"
        Me.txtQnty7.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty7.TabIndex = 20
        '
        'txtQnty8
        '
        Me.txtQnty8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty8.Location = New System.Drawing.Point(503, 347)
        Me.txtQnty8.Name = "txtQnty8"
        Me.txtQnty8.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty8.TabIndex = 23
        '
        'txtQnty10
        '
        Me.txtQnty10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQnty10.Location = New System.Drawing.Point(503, 444)
        Me.txtQnty10.Name = "txtQnty10"
        Me.txtQnty10.Size = New System.Drawing.Size(203, 26)
        Me.txtQnty10.TabIndex = 29
        '
        'txtPrice10
        '
        Me.txtPrice10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice10.Location = New System.Drawing.Point(264, 444)
        Me.txtPrice10.Name = "txtPrice10"
        Me.txtPrice10.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice10.TabIndex = 28
        '
        'txtPrice9
        '
        Me.txtPrice9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice9.Location = New System.Drawing.Point(264, 395)
        Me.txtPrice9.Name = "txtPrice9"
        Me.txtPrice9.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice9.TabIndex = 25
        '
        'txtPrice8
        '
        Me.txtPrice8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice8.Location = New System.Drawing.Point(264, 347)
        Me.txtPrice8.Name = "txtPrice8"
        Me.txtPrice8.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice8.TabIndex = 22
        '
        'txtPrice7
        '
        Me.txtPrice7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice7.Location = New System.Drawing.Point(264, 299)
        Me.txtPrice7.Name = "txtPrice7"
        Me.txtPrice7.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice7.TabIndex = 19
        '
        'txtPrice6
        '
        Me.txtPrice6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice6.Location = New System.Drawing.Point(264, 251)
        Me.txtPrice6.Name = "txtPrice6"
        Me.txtPrice6.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice6.TabIndex = 16
        '
        'txtPrice5
        '
        Me.txtPrice5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice5.Location = New System.Drawing.Point(264, 203)
        Me.txtPrice5.Name = "txtPrice5"
        Me.txtPrice5.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice5.TabIndex = 13
        '
        'txtPrice4
        '
        Me.txtPrice4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice4.Location = New System.Drawing.Point(264, 155)
        Me.txtPrice4.Name = "txtPrice4"
        Me.txtPrice4.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice4.TabIndex = 10
        '
        'txtPrice3
        '
        Me.txtPrice3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice3.Location = New System.Drawing.Point(264, 107)
        Me.txtPrice3.Name = "txtPrice3"
        Me.txtPrice3.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice3.TabIndex = 7
        '
        'txtPrice2
        '
        Me.txtPrice2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice2.Location = New System.Drawing.Point(264, 59)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice2.TabIndex = 4
        '
        'txtPrice1
        '
        Me.txtPrice1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice1.Location = New System.Drawing.Point(264, 11)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice1.TabIndex = 1
        '
        'txtItem10
        '
        Me.txtItem10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem10.Location = New System.Drawing.Point(21, 444)
        Me.txtItem10.Name = "txtItem10"
        Me.txtItem10.Size = New System.Drawing.Size(203, 26)
        Me.txtItem10.TabIndex = 27
        '
        'txtItem9
        '
        Me.txtItem9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem9.Location = New System.Drawing.Point(21, 395)
        Me.txtItem9.Name = "txtItem9"
        Me.txtItem9.Size = New System.Drawing.Size(203, 26)
        Me.txtItem9.TabIndex = 24
        '
        'txtItem8
        '
        Me.txtItem8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem8.Location = New System.Drawing.Point(21, 347)
        Me.txtItem8.Name = "txtItem8"
        Me.txtItem8.Size = New System.Drawing.Size(203, 26)
        Me.txtItem8.TabIndex = 21
        '
        'txtItem7
        '
        Me.txtItem7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem7.Location = New System.Drawing.Point(21, 299)
        Me.txtItem7.Name = "txtItem7"
        Me.txtItem7.Size = New System.Drawing.Size(203, 26)
        Me.txtItem7.TabIndex = 18
        '
        'txtItem6
        '
        Me.txtItem6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem6.Location = New System.Drawing.Point(21, 251)
        Me.txtItem6.Name = "txtItem6"
        Me.txtItem6.Size = New System.Drawing.Size(203, 26)
        Me.txtItem6.TabIndex = 15
        '
        'txtItem5
        '
        Me.txtItem5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem5.Location = New System.Drawing.Point(21, 203)
        Me.txtItem5.Name = "txtItem5"
        Me.txtItem5.Size = New System.Drawing.Size(203, 26)
        Me.txtItem5.TabIndex = 12
        '
        'txtItem4
        '
        Me.txtItem4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem4.Location = New System.Drawing.Point(21, 155)
        Me.txtItem4.Name = "txtItem4"
        Me.txtItem4.Size = New System.Drawing.Size(203, 26)
        Me.txtItem4.TabIndex = 9
        '
        'txtItem3
        '
        Me.txtItem3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem3.Location = New System.Drawing.Point(21, 107)
        Me.txtItem3.Name = "txtItem3"
        Me.txtItem3.Size = New System.Drawing.Size(203, 26)
        Me.txtItem3.TabIndex = 6
        '
        'txtItem2
        '
        Me.txtItem2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem2.Location = New System.Drawing.Point(21, 59)
        Me.txtItem2.Name = "txtItem2"
        Me.txtItem2.Size = New System.Drawing.Size(203, 26)
        Me.txtItem2.TabIndex = 3
        '
        'txtItem1
        '
        Me.txtItem1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem1.Location = New System.Drawing.Point(21, 11)
        Me.txtItem1.Name = "txtItem1"
        Me.txtItem1.Size = New System.Drawing.Size(203, 26)
        Me.txtItem1.TabIndex = 0
        '
        'tlpFinancial
        '
        Me.tlpFinancial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpFinancial.ColumnCount = 3
        Me.tlpFinancial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tlpFinancial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpFinancial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpFinancial.Controls.Add(Me.txtQnty9, 2, 8)
        Me.tlpFinancial.Controls.Add(Me.txtItem2, 0, 1)
        Me.tlpFinancial.Controls.Add(Me.txtItem3, 0, 2)
        Me.tlpFinancial.Controls.Add(Me.txtItem4, 0, 3)
        Me.tlpFinancial.Controls.Add(Me.txtItem5, 0, 4)
        Me.tlpFinancial.Controls.Add(Me.txtItem6, 0, 5)
        Me.tlpFinancial.Controls.Add(Me.txtItem7, 0, 6)
        Me.tlpFinancial.Controls.Add(Me.txtItem8, 0, 7)
        Me.tlpFinancial.Controls.Add(Me.txtItem9, 0, 8)
        Me.tlpFinancial.Controls.Add(Me.txtItem10, 0, 9)
        Me.tlpFinancial.Controls.Add(Me.txtPrice1, 1, 0)
        Me.tlpFinancial.Controls.Add(Me.txtPrice2, 1, 1)
        Me.tlpFinancial.Controls.Add(Me.txtPrice3, 1, 2)
        Me.tlpFinancial.Controls.Add(Me.txtPrice4, 1, 3)
        Me.tlpFinancial.Controls.Add(Me.txtPrice5, 1, 4)
        Me.tlpFinancial.Controls.Add(Me.txtPrice6, 1, 5)
        Me.tlpFinancial.Controls.Add(Me.txtPrice7, 1, 6)
        Me.tlpFinancial.Controls.Add(Me.txtPrice8, 1, 7)
        Me.tlpFinancial.Controls.Add(Me.txtPrice9, 1, 8)
        Me.tlpFinancial.Controls.Add(Me.txtPrice10, 1, 9)
        Me.tlpFinancial.Controls.Add(Me.txtQnty10, 2, 9)
        Me.tlpFinancial.Controls.Add(Me.txtQnty8, 2, 7)
        Me.tlpFinancial.Controls.Add(Me.txtQnty7, 2, 6)
        Me.tlpFinancial.Controls.Add(Me.txtQnty6, 2, 5)
        Me.tlpFinancial.Controls.Add(Me.txtQnty5, 2, 4)
        Me.tlpFinancial.Controls.Add(Me.txtQnty4, 2, 3)
        Me.tlpFinancial.Controls.Add(Me.txtQnty3, 2, 2)
        Me.tlpFinancial.Controls.Add(Me.txtQnty2, 2, 1)
        Me.tlpFinancial.Controls.Add(Me.txtQnty1, 2, 0)
        Me.tlpFinancial.Controls.Add(Me.txtItem1, 0, 0)
        Me.tlpFinancial.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tlpFinancial.Location = New System.Drawing.Point(12, 55)
        Me.tlpFinancial.Name = "tlpFinancial"
        Me.tlpFinancial.RowCount = 10
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFinancial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFinancial.Size = New System.Drawing.Size(725, 483)
        Me.tlpFinancial.TabIndex = 0
        '
        'frmFinancial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 791)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.tlpFinancial)
        Me.Controls.Add(Me.btnTips)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnWriteTo)
        Me.Controls.Add(Me.chkResults)
        Me.Controls.Add(Me.txtAddAmt)
        Me.Controls.Add(Me.lblAddAmt)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.lblIntPerc)
        Me.Controls.Add(Me.lstFinancialOut)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtItem12)
        Me.Controls.Add(Me.txtQty9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFinancial"
        Me.Text = "Financial Assistant"
        Me.tlpFinancial.ResumeLayout(False)
        Me.tlpFinancial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lstFinancialOut As System.Windows.Forms.ListBox
    Friend WithEvents lblIntPerc As System.Windows.Forms.Label
    Friend WithEvents txtInterest As System.Windows.Forms.TextBox
    Friend WithEvents lblAddAmt As System.Windows.Forms.Label
    Friend WithEvents txtAddAmt As System.Windows.Forms.TextBox
    Friend WithEvents chkResults As System.Windows.Forms.CheckBox
    Friend WithEvents btnWriteTo As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnTips As System.Windows.Forms.Button
    Friend WithEvents txtItem12 As System.Windows.Forms.TextBox
    Friend WithEvents txtQty9 As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty9 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty3 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty4 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty5 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty6 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty7 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty8 As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty10 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice10 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice9 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice8 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice7 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice6 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice5 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem10 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem9 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem8 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem7 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem6 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem5 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem4 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem1 As System.Windows.Forms.TextBox
    Friend WithEvents tlpFinancial As System.Windows.Forms.TableLayoutPanel
End Class
