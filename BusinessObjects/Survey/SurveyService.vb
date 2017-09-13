
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public NotInheritable Class SurveyService
        Private Sub New()
        End Sub
        Public Shared Function GetFromDatabase(iKey As Integer) As Survey
            Return Nothing
        End Function

        Public Shared Function GetManyFromDatabase(iCustomer As Customer) As Surveys
            'Get all of the Surveys that belong to the given Customer
            'Loop through the data table or records given and build a Survey and add it to the collection
            'foreach(DataRecord lpDataRecord in DataRecords)
            ' get data out for a survey
            ' call the Build Method
            ' add the new item to the collection

            Return New Surveys()
        End Function

        Private Shared Function Build(iCustomer As Customer, iKey As Integer) As Survey
            Return New Survey(iCustomer, iKey)
        End Function
    End Class
End Namespace