
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public Class Component
        Public Property Type() As String
            Get
                Return m_Type
            End Get
            Private Set
                m_Type = Value
            End Set
        End Property
        Private m_Type As String

        Public Property LengthInchesMaybe() As Integer
            Get
                Return m_LengthInchesMaybe
            End Get
            Private Set
                m_LengthInchesMaybe = Value
            End Set
        End Property
        Private m_LengthInchesMaybe As Integer

        Public Property WidthInchesMaybe() As Integer
            Get
                Return m_WidthInchesMaybe
            End Get
            Private Set
                m_WidthInchesMaybe = Value
            End Set
        End Property
        Private m_WidthInchesMaybe As Integer

        Public Property HeightInchesMaybe() As Integer
            Get
                Return m_HeightInchesMaybe
            End Get
            Private Set
                m_HeightInchesMaybe = Value
            End Set
        End Property
        Private m_HeightInchesMaybe As Integer

        Public Property DiameterInchesMaybe() As Integer
            Get
                Return m_DiameterInchesMaybe
            End Get
            Private Set
                m_DiameterInchesMaybe = Value
            End Set
        End Property
        Private m_DiameterInchesMaybe As Integer

        Public Property CircumferenceInchesMaybe() As Integer
            Get
                Return m_CircumferenceInchesMaybe
            End Get
            Private Set
                m_CircumferenceInchesMaybe = Value
            End Set
        End Property
        Private m_CircumferenceInchesMaybe As Integer

        Public Property RadiatorSetsMaybe() As Integer
            Get
                Return m_RadiatorSetsMaybe
            End Get
            Private Set
                m_RadiatorSetsMaybe = Value
            End Set
        End Property
        Private m_RadiatorSetsMaybe As Integer

        Public Property TubesPerRadiatorMaybe() As Integer
            Get
                Return m_TubesPerRadiatorMaybe
            End Get
            Private Set
                m_TubesPerRadiatorMaybe = Value
            End Set
        End Property
        Private m_TubesPerRadiatorMaybe As Integer

        Public Property SquareInchesMaybe() As Decimal
            Get
                Return m_SquareInchesMaybe
            End Get
            Private Set
                m_SquareInchesMaybe = Value
            End Set
        End Property
        Private m_SquareInchesMaybe As Decimal

        Public Property PaintableSquareFeetMaybe() As Integer
            Get
                Return m_PaintableSquareFeetMaybe
            End Get
            Private Set
                m_PaintableSquareFeetMaybe = Value
            End Set
        End Property
        Private m_PaintableSquareFeetMaybe As Integer

        Public Property Key() As Integer
            Get
                Return m_Key
            End Get
            Private Set
                m_Key = Value
            End Set
        End Property
        Private m_Key As Integer

        Public Sub New(iType As String, iLengthInchesMaybe As Integer, iWidthInchesMaybe As Integer, iHeightInchesMaybe As Integer, iDiameterInchesMaybe As Integer, iCircumferenceInchesMaybe As Integer,
            iRadiatorSetsMaybe As Integer, iTubesPerRadiatorMaybe As Integer, iSquareInchesMaybe As Decimal, iPaintableSquareFeetMaybe As Integer, iKey As Integer)
            Type = iType
            LengthInchesMaybe = iLengthInchesMaybe
            WidthInchesMaybe = iWidthInchesMaybe
            HeightInchesMaybe = iHeightInchesMaybe
            DiameterInchesMaybe = iDiameterInchesMaybe
            CircumferenceInchesMaybe = iCircumferenceInchesMaybe
            RadiatorSetsMaybe = iRadiatorSetsMaybe
            TubesPerRadiatorMaybe = iTubesPerRadiatorMaybe
            SquareInchesMaybe = iSquareInchesMaybe
            PaintableSquareFeetMaybe = iPaintableSquareFeetMaybe
            Key = iKey
        End Sub
    End Class
End Namespace