Imports Estimator.BusinessObjects

Public Class frm_survey_entry

#Region "Module Level Variables"
    Private ChosenCustomer As Customer
#End Region

#Region "Constructors and Form Initialization Logic"
    Public Sub New(ByVal GvnCustomer_iObj As Customer)

        ' This call is required by the designer.
        InitializeComponent()

        ChosenCustomer = GvnCustomer_iObj

        lbl_Page_Num.Text = 1
        lbl_Item_Num.Text = 1

        ' Add any initialization after the InitializeComponent() call.
        Initialize_controls()

        'Use this to log the current user's workable space
        'MessageBox.Show(Screen.PrimaryScreen.WorkingArea.Size().ToString)
    End Sub

    Private Sub Initialize_controls()
        'This initialization is for a new survey---------------------------

        'Form title
        Me.Text = "Survey for " & ChosenCustomer.Name

        LoadSurveyorCmb()

        lnkbtn_add_item.TabStop = False
        lnkbtn_copy_item.TabStop = False
        lnkbtn_add_component.TabStop = False

        dt_date.Value = Today

    End Sub

    Private Sub LoadSurveyorCmb()
        'Load surveyor combobox
        cmb_surveyor.DataSource = Global_Data.SurveyorView
        cmb_surveyor.ValueMember = "pk_employee"
        cmb_surveyor.DisplayMember = "name"
        cmb_surveyor.SelectedIndex = -1

        cmb_surveyor.AutoCompleteMode = AutoCompleteMode.Append
        cmb_surveyor.AutoCompleteSource = AutoCompleteSource.ListItems
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
        Try
            Add_New_Item_Entry_Control()
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    Private Sub Add_New_Item_Entry_Control()
        'Somehow I need to enumerate these or maintain them in a collection
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
        Try
            Add_New_Component_Entry_Control()
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
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
        Try
            ClearInputs()
            SetUpInputsBasedOnCollection()
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    Private Sub btn_finish_Click(sender As Object, e As EventArgs) Handles btn_finish.Click
        Try
            'Insert the current Survey page to the database
            SavePage()

            Me.Close() 'Probably will want to return a dialog result eventually
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
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

#Region "Saving a Page"
    ''' <summary>
    ''' Save's the current page's information to the database
    ''' </summary>
    Private Sub SavePage()
        'Save the survey info
        Dim iSurveyPK As Integer
        Dim SurveryorPK As Integer
        SurveryorPK = 1 'Need to get the actual employee who entered the survey
        iSurveyPK = DAL.Survey_Insert(ChosenCustomer.Key, SurveryorPK)
        'Save the substation 
        Dim iSubstationPK As Integer
        iSubstationPK = DAL.Substation_Insert(iSurveyPK, cmb_substation.Text.Trim(), txt_city.Text, cmb_state.Text.Trim(), ZipMaybe:=Nothing) 'Hardcoded nothing because the GUI doesn't allow the user to enter it
        'Save the Item Set
        Dim ItemSetPK As Integer
        ItemSetPK = DAL.ItemSet_Insert(iSubstationPK, SurveryorPK, lbl_Item_Num.Text, txt_manufacturer.Text.Trim(), txt_size.Text.Trim(),
                                               txt_voltage.Text.Trim(), lbl_Page_Num.Text.Trim(), dt_date.Value, txt_foreman_notes.Text.Trim(),
                                               txt_customer_notes.Text.Trim(), txt_surveyor_notes.Text.Trim())
        'Save the Items to the Item Set
        For Each lpControl As Control In flwpnl_Item.Controls
            Dim ItemEntryControl As ctrl_item_entry
            ItemEntryControl = CType(lpControl, ctrl_item_entry)
            ItemEntryControl.SaveItem(ItemSetPK)
        Next
        'Save the Component(s)
        For Each lpControl As Control In flwpnl_component.Controls
            Dim CompontenEntryControl As ctrl_component_entry
            CompontenEntryControl = CType(lpControl, ctrl_component_entry)
            CompontenEntryControl.SaveComponent(ItemSetPK)
        Next
    End Sub
#End Region

    Private Sub ClearInputs()
        txt_city.Clear()
        cmb_substation.SelectedItem = -1
        cmb_state.SelectedItem = -1
        cmb_surveyor.SelectedItem = -1
        txt_manufacturer.Clear()
        txt_size.Clear()
        txt_voltage.Clear()
        txt_customer_notes.Clear()
        txt_foreman_notes.Clear()
        txt_surveyor_notes.Clear()
        flwpnl_Item.Controls.Clear()
        flwpnl_component.Controls.Clear()

    End Sub

    Private Sub SetUpInputsBasedOnCollection()
        Add_New_Item_Entry_Control()

        Add_New_Component_Entry_Control()

    End Sub

#Region "Error Handling"
    Private Sub ShowErrorMessage(ex As Exception)
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
#End Region
End Class
