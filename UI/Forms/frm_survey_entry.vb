Public Class frm_survey_entry

#Region "Module Level Variables"
    Private mn_fk_customer As Integer
    Private ms_customer_name As String
#End Region

#Region "Constructors and Form Initialization Logic"
    Public Sub New(ByVal n_fk_customer As Integer, ByVal s_customer_name As String)

        ' This call is required by the designer.
        InitializeComponent()

        mn_fk_customer = n_fk_customer
        ms_customer_name = s_customer_name

        lbl_Page_Num.Text = 1
        lbl_Item_Num.Text = 1

        ' Add any initialization after the InitializeComponent() call.
        Initialize_controls()

        'Use this to log the current user's workable space
        'MessageBox.Show(Screen.PrimaryScreen.WorkingArea.Size().ToString)
    End Sub

    Public Sub New(ByVal n_fk_customer As Integer, ByVal s_customer_name As String, ByVal substation As String, ByVal city As String, ByVal st As String, ByVal dt As DateTime, ByVal surveyor As String, ByVal pg As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        mn_fk_customer = n_fk_customer
        ms_customer_name = s_customer_name

        ' Add any initialization after the InitializeComponent() call.
        Initialize_controls()

        'Demo code
        cmb_substation.Text = substation
        txt_city.Text = city
        cmb_state.Text = st
        dt_date.Text = dt
        cmb_surveyor.Text = surveyor
        lbl_Page_Num.Text = pg + 1
        lbl_Item_Num.Text = lbl_Page_Num.Text

        txt_manufacturer.Select()

        'Use this to log the current user's workable space
        'MessageBox.Show(Screen.PrimaryScreen.WorkingArea.Size().ToString)
    End Sub

    Public Overloads Sub Show(ByRef frm_calling As Form)
        Me.Show()
        frm_calling.Close()

    End Sub

    Private Sub Initialize_controls()
        'This initialization is for a new survey---------------------------

        'Form title
        Me.Text = "Survey for " & ms_customer_name

        'Load surveyor combobox
        cmb_surveyor.DataSource = Global_Data.SurveyorView
        cmb_surveyor.ValueMember = "pk_employee"
        cmb_surveyor.DisplayMember = "name"
        cmb_surveyor.SelectedIndex = -1

        cmb_surveyor.AutoCompleteMode = AutoCompleteMode.Append
        cmb_surveyor.AutoCompleteSource = AutoCompleteSource.ListItems

        lnkbtn_add_item.TabStop = False
        lnkbtn_copy_item.TabStop = False
        lnkbtn_add_component.TabStop = False

        dt_date.Value = Today

    End Sub
#End Region

#Region "Header Control Events"

#End Region

#Region "Item-Related Control Events"
    Private Sub flwpnl_Item_SizeChanged(sender As Object, e As EventArgs) Handles flwpnl_Item.SizeChanged
        lnkbtn_add_item.Top = flwpnl_Item.Location.Y + flwpnl_Item.Size.Height + 5
        lnkbtn_copy_item.Top = lnkbtn_add_item.Top
    End Sub

    Private Sub lnkbtn_add_unit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkbtn_add_item.LinkClicked
        'Somehow I need to enumerate these or maintian them in a collection
        Dim ctl As New ctrl_item_entry
        ctl.lnklbl_delete.Visible = True
        flwpnl_Item.Controls.Add(ctl)
        flwpnl_Item.ScrollControlIntoView(ctl)
        ctl.Set_Focus_to_txt_Item_Name()
    End Sub
    Protected Sub Item_Brush_Blash_Entered() Handles Ctrl_item_entry1.Brush_Blast_Entered
        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    End Sub
#End Region

#Region "Component-Level Control Events"
    Private Sub flwpnl_component_SizeChanged(sender As Object, e As EventArgs) Handles flwpnl_component.SizeChanged
        lnkbtn_add_component.Top = flwpnl_component.Location.Y + flwpnl_component.Size.Height + 5
    End Sub

    Private Sub lnkbtn_add_component_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkbtn_add_component.LinkClicked
        Add_New_Component_Entry_Control()
    End Sub

    Private Sub Add_New_Component_Entry_Control()
        'Somehow I need to enumerate these or maintian them in a collection
        Dim ctl As New ctrl_component_entry
        ctl.lnklbl_delete.Visible = True
        flwpnl_component.Controls.Add(ctl)
        flwpnl_component.ScrollControlIntoView(ctl)
        ctl.Set_Focus_to_cmb_Component_Type()
        AddHandler ctl.Quantity_Entered, AddressOf Add_New_Component_Entry_Control
    End Sub

    Protected Sub Component_Qty_Entered() Handles ctrl_component_entry.Quantity_Entered
        Add_New_Component_Entry_Control()
    End Sub
#End Region

#Region "Footer Control Events"

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim frm As New frm_main
        frm.Show(Me)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        Dim frm2 As New frm_survey_entry(mn_fk_customer, ms_customer_name, cmb_substation.Text, txt_city.Text, cmb_state.Text, dt_date.Text, cmb_surveyor.Text, lbl_Page_Num.Text)
        frm2.Show(Me)
    End Sub

    Private Sub btn_finish_Click(sender As Object, e As EventArgs) Handles btn_finish.Click
        Me.Close()

    End Sub
#End Region

#Region "Control Navigation and Color"
    Private Sub Text_Control_Enter(sender As Object, e As EventArgs) Handles cmb_substation.Enter, txt_city.Enter, cmb_state.Enter, dt_date.Enter, cmb_surveyor.Enter, txt_manufacturer.Enter, txt_size.Enter, txt_voltage.Enter, txt_foreman_notes.Enter, txt_surveyor_notes.Enter, txt_customer_notes.Enter, chk_busing_caps.Enter, chk_caulk.Enter, chk_lead.Enter, chk_outtage.Enter, chk_overspray.Enter, chk_RR_fans.Enter, chk_water_power.Enter
        Dim cntrl As Control = DirectCast(sender, Control)

        If cntrl.Name = "dt_date" Then
            pnl_dt_date.BackColor = SystemColors.MenuHighlight
        Else
            pnl_dt_date.BackColor = SystemColors.GradientActiveCaption
        End If

        cntrl.BackColor = Global_Data.ActiveControlBackgroundColor
    End Sub

    Private Sub Text_Control_Leave(sender As Object, e As EventArgs) Handles cmb_substation.Leave, txt_city.Leave, cmb_state.Leave, dt_date.Leave, cmb_surveyor.Leave, txt_manufacturer.Leave, txt_size.Leave, txt_voltage.Leave, txt_foreman_notes.Leave, txt_surveyor_notes.Leave, txt_customer_notes.Leave, chk_busing_caps.Leave, chk_caulk.Leave, chk_lead.Leave, chk_outtage.Leave, chk_overspray.Leave, chk_RR_fans.Leave, chk_water_power.Leave
        Dim cntrl As Control = DirectCast(sender, Control)

        cntrl.BackColor = Color.FromKnownColor(KnownColor.White)
    End Sub

    Private Sub Handle_Enter_As_Tab(sender As Object, e As KeyEventArgs) Handles cmb_substation.KeyDown, txt_city.KeyDown, cmb_state.KeyDown, dt_date.KeyDown, cmb_surveyor.KeyDown, txt_manufacturer.KeyDown, txt_size.KeyDown, txt_voltage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim CurrentControl As Control = DirectCast(sender, Control)
            Me.SelectNextControl(CurrentControl, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Handle_Checkbox_Keys(sender As Object, e As KeyEventArgs) Handles chk_busing_caps.KeyDown, chk_caulk.KeyDown, chk_lead.KeyDown, chk_outtage.KeyDown, chk_overspray.KeyDown, chk_RR_fans.KeyDown, chk_water_power.KeyDown

        Dim CurrentControl As CheckBox = DirectCast(sender, Control)

        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Down Then
            Me.SelectNextControl(CurrentControl, True, True, True, True)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            Me.SelectNextControl(CurrentControl, False, True, True, True)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Add Then
            If CurrentControl.Checked Then
                CurrentControl.Checked = False
            Else
                CurrentControl.Checked = True
            End If

            Me.SelectNextControl(CurrentControl, True, True, True, True)
            e.SuppressKeyPress = True

        ElseIf e.KeyCode = Keys.Subtract Then
            CurrentControl.Checked = False
            Me.SelectNextControl(CurrentControl, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_customer_notes_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_customer_notes.KeyDown, txt_foreman_notes.KeyDown, txt_surveyor_notes.KeyDown

        Dim CurrentControl As RichTextBox = DirectCast(sender, Control)

        If e.KeyCode = Keys.Down Then
            Me.SelectNextControl(CurrentControl, True, True, True, True)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up Then
            Me.SelectNextControl(CurrentControl, False, True, True, True)
            e.SuppressKeyPress = True
        End If

    End Sub
#End Region

End Class
