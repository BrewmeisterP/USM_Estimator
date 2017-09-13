<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_survey_entry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.txt_foreman_notes = New System.Windows.Forms.RichTextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_Item_Num = New System.Windows.Forms.Label()
        Me.lbl_Page_Num = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_surveyor = New System.Windows.Forms.ComboBox()
        Me.dt_date = New System.Windows.Forms.DateTimePicker()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_state = New System.Windows.Forms.ComboBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.cmb_substation = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pnl_dt_date = New System.Windows.Forms.Panel()
        Me.txt_surveyor_notes = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_customer_notes = New System.Windows.Forms.RichTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.chk_RR_fans = New System.Windows.Forms.CheckBox()
        Me.chk_caulk = New System.Windows.Forms.CheckBox()
        Me.chk_lead = New System.Windows.Forms.CheckBox()
        Me.chk_water_power = New System.Windows.Forms.CheckBox()
        Me.chk_busing_caps = New System.Windows.Forms.CheckBox()
        Me.chk_overspray = New System.Windows.Forms.CheckBox()
        Me.chk_outtage = New System.Windows.Forms.CheckBox()
        Me.txt_voltage = New System.Windows.Forms.TextBox()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.txt_manufacturer = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.lnkbtn_copy_item = New System.Windows.Forms.LinkLabel()
        Me.lnkbtn_add_item = New System.Windows.Forms.LinkLabel()
        Me.flwpnl_Item = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.flwpnl_component = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_finish = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lnkbtn_add_component = New System.Windows.Forms.LinkLabel()
        Me.ctrl_component_entry = New Estimator.ctrl_component_entry()
        Me.ctrl_Component_Header = New Estimator.ctrl_header_1()
        Me.Ctrl_item_entry1 = New Estimator.ctrl_item_entry()
        Me.ctrl_Item_Header = New Estimator.ctrl_header_1()
        Me.groupBox1.SuspendLayout()
        Me.flwpnl_Item.SuspendLayout()
        Me.flwpnl_component.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_foreman_notes
        '
        Me.txt_foreman_notes.Location = New System.Drawing.Point(655, 116)
        Me.txt_foreman_notes.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_foreman_notes.Name = "txt_foreman_notes"
        Me.txt_foreman_notes.Size = New System.Drawing.Size(340, 87)
        Me.txt_foreman_notes.TabIndex = 6
        Me.txt_foreman_notes.Text = "The quick brown fox jumps over the lazy dog."
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.label17.Location = New System.Drawing.Point(655, 91)
        Me.label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(102, 17)
        Me.label17.TabIndex = 14
        Me.label17.Text = "Foreman Notes"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.groupBox1.Controls.Add(Me.lbl_Item_Num)
        Me.groupBox1.Controls.Add(Me.lbl_Page_Num)
        Me.groupBox1.Controls.Add(Me.Label27)
        Me.groupBox1.Controls.Add(Me.Label23)
        Me.groupBox1.Controls.Add(Me.cmb_surveyor)
        Me.groupBox1.Controls.Add(Me.dt_date)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.Label18)
        Me.groupBox1.Controls.Add(Me.cmb_state)
        Me.groupBox1.Controls.Add(Me.txt_city)
        Me.groupBox1.Controls.Add(Me.cmb_substation)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.pnl_dt_date)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(0, 0)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(1008, 89)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        '
        'lbl_Item_Num
        '
        Me.lbl_Item_Num.AutoSize = True
        Me.lbl_Item_Num.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Item_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.lbl_Item_Num.Location = New System.Drawing.Point(946, 47)
        Me.lbl_Item_Num.Name = "lbl_Item_Num"
        Me.lbl_Item_Num.Size = New System.Drawing.Size(37, 21)
        Me.lbl_Item_Num.TabIndex = 33
        Me.lbl_Item_Num.Text = "999"
        Me.lbl_Item_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Page_Num
        '
        Me.lbl_Page_Num.AutoSize = True
        Me.lbl_Page_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.lbl_Page_Num.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Page_Num.ForeColor = System.Drawing.Color.White
        Me.lbl_Page_Num.Location = New System.Drawing.Point(946, 18)
        Me.lbl_Page_Num.Name = "lbl_Page_Num"
        Me.lbl_Page_Num.Size = New System.Drawing.Size(37, 21)
        Me.lbl_Page_Num.TabIndex = 32
        Me.lbl_Page_Num.Text = "999"
        Me.lbl_Page_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(886, 50)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 19)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Item #"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(884, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 19)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Page #"
        '
        'cmb_surveyor
        '
        Me.cmb_surveyor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_surveyor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_surveyor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_surveyor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_surveyor.FormattingEnabled = True
        Me.cmb_surveyor.Location = New System.Drawing.Point(715, 42)
        Me.cmb_surveyor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_surveyor.Name = "cmb_surveyor"
        Me.cmb_surveyor.Size = New System.Drawing.Size(162, 27)
        Me.cmb_surveyor.TabIndex = 5
        '
        'dt_date
        '
        Me.dt_date.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_date.Location = New System.Drawing.Point(571, 43)
        Me.dt_date.Margin = New System.Windows.Forms.Padding(4)
        Me.dt_date.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(137, 26)
        Me.dt_date.TabIndex = 4
        Me.dt_date.Value = New Date(2017, 5, 3, 0, 0, 0, 0)
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(715, 16)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(59, 17)
        Me.label4.TabIndex = 29
        Me.label4.Text = "Surveyor"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(569, 16)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 17)
        Me.label3.TabIndex = 28
        Me.label3.Text = "Survey Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(494, 16)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 17)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "State"
        '
        'cmb_state
        '
        Me.cmb_state.AutoCompleteCustomSource.AddRange(New String() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cmb_state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_state.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_state.DropDownHeight = 200
        Me.cmb_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_state.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_state.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_state.FormattingEnabled = True
        Me.cmb_state.IntegralHeight = False
        Me.cmb_state.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cmb_state.Location = New System.Drawing.Point(494, 42)
        Me.cmb_state.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_state.Name = "cmb_state"
        Me.cmb_state.Size = New System.Drawing.Size(64, 27)
        Me.cmb_state.TabIndex = 3
        '
        'txt_city
        '
        Me.txt_city.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_city.Location = New System.Drawing.Point(253, 43)
        Me.txt_city.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_city.Size = New System.Drawing.Size(230, 26)
        Me.txt_city.TabIndex = 2
        '
        'cmb_substation
        '
        Me.cmb_substation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_substation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_substation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_substation.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_substation.FormattingEnabled = True
        Me.cmb_substation.Location = New System.Drawing.Point(12, 42)
        Me.cmb_substation.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_substation.Name = "cmb_substation"
        Me.cmb_substation.Size = New System.Drawing.Size(230, 27)
        Me.cmb_substation.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(253, 16)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(94, 17)
        Me.label2.TabIndex = 23
        Me.label2.Text = "Substation City"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 16)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(108, 17)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Substation Name"
        '
        'pnl_dt_date
        '
        Me.pnl_dt_date.Location = New System.Drawing.Point(568, 40)
        Me.pnl_dt_date.Name = "pnl_dt_date"
        Me.pnl_dt_date.Size = New System.Drawing.Size(143, 34)
        Me.pnl_dt_date.TabIndex = 34
        '
        'txt_surveyor_notes
        '
        Me.txt_surveyor_notes.Location = New System.Drawing.Point(655, 234)
        Me.txt_surveyor_notes.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_surveyor_notes.Name = "txt_surveyor_notes"
        Me.txt_surveyor_notes.Size = New System.Drawing.Size(340, 87)
        Me.txt_surveyor_notes.TabIndex = 7
        Me.txt_surveyor_notes.Text = "The quick brown fox jumps over the lazy dog."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(655, 209)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 17)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Surveyor Notes"
        '
        'txt_customer_notes
        '
        Me.txt_customer_notes.Location = New System.Drawing.Point(655, 353)
        Me.txt_customer_notes.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_customer_notes.Name = "txt_customer_notes"
        Me.txt_customer_notes.Size = New System.Drawing.Size(340, 87)
        Me.txt_customer_notes.TabIndex = 8
        Me.txt_customer_notes.Text = "The quick brown fox jumps over the lazy dog."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(655, 327)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(107, 17)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Customer Notes"
        '
        'chk_RR_fans
        '
        Me.chk_RR_fans.AutoSize = True
        Me.chk_RR_fans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_RR_fans.Location = New System.Drawing.Point(655, 447)
        Me.chk_RR_fans.Name = "chk_RR_fans"
        Me.chk_RR_fans.Size = New System.Drawing.Size(135, 23)
        Me.chk_RR_fans.TabIndex = 9
        Me.chk_RR_fans.Text = "USM to R&R Fans"
        Me.chk_RR_fans.UseMnemonic = False
        Me.chk_RR_fans.UseVisualStyleBackColor = True
        '
        'chk_caulk
        '
        Me.chk_caulk.AutoSize = True
        Me.chk_caulk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_caulk.Location = New System.Drawing.Point(655, 479)
        Me.chk_caulk.Name = "chk_caulk"
        Me.chk_caulk.Size = New System.Drawing.Size(142, 23)
        Me.chk_caulk.TabIndex = 10
        Me.chk_caulk.Text = "Caulking Required?"
        Me.chk_caulk.UseVisualStyleBackColor = True
        '
        'chk_lead
        '
        Me.chk_lead.AutoSize = True
        Me.chk_lead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_lead.Location = New System.Drawing.Point(655, 543)
        Me.chk_lead.Name = "chk_lead"
        Me.chk_lead.Size = New System.Drawing.Size(110, 23)
        Me.chk_lead.TabIndex = 12
        Me.chk_lead.Text = "Lead in Paint?"
        Me.chk_lead.UseVisualStyleBackColor = True
        '
        'chk_water_power
        '
        Me.chk_water_power.AutoSize = True
        Me.chk_water_power.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_water_power.Location = New System.Drawing.Point(655, 511)
        Me.chk_water_power.Name = "chk_water_power"
        Me.chk_water_power.Size = New System.Drawing.Size(159, 23)
        Me.chk_water_power.TabIndex = 11
        Me.chk_water_power.Text = "Water/Power Present?"
        Me.chk_water_power.UseVisualStyleBackColor = True
        '
        'chk_busing_caps
        '
        Me.chk_busing_caps.AutoSize = True
        Me.chk_busing_caps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_busing_caps.Location = New System.Drawing.Point(655, 639)
        Me.chk_busing_caps.Name = "chk_busing_caps"
        Me.chk_busing_caps.Size = New System.Drawing.Size(114, 23)
        Me.chk_busing_caps.TabIndex = 15
        Me.chk_busing_caps.Text = "Bushing Caps?"
        Me.chk_busing_caps.UseVisualStyleBackColor = True
        '
        'chk_overspray
        '
        Me.chk_overspray.AutoSize = True
        Me.chk_overspray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_overspray.Location = New System.Drawing.Point(655, 607)
        Me.chk_overspray.Name = "chk_overspray"
        Me.chk_overspray.Size = New System.Drawing.Size(149, 23)
        Me.chk_overspray.TabIndex = 14
        Me.chk_overspray.Text = "Overspray Problem?"
        Me.chk_overspray.UseVisualStyleBackColor = True
        '
        'chk_outtage
        '
        Me.chk_outtage.AutoSize = True
        Me.chk_outtage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_outtage.Location = New System.Drawing.Point(655, 575)
        Me.chk_outtage.Name = "chk_outtage"
        Me.chk_outtage.Size = New System.Drawing.Size(128, 23)
        Me.chk_outtage.TabIndex = 13
        Me.chk_outtage.Text = "Outage Needed?"
        Me.chk_outtage.UseVisualStyleBackColor = True
        '
        'txt_voltage
        '
        Me.txt_voltage.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_voltage.Location = New System.Drawing.Point(434, 146)
        Me.txt_voltage.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_voltage.Name = "txt_voltage"
        Me.txt_voltage.Size = New System.Drawing.Size(200, 26)
        Me.txt_voltage.TabIndex = 3
        '
        'txt_size
        '
        Me.txt_size.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_size.Location = New System.Drawing.Point(223, 146)
        Me.txt_size.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(200, 26)
        Me.txt_size.TabIndex = 2
        '
        'txt_manufacturer
        '
        Me.txt_manufacturer.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_manufacturer.Location = New System.Drawing.Point(12, 146)
        Me.txt_manufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_manufacturer.Name = "txt_manufacturer"
        Me.txt_manufacturer.Size = New System.Drawing.Size(200, 26)
        Me.txt_manufacturer.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(472, 177)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 19)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "%BB"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(434, 120)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(55, 19)
        Me.label9.TabIndex = 48
        Me.label9.Text = "Voltage"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(223, 120)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(32, 19)
        Me.label8.TabIndex = 47
        Me.label8.Text = "Size"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(12, 120)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(92, 19)
        Me.label7.TabIndex = 46
        Me.label7.Text = "Manufacturer"
        '
        'lnkbtn_copy_item
        '
        Me.lnkbtn_copy_item.AutoSize = True
        Me.lnkbtn_copy_item.Location = New System.Drawing.Point(102, 241)
        Me.lnkbtn_copy_item.Name = "lnkbtn_copy_item"
        Me.lnkbtn_copy_item.Size = New System.Drawing.Size(146, 19)
        Me.lnkbtn_copy_item.TabIndex = 56
        Me.lnkbtn_copy_item.TabStop = True
        Me.lnkbtn_copy_item.Text = "copy item from survey"
        '
        'lnkbtn_add_item
        '
        Me.lnkbtn_add_item.AutoSize = True
        Me.lnkbtn_add_item.Location = New System.Drawing.Point(12, 241)
        Me.lnkbtn_add_item.Name = "lnkbtn_add_item"
        Me.lnkbtn_add_item.Size = New System.Drawing.Size(63, 19)
        Me.lnkbtn_add_item.TabIndex = 55
        Me.lnkbtn_add_item.TabStop = True
        Me.lnkbtn_add_item.Text = "add item"
        '
        'flwpnl_Item
        '
        Me.flwpnl_Item.AutoScroll = True
        Me.flwpnl_Item.AutoSize = True
        Me.flwpnl_Item.BackColor = System.Drawing.SystemColors.Control
        Me.flwpnl_Item.Controls.Add(Me.Ctrl_item_entry1)
        Me.flwpnl_Item.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwpnl_Item.Location = New System.Drawing.Point(12, 202)
        Me.flwpnl_Item.Margin = New System.Windows.Forms.Padding(0)
        Me.flwpnl_Item.MaximumSize = New System.Drawing.Size(622, 127)
        Me.flwpnl_Item.Name = "flwpnl_Item"
        Me.flwpnl_Item.Size = New System.Drawing.Size(622, 34)
        Me.flwpnl_Item.TabIndex = 4
        Me.flwpnl_Item.WrapContents = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(430, 177)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 19)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "%SB"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(223, 177)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(66, 19)
        Me.label6.TabIndex = 45
        Me.label6.Text = "Serial No."
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 177)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(130, 19)
        Me.label5.TabIndex = 44
        Me.label5.Text = "Customer # / Name"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(380, 390)
        Me.label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(40, 19)
        Me.label16.TabIndex = 65
        Me.label16.Text = "Sq Ft"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(287, 390)
        Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(32, 19)
        Me.label15.TabIndex = 64
        Me.label15.Text = "Circ"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(337, 390)
        Me.label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(29, 19)
        Me.label14.TabIndex = 63
        Me.label14.Text = "Dia"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(248, 390)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(19, 19)
        Me.label13.TabIndex = 62
        Me.label13.Text = "H"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(198, 390)
        Me.label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(22, 19)
        Me.label12.TabIndex = 61
        Me.label12.Text = "W"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(155, 390)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(16, 19)
        Me.label11.TabIndex = 60
        Me.label11.Text = "L"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(12, 390)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(37, 19)
        Me.label10.TabIndex = 59
        Me.label10.Text = "Type"
        '
        'flwpnl_component
        '
        Me.flwpnl_component.AutoScroll = True
        Me.flwpnl_component.AutoSize = True
        Me.flwpnl_component.Controls.Add(Me.ctrl_component_entry)
        Me.flwpnl_component.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwpnl_component.Location = New System.Drawing.Point(12, 415)
        Me.flwpnl_component.Margin = New System.Windows.Forms.Padding(0)
        Me.flwpnl_component.MaximumSize = New System.Drawing.Size(622, 253)
        Me.flwpnl_component.Name = "flwpnl_component"
        Me.flwpnl_component.Size = New System.Drawing.Size(622, 34)
        Me.flwpnl_component.TabIndex = 5
        Me.flwpnl_component.WrapContents = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.btn_back)
        Me.Panel2.Controls.Add(Me.btn_next)
        Me.Panel2.Controls.Add(Me.btn_finish)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Location = New System.Drawing.Point(0, 717)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 73)
        Me.Panel2.TabIndex = 16
        '
        'btn_back
        '
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Location = New System.Drawing.Point(661, 21)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(102, 38)
        Me.btn_back.TabIndex = 19
        Me.btn_back.Text = "<< Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Location = New System.Drawing.Point(777, 21)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(102, 38)
        Me.btn_next.TabIndex = 17
        Me.btn_next.Text = "Next >>"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_finish
        '
        Me.btn_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finish.Location = New System.Drawing.Point(893, 21)
        Me.btn_finish.Name = "btn_finish"
        Me.btn_finish.Size = New System.Drawing.Size(102, 38)
        Me.btn_finish.TabIndex = 18
        Me.btn_finish.Text = "Finish"
        Me.btn_finish.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(11, 21)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(102, 38)
        Me.btn_cancel.TabIndex = 20
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(441, 390)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(17, 19)
        Me.Label24.TabIndex = 73
        Me.Label24.Text = "R"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(480, 390)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 19)
        Me.Label25.TabIndex = 74
        Me.Label25.Text = "T/R"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(528, 390)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 19)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "Qty"
        '
        'lnkbtn_add_component
        '
        Me.lnkbtn_add_component.AutoSize = True
        Me.lnkbtn_add_component.Location = New System.Drawing.Point(12, 451)
        Me.lnkbtn_add_component.Name = "lnkbtn_add_component"
        Me.lnkbtn_add_component.Size = New System.Drawing.Size(106, 19)
        Me.lnkbtn_add_component.TabIndex = 77
        Me.lnkbtn_add_component.TabStop = True
        Me.lnkbtn_add_component.Text = "add component"
        '
        'ctrl_component_entry
        '
        Me.ctrl_component_entry.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctrl_component_entry.Location = New System.Drawing.Point(0, 0)
        Me.ctrl_component_entry.Margin = New System.Windows.Forms.Padding(0)
        Me.ctrl_component_entry.Name = "ctrl_component_entry"
        Me.ctrl_component_entry.Size = New System.Drawing.Size(591, 30)
        Me.ctrl_component_entry.TabIndex = 10
        '
        'ctrl_Component_Header
        '
        Me.ctrl_Component_Header.Header_Text = "COMPONENTS"
        Me.ctrl_Component_Header.Location = New System.Drawing.Point(12, 359)
        Me.ctrl_Component_Header.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ctrl_Component_Header.Name = "ctrl_Component_Header"
        Me.ctrl_Component_Header.Size = New System.Drawing.Size(623, 27)
        Me.ctrl_Component_Header.TabIndex = 57
        Me.ctrl_Component_Header.TabStop = False
        '
        'Ctrl_item_entry1
        '
        Me.Ctrl_item_entry1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctrl_item_entry1.Location = New System.Drawing.Point(0, 0)
        Me.Ctrl_item_entry1.Margin = New System.Windows.Forms.Padding(0)
        Me.Ctrl_item_entry1.Name = "Ctrl_item_entry1"
        Me.Ctrl_item_entry1.Size = New System.Drawing.Size(555, 30)
        Me.Ctrl_item_entry1.TabIndex = 0
        '
        'ctrl_Item_Header
        '
        Me.ctrl_Item_Header.Header_Text = "ITEMS"
        Me.ctrl_Item_Header.Location = New System.Drawing.Point(12, 91)
        Me.ctrl_Item_Header.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ctrl_Item_Header.Name = "ctrl_Item_Header"
        Me.ctrl_Item_Header.Size = New System.Drawing.Size(623, 27)
        Me.ctrl_Item_Header.TabIndex = 31
        Me.ctrl_Item_Header.TabStop = False
        '
        'frm_survey_entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 790)
        Me.Controls.Add(Me.lnkbtn_add_component)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.flwpnl_component)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.ctrl_Component_Header)
        Me.Controls.Add(Me.txt_voltage)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.txt_manufacturer)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.lnkbtn_copy_item)
        Me.Controls.Add(Me.lnkbtn_add_item)
        Me.Controls.Add(Me.flwpnl_Item)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.ctrl_Item_Header)
        Me.Controls.Add(Me.chk_busing_caps)
        Me.Controls.Add(Me.chk_overspray)
        Me.Controls.Add(Me.chk_outtage)
        Me.Controls.Add(Me.chk_lead)
        Me.Controls.Add(Me.chk_water_power)
        Me.Controls.Add(Me.chk_caulk)
        Me.Controls.Add(Me.chk_RR_fans)
        Me.Controls.Add(Me.txt_customer_notes)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txt_surveyor_notes)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_foreman_notes)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frm_survey_entry"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USM Estimator"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.flwpnl_Item.ResumeLayout(False)
        Me.flwpnl_component.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txt_foreman_notes As RichTextBox
    Private WithEvents label17 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents cmb_surveyor As ComboBox
    Private WithEvents dt_date As DateTimePicker
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents Label18 As Label
    Private WithEvents cmb_state As ComboBox
    Private WithEvents txt_city As TextBox
    Private WithEvents cmb_substation As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txt_surveyor_notes As RichTextBox
    Private WithEvents Label21 As Label
    Private WithEvents txt_customer_notes As RichTextBox
    Private WithEvents Label22 As Label
    Friend WithEvents chk_RR_fans As CheckBox
    Friend WithEvents chk_caulk As CheckBox
    Friend WithEvents chk_lead As CheckBox
    Friend WithEvents chk_water_power As CheckBox
    Friend WithEvents chk_busing_caps As CheckBox
    Friend WithEvents chk_overspray As CheckBox
    Friend WithEvents chk_outtage As CheckBox
    Friend WithEvents ctrl_Item_Header As ctrl_header_1
    Private WithEvents txt_voltage As TextBox
    Private WithEvents txt_size As TextBox
    Private WithEvents txt_manufacturer As TextBox
    Private WithEvents Label20 As Label
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Friend WithEvents lnkbtn_copy_item As LinkLabel
    Friend WithEvents lnkbtn_add_item As LinkLabel
    Friend WithEvents flwpnl_Item As FlowLayoutPanel
    Friend WithEvents Ctrl_item_entry1 As ctrl_item_entry
    Private WithEvents Label19 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Friend WithEvents ctrl_Component_Header As ctrl_header_1
    Private WithEvents label16 As Label
    Private WithEvents label15 As Label
    Private WithEvents label14 As Label
    Private WithEvents label13 As Label
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Friend WithEvents flwpnl_component As FlowLayoutPanel
    Friend WithEvents ctrl_component_entry As ctrl_component_entry
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_finish As Button
    Friend WithEvents btn_cancel As Button
    Private WithEvents Label24 As Label
    Private WithEvents Label25 As Label
    Private WithEvents Label26 As Label
    Friend WithEvents lnkbtn_add_component As LinkLabel
    Friend WithEvents lbl_Item_Num As Label
    Friend WithEvents lbl_Page_Num As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents pnl_dt_date As Panel
End Class
