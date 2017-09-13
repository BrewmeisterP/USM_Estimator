
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Items
        Private Property pItems() As List(Of Item)
            Get
                Return m_pItems
            End Get
            Set
                m_pItems = Value
            End Set
        End Property
        Private m_pItems As List(Of Item)

        Public Sub New()
            pItems = New List(Of Item)()
        End Sub

        Public Sub Add(iNewItem As Item)
            Me.pItems.Add(iNewItem)
        End Sub
    End Class
End Namespace