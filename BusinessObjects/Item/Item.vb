
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Item
        Public Property Substation() As Substation
            Get
                Return m_Substation
            End Get
            Private Set
                m_Substation = Value
            End Set
        End Property
        Private m_Substation As Substation

        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Private Set
                m_Name = Value
            End Set
        End Property
        Private m_Name As String

        Public Property ItemNumber() As Integer
            Get
                Return m_ItemNumber
            End Get
            Private Set
                m_ItemNumber = Value
            End Set
        End Property
        Private m_ItemNumber As Integer

        Public Property ManufacturerMaybe() As String
            Get
                Return m_ManufacturerMaybe
            End Get
            Private Set
                m_ManufacturerMaybe = Value
            End Set
        End Property
        Private m_ManufacturerMaybe As String

        Public Property SerialNumberMaybe() As String
            Get
                Return m_SerialNumberMaybe
            End Get
            Private Set
                m_SerialNumberMaybe = Value
            End Set
        End Property
        Private m_SerialNumberMaybe As String

        Public Property SizeMaybe() As String
            Get
                Return m_SizeMaybe
            End Get
            Private Set
                m_SizeMaybe = Value
            End Set
        End Property
        Private m_SizeMaybe As String

        Public Property VoltageMaybe() As String
            Get
                Return m_VoltageMaybe
            End Get
            Private Set
                m_VoltageMaybe = Value
            End Set
        End Property
        Private m_VoltageMaybe As String

        Public Property SurveryPageNumber() As Integer
            Get
                Return m_SurveryPageNumber
            End Get
            Set
                m_SurveryPageNumber = Value
            End Set
        End Property
        Private m_SurveryPageNumber As Integer

        Public Property SurveyDate() As DateTime
            Get
                Return m_SurveyDate
            End Get
            Private Set
                m_SurveyDate = Value
            End Set
        End Property
        Private m_SurveyDate As DateTime

        Public Property Components() As Components
            Get
                Return m_Components
            End Get
            Set
                m_Components = Value
            End Set
        End Property
        Private m_Components As Components

        Public Property Key() As Integer
            Get
                Return m_Key
            End Get
            Private Set
                m_Key = Value
            End Set
        End Property
        Private m_Key As Integer

        Public Sub New(iSubstation As Substation, iName As String, iItemNumber As Integer, iManufacturerMaybe As String, iSerialNumberMaybe As String, iSizeMaybe As String,
            iVoltageMaybe As String, iSurveyPageNumber As Integer, iSurveyDate As DateTime, iComponents As Components, iKey As Integer)
            Substation = iSubstation
            Name = iName
            ItemNumber = iItemNumber
            ManufacturerMaybe = iManufacturerMaybe
            SerialNumberMaybe = iSerialNumberMaybe
            SizeMaybe = iSizeMaybe
            VoltageMaybe = iVoltageMaybe
            SurveryPageNumber = iSurveyPageNumber
            SurveyDate = iSurveyDate
            Components = iComponents
            Key = iKey
        End Sub
    End Class
End Namespace