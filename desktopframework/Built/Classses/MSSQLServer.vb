Imports System.Data.SqlClient

Public Class MSSQLServer
    Public nelReader As SqlDataReader
    Public NelTable As DataTable

    Private strSQL As String
    Private strSaveUpdate As String

    Public Property strSELECTSQL() As String
        Get
            Return strSQL
        End Get
        Set(ByVal value As String)
            strSQL = value
        End Set
    End Property

    Public Property strSaveUpdateSQL() As String
        Get
            Return strSaveUpdate
        End Get
        Set(ByVal value As String)
            strSaveUpdate = value
        End Set
    End Property

    Public Sub ReadData()
        'Dim myDataReader As SqlCommand
        'Try
        '    myDataReader = tempconn.CreateCommand()
        '    myDataReader.CommandText = strSQL
        '    nelReader = myDataReader.ExecuteReader
        'Catch myerror As ArgumentException    'MySql.Data.MySqlClient.MySqlException
        '    MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        '    End
        'End Try
    End Sub

    Public Sub GetTable()
        'Dim catCMD As New SqlCommand
        'catCMD = tempconn.CreateCommand()
        'catCMD.CommandText = strSQL

        'nelReader = catCMD.ExecuteReader
        'Dim myTable As DataTable = New DataTable
        'myTable.Load(nelReader)

        'NelTable = myTable

    End Sub


    Public Sub DataUpdate()
        'Dim inst As New SqlCommand(strSaveUpdate, tempconn)
        'inst.ExecuteNonQuery()
    End Sub
End Class
