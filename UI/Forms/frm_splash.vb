Imports System.ComponentModel

Public Class frm_splash

    ' Private n_count As Integer

#If DEBUG Then
    Private n_count As Integer = 0
#Else
    Private n_count As Integer = 20
#End If

    Private Sub tmr_splash_Tick(sender As Object, e As EventArgs) Handles tmr_splash.Tick
        If n_count = 0 Then
            tmr_splash.Enabled = False
            tmr_fade_out.Enabled = True
            Return
        End If
        n_count -= 1
    End Sub

    Private Sub tmr_fade_in_Tick(sender As Object, e As EventArgs) Handles tmr_fade_in.Tick
        If Opacity = 1 Then
            tmr_fade_in.Enabled = False
            tmr_splash.Enabled = True
        End If
        Me.Opacity += 0.01
    End Sub

    Private Sub tmr_fade_out_Tick(sender As Object, e As EventArgs) Handles tmr_fade_out.Tick
        If Me.Opacity = 0 Then
            tmr_fade_out.Enabled = False
            Dim frm As New frm_main
            frm.Show(Me)
        End If
        Me.Opacity -= 0.01
    End Sub

    Private Sub frm_splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Global_Data.Initialize_global_data()
    End Sub
End Class