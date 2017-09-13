
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public NotInheritable Class ComponentService
        Private Sub New()
        End Sub
        Public Shared Function GetFromDatabase(iKey As Integer) As Component
            Return Nothing
        End Function

        Public Shared Function GetManyFromDatabase(iItem As Item) As Components
            'Get all of the Components that belong to the given Item
            'Loop through the data table or records given and build a Survey and add it to the collection
            'foreach(DataRecord lpDataRecord in DataRecords)
            ' get data out for an Item
            ' call the Build Method
            ' add the new item to the collection

            Return New Components()
        End Function

        Private Shared Function Build(iType As String, iLengthInchesMaybe As Integer, iWidthInchesMaybe As Integer, iHeightInchesMaybe As Integer, iDiameterInchesMaybe As Integer, iCircumferenceInchesMaybe As Integer,
            iRadiatorSetsMaybe As Integer, iTubesPerRadiatorMaybe As Integer, iSquareInchesMaybe As Decimal, iPaintableSquareFeetMaybe As Integer, iKey As Integer) As Component
            Return New Component(iType, iLengthInchesMaybe, iWidthInchesMaybe, iHeightInchesMaybe, iDiameterInchesMaybe, iCircumferenceInchesMaybe,
                iRadiatorSetsMaybe, iTubesPerRadiatorMaybe, iSquareInchesMaybe, iPaintableSquareFeetMaybe, iKey)
        End Function
    End Class
End Namespace