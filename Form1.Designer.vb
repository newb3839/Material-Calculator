<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatCalc))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMainIntro = New System.Windows.Forms.Label()
        Me.btnTutorial = New System.Windows.Forms.Button()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.btnFinancial = New System.Windows.Forms.Button()
        Me.grpBasCalc = New System.Windows.Forms.GroupBox()
        Me.pbxJerry = New System.Windows.Forms.PictureBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.grpBasCalc.SuspendLayout()
        CType(Me.pbxJerry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(680, 512)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(140, 66)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblMainIntro
        '
        Me.lblMainIntro.BackColor = System.Drawing.Color.Aqua
        Me.lblMainIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMainIntro.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainIntro.Location = New System.Drawing.Point(134, 20)
        Me.lblMainIntro.Name = "lblMainIntro"
        Me.lblMainIntro.Size = New System.Drawing.Size(565, 43)
        Me.lblMainIntro.TabIndex = 2
        Me.lblMainIntro.Text = "Pick What You'd Like to Use:"
        Me.lblMainIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTutorial
        '
        Me.btnTutorial.Location = New System.Drawing.Point(12, 512)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(140, 66)
        Me.btnTutorial.TabIndex = 1
        Me.btnTutorial.Text = "Tutorial"
        Me.btnTutorial.UseVisualStyleBackColor = True
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(41, 31)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(299, 60)
        Me.btnRectangle.TabIndex = 0
        Me.btnRectangle.Text = "&Rectangles"
        Me.btnRectangle.UseVisualStyleBackColor = True
        '
        'btnTriangle
        '
        Me.btnTriangle.Location = New System.Drawing.Point(41, 227)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(299, 60)
        Me.btnTriangle.TabIndex = 1
        Me.btnTriangle.Text = "&Triangles"
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'btnCircle
        '
        Me.btnCircle.Location = New System.Drawing.Point(41, 129)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(299, 60)
        Me.btnCircle.TabIndex = 2
        Me.btnCircle.Text = "&Circles"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'btnFinancial
        '
        Me.btnFinancial.Location = New System.Drawing.Point(41, 325)
        Me.btnFinancial.Name = "btnFinancial"
        Me.btnFinancial.Size = New System.Drawing.Size(299, 60)
        Me.btnFinancial.TabIndex = 3
        Me.btnFinancial.Text = "&Financial"
        Me.btnFinancial.UseVisualStyleBackColor = True
        '
        'grpBasCalc
        '
        Me.grpBasCalc.Controls.Add(Me.btnFinancial)
        Me.grpBasCalc.Controls.Add(Me.btnCircle)
        Me.grpBasCalc.Controls.Add(Me.btnTriangle)
        Me.grpBasCalc.Controls.Add(Me.btnRectangle)
        Me.grpBasCalc.Location = New System.Drawing.Point(33, 79)
        Me.grpBasCalc.Name = "grpBasCalc"
        Me.grpBasCalc.Size = New System.Drawing.Size(383, 412)
        Me.grpBasCalc.TabIndex = 0
        Me.grpBasCalc.TabStop = False
        Me.grpBasCalc.Text = "Basic Calculations"
        '
        'pbxJerry
        '
        Me.pbxJerry.BackgroundImage = Global.Material_Calculator.My.Resources.Resources.Jerry
        Me.pbxJerry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxJerry.Location = New System.Drawing.Point(441, 79)
        Me.pbxJerry.Name = "pbxJerry"
        Me.pbxJerry.Size = New System.Drawing.Size(359, 411)
        Me.pbxJerry.TabIndex = 3
        Me.pbxJerry.TabStop = False
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(342, 512)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(162, 66)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Conversion"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'frmMatCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 590)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.pbxJerry)
        Me.Controls.Add(Me.grpBasCalc)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.lblMainIntro)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMatCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jerry's Material Calculator Version 1.1"
        Me.grpBasCalc.ResumeLayout(False)
        CType(Me.pbxJerry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblMainIntro As System.Windows.Forms.Label
    Friend WithEvents btnTutorial As System.Windows.Forms.Button
    Friend WithEvents btnRectangle As System.Windows.Forms.Button
    Friend WithEvents btnTriangle As System.Windows.Forms.Button
    Friend WithEvents btnCircle As System.Windows.Forms.Button
    Friend WithEvents btnFinancial As System.Windows.Forms.Button
    Friend WithEvents grpBasCalc As System.Windows.Forms.GroupBox
    Friend WithEvents pbxJerry As System.Windows.Forms.PictureBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button

End Class
