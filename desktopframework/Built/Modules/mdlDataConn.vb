Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module mdlDataConn
    Public conn As New MySqlConnection
    Public tempconn As New SqlConnection
    Public Sub ConnectDatabase()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "DATABASE=" & My.Settings.database & ";" _
             & "SERVER=" & ServerIP & ";user id=" & My.Settings.username _
             & ";password=" & My.Settings.password & ";port=" & My.Settings.port & ";charset=utf8"
                conn.Open()
            End If

        Catch myerror As Exception
            MessageBox.Show("Error Connecting to the database", "Error Database Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
    End Sub

    Public Sub ConnectDatabase(ByVal strIP As String)

        Try
            'strIP = ServerIP
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "DATABASE=" & My.Settings.database & ";" _
             & "SERVER=" & strIP & ";user id=" & My.Settings.username _
             & ";password=" & My.Settings.password & ";port=" & My.Settings.port & ";charset=utf8"
                conn.Open()
            End If

        Catch myerror As Exception
            MessageBox.Show("Error Connecting to the database", "Error Database Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
    End Sub

    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException

        End Try
    End Sub

    Public Sub TempConnectDatabase()

        'Try
        '    If tempconn.State = ConnectionState.Closed Then
        '        tempconn.ConnectionString = My.Settings.dbInventoryConnectionString
        '        tempconn.Open()
        '    End If

        'Catch myerror As SqlException
        '    MessageBox.Show("Error Caching data" + Chr(10) + "Contact Programmer", "Error Cache", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    End
        'End Try
    End Sub

    Public Sub TempDisconnectDatabase()
        Try
            tempconn.Close()
        Catch myerror As SqlException

        End Try
    End Sub
End Module
