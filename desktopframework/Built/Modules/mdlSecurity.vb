Imports MySql.Data.MySqlClient

Module mdlSecurity
    Public P_username As String
    Public P_SuperAdmin As Boolean
    Public P_Administrator As Boolean
    Public P_StockOfficer As Boolean
    Public P_StockManager As Boolean
    Public P_StockInquiry As Boolean

    Public P_ServerDate As String
    Public P_ServerTime As String

    Public Sub ActionLog(ByVal strLogAction As String, ByVal strFormName As String)

        Dim strADD As String = "INSERT INTO tbllogaction(UserName, tdate, ttime, " _
        & " LogAction, FormName) " _
        & " VALUES('" & P_username & "','" & P_ServerDate & "','" & P_ServerTime & "', " _
        & " '" & strLogAction & "','" & strFormName & "') "
        Try
            Dim DReader As New DataClassReader
            DReader.strSaveUpdateSQL = strADD
            'DReader.nelReader.Close()
            DReader.DataUpdate()
        Catch ex As MySqlException

        End Try
    End Sub

    Public Function GetServerDate() As Date
        Dim catCMD As MySqlCommand
        Dim myReader As MySqlDataReader
        ConnectDatabase()
        Try
            catCMD = conn.CreateCommand()
            catCMD.CommandText = "SELECT CURRENT_DATE "
            myReader = catCMD.ExecuteReader

            If myReader.Read() Then
                GetServerDate = CDate(FormatDateTime(myReader.Item(0).ToString, DateFormat.ShortDate))
            Else
                GetServerDate = CDate(Now.Date)
            End If
            myReader.Close()
        Catch ex As MySqlException
            GetServerDate = Now.Date
        End Try
    End Function

    Public Function GetServerTime() As String
        Dim catCMD As MySqlCommand
        Dim myReader As MySqlDataReader
        ConnectDatabase()
        Try
            catCMD = conn.CreateCommand()
            catCMD.CommandText = "SELECT CURRENT_TIME "
            myReader = catCMD.ExecuteReader

            If myReader.Read() Then
                GetServerTime = FormatDateTime(myReader.Item(0).ToString, DateFormat.ShortTime)
            Else
                GetServerTime = Now.TimeOfDay.ToString
            End If
            myReader.Close()
        Catch ex As MySqlException
            GetServerTime = Now.TimeOfDay.ToString
        End Try
    End Function

End Module
