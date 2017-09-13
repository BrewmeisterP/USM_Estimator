<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.btn_estimate = New System.Windows.Forms.Button()
        Me.btn_survey = New System.Windows.Forms.Button()
        Me.btn_settings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_estimate
        '
        Me.btn_estimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estimate.Image = Global.Estimator.My.Resources.Resources.estimate_button
        Me.btn_estimate.Location = New System.Drawing.Point(446, 106)
        Me.btn_estimate.Name = "btn_estimate"
        Me.btn_estimate.Size = New System.Drawing.Size(235, 140)
        Me.btn_estimate.TabIndex = 1
        Me.btn_estimate.UseVisualStyleBackColor = True
        '
        'btn_survey
        '
        Me.btn_survey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_survey.Image = Global.Estimator.My.Resources.Resources.survey_button
        Me.btn_survey.Location = New System.Drawing.Point(101, 106)
        Me.btn_survey.Name = "btn_survey"
        Me.btn_survey.Size = New System.Drawing.Size(235, 140)
        Me.btn_survey.TabIndex = 0
        Me.btn_survey.UseVisualStyleBackColor = True
        '
        'btn_settings
        '
        Me.btn_settings.BackColor = System.Drawing.SystemColors.Control
        Me.btn_settings.Image = Global.Estimator.My.Resources.Resources.settings_button
        Me.btn_settings.Location = New System.Drawing.Point(710, 12)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(60, 60)
        Me.btn_settings.TabIndex = 3
        Me.btn_settings.UseVisualStyleBackColor = False
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 353)
        Me.Controls.Add(Me.btn_settings)
        Me.Controls.Add(Me.btn_estimate)
        Me.Controls.Add(Me.btn_survey)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USM Estimator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_survey As Button
    Friend WithEvents btn_estimate As Button
    Friend WithEvents btn_settings As Button
End Class
