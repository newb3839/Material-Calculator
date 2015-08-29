<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinancialTips
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinancialTips))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rtbTips = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(177, 308)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(167, 63)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rtbTips
        '
        Me.rtbTips.BackColor = System.Drawing.Color.Yellow
        Me.rtbTips.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTips.Location = New System.Drawing.Point(11, 12)
        Me.rtbTips.Name = "rtbTips"
        Me.rtbTips.ReadOnly = True
        Me.rtbTips.Size = New System.Drawing.Size(500, 282)
        Me.rtbTips.TabIndex = 2
        Me.rtbTips.Text = resources.GetString("rtbTips.Text")
        '
        'frmFinancialTips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 389)
        Me.Controls.Add(Me.rtbTips)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmFinancialTips"
        Me.Text = "frmFinancialTips"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rtbTips As System.Windows.Forms.RichTextBox
End Class
