
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Survey
        Public Property Customer() As Customer
            Get
                Return m_Customer
            End Get
            Private Set
                m_Customer = Value
            End Set
        End Property
        Private m_Customer As Customer
        Public Property Key() As Integer
            Get
                Return m_Key
            End Get
            Private Set
                m_Key = Value
            End Set
        End Property
        Private m_Key As Integer

        Public Sub New(iCustomer As Customer, iKey As Integer)
            Customer = iCustomer
            Key = iKey
        End Sub
    End Class
End Namespace