Imports Estimator.BusinessObjects

Public Class frm_main

    Public Sub New()

        'Using frm_splash As New frm_splash()
        '    frm_splash.ShowDialog()
        'End Using

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Overloads Sub Show(ByRef frm_calling As Form)
        Me.Show()
        frm_calling.Close()
    End Sub

    Private Sub btn_survey_Click(sender As Object, e As EventArgs) Handles btn_survey.Click
        Dim frm1 As New frm_survey_select
        If frm1.ShowDialog = DialogResult.OK Then
            Dim frm2 As New frm_survey_entry(CustomerService.BuildHardCoded().Items(0)) 'HACK - Replace hard coded crap here
            frm2.Show(Me)
        End If
    End Sub

    Private Sub btn_estimate_Click(sender As Object, e As EventArgs) Handles btn_estimate.Click
        MessageBox.Show("Sorry, ESTIMATING functionality isn't available, yet.", "Well aren't you the busy bee....", MessageBoxButtons.OK)
    End Sub

    Private Sub btn_settings_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        Dim frm As New frm_settings
        frm.Show()
    End Sub
End Class
