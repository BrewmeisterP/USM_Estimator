<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splash
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
        Me.components = New System.ComponentModel.Container()
        Me.tmr_splash = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_fade_in = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_fade_out = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tmr_splash
        '
        Me.tmr_splash.Interval = 50
        '
        'tmr_fade_in
        '
        Me.tmr_fade_in.Enabled = True
        Me.tmr_fade_in.Interval = 1
        '
        'tmr_fade_out
        '
        Me.tmr_fade_out.Interval = 1
        '
        'frm_splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Estimator.My.Resources.Resources.splash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(348, 261)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_splash"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tmr_splash As Timer
    Private WithEvents tmr_fade_in As Timer
    Private WithEvents tmr_fade_out As Timer
End Class
