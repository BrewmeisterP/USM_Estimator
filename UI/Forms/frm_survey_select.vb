Imports System.Windows.Forms

Public Class frm_survey_select

    Private n_pk_customer As Integer
    Private s_customer_name As String
    Public ReadOnly Property pk_customer() As Integer
        Get
            Return n_pk_customer
        End Get
    End Property

    Public ReadOnly Property customer_name() As String
        Get
            Return s_customer_name
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        If cmb_Customer.Text = "" Then
            MessageBox.Show("Please select a customer from the list or type a name to create a new customer", "Customer Name is Required", MessageBoxButtons.OK)
        Else
            'Add new customer and get pk
            n_pk_customer = 1
            s_customer_name = cmb_Customer.Text
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

End Class
