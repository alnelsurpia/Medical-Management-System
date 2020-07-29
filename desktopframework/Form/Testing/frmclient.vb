Imports WeifenLuo.WinFormsUI.Docking
Public Class frmclient
    Inherits DockContent
    Dim clientno As String = ""
    Private Sub frmclient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PopulateCombo(cmbdesc, "Select suppname from tblclient")
        'Me.ReportViewer1.RefreshReport()
        populateclient()
        populatedtr()
    End Sub
    Private Sub populateclient()
        Dim strSELECT As String = "SELECT suppname,address,suppNO FROM tblclient "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbdesc.Items.Clear()
        Do While DReader.nelReader.Read
            cmbdesc.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        filterpk()
        populatedtr()
        'Filter()
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

        dtData.strSELECT = "SELECT * FROM tblclient WHERE pk='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tblclient WHERE pk='" & strProfileNo & "'"
        dtData.DELETE()
        'ActionLog("Emplyee Profile deleted Ref: " & txtProfileNo.Text & " Emplyee Name: " & txtName.Text, Me.Text)
    End Sub
    Private Sub populatedtr()
        dtgitemlist.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblclient where suppname like '%" & cmbdesc.Text & "%'"
        tabledtg(strSELECT)
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

            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
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
                Dim suppno As String = "" '.Item(2, a).Value
                Dim suppname As String = .Item(3, a).Value
                Dim address As String = .Item(4, a).Value
                Dim suppcontactP As String = .Item(5, a).Value
                Dim remarks As String = .Item(6, a).Value

                If pk = "" Or chk = True Then
                    'suppno = IDgenerator("client")
                    'IDgeneratorSave("client", suppno)
                    updatecontent(pk, suppname, suppcontactP, remarks, address)
                End If

            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub updatecontent(ByVal pk As String, _
                              ByVal suppname As String, _
                             ByVal suppcontactP As String, _
                             ByVal remrks As String, ByVal address As String)
        Dim suppno As String = ""
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        suppno = IDgenerator("client")
        dtData.strSELECT = "SELECT * FROM tblclient WHERE pk = '" & pk & "'"
        dtData.strUpdate = "UPDATE tblclient SET " _
            & " suppname = '" & suppname & "', " _
            & " suppNO = '" & suppno & "', " _
            & " suppcontactP = '" & suppcontactP & "', " _
            & " rem = '" & remrks & "',address = '" & address & "' " _
            & " WHERE pk = '" & pk & "'"
        dtData.strAdd = "INSERT INTO tblclient " _
            & " (suppname," _
            & " suppNO," _
            & " suppcontactP," _
            & " rem,address) " _
            & " VALUES('" & suppname & "'," _
            & " '" & suppno & "'," _
            & " '" & suppcontactP & "'," _
            & " '" & remrks & "','" & address & "')"
        dtData.Save()
        IDgeneratorSave("client", suppno)
    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        delfilter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If clientno <> "" Then
            Statement.cmbclientname.Text = cmbdesc.Text
            statfrm = dtpfrom.Text
            statto = dtpto.Text
            statecno = clientno
            Statement.Close()
            Statement.Show()
        End If
    End Sub

    Private Sub cmbdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesc.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbdesc.SelectedItem, SupplierInfo)
        'cmbclientadd.Text = acc.SupplierNo
        clientno = acc.SupplierAddress
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If clientno <> "" Then
            statfrm = dtpfrom.Text
            statto = dtpto.Text
            statecno = clientno
            frmcollected.Close()
            frmcollected.Show()
        End If
    End Sub

    Private Sub cmdstatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstatement.Click
        If clientno <> "" Then
            statfrm = dtpfrom.Text
            statto = dtpto.Text
            statecno = clientno
            frmallstatement.Close()
            frmallstatement.Show()
        End If
    End Sub
End Class