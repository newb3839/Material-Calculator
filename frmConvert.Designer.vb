<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvert))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtDecimal = New System.Windows.Forms.TextBox()
        Me.txtInch = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(21, 225)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(169, 56)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTable
        '
        Me.btnTable.Location = New System.Drawing.Point(423, 225)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(169, 56)
        Me.btnTable.TabIndex = 3
        Me.btnTable.Text = "Table"
        Me.btnTable.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(624, 223)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(169, 56)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(222, 225)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(169, 56)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtDecimal
        '
        Me.txtDecimal.Location = New System.Drawing.Point(103, 151)
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.Size = New System.Drawing.Size(172, 26)
        Me.txtDecimal.TabIndex = 0
        '
        'txtInch
        '
        Me.txtInch.Location = New System.Drawing.Point(539, 151)
        Me.txtInch.Name = "txtInch"
        Me.txtInch.ReadOnly = True
        Me.txtInch.Size = New System.Drawing.Size(172, 26)
        Me.txtInch.TabIndex = 5
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.Color.Yellow
        Me.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(98, 27)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(618, 31)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Input Decimal Value in Left Text Box and Press Calculate"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.BackColor = System.Drawing.Color.Aqua
        Me.lblInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(103, 101)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(140, 31)
        Me.lblInput.TabIndex = 7
        Me.lblInput.Text = "Input Value:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.Color.Aqua
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(552, 101)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(159, 31)
        Me.lblOutput.TabIndex = 8
        Me.lblOutput.Text = "Output Value:"
        '
        'frmConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 291)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.txtInch)
        Me.Controls.Add(Me.txtDecimal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.btnClear)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConvert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnTable As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtDecimal As System.Windows.Forms.TextBox
    Friend WithEvents txtInch As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
End Class
