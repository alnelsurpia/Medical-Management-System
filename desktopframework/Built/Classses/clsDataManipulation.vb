Imports System.IO
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Public Class clsDataManipulation

    Public Sub New()
        _IDGenSave = False
        _IDGenCode = ""
        _IDGenValue = ""
    End Sub

    Private _IDGenSave As Boolean
    Public Property IDGenSave() As Boolean
        Get
            Return _IDGenSave
        End Get
        Set(ByVal value As Boolean)
            _IDGenSave = value
        End Set
    End Property

    Private _IDGenCode As String
    Public Property IDGenCode() As String
        Get
            Return _IDGenCode
        End Get
        Set(ByVal value As String)
            _IDGenCode = value
        End Set
    End Property

    Private _IDGenValue As String
    Public Property IDGenValue() As String
        Get
            Return _IDGenValue
        End Get
        Set(ByVal value As String)
            _IDGenValue = value
        End Set
    End Property

    Private _strSELECT As String
    Public Property strSELECT() As String
        Get
            Return _strSELECT
        End Get
        Set(ByVal value As String)
            _strSELECT = value
        End Set
    End Property

    Private _strDELETE As String
    Public Property strDELETE() As String
        Get
            Return _strDELETE
        End Get
        Set(ByVal value As String)
            _strDELETE = value
        End Set
    End Property

    Private _strAdd As String
    Public Property strAdd() As String
        Get
            Return _strAdd
        End Get
        Set(ByVal value As String)
            _strAdd = value
        End Set
    End Property

    Private _strUpdate As String
    Public Property strUpdate() As String
        Get
            Return _strUpdate
        End Get
        Set(ByVal value As String)
            _strUpdate = value
        End Set
    End Property

    Public Sub Save()

        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = _strSELECT
        DReader.ReadData()

        If DReader.nelReader.Read Then
            DReader.nelReader.Close()
            DReader.strSaveUpdateSQL = _strUpdate
            DReader.DataUpdate()
        Else
            DReader.nelReader.Close()
            DReader.strSaveUpdateSQL = _strAdd
            DReader.DataUpdate()


            If _IDGenSave = True Then
                IDgeneratorSave(_IDGenCode, _IDGenValue)
            End If

        End If
    End Sub
    Public Sub Save(ByVal picShowPicture As PictureBox, ByVal strDataManipulation As String)
        If picShowPicture.Image Is Nothing Then Exit Sub

        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = _strSELECT
        DReader.ReadData()

        If DReader.nelReader.Read Then
            DReader.nelReader.Close()
        Else
            DReader.nelReader.Close()
            If _IDGenSave = True Then
                IDgeneratorSave(_IDGenCode, _IDGenValue)
            End If
        End If


        Dim ms As MemoryStream = New MemoryStream
        picShowPicture.Image.Save(ms, ImageFormat.Png)
        Dim bytBLOBData(ms.Length - 1) As Byte

        ms.Position = 0
        ms.Read(bytBLOBData, 0, ms.Length)


        'Dim prm As New MySql.Data.MySqlClient.MySqlParameter("@BLOBData", _
        'MySql.Data.MySqlClient.MySqlDbType.Blob, _
        'bytBLOBData.Length, ParameterDirection.Input, False, _
        '0, 0, Nothing, DataRowVersion.Current, bytBLOBData)

        Dim cmd As MySqlCommand = New MySqlCommand(strDataManipulation, conn)
        Dim pic As MySqlParameter = New MySqlParameter("?picsd", MySqlDbType.Blob)
        pic.Value = bytBLOBData
        cmd.Parameters.Add(pic)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub DELETE()

        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = _strSELECT
        DReader.ReadData()

        If DReader.nelReader.Read Then
            DReader.nelReader.Close()
            DReader.strSaveUpdateSQL = _strDELETE
            DReader.DataUpdate()
        Else
            DReader.nelReader.Close()
        End If
    End Sub
End Class
