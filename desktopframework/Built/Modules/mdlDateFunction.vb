Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module mdlDateFunction
    Public Sub PopulateMonth(ByVal comboMonth As ComboBox)
        With comboMonth
            .Items.Clear()
            Dim a As Integer
            For a = 1 To 12
                .Items.Add(MonthName(a))
            Next a
            .Text = MonthName(Month(Now))
        End With
    End Sub

    Public Function GetMonth(ByVal strMonth As String) As Integer
        Select Case strMonth
            Case "January"
                GetMonth = 1
            Case "February"
                GetMonth = 2
            Case "March"
                GetMonth = 3
            Case "April"
                GetMonth = 4
            Case "May"
                GetMonth = 5
            Case "June"
                GetMonth = 6
            Case "July"
                GetMonth = 7
            Case "August"
                GetMonth = 8
            Case "September"
                GetMonth = 9
            Case "October"
                GetMonth = 10
            Case "November"
                GetMonth = 11
            Case "December"
                GetMonth = 12
        End Select
    End Function

    Public Sub PopulateYear(ByVal comboYear As ComboBox)
        Dim i As Integer
        comboYear.Items.Clear()
        For i = 2007 To Year(Now)
            comboYear.Items.Add(i)
        Next i
        comboYear.Text = Year(Now)
    End Sub

    Public Function IDgenerator(ByVal strType As String) As String
        'IDgenerator = strEntry & Year(Now) & Month(Now) & Hour(Now) & Minute(Now) & Second(Now)
        Dim catCMD As MySqlCommand
        Dim myReader As MySqlDataReader
        ConnectDatabase()
        Try
            catCMD = conn.CreateCommand()
            catCMD.CommandText = "SELECT * FROM gencode " _
            & " WHERE ttype='" & strType & "'"
            myReader = catCMD.ExecuteReader

            If myReader.Read() Then
                IDgenerator = ZeroGen(myReader.Item(1).ToString)
            Else
                IDgenerator = "Invalid ID"
            End If
            myReader.Close()
        Catch ex As MySqlException
            IDgenerator = "Invalid ID"
        End Try

    End Function

    Public Sub IDgeneratorSave(ByVal strType As String, ByVal strVal As String)
        Try
            Dim strInsert As String = "UPDATE gencode SET tcode = '" & strVal & "'" _
            & " WHERE ttype='" & strType & "'"
            Dim inst As New MySqlCommand(strInsert, conn)
            inst.ExecuteNonQuery()
        Catch ex As MySqlException
        End Try

    End Sub

    Private Function ZeroGen(ByVal strData As String)
        Dim intLenght As Integer = strData.Length
        Dim strDataTemp As String = Val(strData) + 1
        Dim intDataLenght As Integer = Len(strDataTemp)
        Dim strDataV As String = Val(strData) + 1

        Dim a As Integer

        For a = 1 To intLenght - intDataLenght
            strDataV = "0" + strDataV
        Next a
        ZeroGen = strDataV
    End Function

    Public Function GetDatabaseServerTime() As Date
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = "SELECT * FROM tblServerTime"
        Dim strTime As String
        DReader.ReadData()

        If DReader.nelReader.Read Then
            strTime = DReader.nelReader.Item(0)
            DReader.nelReader.Close()
        Else
            strTime = DReader.nelReader.Item(0)
            DReader.nelReader.Close()
        End If
        Return CDate(strTime)

    End Function

    Public Function ConvertWinToLinDate(ByVal strDate As String) As String
        Dim dt As Date = CDate(strDate)
        Dim strLinDate As String = Format(dt, "yyyy-MM-dd")
        Return strLinDate
    End Function
End Module
