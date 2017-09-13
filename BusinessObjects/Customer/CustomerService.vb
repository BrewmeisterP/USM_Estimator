
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BusinessObjects
    Public NotInheritable Class CustomerService
        Private Sub New()
        End Sub
        Public Shared Function GetFromDatabase(iKey As Integer) As Customer
            'Code to call the dal to return a data reader, node or what ever you want to call it
            ' Here we will grab all of the values out of the object and pass it in to the call below
            Return Nothing
        End Function

        Private Shared Function Build(iName As String, iCity As String, iState As String, iZip As String, iPhoneNumber As String, iKey As Integer) As Customer
            Return New Customer(iName, iCity, iState, iZip, iPhoneNumber, iKey)
        End Function

        Public Shared Function BuildHardCoded() As Customers
            Dim oCustomers As New Customers()
            Dim oCustomer As New Customer("Dan Customer", "Hazelwood", "MO", "63042", "3148315555", 1)
            oCustomers.Add(oCustomer)
            Return oCustomers
        End Function
    End Class
End Namespace