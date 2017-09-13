<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrl_header_1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_header_text = New System.Windows.Forms.Label()
        Me.lbl_line = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_header_text
        '
        Me.lbl_header_text.AutoSize = True
        Me.lbl_header_text.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header_text.Location = New System.Drawing.Point(8, 0)
        Me.lbl_header_text.Name = "lbl_header_text"
        Me.lbl_header_text.Size = New System.Drawing.Size(96, 17)
        Me.lbl_header_text.TabIndex = 34
        Me.lbl_header_text.Text = "<header text>"
        '
        'lbl_line
        '
        Me.lbl_line.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_line.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_line.Location = New System.Drawing.Point(-249, 20)
        Me.lbl_line.Name = "lbl_line"
        Me.lbl_line.Size = New System.Drawing.Size(870, 4)
        Me.lbl_line.TabIndex = 33
        '
        'ctrl_header_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_header_text)
        Me.Controls.Add(Me.lbl_line)
        Me.Name = "ctrl_header_1"
        Me.Size = New System.Drawing.Size(620, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header_text As Label
    Friend WithEvents lbl_line As Label
End Class
