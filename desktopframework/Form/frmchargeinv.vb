Public Class frmchargeinv

    Private Sub frmchargeinv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateCombo(cmbtrno, "Select trno from tbltrmain group by trno")
        PopulateCombo(txtcino, "Select cino from tblchargenew group by cino")
        PopulateCombo(cmbflterbox, "Select cino from tblchargenew group by cino")
        cmbtrno.Text = maintr
        PopulateItem()
        'PopulateItem
    End Sub
    Private Sub cmdfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfilter.Click
        PopulateItem()
    End Sub
    Private Sub PopulateItem()
        dtgdrlist.Rows.Clear()
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tbltrmain where trno = '" & cmbtrno.Text & "' order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgdrlist
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("itemcode")
                .Item(2, a).Value = DReader.nelReader.Item("pk")
                .Item(3, a).Value = DReader.nelReader.Item("descripition") & " " & DReader.nelReader.Item("size")
                .Item(4, a).Value = DReader.nelReader.Item("unit")
                'no cpr
                .Item(6, a).Value = DReader.nelReader.Item("lnbn")
                .Item(7, a).Value = DReader.nelReader.Item("expdate")
                .Item(8, a).Value = DReader.nelReader.Item("drqty")
                .Item(9, a).Value = DReader.nelReader.Item("sp1")
                .Item(10, a).Value = Val(Replace(.Item(9, a).Value, ",", "")) * Val(Replace(.Item(8, a).Value, ",", ""))
                .Item(11, a).Value = Val(Replace(DReader.nelReader.Item("qty"), ",", "")) - Val(Replace(DReader.nelReader.Item("drqty"), ",", ""))
                lbltr.Text = DReader.nelReader.Item("trno")
                lblpr.Text = DReader.nelReader.Item("prno")
                lblpo.Text = DReader.nelReader.Item("ponumb")
                txtsoldto.Text = DReader.nelReader.Item("cname")
                txtaddress.Text = DReader.nelReader.Item("placeofdel")
                If Val(.Item(11, a).Value) > 0 Then
                    .Item(12, a).Value = "Incomplete"
                ElseIf Val(.Item(11, a).Value) <= 0 Then
                    .Item(12, a).Value = "Complete"
                End If
                .Item(13, a).Value = DReader.nelReader.Item("drno")
                'txtcino.Text = DReader.nelReader.Item("drno")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        GroupBox1.Enabled = True
    End Sub
    Private Sub cmdapproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdapproved.Click
        checkdrifexsist()
        If found = True Then
            Dim ans As Long = MessageBox.Show("This CI no. already exist wanna continue", "Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If ans = vbYes Then
                If txtcino.Text <> "" Then
                    filterpk()
                Else
                    MessageBox.Show("No Charge Invoice Number..")
                End If
            End If
        Else
            If txtcino.Text <> "" Then
                filterpk()
            Else
                MessageBox.Show("No Charge Invoice Number..")
            End If

        End If
    End Sub
    Dim found As Boolean = False
    Private Sub checkdrifexsist()
        Dim stocks As Double = 0
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblchargenew WHERE cino = '" & txtcino.Text & "'"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        If DReader.nelReader.Read Then
            found = True
        Else
            found = False
        End If
        DReader.nelReader.Close()
    End Sub
    Private Sub filterpk()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgdrlist.RowCount - 1
        Dim a As Integer
        Dim pk As String = ""
        Dim chk As Boolean = False
        With dtgdrlist
            For a = 0 To rCnt
                Dim drqty As String = .Item(8, a).Value
                Dim drdesc As String = .Item(3, a).Value
                Dim drunit As String = .Item(4, a).Value
                Dim dritemcode As String = .Item(0, a).Value
                Dim drcpr As String = .Item(5, a).Value
                Dim drlnbn As String = .Item(6, a).Value
                Dim drexpdate As String = .Item(7, a).Value
                Dim drunitprice As String = .Item(9, a).Value
                'Dim pk1 As String = .Item(0, a).Value
                If .Item(1, a).Value = True Then
                    savetitem(drqty, drdesc, drunit, dritemcode, drcpr, _
                                  drlnbn, drexpdate, drunitprice, txtsoldto.Text, _
                                  txtaddress.Text, dtpdrdate.Text)
                End If
            Next a
            MessageBox.Show("SAVED!!!")
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub savetitem(ByVal drqty As String, _
                          ByVal drdesc As String, _
                          ByVal drunit As String, _
                          ByVal dritemcode As String, _
                          ByVal drcpr As String, _
                          ByVal drlnbn As String, _
                          ByVal drexpdate As String, _
                          ByVal drunitprice As String, _
                          ByVal cname As String, _
                          ByVal caddress As String, _
                          ByVal drdate As String)
        Dim dredit As String = txtdrs.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblchargenew WHERE cino = '" & txtcino.Text & "' and prodcode = '" & dritemcode & "'"
        dtData.strUpdate = "UPDATE tblchargenew SET " _
            & " soldto = '" & txtsoldto.Text & "'," _
            & " address = '" & txtaddress.Text & "'," _
            & " prno = '" & lblpr.Text & "'," _
            & " trno = '" & lbltr.Text & "'," _
            & " pono = '" & lblpo.Text & "'," _
            & " qty = '" & drqty & "'," _
            & " drdate = '" & dtpdrdate.Text & "'," _
            & " drno = '" & dredit & "'," _
            & " description = '" & drdesc & "'," _
            & " unit = '" & drunit & "'," _
            & " prodcode = '" & dritemcode & "'," _
            & " cpr = '" & drcpr & "'," _
            & " lnbn = '" & drlnbn & "'," _
            & " expdate = '" & drexpdate & "'," _
            & " unitprice = '" & drunitprice & "',cino = '" & txtcino.Text & "'" _
            & " WHERE cino = '" & txtcino.Text & "' and prodcode = '" & dritemcode & "'"
        dtData.strAdd = "INSERT INTO tblchargenew " _
            & " (soldto,address,prno,trno,pono,qty,drdate," _
            & " drno,description,unit,prodcode,cpr,lnbn,expdate," _
            & " unitprice,cino) " _
            & " VALUES( '" & txtsoldto.Text & "'," _
            & " '" & txtaddress.Text & "'," _
            & " '" & lblpr.Text & "', " _
            & " '" & lbltr.Text & "'," _
            & " '" & lblpo.Text & "', " _
            & " '" & drqty & "', " _
            & " '" & dtpdrdate.Text & "'," _
            & " '" & dredit & "', " _
            & " '" & drdesc & "'," _
            & " '" & drunit & "', " _
            & " '" & dritemcode & "'," _
            & " '" & drcpr & "'," _
            & " '" & drlnbn & "'," _
            & " '" & drexpdate & "'," _
            & " '" & drunitprice & "','" & txtcino.Text & "')"
        dtData.Save()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        CHinvoiceno = txtcino.Text
        frmCinvoice.Close()
        frmCinvoice.ShowDialog()
    End Sub

    Private Sub cmdfiltermain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfiltermain.Click
        PopulateItemmain()
    End Sub
    Private Sub PopulateItemmain()
        dtgcimain.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblchargenew where cino like '%" & cmbflterbox.Text & "%' or soldto like '%" & cmbflterbox.Text & "%' group by drno order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgcimain
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("drdate")
                .Item(1, a).Value = DReader.nelReader.Item("cino")
                .Item(2, a).Value = DReader.nelReader.Item("soldto")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
End Class