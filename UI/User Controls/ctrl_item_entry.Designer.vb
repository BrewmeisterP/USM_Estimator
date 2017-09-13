<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrl_item_entry
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
        Me.txt_item_name = New System.Windows.Forms.TextBox()
        Me.txt_item_serial_no = New System.Windows.Forms.TextBox()
        Me.txt_pct_spot_blast = New System.Windows.Forms.TextBox()
        Me.txt_pct_brush_blast = New System.Windows.Forms.TextBox()
        Me.lnklbl_delete = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'txt_item_name
        '
        Me.txt_item_name.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item_name.Location = New System.Drawing.Point(0, 0)
        Me.txt_item_name.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_item_name.Name = "txt_item_name"
        Me.txt_item_name.Size = New System.Drawing.Size(200, 30)
        Me.txt_item_name.TabIndex = 0
        '
        'txt_item_serial_no
        '
        Me.txt_item_serial_no.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item_serial_no.Location = New System.Drawing.Point(211, 0)
        Me.txt_item_serial_no.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_item_serial_no.Name = "txt_item_serial_no"
        Me.txt_item_serial_no.Size = New System.Drawing.Size(200, 30)
        Me.txt_item_serial_no.TabIndex = 1
        '
        'txt_pct_spot_blast
        '
        Me.txt_pct_spot_blast.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pct_spot_blast.Location = New System.Drawing.Point(422, 0)
        Me.txt_pct_spot_blast.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_pct_spot_blast.MaxLength = 2
        Me.txt_pct_spot_blast.Name = "txt_pct_spot_blast"
        Me.txt_pct_spot_blast.Size = New System.Drawing.Size(32, 30)
        Me.txt_pct_spot_blast.TabIndex = 2
        '
        'txt_pct_brush_blast
        '
        Me.txt_pct_brush_blast.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pct_brush_blast.Location = New System.Drawing.Point(465, 0)
        Me.txt_pct_brush_blast.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_pct_brush_blast.MaxLength = 2
        Me.txt_pct_brush_blast.Name = "txt_pct_brush_blast"
        Me.txt_pct_brush_blast.Size = New System.Drawing.Size(32, 30)
        Me.txt_pct_brush_blast.TabIndex = 3
        '
        'lnklbl_delete
        '
        Me.lnklbl_delete.AutoSize = True
        Me.lnklbl_delete.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklbl_delete.Location = New System.Drawing.Point(509, 4)
        Me.lnklbl_delete.Name = "lnklbl_delete"
        Me.lnklbl_delete.Size = New System.Drawing.Size(57, 23)
        Me.lnklbl_delete.TabIndex = 4
        Me.lnklbl_delete.TabStop = True
        Me.lnklbl_delete.Text = "delete"
        Me.lnklbl_delete.Visible = False
        '
        'ctrl_item_entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lnklbl_delete)
        Me.Controls.Add(Me.txt_item_name)
        Me.Controls.Add(Me.txt_item_serial_no)
        Me.Controls.Add(Me.txt_pct_spot_blast)
        Me.Controls.Add(Me.txt_pct_brush_blast)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrl_item_entry"
        Me.Size = New System.Drawing.Size(564, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txt_item_name As TextBox
    Private WithEvents txt_item_serial_no As TextBox
    Private WithEvents txt_pct_spot_blast As TextBox
    Private WithEvents txt_pct_brush_blast As TextBox
    Friend WithEvents lnklbl_delete As LinkLabel
End Class
