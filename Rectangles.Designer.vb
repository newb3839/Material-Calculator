<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRectangles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRectangles))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblDepth = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtDepth = New System.Windows.Forms.TextBox()
        Me.lbl3DArea = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lbl3DVol = New System.Windows.Forms.Label()
        Me.txt3DSurfArea = New System.Windows.Forms.TextBox()
        Me.txtPerimeter = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.grpInputVal = New System.Windows.Forms.GroupBox()
        Me.lbl3DPerim = New System.Windows.Forms.Label()
        Me.txt3DPerim = New System.Windows.Forms.TextBox()
        Me.grpOutVal = New System.Windows.Forms.GroupBox()
        Me.btnTips = New System.Windows.Forms.Button()
        Me.lstRecInfo = New System.Windows.Forms.ListBox()
        Me.chkResults = New System.Windows.Forms.CheckBox()
        Me.btnWriteTo = New System.Windows.Forms.Button()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.grpInputVal.SuspendLayout()
        Me.grpOutVal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 268)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(264, 59)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(11, 788)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(168, 59)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(818, 788)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(168, 59)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.BackColor = System.Drawing.Color.Aqua
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(242, 38)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(90, 34)
        Me.lblArea.TabIndex = 3
        Me.lblArea.Text = "Area:"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(170, 51)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(151, 30)
        Me.txtHeight.TabIndex = 0
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.Yellow
        Me.lblHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(31, 48)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(115, 34)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "Height:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.BackColor = System.Drawing.Color.Yellow
        Me.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.Location = New System.Drawing.Point(39, 112)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(104, 34)
        Me.lblWidth.TabIndex = 6
        Me.lblWidth.Text = "Width:"
        '
        'lblDepth
        '
        Me.lblDepth.AutoSize = True
        Me.lblDepth.BackColor = System.Drawing.Color.Yellow
        Me.lblDepth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepth.Location = New System.Drawing.Point(39, 176)
        Me.lblDepth.Name = "lblDepth"
        Me.lblDepth.Size = New System.Drawing.Size(107, 34)
        Me.lblDepth.TabIndex = 7
        Me.lblDepth.Text = "Depth:"
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(170, 115)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(151, 30)
        Me.txtWidth.TabIndex = 1
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDepth
        '
        Me.txtDepth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepth.Location = New System.Drawing.Point(170, 179)
        Me.txtDepth.Name = "txtDepth"
        Me.txtDepth.Size = New System.Drawing.Size(151, 30)
        Me.txtDepth.TabIndex = 2
        Me.txtDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl3DArea
        '
        Me.lbl3DArea.AutoSize = True
        Me.lbl3DArea.BackColor = System.Drawing.Color.Aqua
        Me.lbl3DArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3DArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3DArea.Location = New System.Drawing.Point(73, 152)
        Me.lbl3DArea.Name = "lbl3DArea"
        Me.lbl3DArea.Size = New System.Drawing.Size(259, 34)
        Me.lbl3DArea.TabIndex = 14
        Me.lbl3DArea.Text = "3-D Surface Area:"
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.BackColor = System.Drawing.Color.Aqua
        Me.lblPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerimeter.Location = New System.Drawing.Point(174, 93)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(158, 34)
        Me.lblPerimeter.TabIndex = 15
        Me.lblPerimeter.Text = "Perimeter:"
        '
        'lbl3DVol
        '
        Me.lbl3DVol.AutoSize = True
        Me.lbl3DVol.BackColor = System.Drawing.Color.Aqua
        Me.lbl3DVol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3DVol.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3DVol.Location = New System.Drawing.Point(147, 207)
        Me.lbl3DVol.Name = "lbl3DVol"
        Me.lbl3DVol.Size = New System.Drawing.Size(185, 34)
        Me.lbl3DVol.TabIndex = 16
        Me.lbl3DVol.Text = "3-D Volume:"
        '
        'txt3DSurfArea
        '
        Me.txt3DSurfArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3DSurfArea.Location = New System.Drawing.Point(363, 152)
        Me.txt3DSurfArea.Name = "txt3DSurfArea"
        Me.txt3DSurfArea.ReadOnly = True
        Me.txt3DSurfArea.Size = New System.Drawing.Size(151, 30)
        Me.txt3DSurfArea.TabIndex = 19
        Me.txt3DSurfArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPerimeter
        '
        Me.txtPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerimeter.Location = New System.Drawing.Point(363, 97)
        Me.txtPerimeter.Name = "txtPerimeter"
        Me.txtPerimeter.ReadOnly = True
        Me.txtPerimeter.Size = New System.Drawing.Size(151, 30)
        Me.txtPerimeter.TabIndex = 18
        Me.txtPerimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(363, 39)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(151, 30)
        Me.txtArea.TabIndex = 17
        Me.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolume
        '
        Me.txtVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.Location = New System.Drawing.Point(363, 207)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.ReadOnly = True
        Me.txtVolume.Size = New System.Drawing.Size(151, 30)
        Me.txtVolume.TabIndex = 20
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpInputVal
        '
        Me.grpInputVal.Controls.Add(Me.txtDepth)
        Me.grpInputVal.Controls.Add(Me.txtWidth)
        Me.grpInputVal.Controls.Add(Me.lblDepth)
        Me.grpInputVal.Controls.Add(Me.lblWidth)
        Me.grpInputVal.Controls.Add(Me.lblHeight)
        Me.grpInputVal.Controls.Add(Me.txtHeight)
        Me.grpInputVal.Location = New System.Drawing.Point(12, 12)
        Me.grpInputVal.Name = "grpInputVal"
        Me.grpInputVal.Size = New System.Drawing.Size(347, 246)
        Me.grpInputVal.TabIndex = 0
        Me.grpInputVal.TabStop = False
        Me.grpInputVal.Text = "Input Values"
        '
        'lbl3DPerim
        '
        Me.lbl3DPerim.AutoSize = True
        Me.lbl3DPerim.BackColor = System.Drawing.Color.Aqua
        Me.lbl3DPerim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3DPerim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3DPerim.Location = New System.Drawing.Point(118, 265)
        Me.lbl3DPerim.Name = "lbl3DPerim"
        Me.lbl3DPerim.Size = New System.Drawing.Size(214, 34)
        Me.lbl3DPerim.TabIndex = 22
        Me.lbl3DPerim.Text = "3-D Perimeter:"
        '
        'txt3DPerim
        '
        Me.txt3DPerim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3DPerim.Location = New System.Drawing.Point(363, 265)
        Me.txt3DPerim.Name = "txt3DPerim"
        Me.txt3DPerim.ReadOnly = True
        Me.txt3DPerim.Size = New System.Drawing.Size(151, 30)
        Me.txt3DPerim.TabIndex = 23
        Me.txt3DPerim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpOutVal
        '
        Me.grpOutVal.Controls.Add(Me.txt3DPerim)
        Me.grpOutVal.Controls.Add(Me.lbl3DPerim)
        Me.grpOutVal.Controls.Add(Me.txtVolume)
        Me.grpOutVal.Controls.Add(Me.txt3DSurfArea)
        Me.grpOutVal.Controls.Add(Me.txtPerimeter)
        Me.grpOutVal.Controls.Add(Me.txtArea)
        Me.grpOutVal.Controls.Add(Me.lbl3DVol)
        Me.grpOutVal.Controls.Add(Me.lblPerimeter)
        Me.grpOutVal.Controls.Add(Me.lbl3DArea)
        Me.grpOutVal.Controls.Add(Me.lblArea)
        Me.grpOutVal.Location = New System.Drawing.Point(448, 12)
        Me.grpOutVal.Name = "grpOutVal"
        Me.grpOutVal.Size = New System.Drawing.Size(539, 341)
        Me.grpOutVal.TabIndex = 24
        Me.grpOutVal.TabStop = False
        Me.grpOutVal.Text = "Output Values"
        '
        'btnTips
        '
        Me.btnTips.Location = New System.Drawing.Point(309, 268)
        Me.btnTips.Name = "btnTips"
        Me.btnTips.Size = New System.Drawing.Size(114, 59)
        Me.btnTips.TabIndex = 2
        Me.btnTips.Text = "&Tips"
        Me.btnTips.UseVisualStyleBackColor = True
        '
        'lstRecInfo
        '
        Me.lstRecInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecInfo.FormattingEnabled = True
        Me.lstRecInfo.ItemHeight = 27
        Me.lstRecInfo.Location = New System.Drawing.Point(13, 470)
        Me.lstRecInfo.Name = "lstRecInfo"
        Me.lstRecInfo.Size = New System.Drawing.Size(974, 301)
        Me.lstRecInfo.TabIndex = 26
        '
        'chkResults
        '
        Me.chkResults.AutoSize = True
        Me.chkResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResults.Location = New System.Drawing.Point(12, 352)
        Me.chkResults.Name = "chkResults"
        Me.chkResults.Size = New System.Drawing.Size(238, 29)
        Me.chkResults.TabIndex = 2
        Me.chkResults.Text = "Show Previous Results"
        Me.chkResults.UseVisualStyleBackColor = True
        '
        'btnWriteTo
        '
        Me.btnWriteTo.Location = New System.Drawing.Point(414, 788)
        Me.btnWriteTo.Name = "btnWriteTo"
        Me.btnWriteTo.Size = New System.Drawing.Size(168, 59)
        Me.btnWriteTo.TabIndex = 5
        Me.btnWriteTo.Text = "&Write To "
        Me.btnWriteTo.UseVisualStyleBackColor = True
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(12, 403)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(248, 29)
        Me.lblComments.TabIndex = 29
        Me.lblComments.Text = "Additional Comments:"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(312, 372)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(675, 79)
        Me.txtComments.TabIndex = 3
        '
        'frmRectangles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 859)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.btnWriteTo)
        Me.Controls.Add(Me.chkResults)
        Me.Controls.Add(Me.lstRecInfo)
        Me.Controls.Add(Me.btnTips)
        Me.Controls.Add(Me.grpOutVal)
        Me.Controls.Add(Me.grpInputVal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRectangles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rectangle Tools"
        Me.grpInputVal.ResumeLayout(False)
        Me.grpInputVal.PerformLayout()
        Me.grpOutVal.ResumeLayout(False)
        Me.grpOutVal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblDepth As System.Windows.Forms.Label
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtDepth As System.Windows.Forms.TextBox
    Friend WithEvents lbl3DArea As System.Windows.Forms.Label
    Friend WithEvents lblPerimeter As System.Windows.Forms.Label
    Friend WithEvents lbl3DVol As System.Windows.Forms.Label
    Friend WithEvents txt3DSurfArea As System.Windows.Forms.TextBox
    Friend WithEvents txtPerimeter As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents grpInputVal As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3DPerim As System.Windows.Forms.Label
    Friend WithEvents txt3DPerim As System.Windows.Forms.TextBox
    Friend WithEvents grpOutVal As System.Windows.Forms.GroupBox
    Friend WithEvents btnTips As System.Windows.Forms.Button
    Friend WithEvents lstRecInfo As System.Windows.Forms.ListBox
    Friend WithEvents chkResults As System.Windows.Forms.CheckBox
    Friend WithEvents btnWriteTo As System.Windows.Forms.Button
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
End Class
