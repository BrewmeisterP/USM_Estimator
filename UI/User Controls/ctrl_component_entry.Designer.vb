<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrl_component_entry
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_square_feet = New System.Windows.Forms.TextBox()
        Me.txt_diameter = New System.Windows.Forms.TextBox()
        Me.txt_circumference = New System.Windows.Forms.TextBox()
        Me.txt_height = New System.Windows.Forms.TextBox()
        Me.txt_width = New System.Windows.Forms.TextBox()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.cmb_component_type = New System.Windows.Forms.ComboBox()
        Me.lnklbl_delete = New System.Windows.Forms.LinkLabel()
        Me.txt_rows_of_radiators = New System.Windows.Forms.TextBox()
        Me.txt_tubes_per_row = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_square_feet
        '
        Me.txt_square_feet.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_square_feet.Location = New System.Drawing.Point(374, 0)
        Me.txt_square_feet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_square_feet.Name = "txt_square_feet"
        Me.txt_square_feet.Size = New System.Drawing.Size(34, 30)
        Me.txt_square_feet.TabIndex = 20
        '
        'txt_diameter
        '
        Me.txt_diameter.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diameter.Location = New System.Drawing.Point(326, 0)
        Me.txt_diameter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_diameter.Name = "txt_diameter"
        Me.txt_diameter.Size = New System.Drawing.Size(34, 30)
        Me.txt_diameter.TabIndex = 19
        '
        'txt_circumference
        '
        Me.txt_circumference.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_circumference.Location = New System.Drawing.Point(278, 0)
        Me.txt_circumference.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_circumference.Name = "txt_circumference"
        Me.txt_circumference.Size = New System.Drawing.Size(34, 30)
        Me.txt_circumference.TabIndex = 18
        '
        'txt_height
        '
        Me.txt_height.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_height.Location = New System.Drawing.Point(230, 0)
        Me.txt_height.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(34, 30)
        Me.txt_height.TabIndex = 17
        '
        'txt_width
        '
        Me.txt_width.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_width.Location = New System.Drawing.Point(182, 0)
        Me.txt_width.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Size = New System.Drawing.Size(34, 30)
        Me.txt_width.TabIndex = 16
        '
        'txt_length
        '
        Me.txt_length.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_length.Location = New System.Drawing.Point(134, 0)
        Me.txt_length.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(34, 30)
        Me.txt_length.TabIndex = 15
        '
        'cmb_component_type
        '
        Me.cmb_component_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_component_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_component_type.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_component_type.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_component_type.FormattingEnabled = True
        Me.cmb_component_type.Location = New System.Drawing.Point(0, 0)
        Me.cmb_component_type.Margin = New System.Windows.Forms.Padding(5)
        Me.cmb_component_type.Name = "cmb_component_type"
        Me.cmb_component_type.Size = New System.Drawing.Size(120, 31)
        Me.cmb_component_type.TabIndex = 14
        '
        'lnklbl_delete
        '
        Me.lnklbl_delete.AutoSize = True
        Me.lnklbl_delete.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklbl_delete.Location = New System.Drawing.Point(559, 4)
        Me.lnklbl_delete.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklbl_delete.Name = "lnklbl_delete"
        Me.lnklbl_delete.Size = New System.Drawing.Size(57, 23)
        Me.lnklbl_delete.TabIndex = 23
        Me.lnklbl_delete.TabStop = True
        Me.lnklbl_delete.Text = "delete"
        Me.lnklbl_delete.Visible = False
        '
        'txt_rows_of_radiators
        '
        Me.txt_rows_of_radiators.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rows_of_radiators.Location = New System.Drawing.Point(422, 0)
        Me.txt_rows_of_radiators.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_rows_of_radiators.Name = "txt_rows_of_radiators"
        Me.txt_rows_of_radiators.Size = New System.Drawing.Size(34, 30)
        Me.txt_rows_of_radiators.TabIndex = 24
        '
        'txt_tubes_per_row
        '
        Me.txt_tubes_per_row.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tubes_per_row.Location = New System.Drawing.Point(470, 0)
        Me.txt_tubes_per_row.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_tubes_per_row.Name = "txt_tubes_per_row"
        Me.txt_tubes_per_row.Size = New System.Drawing.Size(34, 30)
        Me.txt_tubes_per_row.TabIndex = 25
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(518, 0)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(34, 30)
        Me.txt_quantity.TabIndex = 26
        '
        'ctrl_component_entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_tubes_per_row)
        Me.Controls.Add(Me.txt_rows_of_radiators)
        Me.Controls.Add(Me.lnklbl_delete)
        Me.Controls.Add(Me.txt_square_feet)
        Me.Controls.Add(Me.txt_diameter)
        Me.Controls.Add(Me.txt_circumference)
        Me.Controls.Add(Me.txt_height)
        Me.Controls.Add(Me.txt_width)
        Me.Controls.Add(Me.txt_length)
        Me.Controls.Add(Me.cmb_component_type)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrl_component_entry"
        Me.Size = New System.Drawing.Size(601, 31)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txt_square_feet As TextBox
    Private WithEvents txt_diameter As TextBox
    Private WithEvents txt_circumference As TextBox
    Private WithEvents txt_height As TextBox
    Private WithEvents txt_width As TextBox
    Private WithEvents txt_length As TextBox
    Private WithEvents cmb_component_type As ComboBox
    Friend WithEvents lnklbl_delete As LinkLabel
    Private WithEvents txt_rows_of_radiators As TextBox
    Private WithEvents txt_tubes_per_row As TextBox
    Private WithEvents txt_quantity As TextBox
End Class
