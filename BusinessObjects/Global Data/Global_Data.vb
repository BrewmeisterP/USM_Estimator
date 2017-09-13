
Public Class Global_Data

    Public Shared EmployeeTable As DataTable
    Public Shared SurveyorView As DataView
    Public Shared ComponentTypeTable As DataTable

    Public Shared ActiveControlBackgroundColor As Color = Color.FromArgb(160, 190, 230)


    Public Shared Sub Initialize_global_data()
        'Set connection string for the life of the application
#If DEBUG Then
        SqlHelper.ConnectionString = My.Settings.DevConnString
#Else
        SqlHelper.ConnectionString = My.Settings.ProdConnString + "86<fsas<88"

#End If
        'MessageBox.Show(SqlHelper.ConnectionString)
        Load_Employee_Data()
        Load_Component_Type_Data()
    End Sub

    Private Shared Sub Load_Employee_Data()
        EmployeeTable = SqlHelper.ExecuteDataTable(CommandType.StoredProcedure, "stp_global__employee")
        SurveyorView = New DataView(EmployeeTable, "conducts_surveys = 1", "name", DataViewRowState.Unchanged)
    End Sub

    Private Shared Sub Load_Component_Type_Data()
        ComponentTypeTable = SqlHelper.ExecuteDataTable(CommandType.StoredProcedure, "stp_global__component_type")
    End Sub



End Class
