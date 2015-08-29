<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCircles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCircles))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblDiamOut = New System.Windows.Forms.Label()
        Me.lblCircumOut = New System.Windows.Forms.Label()
        Me.lblAreaOut = New System.Windows.Forms.Label()
        Me.lblVolOut = New System.Windows.Forms.Label()
        Me.chkResults = New System.Windows.Forms.CheckBox()
        Me.txtDiamOut = New System.Windows.Forms.TextBox()
        Me.txtCircumOut = New System.Windows.Forms.TextBox()
        Me.txtAreaOut = New System.Windows.Forms.TextBox()
        Me.txtVolOut = New System.Windows.Forms.TextBox()
        Me.grpOutValues = New System.Windows.Forms.GroupBox()
        Me.txtVolCylOut = New System.Windows.Forms.TextBox()
        Me.lblVolCyl = New System.Windows.Forms.Label()
        Me.txtRadOut = New System.Windows.Forms.TextBox()
        Me.lblRadOut = New System.Windows.Forms.Label()
        Me.lstCircInfo = New System.Windows.Forms.ListBox()
        Me.btnTips = New System.Windows.Forms.Button()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.lblDiameter = New System.Windows.Forms.Label()
        Me.lblCircumference = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.txtDiameter = New System.Windows.Forms.TextBox()
        Me.txtCircum = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.grpInputVal = New System.Windows.Forms.GroupBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.btnWriteTo = New System.Windows.Forms.Button()
        Me.grpOutValues.SuspendLayout()
        Me.grpInputVal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(761, 783)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(207, 75)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 783)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(207, 75)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(13, 344)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(207, 64)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblDiamOut
        '
        Me.lblDiamOut.AutoSize = True
        Me.lblDiamOut.BackColor = System.Drawing.Color.Aqua
        Me.lblDiamOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiamOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiamOut.Location = New System.Drawing.Point(129, 100)
        Me.lblDiamOut.Name = "lblDiamOut"
        Me.lblDiamOut.Size = New System.Drawing.Size(149, 34)
        Me.lblDiamOut.TabIndex = 6
        Me.lblDiamOut.Text = "Diameter:"
        '
        'lblCircumOut
        '
        Me.lblCircumOut.AutoSize = True
        Me.lblCircumOut.BackColor = System.Drawing.Color.Aqua
        Me.lblCircumOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCircumOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircumOut.Location = New System.Drawing.Point(55, 164)
        Me.lblCircumOut.Name = "lblCircumOut"
        Me.lblCircumOut.Size = New System.Drawing.Size(223, 34)
        Me.lblCircumOut.TabIndex = 7
        Me.lblCircumOut.Text = "Circumference:"
        '
        'lblAreaOut
        '
        Me.lblAreaOut.AutoSize = True
        Me.lblAreaOut.BackColor = System.Drawing.Color.Aqua
        Me.lblAreaOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAreaOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaOut.Location = New System.Drawing.Point(188, 228)
        Me.lblAreaOut.Name = "lblAreaOut"
        Me.lblAreaOut.Size = New System.Drawing.Size(90, 34)
        Me.lblAreaOut.TabIndex = 8
        Me.lblAreaOut.Text = "Area:"
        '
        'lblVolOut
        '
        Me.lblVolOut.AutoSize = True
        Me.lblVolOut.BackColor = System.Drawing.Color.Aqua
        Me.lblVolOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolOut.Location = New System.Drawing.Point(31, 292)
        Me.lblVolOut.Name = "lblVolOut"
        Me.lblVolOut.Size = New System.Drawing.Size(247, 34)
        Me.lblVolOut.TabIndex = 9
        Me.lblVolOut.Text = "Volume(Sphere):"
        '
        'chkResults
        '
        Me.chkResults.AutoSize = True
        Me.chkResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResults.Location = New System.Drawing.Point(13, 430)
        Me.chkResults.Name = "chkResults"
        Me.chkResults.Size = New System.Drawing.Size(238, 29)
        Me.chkResults.TabIndex = 3
        Me.chkResults.Text = "Show Previous Results"
        Me.chkResults.UseVisualStyleBackColor = True
        '
        'txtDiamOut
        '
        Me.txtDiamOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiamOut.Location = New System.Drawing.Point(305, 103)
        Me.txtDiamOut.Name = "txtDiamOut"
        Me.txtDiamOut.ReadOnly = True
        Me.txtDiamOut.Size = New System.Drawing.Size(151, 30)
        Me.txtDiamOut.TabIndex = 14
        Me.txtDiamOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCircumOut
        '
        Me.txtCircumOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCircumOut.Location = New System.Drawing.Point(305, 167)
        Me.txtCircumOut.Name = "txtCircumOut"
        Me.txtCircumOut.ReadOnly = True
        Me.txtCircumOut.Size = New System.Drawing.Size(151, 30)
        Me.txtCircumOut.TabIndex = 15
        Me.txtCircumOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAreaOut
        '
        Me.txtAreaOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaOut.Location = New System.Drawing.Point(305, 231)
        Me.txtAreaOut.Name = "txtAreaOut"
        Me.txtAreaOut.ReadOnly = True
        Me.txtAreaOut.Size = New System.Drawing.Size(151, 30)
        Me.txtAreaOut.TabIndex = 16
        Me.txtAreaOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolOut
        '
        Me.txtVolOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolOut.Location = New System.Drawing.Point(305, 295)
        Me.txtVolOut.Name = "txtVolOut"
        Me.txtVolOut.ReadOnly = True
        Me.txtVolOut.Size = New System.Drawing.Size(151, 30)
        Me.txtVolOut.TabIndex = 17
        Me.txtVolOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpOutValues
        '
        Me.grpOutValues.Controls.Add(Me.txtVolCylOut)
        Me.grpOutValues.Controls.Add(Me.lblVolCyl)
        Me.grpOutValues.Controls.Add(Me.txtRadOut)
        Me.grpOutValues.Controls.Add(Me.txtDiamOut)
        Me.grpOutValues.Controls.Add(Me.txtCircumOut)
        Me.grpOutValues.Controls.Add(Me.txtAreaOut)
        Me.grpOutValues.Controls.Add(Me.lblRadOut)
        Me.grpOutValues.Controls.Add(Me.txtVolOut)
        Me.grpOutValues.Controls.Add(Me.lblVolOut)
        Me.grpOutValues.Controls.Add(Me.lblAreaOut)
        Me.grpOutValues.Controls.Add(Me.lblCircumOut)
        Me.grpOutValues.Controls.Add(Me.lblDiamOut)
        Me.grpOutValues.Location = New System.Drawing.Point(490, 9)
        Me.grpOutValues.Name = "grpOutValues"
        Me.grpOutValues.Size = New System.Drawing.Size(478, 419)
        Me.grpOutValues.TabIndex = 18
        Me.grpOutValues.TabStop = False
        Me.grpOutValues.Text = "Output Values"
        '
        'txtVolCylOut
        '
        Me.txtVolCylOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolCylOut.Location = New System.Drawing.Point(305, 359)
        Me.txtVolCylOut.Name = "txtVolCylOut"
        Me.txtVolCylOut.ReadOnly = True
        Me.txtVolCylOut.Size = New System.Drawing.Size(151, 30)
        Me.txtVolCylOut.TabIndex = 19
        Me.txtVolCylOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVolCyl
        '
        Me.lblVolCyl.AutoSize = True
        Me.lblVolCyl.BackColor = System.Drawing.Color.Aqua
        Me.lblVolCyl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolCyl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolCyl.Location = New System.Drawing.Point(16, 356)
        Me.lblVolCyl.Name = "lblVolCyl"
        Me.lblVolCyl.Size = New System.Drawing.Size(262, 34)
        Me.lblVolCyl.TabIndex = 18
        Me.lblVolCyl.Text = "Volume(Cylinder):"
        '
        'txtRadOut
        '
        Me.txtRadOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRadOut.Location = New System.Drawing.Point(305, 39)
        Me.txtRadOut.Name = "txtRadOut"
        Me.txtRadOut.ReadOnly = True
        Me.txtRadOut.Size = New System.Drawing.Size(151, 30)
        Me.txtRadOut.TabIndex = 15
        Me.txtRadOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRadOut
        '
        Me.lblRadOut.AutoSize = True
        Me.lblRadOut.BackColor = System.Drawing.Color.Aqua
        Me.lblRadOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRadOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadOut.Location = New System.Drawing.Point(159, 36)
        Me.lblRadOut.Name = "lblRadOut"
        Me.lblRadOut.Size = New System.Drawing.Size(121, 34)
        Me.lblRadOut.TabIndex = 14
        Me.lblRadOut.Text = "Radius:"
        '
        'lstCircInfo
        '
        Me.lstCircInfo.FormattingEnabled = True
        Me.lstCircInfo.ItemHeight = 20
        Me.lstCircInfo.Location = New System.Drawing.Point(12, 539)
        Me.lstCircInfo.Name = "lstCircInfo"
        Me.lstCircInfo.Size = New System.Drawing.Size(956, 224)
        Me.lstCircInfo.TabIndex = 19
        '
        'btnTips
        '
        Me.btnTips.Location = New System.Drawing.Point(247, 344)
        Me.btnTips.Name = "btnTips"
        Me.btnTips.Size = New System.Drawing.Size(134, 64)
        Me.btnTips.TabIndex = 2
        Me.btnTips.Text = "&Tips"
        Me.btnTips.UseVisualStyleBackColor = True
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.BackColor = System.Drawing.Color.Yellow
        Me.lblRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadius.Location = New System.Drawing.Point(132, 36)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(121, 34)
        Me.lblRadius.TabIndex = 4
        Me.lblRadius.Text = "Radius:"
        '
        'lblDiameter
        '
        Me.lblDiameter.AutoSize = True
        Me.lblDiameter.BackColor = System.Drawing.Color.Yellow
        Me.lblDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiameter.Location = New System.Drawing.Point(104, 100)
        Me.lblDiameter.Name = "lblDiameter"
        Me.lblDiameter.Size = New System.Drawing.Size(149, 34)
        Me.lblDiameter.TabIndex = 5
        Me.lblDiameter.Text = "Diameter:"
        '
        'lblCircumference
        '
        Me.lblCircumference.AutoSize = True
        Me.lblCircumference.BackColor = System.Drawing.Color.Yellow
        Me.lblCircumference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCircumference.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircumference.Location = New System.Drawing.Point(30, 164)
        Me.lblCircumference.Name = "lblCircumference"
        Me.lblCircumference.Size = New System.Drawing.Size(223, 34)
        Me.lblCircumference.TabIndex = 10
        Me.lblCircumference.Text = "Circumference:"
        '
        'txtRadius
        '
        Me.txtRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRadius.Location = New System.Drawing.Point(282, 39)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(151, 30)
        Me.txtRadius.TabIndex = 0
        Me.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiameter
        '
        Me.txtDiameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiameter.Location = New System.Drawing.Point(282, 103)
        Me.txtDiameter.Name = "txtDiameter"
        Me.txtDiameter.Size = New System.Drawing.Size(151, 30)
        Me.txtDiameter.TabIndex = 1
        Me.txtDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCircum
        '
        Me.txtCircum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCircum.Location = New System.Drawing.Point(282, 167)
        Me.txtCircum.Name = "txtCircum"
        Me.txtCircum.Size = New System.Drawing.Size(151, 30)
        Me.txtCircum.TabIndex = 2
        Me.txtCircum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.BackColor = System.Drawing.Color.Yellow
        Me.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(133, 227)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(120, 34)
        Me.lblLength.TabIndex = 14
        Me.lblLength.Text = "Length:"
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(282, 231)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(151, 30)
        Me.txtLength.TabIndex = 3
        Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpInputVal
        '
        Me.grpInputVal.Controls.Add(Me.txtLength)
        Me.grpInputVal.Controls.Add(Me.lblLength)
        Me.grpInputVal.Controls.Add(Me.txtCircum)
        Me.grpInputVal.Controls.Add(Me.txtDiameter)
        Me.grpInputVal.Controls.Add(Me.txtRadius)
        Me.grpInputVal.Controls.Add(Me.lblCircumference)
        Me.grpInputVal.Controls.Add(Me.lblDiameter)
        Me.grpInputVal.Controls.Add(Me.lblRadius)
        Me.grpInputVal.Location = New System.Drawing.Point(12, 9)
        Me.grpInputVal.Name = "grpInputVal"
        Me.grpInputVal.Size = New System.Drawing.Size(472, 300)
        Me.grpInputVal.TabIndex = 0
        Me.grpInputVal.TabStop = False
        Me.grpInputVal.Text = "Input Values"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(294, 444)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(675, 79)
        Me.txtComments.TabIndex = 4
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(7, 471)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(248, 29)
        Me.lblComments.TabIndex = 21
        Me.lblComments.Text = "Additional Comments:"
        '
        'btnWriteTo
        '
        Me.btnWriteTo.Location = New System.Drawing.Point(389, 783)
        Me.btnWriteTo.Name = "btnWriteTo"
        Me.btnWriteTo.Size = New System.Drawing.Size(207, 75)
        Me.btnWriteTo.TabIndex = 6
        Me.btnWriteTo.Text = "&Write To"
        Me.btnWriteTo.UseVisualStyleBackColor = True
        '
        'frmCircles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 870)
        Me.Controls.Add(Me.btnWriteTo)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.lstCircInfo)
        Me.Controls.Add(Me.grpOutValues)
        Me.Controls.Add(Me.grpInputVal)
        Me.Controls.Add(Me.chkResults)
        Me.Controls.Add(Me.btnTips)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCircles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circle Tools"
        Me.grpOutValues.ResumeLayout(False)
        Me.grpOutValues.PerformLayout()
        Me.grpInputVal.ResumeLayout(False)
        Me.grpInputVal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lblDiamOut As System.Windows.Forms.Label
    Friend WithEvents lblCircumOut As System.Windows.Forms.Label
    Friend WithEvents lblAreaOut As System.Windows.Forms.Label
    Friend WithEvents lblVolOut As System.Windows.Forms.Label
    Friend WithEvents chkResults As System.Windows.Forms.CheckBox
    Friend WithEvents txtDiamOut As System.Windows.Forms.TextBox
    Friend WithEvents txtCircumOut As System.Windows.Forms.TextBox
    Friend WithEvents txtAreaOut As System.Windows.Forms.TextBox
    Friend WithEvents txtVolOut As System.Windows.Forms.TextBox
    Friend WithEvents grpOutValues As System.Windows.Forms.GroupBox
    Friend WithEvents lstCircInfo As System.Windows.Forms.ListBox
    Friend WithEvents txtRadOut As System.Windows.Forms.TextBox
    Friend WithEvents lblRadOut As System.Windows.Forms.Label
    Friend WithEvents txtVolCylOut As System.Windows.Forms.TextBox
    Friend WithEvents lblVolCyl As System.Windows.Forms.Label
    Friend WithEvents btnTips As System.Windows.Forms.Button
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents lblDiameter As System.Windows.Forms.Label
    Friend WithEvents lblCircumference As System.Windows.Forms.Label
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents txtDiameter As System.Windows.Forms.TextBox
    Friend WithEvents txtCircum As System.Windows.Forms.TextBox
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents grpInputVal As System.Windows.Forms.GroupBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents btnWriteTo As System.Windows.Forms.Button
End Class
