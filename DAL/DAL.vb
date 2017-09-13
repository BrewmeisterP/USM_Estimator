Imports System.Data.SqlClient

Public Module DAL
    Public Function Survey_Insert(ByVal Customer_Pk As Integer, ByVal Employee_Entered_PK As Integer) As Integer
        Dim o_Survey_Pk As Integer
        o_Survey_Pk = 0
        Dim SqlCon = New SqlConnection(My.Settings.DevConnString)
        Using Connection = SqlCon
            Connection.Open()

            ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("stp_survey__insert", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fk_customer", Customer_Pk)
            cmd.Parameters.AddWithValue("@fk_employee__entered_by", Employee_Entered_PK)

            Dim DummyValue As Integer 'SQL just needs a fillin value for this
            cmd.Parameters.AddWithValue("@pk_survey", DummyValue)
            cmd.Parameters("@pk_survey").Direction = ParameterDirection.Output

            ' Ask the command to create an SqlDataReader on the result of the sproc'
            Using Reader = cmd.ExecuteReader()
                Dim PkAsString As String
                PkAsString = cmd.Parameters("@pk_survey").Value.ToString()
                If Integer.TryParse(PkAsString, o_Survey_Pk) = False Then
                    Throw New Exception("Survey Insert didn't return a new PK")
                End If
            End Using
        End Using
        'If 0 throw an error
        Return o_Survey_Pk
    End Function

    Public Function Substation_Insert(ByVal Survey_Pk As Integer, ByVal Name As String, ByVal City As String, ByVal State As String,
                                             ByVal ZipMaybe As String) As Integer
        Dim o_iSubstation_Pk As Integer
        o_iSubstation_Pk = 0
        Dim SqlCon = New SqlConnection(My.Settings.DevConnString)
        Using Connection = SqlCon
            Connection.Open()

            ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("stp_substation__insert", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fk_survey", Survey_Pk)
            cmd.Parameters.AddWithValue("@name", Name)
            cmd.Parameters.AddWithValue("@city", City)
            cmd.Parameters.AddWithValue("@state", State)
            cmd.Parameters.AddWithValue("@zip", ZipMaybe)

            Dim DummyValue As Integer 'SQL just needs a fillin value for this
            cmd.Parameters.AddWithValue("@pk_substation", DummyValue)
            cmd.Parameters("@pk_substation").Direction = ParameterDirection.Output

            ' Ask the command to create an SqlDataReader on the result of the sproc'
            Using Reader = cmd.ExecuteReader()
                Dim PkAsString As String
                PkAsString = cmd.Parameters("@pk_substation").Value.ToString()
                If Integer.TryParse(PkAsString, o_iSubstation_Pk) = False Then
                    Throw New Exception("Substation Insert didn't return a new PK")
                End If
            End Using
        End Using
        'If 0 throw an error
        Return o_iSubstation_Pk
    End Function

    Public Function ItemSet_Insert(ByVal Substation_Pk As Integer, ByVal Surveyor_Pk As Integer, ByVal ItemNumber As Integer,
                                          ByVal ManufacturerMaybe As String, ByVal SizeMaybe As String, ByVal VoltageMaybe As String,
                                          ByVal SurveryPageNumber As Integer, ByVal SurveyDate As Date, ByVal ForemanNotesMaybe As String,
                                          ByVal CustomerNotesMaybe As String, ByVal SurveyorNotesMaybe As String) As Integer
        Dim o_iItemSet_Pk As Integer
        o_iItemSet_Pk = 0
        Dim SqlCon = New SqlConnection(My.Settings.DevConnString)
        Using Connection = SqlCon
            Connection.Open()

            ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("stp_item_set__insert", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fk_substation", Substation_Pk)
            cmd.Parameters.AddWithValue("@fk_employee__surveyor", Surveyor_Pk)
            cmd.Parameters.AddWithValue("@item_number", ItemNumber)
            cmd.Parameters.AddWithValue("@manufacturer", ManufacturerMaybe)
            cmd.Parameters.AddWithValue("@size", SizeMaybe)
            cmd.Parameters.AddWithValue("@voltage", VoltageMaybe)
            cmd.Parameters.AddWithValue("@survey_page_number", SurveryPageNumber)
            cmd.Parameters.AddWithValue("@survey_date", SurveyDate)
            cmd.Parameters.AddWithValue("@foreman_notes", ForemanNotesMaybe)
            cmd.Parameters.AddWithValue("@customer_notes", CustomerNotesMaybe)
            cmd.Parameters.AddWithValue("@surveyor_notes", SurveyorNotesMaybe)

            Dim DummyValue As Integer 'SQL just needs a fillin value for this
            cmd.Parameters.AddWithValue("@pk_item_set", DummyValue)
            cmd.Parameters("@pk_item_set").Direction = ParameterDirection.Output

            ' Ask the command to create an SqlDataReader on the result of the sproc'
            Using Reader = cmd.ExecuteReader()
                Dim PkAsString As String
                PkAsString = cmd.Parameters("@pk_item_set").Value.ToString()
                If Integer.TryParse(PkAsString, o_iItemSet_Pk) = False Then
                    Throw New Exception("ItemSet Insert didn't return a new PK")
                End If
            End Using
        End Using
        'If 0 throw an error
        Return o_iItemSet_Pk
    End Function

    Public Sub Item_Insert(ByVal ItemSet_Pk As Integer, ByVal Name As String, ByVal SerialNumber As String,
                                          ByVal PercentBrushBlast As Integer, ByVal PercentSpotBlast As Integer)

        Dim SqlCon = New SqlConnection(My.Settings.DevConnString)
        Using Connection = SqlCon
            Connection.Open()

            ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("stp_item__insert", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fk_item_set", ItemSet_Pk)
            cmd.Parameters.AddWithValue("@name", Name)
            cmd.Parameters.AddWithValue("@serial_number", SerialNumber)
            cmd.Parameters.AddWithValue("@pct_brush_blast", PercentBrushBlast)
            cmd.Parameters.AddWithValue("@pct_spot_blast", PercentSpotBlast)

            ' Ask the command to create an SqlDataReader on the result of the sproc'
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>
    ''' Every one of these is a maybe. It depends on the Component Type which should contain values
    ''' Also When a value is passed in it should be in Feet NOT inches
    ''' </summary>
    Public Sub Component_Insert(ByVal ComponentType_Pk As Integer, ByVal ItemSet_Pk As Integer, ByVal Length As Integer, ByVal Width As Integer,
                                ByVal Height As Integer, ByVal Diameter As Integer, ByVal Circumference As Integer, ByVal SquareInches As Decimal,
                                ByVal RadiatorSets As Integer, ByVal TubesPerRS As Integer, ByVal Quantity As Integer, ByVal PaintableSqFt As Decimal)

        Dim SqlCon = New SqlConnection(My.Settings.DevConnString)
        Using Connection = SqlCon
            Connection.Open()

            ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("stp_component__insert", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fk_component_type", ComponentType_Pk)
            cmd.Parameters.AddWithValue("@fk_item_set", ItemSet_Pk)
            cmd.Parameters.AddWithValue("@length", Length)
            cmd.Parameters.AddWithValue("@width", Width)
            cmd.Parameters.AddWithValue("@height", Height)
            cmd.Parameters.AddWithValue("@diameter", Diameter)
            cmd.Parameters.AddWithValue("@circumference", Circumference)
            cmd.Parameters.AddWithValue("@square_inches", SquareInches)
            cmd.Parameters.AddWithValue("@radiator_sets", RadiatorSets)
            cmd.Parameters.AddWithValue("@tubes_per_radiator", TubesPerRS)
            cmd.Parameters.AddWithValue("@quantity", Quantity)
            cmd.Parameters.AddWithValue("@paintable_square_inches", PaintableSqFt)

            ' Ask the command to create an SqlDataReader on the result of the sproc'
            cmd.ExecuteNonQuery()
        End Using
    End Sub


End Module
