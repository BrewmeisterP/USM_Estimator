Public Class ctrl_item_entry

    Public Event Brush_Blast_Entered()


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Initialize_controls()
    End Sub

    Public Sub Set_Focus_to_txt_Item_Name()
        txt_item_name.Select()
    End Sub

    Private Sub lnklbl_delete_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_delete.LinkClicked
        Me.Dispose()
    End Sub

    Private Sub Initialize_controls()
        lnklbl_delete.TabStop = False
    End Sub


    Private Sub Text_Control_Enter(sender As Object, e As EventArgs) Handles txt_item_name.Enter, txt_item_serial_no.Enter, txt_pct_spot_blast.Enter, txt_pct_brush_blast.Enter
        Dim cntrl As Control = DirectCast(sender, Control)
        cntrl.BackColor = Global_Data.ActiveControlBackgroundColor
    End Sub

    Private Sub Text_Control_Leave(sender As Object, e As EventArgs) Handles txt_item_name.Leave, txt_item_serial_no.Leave, txt_pct_spot_blast.Leave, txt_pct_brush_blast.Leave
        Dim cntrl As Control = DirectCast(sender, Control)
        cntrl.BackColor = Color.FromKnownColor(KnownColor.White)
    End Sub

    Private Sub Handle_Enter_As_Tab(sender As Object, e As KeyEventArgs) Handles txt_item_name.KeyDown, txt_item_serial_no.KeyDown, txt_pct_spot_blast.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim CurrentControl As Control = DirectCast(sender, Control)
            Me.SelectNextControl(CurrentControl, True, True, True, True)
            e.SuppressKeyPress = True
        End If
        'Need to add logic, on the form somehow, to create a new user control when the last possible item is entered.
    End Sub

    Private Sub txt_quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pct_brush_blast.KeyDown
        If e.KeyCode = Keys.Enter Then
            RaiseEvent Brush_Blast_Entered()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
