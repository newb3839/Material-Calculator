<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriangles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTriangles))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnWriteTo = New System.Windows.Forms.Button()
        Me.btnTips = New System.Windows.Forms.Button()
        Me.lstTriInfo = New System.Windows.Forms.ListBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.chkResults = New System.Windows.Forms.CheckBox()
        Me.pbxTriangle = New System.Windows.Forms.PictureBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblSmallB = New System.Windows.Forms.Label()
        Me.lblSmallC = New System.Windows.Forms.Label()
        Me.lblSmallA = New System.Windows.Forms.Label()
        Me.txtSmallA = New System.Windows.Forms.TextBox()
        Me.txtSmallB = New System.Windows.Forms.TextBox()
        Me.txtSmallC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.grpAngles = New System.Windows.Forms.GroupBox()
        Me.grpSides = New System.Windows.Forms.GroupBox()
        CType(Me.pbxTriangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAngles.SuspendLayout()
        Me.grpSides.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(14, 680)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(185, 68)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(824, 680)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(185, 68)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnWriteTo
        '
        Me.btnWriteTo.Location = New System.Drawing.Point(824, 606)
        Me.btnWriteTo.Name = "btnWriteTo"
        Me.btnWriteTo.Size = New System.Drawing.Size(185, 68)
        Me.btnWriteTo.TabIndex = 9
        Me.btnWriteTo.Text = "&Write To"
        Me.btnWriteTo.UseVisualStyleBackColor = True
        '
        'btnTips
        '
        Me.btnTips.Location = New System.Drawing.Point(419, 606)
        Me.btnTips.Name = "btnTips"
        Me.btnTips.Size = New System.Drawing.Size(185, 68)
        Me.btnTips.TabIndex = 4
        Me.btnTips.Text = "&Tips"
        Me.btnTips.UseVisualStyleBackColor = True
        '
        'lstTriInfo
        '
        Me.lstTriInfo.FormattingEnabled = True
        Me.lstTriInfo.ItemHeight = 20
        Me.lstTriInfo.Location = New System.Drawing.Point(499, 12)
        Me.lstTriInfo.Name = "lstTriInfo"
        Me.lstTriInfo.Size = New System.Drawing.Size(512, 424)
        Me.lstTriInfo.TabIndex = 9
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(499, 496)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(512, 88)
        Me.txtComments.TabIndex = 6
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(490, 464)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(135, 29)
        Me.lblComments.TabIndex = 11
        Me.lblComments.Text = "Comments:"
        '
        'chkResults
        '
        Me.chkResults.AutoSize = True
        Me.chkResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResults.Location = New System.Drawing.Point(769, 452)
        Me.chkResults.Name = "chkResults"
        Me.chkResults.Size = New System.Drawing.Size(238, 29)
        Me.chkResults.TabIndex = 12
        Me.chkResults.Text = "Show Previous Results"
        Me.chkResults.UseVisualStyleBackColor = True
        '
        'pbxTriangle
        '
        Me.pbxTriangle.BackgroundImage = CType(resources.GetObject("pbxTriangle.BackgroundImage"), System.Drawing.Image)
        Me.pbxTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxTriangle.Location = New System.Drawing.Point(12, 12)
        Me.pbxTriangle.Name = "pbxTriangle"
        Me.pbxTriangle.Size = New System.Drawing.Size(453, 379)
        Me.pbxTriangle.TabIndex = 13
        Me.pbxTriangle.TabStop = False
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.BackColor = System.Drawing.Color.Yellow
        Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(15, 20)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(46, 34)
        Me.lblA.TabIndex = 14
        Me.lblA.Text = "A:"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.BackColor = System.Drawing.Color.Yellow
        Me.lblB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(15, 70)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(46, 34)
        Me.lblB.TabIndex = 15
        Me.lblB.Text = "B:"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.BackColor = System.Drawing.Color.Yellow
        Me.lblC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(15, 120)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(47, 34)
        Me.lblC.TabIndex = 16
        Me.lblC.Text = "C:"
        '
        'lblSmallB
        '
        Me.lblSmallB.AutoSize = True
        Me.lblSmallB.BackColor = System.Drawing.Color.Yellow
        Me.lblSmallB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSmallB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmallB.Location = New System.Drawing.Point(30, 70)
        Me.lblSmallB.Name = "lblSmallB"
        Me.lblSmallB.Size = New System.Drawing.Size(43, 34)
        Me.lblSmallB.TabIndex = 17
        Me.lblSmallB.Text = "b:"
        '
        'lblSmallC
        '
        Me.lblSmallC.AutoSize = True
        Me.lblSmallC.BackColor = System.Drawing.Color.Yellow
        Me.lblSmallC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSmallC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmallC.Location = New System.Drawing.Point(30, 120)
        Me.lblSmallC.Name = "lblSmallC"
        Me.lblSmallC.Size = New System.Drawing.Size(41, 34)
        Me.lblSmallC.TabIndex = 18
        Me.lblSmallC.Text = "c:"
        '
        'lblSmallA
        '
        Me.lblSmallA.AutoSize = True
        Me.lblSmallA.BackColor = System.Drawing.Color.Yellow
        Me.lblSmallA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSmallA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmallA.Location = New System.Drawing.Point(30, 20)
        Me.lblSmallA.Name = "lblSmallA"
        Me.lblSmallA.Size = New System.Drawing.Size(43, 34)
        Me.lblSmallA.TabIndex = 19
        Me.lblSmallA.Text = "a:"
        '
        'txtSmallA
        '
        Me.txtSmallA.Location = New System.Drawing.Point(79, 26)
        Me.txtSmallA.Name = "txtSmallA"
        Me.txtSmallA.Size = New System.Drawing.Size(118, 26)
        Me.txtSmallA.TabIndex = 3
        '
        'txtSmallB
        '
        Me.txtSmallB.Location = New System.Drawing.Point(79, 76)
        Me.txtSmallB.Name = "txtSmallB"
        Me.txtSmallB.Size = New System.Drawing.Size(118, 26)
        Me.txtSmallB.TabIndex = 4
        '
        'txtSmallC
        '
        Me.txtSmallC.Location = New System.Drawing.Point(79, 126)
        Me.txtSmallC.Name = "txtSmallC"
        Me.txtSmallC.Size = New System.Drawing.Size(118, 26)
        Me.txtSmallC.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 26
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(14, 606)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(185, 68)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(419, 680)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(185, 68)
        Me.btnConvert.TabIndex = 30
        Me.btnConvert.Text = "Conversion"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(67, 26)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(118, 26)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(67, 76)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(118, 26)
        Me.txtB.TabIndex = 1
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(67, 126)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(118, 26)
        Me.txtC.TabIndex = 2
        '
        'grpAngles
        '
        Me.grpAngles.Controls.Add(Me.txtC)
        Me.grpAngles.Controls.Add(Me.txtB)
        Me.grpAngles.Controls.Add(Me.txtA)
        Me.grpAngles.Controls.Add(Me.lblC)
        Me.grpAngles.Controls.Add(Me.lblB)
        Me.grpAngles.Controls.Add(Me.lblA)
        Me.grpAngles.Location = New System.Drawing.Point(14, 414)
        Me.grpAngles.Name = "grpAngles"
        Me.grpAngles.Size = New System.Drawing.Size(206, 169)
        Me.grpAngles.TabIndex = 31
        Me.grpAngles.TabStop = False
        Me.grpAngles.Text = "Angles"
        '
        'grpSides
        '
        Me.grpSides.Controls.Add(Me.txtSmallC)
        Me.grpSides.Controls.Add(Me.txtSmallB)
        Me.grpSides.Controls.Add(Me.txtSmallA)
        Me.grpSides.Controls.Add(Me.lblSmallA)
        Me.grpSides.Controls.Add(Me.lblSmallC)
        Me.grpSides.Controls.Add(Me.lblSmallB)
        Me.grpSides.Location = New System.Drawing.Point(246, 414)
        Me.grpSides.Name = "grpSides"
        Me.grpSides.Size = New System.Drawing.Size(213, 169)
        Me.grpSides.TabIndex = 32
        Me.grpSides.TabStop = False
        Me.grpSides.Text = "Sides"
        '
        'frmTriangles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 759)
        Me.Controls.Add(Me.grpSides)
        Me.Controls.Add(Me.grpAngles)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxTriangle)
        Me.Controls.Add(Me.chkResults)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.lstTriInfo)
        Me.Controls.Add(Me.btnTips)
        Me.Controls.Add(Me.btnWriteTo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTriangles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Triangle Tools"
        CType(Me.pbxTriangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAngles.ResumeLayout(False)
        Me.grpAngles.PerformLayout()
        Me.grpSides.ResumeLayout(False)
        Me.grpSides.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnWriteTo As System.Windows.Forms.Button
    Friend WithEvents btnTips As System.Windows.Forms.Button
    Friend WithEvents lstTriInfo As System.Windows.Forms.ListBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents chkResults As System.Windows.Forms.CheckBox
    Friend WithEvents pbxTriangle As System.Windows.Forms.PictureBox
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblSmallB As System.Windows.Forms.Label
    Friend WithEvents lblSmallC As System.Windows.Forms.Label
    Friend WithEvents lblSmallA As System.Windows.Forms.Label
    Friend WithEvents txtSmallA As System.Windows.Forms.TextBox
    Friend WithEvents txtSmallB As System.Windows.Forms.TextBox
    Friend WithEvents txtSmallC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents grpAngles As System.Windows.Forms.GroupBox
    Friend WithEvents grpSides As System.Windows.Forms.GroupBox
End Class
