﻿Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Substation
        Public Property Survey() As Survey
            Get
                Return m_Survey
            End Get
            Private Set
                m_Survey = Value
            End Set
        End Property
        Private m_Survey As Survey
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Private Set
                m_Name = Value
            End Set
        End Property
        Private m_Name As String
        Public Property City() As String
            Get
                Return m_City
            End Get
            Private Set
                m_City = Value
            End Set
        End Property
        Private m_City As String
        Public Property State() As String
            Get
                Return m_State
            End Get
            Private Set
                m_State = Value
            End Set
        End Property
        Private m_State As String
        Public Property Zip() As String
            Get
                Return m_Zip
            End Get
            Private Set
                m_Zip = Value
            End Set
        End Property
        Private m_Zip As String
        Public Property Key() As Integer
            Get
                Return m_Key
            End Get
            Private Set
                m_Key = Value
            End Set
        End Property
        Private m_Key As Integer

        Friend Sub New(iSurvey As Survey, iName As String, iCity As String, iState As String, iZip As String, iKey As Integer)
            Survey = iSurvey
            Name = iName
            City = iCity
            State = iState
            Zip = iZip
            Key = iKey
        End Sub
    End Class
End Namespace