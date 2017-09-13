
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Customers
        Public Property Items() As List(Of Customer)
            Get
                Return m_Items
            End Get
            Set
                m_Items = Value
            End Set
        End Property

        Private m_Items As List(Of Customer)

        Public Sub New()
            Items = New List(Of Customer)()
        End Sub

        Public Sub Add(iNewCustomer As Customer)
            Me.Items.Add(iNewCustomer)
        End Sub

        ''' <summary>
        ''' Given a Customer's Name check to see if it exists in the collection
        ''' </summary>
        Public Function ContainsGvnName(i_Name As String) As Boolean
            Dim o_bContainsName As Boolean
            o_bContainsName = False 'Set this as false until proven otherwise

            For Each lpCustomer As Customer In Me.Items
                If lpCustomer.Name.ToLower() = i_Name.ToLower() Then
                    o_bContainsName = True
                End If
            Next

            Return o_bContainsName
        End Function

        ''' <summary>
        ''' Should throw an exception if nothing is returned
        ''' </summary>
        Public Function GetCustomerGvnName(i_Name As String) As Customer
            Dim o_oCustomer As Customer
            o_oCustomer = Nothing

            For Each lpCustomer As Customer In Me.Items
                If lpCustomer.Name.ToLower() = i_Name.ToLower() Then
                    o_oCustomer = lpCustomer
                End If
            Next

            Return o_oCustomer
        End Function

    End Class
End Namespace