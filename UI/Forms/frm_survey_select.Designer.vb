<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_survey_select
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
        Me.cmb_Customer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Ctrl_header_1 = New Estimator.ctrl_header_1()
        Me.SuspendLayout()
        '
        'cmb_Customer
        '
        Me.cmb_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Customer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_Customer.FormattingEnabled = True
        Me.cmb_Customer.Location = New System.Drawing.Point(18, 73)
        Me.cmb_Customer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_Customer.Name = "cmb_Customer"
        Me.cmb_Customer.Size = New System.Drawing.Size(300, 27)
        Me.cmb_Customer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Surveys for XXXXXXXXXXXXXXX"
        '
        'btn_new
        '
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Location = New System.Drawing.Point(329, 74)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(83, 31)
        Me.btn_new.TabIndex = 2
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(23, 139)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(389, 142)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btn_cancel
        '
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(329, 298)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(83, 31)
        Me.btn_cancel.TabIndex = 4
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Ctrl_header_1
        '
        Me.Ctrl_header_1.Header_Text = "Select Existing or Add New Customer"
        Me.Ctrl_header_1.Location = New System.Drawing.Point(18, 13)
        Me.Ctrl_header_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ctrl_header_1.Name = "Ctrl_header_1"
        Me.Ctrl_header_1.Size = New System.Drawing.Size(393, 32)
        Me.Ctrl_header_1.TabIndex = 4
        Me.Ctrl_header_1.TabStop = False
        '
        'frm_survey_select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 341)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ctrl_header_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Customer)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_survey_select"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ctrl_header_11 As ctrl_header_1
    Friend WithEvents cmb_Customer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ctrl_header_1 As ctrl_header_1
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_new As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btn_cancel As Button
End Class
