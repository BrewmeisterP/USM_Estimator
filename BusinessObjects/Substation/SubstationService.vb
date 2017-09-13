
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public NotInheritable Class SubstationService
        Private Sub New()
        End Sub
        Public Shared Function GetFromDatabase(iKey As Integer) As Substation
            Return Nothing
        End Function

        Public Shared Function GetManyFromDatabase(iSurvey As Survey) As Substations
            'Get all of the Substations that belong to the given Survey
            'Loop through the data table or records given and build a Substation and add it to the collection
            'foreach(DataRecord lpDataRecord in DataRecords)
            ' get data out for a survey
            ' call the Build Method
            ' add the new item to the collection

            Return New Substations()
        End Function

        Private Shared Function Build(iSurvey As Survey, iName As String, iCity As String, iState As String, iZip As String, iKey As Integer) As Substation
            Return New Substation(iSurvey, iName, iCity, iState, iZip, iKey)
        End Function
    End Class
End Namespace