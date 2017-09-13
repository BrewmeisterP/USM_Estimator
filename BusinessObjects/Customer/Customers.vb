
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Customers
        Private Property Items() As List(Of Customer)
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
    End Class
End Namespace