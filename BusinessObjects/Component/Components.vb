
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Components
        Private Property Items() As List(Of Component)
            Get
                Return m_Items
            End Get
            Set
                m_Items = Value
            End Set
        End Property
        Private m_Items As List(Of Component)

        Public Sub New()
            Items = New List(Of Component)()
        End Sub

        Public Sub Add(iNewComponent As Component)
            Me.Items.Add(iNewComponent)
        End Sub
    End Class
End Namespace