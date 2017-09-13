
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Substations
        Private Property Items() As List(Of Substation)
            Get
                Return m_Items
            End Get
            Set
                m_Items = Value
            End Set
        End Property
        Private m_Items As List(Of Substation)

        Public Sub New()
            Items = New List(Of Substation)()
        End Sub

        Public Sub Add(iNewSubstation As Substation)
            Me.Items.Add(iNewSubstation)
        End Sub
    End Class
End Namespace