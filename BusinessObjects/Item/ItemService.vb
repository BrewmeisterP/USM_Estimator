
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public NotInheritable Class ItemService
        Private Sub New()
        End Sub
        Public Shared Function GetFromDatabase(iKey As Integer) As Item
            Return Nothing
        End Function

        Public Shared Function GetManyFromDatabase(iSubstation As Substation) As Items
            'Get all of the Items that belong to the given Substation
            'Loop through the data table or records given and build a Item and add it to the collection
            'foreach(DataRecord lpDataRecord in DataRecords)
            'Also For each Item we get we want to go get all of the Components that belong to it
            ' get data out for a survey
            ' call the Build Method
            ' add the new item to the collection

            Return New Items()
        End Function

        Private Shared Function Build(iSubstation As Substation, iName As String, iItemNumber As Integer, iManufacturerMaybe As String, iSerialNumberMaybe As String, iSizeMaybe As String,
            iVoltageMaybe As String, iSurveyPageNumber As Integer, iSurveyDate As DateTime, iComponents As Components, iKey As Integer) As Item
            Return New Item(iSubstation, iName, iItemNumber, iManufacturerMaybe, iSerialNumberMaybe, iSizeMaybe,
                iVoltageMaybe, iSurveyPageNumber, iSurveyDate, iComponents, iKey)
        End Function
    End Class
End Namespace