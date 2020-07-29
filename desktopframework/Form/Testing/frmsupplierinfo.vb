Imports WeifenLuo.WinFormsUI.Docking
Public Class frmmanufacturerinfo
    Inherits DockContent
    Private Sub frmsupplierinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtssupplier.tblsupplier' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Dtssupplier.tblsupplier' table. You can move, or remove it, as needed.
        'PopulateCombo(cmbdesc, "Select suppname from tblsupplier  group by suppname")
        filter()
        cmbdesc.Text = ""
        populatedtr()
    End Sub
    Private Sub filter()
        TblsupplierTableAdapter.Connection = conn
        Me.TblsupplierTableAdapter.Fill(Me.Dtssupplier.tblsupplier)
    End Sub


    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        populatedtr()
    End Sub
    Private Sub populatedtr()
        dtgitemlist.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblsupplier where suppname like '%" & cmbdesc.Text & "%'"
        tabledtg(strSELECT)
    End Sub
    Private Sub tabledtg(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitemlist
                .Rows.Add()
                '.Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = DReader.nelReader.Item("pk")
                .Item(2, a).Value = DReader.nelReader.Item("suppNO")
                .Item(3, a).Value = DReader.nelReader.Item("suppname")
                .Item(4, a).Value = DReader.nelReader.Item("address")
                .Item(5, a).Value = DReader.nelReader.Item("suppcontactP")
                .Item(6, a).Value = DReader.nelReader.Item("rem")
                .Item(7, a).Value = DReader.nelReader.Item("manufacturer")
                .Item(8, a).Value = DReader.nelReader.Item("supplier")

            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        filterpk()
        populatedtr()
        filter()
    End Sub
    Private Sub filterpk()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgitemlist.RowCount - 2
        Dim a As Integer
        Dim pk As String = ""
        Dim chk As Boolean = False
        With dtgitemlist
            For a = 0 To rCnt
                'On Error Resume Next
                pk = .Item(1, a).Value
                chk = .Item(0, a).Value
                '.Item(2, a).Value
                Dim suppname As String = .Item(3, a).Value
                Dim address As String = .Item(4, a).Value
                Dim suppcontactP As String = .Item(5, a).Value
                Dim remarks As String = .Item(6, a).Value
                Dim man As String = .Item(7, a).Value
                Dim supp As String = .Item(8, a).Value
                If pk = "" Or chk = True Then
                    updatecontent(pk, suppname, suppcontactP, remarks, address, man, supp)
                End If

            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub updatecontent(ByVal pk As String, _
                             ByVal suppname As String, _
                             ByVal suppcontactP As String, _
                             ByVal remrks As String, ByVal address As String, _
                             ByVal man As String, ByVal supp As String)
        Dim suppno As String = ""
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        suppno = IDgenerator("supplier")
        dtData.strSELECT = "SELECT * FROM tblsupplier WHERE pk = '" & pk & "'"
        dtData.strUpdate = "UPDATE tblsupplier SET " _
            & " suppname = '" & suppname & "', " _
            & " suppNO = '" & suppno & "', " _
            & " suppcontactP = '" & suppcontactP & "', " _
            & " rem = '" & remrks & "',address = '" & address & "', " _
            & " manufacturer = '" & man & "', supplier = '" & supp & "'" _
            & " WHERE pk = '" & pk & "'"
        dtData.strAdd = "INSERT INTO tblsupplier " _
            & " (suppname," _
            & " suppNO," _
            & " suppcontactP," _
            & " rem,address,manufacturer,supplier) " _
            & " VALUES('" & suppname & "'," _
            & " '" & suppno & "'," _
            & " '" & suppcontactP & "'," _
            & " '" & remrks & "','" & address & "','" & man & "','" & supp & "')"
        dtData.Save()
        IDgeneratorSave("supplier", suppno)
    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        delfilter()
    End Sub
    Private Sub delfilter()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgitemlist.RowCount - 2
        Dim a As Integer
        Dim pk As String = ""
        Dim chk As Boolean = False
        With dtgitemlist
            For a = 0 To rCnt
                'On Error Resume Next
                pk = .Item(1, a).Value
                chk = .Item(0, a).Value
                If chk = True Then
                    del(pk)
                End If
            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub del(ByVal pk As String)
        If pk.Trim <> "" Then
            Dim ans As Long = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ans = vbYes Then
                DeleteLogistic(pk)
                populatedtr()
            End If
        End If
    End Sub
    Private Sub DeleteLogistic(ByVal pk As String)
        Dim strProfileNo As String = pk
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblsupplier WHERE pk='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tblsupplier WHERE pk='" & strProfileNo & "'"
        dtData.DELETE()
        'ActionLog("Emplyee Profile deleted Ref: " & txtProfileNo.Text & " Emplyee Name: " & txtName.Text, Me.Text)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dtgitemlist.Rows.Clear()
    End Sub
End Class