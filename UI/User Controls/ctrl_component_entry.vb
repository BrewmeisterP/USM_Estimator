Public Class ctrl_component_entry

    Private mb_initilizing As Boolean

    Public Event Quantity_Entered()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mb_initilizing = True
        Initialize_controls()
        mb_initilizing = False
    End Sub

    Private Sub lnklbl_delete_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_delete.LinkClicked
        Me.Dispose()
    End Sub
    Public Sub Set_Focus_to_cmb_Component_Type()
        cmb_component_type.Select()
    End Sub
    Private Sub Initialize_controls()
        lnklbl_delete.TabStop = False

        'Load surveyor combobox
        cmb_component_type.DataSource = Global_Data.ComponentTypeTable
        cmb_component_type.ValueMember = "pk_component_type"
        cmb_component_type.DisplayMember = "name"
        cmb_component_type.SelectedIndex = -1

        cmb_component_type.AutoCompleteMode = AutoCompleteMode.Append
        cmb_component_type.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub


    Private Sub Text_Control_Enter(sender As Object, e As EventArgs) Handles cmb_component_type.Enter, txt_diameter.Enter, txt_circumference.Enter, txt_height.Enter, txt_length.Enter, txt_quantity.Enter, txt_rows_of_radiators.Enter, txt_square_feet.Enter, txt_tubes_per_row.Enter, txt_width.Enter
        Dim cntrl As Control = DirectCast(sender, Control)
        cntrl.BackColor = Global_Data.ActiveControlBackgroundColor
    End Sub

    Private Sub Text_Control_Leave(sender As Object, e As EventArgs) Handles cmb_component_type.Leave, txt_diameter.Leave, txt_circumference.Leave, txt_height.Leave, txt_length.Leave, txt_quantity.Leave, txt_rows_of_radiators.Leave, txt_square_feet.Leave, txt_tubes_per_row.Leave, txt_width.Leave
        Dim cntrl As Control = DirectCast(sender, Control)
        cntrl.BackColor = Color.White
    End Sub

    Private Sub Handle_Enter_As_Tab(sender As Object, e As KeyEventArgs) Handles cmb_component_type.KeyDown, txt_diameter.KeyDown, txt_circumference.KeyDown, txt_height.KeyDown, txt_length.KeyDown, txt_rows_of_radiators.KeyDown, txt_square_feet.KeyDown, txt_tubes_per_row.KeyDown, txt_width.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim CurrentControl As Control = DirectCast(sender, Control)
            Me.SelectNextControl(CurrentControl, True, True, True, True)
            e.SuppressKeyPress = True
        End If
        'Need to add logic, on the form somehow, to create a new user control when the last possible item is entered.
    End Sub

    Private Sub cmb_component_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_component_type.SelectedIndexChanged

        If mb_initilizing = True Then Return

        'Get the combobox control
        Dim cmb As ComboBox = DirectCast(sender, ComboBox)

        'Get the datatable row selected in the combobox
        Dim drv As DataRowView = DirectCast(cmb.SelectedItem, DataRowView)
        Dim row As DataRow = drv.Row

        'Enable control if used with this component, else disable and clear.
        If row.Item("gets_length") = True Then
            txt_length.Enabled = True
            txt_length.BackColor = Color.White
        Else
            txt_length.Text = ""
            txt_length.Enabled = False
            txt_length.BackColor = SystemColors.ControlDark
        End If

        If row.Item("gets_width") = True Then
            txt_width.Enabled = True
            txt_width.BackColor = Color.White
        Else
            txt_width.Text = ""
            txt_width.Enabled = False
            txt_width.BackColor = SystemColors.ControlDark
        End If

        If row.Item("gets_height") = True Then
            txt_height.Enabled = True
            txt_height.BackColor = Color.White
        Else
            txt_height.Text = ""
            txt_height.Enabled = False
            txt_height.BackColor = SystemColors.ControlDark
        End If

        If row.Item("gets_circumference") = True Then
            txt_circumference.Enabled = True
            txt_circumference.BackColor = Color.White
        Else
            txt_circumference.Text = ""
            txt_circumference.Enabled = False
            txt_circumference.BackColor = SystemColors.ControlDark
        End If

        If row.Item("gets_diameter") = True Then
            txt_diameter.Enabled = True
            txt_diameter.BackColor = Color.White
        Else
            txt_diameter.Text = ""
            txt_diameter.Enabled = False
            txt_diameter.BackColor = SystemColors.ControlDark
        End If

        If row.Item("gets_square_feet") = True Then
            txt_square_feet.Enabled = True
            txt_square_feet.BackColor = Color.White
        Else
            txt_square_feet.Text = ""
            txt_square_feet.Enabled = False
            txt_square_feet.BackColor = SystemColors.ControlDark
        End If

        If row.Item("gets_rows_of_radiators") = True Then
            txt_rows_of_radiators.Enabled = True
            txt_rows_of_radiators.BackColor = Color.White
        Else
            txt_rows_of_radiators.Text = ""
            txt_rows_of_radiators.Enabled = False
            txt_rows_of_radiators.BackColor = SystemColors.ControlDark
        End If

        If row.Item("gets_tubes_per_row") = True Then
            txt_tubes_per_row.Enabled = True
            txt_tubes_per_row.BackColor = Color.White
        Else
            txt_tubes_per_row.Text = ""
            txt_tubes_per_row.Enabled = False
            txt_tubes_per_row.BackColor = SystemColors.ControlDark
        End If

        If row.Item("gets_quantity") = True Then
            txt_quantity.Enabled = True
            txt_quantity.BackColor = Color.White
        Else
            txt_quantity.Text = ""
            txt_quantity.Enabled = False
            txt_quantity.BackColor = SystemColors.ControlDark
        End If
    End Sub

    Private Sub txt_quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            RaiseEvent Quantity_Entered()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
