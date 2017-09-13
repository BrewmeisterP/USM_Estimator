
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Surveys
        Private Property Items() As List(Of Survey)
            Get
                Return m_Items
            End Get
            Set
                m_Items = Value
            End Set
        End Property
        Private m_Items As List(Of Survey)

        Public Sub New()
            Items = New List(Of Survey)()
        End Sub

        Public Sub Add(iNewSurvey As Survey)
            Me.Items.Add(iNewSurvey)
        End Sub
    End Class
End Namespace