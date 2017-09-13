Imports System.Windows.Forms
Imports Estimator.BusinessObjects

Public Class frm_survey_select

    Private n_pk_customer As Integer
    Private s_customer_name As String
    Private o_AllCustomers As Customers
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

        ' Get all of the available customers from the DB (CURRENTLY HARDCODED)
        o_AllCustomers = CustomerService.BuildHardCoded()
        DisplayCustomerNamesOnComboList()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Dim GvnTextString As String
        GvnTextString = cmb_Customer.Text.Trim()
        If GvnTextString = "" Then
            MessageBox.Show("Please select a customer from the list or type a name to create a new customer", "Customer Name is Required", MessageBoxButtons.OK)
        Else
            'Check if the entered Text matches a current Customer, else create the Customer and returns its PK
            If o_AllCustomers.ContainsGvnName(GvnTextString) Then
                'Get that Customer
                Dim o_ChosenCustomer As Customer
                o_ChosenCustomer = o_AllCustomers.GetCustomerGvnName(GvnTextString)
                n_pk_customer = o_ChosenCustomer.Key
                s_customer_name = o_ChosenCustomer.Name
            Else
                'Add new customer and get pk
                n_pk_customer = 2
                s_customer_name = cmb_Customer.Text
            End If

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub DisplayCustomerNamesOnComboList()
        'Loop through each customer and add them to the Combo Box
        For Each lpCustomer As Customer In o_AllCustomers.Items
            cmb_Customer.Items.Add(lpCustomer)
        Next
    End Sub

End Class
