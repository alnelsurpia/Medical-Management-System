Public Class frmcollectionrec
    Dim clientno As String = ""
    Dim rcost As Double = 0
    Dim collno As String = ""
    Dim dbpayment As Double = 0
    Dim itmpk As String = ""
    Private Sub frmcollectionrec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populateclient()
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

    Private Sub cmbdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesc.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbdesc.SelectedItem, SupplierInfo)
        'cmbclientadd.Text = acc.SupplierNo
        clientno = acc.SupplierAddress
    End Sub

    Private Sub btnlocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlocate.Click
        If cmbdesc.Text <> "" Then
            populateitems()
        End If
    End Sub
    Private Sub populateitems()
        dtgmain.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT tdate,delNo, qty, SUM(amount)," _
        & " SUM(Payment)  FROM tbldelievery where clientno like '%" & clientno & "%' and amount > Payment and Ptype = 'Charge' group by delNo"
        tabledtgdritem(strSELECT)
    End Sub
    Private Sub tabledtgdritem(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgmain
                .Rows.Add()
                .Item(1, a).Value = DReader.nelReader.Item("tdate")
                .Item(2, a).Value = DReader.nelReader.Item("delNo")
                .Item(3, a).Value = DReader.nelReader.Item("qty")
                .Item(4, a).Value = FormatNumber(DReader.nelReader.Item("SUM(amount)"), 2)
                .Item(5, a).Value = FormatNumber(DReader.nelReader.Item("SUM(Payment)"), 2)
            End With
            a = a + 1
        Loop
        'txttamount.Text = FormatNumber(SumItUp(dtgitemlist, 5), 2)
        DReader.nelReader.Close()
    End Sub

    Private Sub dtgmain_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgmain.CellClick
        With dtgmain.SelectedRows(0)
            Dim pk As String = .Cells(2).Value
            populateitems(pk)
        End With
    End Sub
    Private Sub populateitems(ByVal delno As String)
        dtgitem.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbldelievery where delNo = '" & delno & "'"
        tabledtgdritem2(strSELECT)
    End Sub
    Private Sub tabledtgdritem2(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitem
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = DReader.nelReader.Item("itemdesc")
                .Item(2, a).Value = DReader.nelReader.Item("uprice")
                .Item(3, a).Value = FormatNumber(DReader.nelReader.Item("qty"), 2)
                .Item(4, a).Value = FormatNumber(Val(DReader.nelReader.Item("qty")) * Val(DReader.nelReader.Item("uprice")), 2)
                .Item(5, a).Value = DReader.nelReader.Item("amount")
                .Item(6, a).Value = DReader.nelReader.Item("Payment")
            End With
            a = a + 1
        Loop
        ' txttamount.Text = FormatNumber(SumItUp(dtgitemlist, 5), 2)
        DReader.nelReader.Close()
    End Sub

    Private Sub dtgmain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgmain.CellContentClick

    End Sub

    Private Sub btnpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpay.Click
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgmain.RowCount - 1
        Dim a As Integer

        Dim payment As Double = Replace(txtamount.Text, ",", "")
        Dim payment2 As Double = 0
        Dim paid As Double = 0
        Dim drno As String = ""

        collno = IDgenerator("collno")
        'With dtgmain
        For a = 0 To rCnt
            'On Error Resume Next
            Dim b As Boolean = dtgmain.Item(0, a).Value
            If b = "True" Then
                Dim amntsaved As Double = 0
                Dim rCnt2 As Integer = dtgitem.RowCount - 1
                Dim a1 As Integer
                drno = dtgmain.Item(2, a).Value
                populateitems(drno)
                'With dtgitem
                For a1 = 0 To rCnt2
                    'With dtgitem
                    'itmpk = dtgitem.Item(0, a1).Value
                    finditmpk(a1)
                    locateamount(drno, itmpk)
                    'End With
                    'If rcost >= dbpayment Then
                    amntsaved = rcost - dbpayment
                    'End If
                    payment2 = payment
                    If payment2 >= amntsaved Then
                        paid = amntsaved
                    Else
                        paid = payment2
                    End If
                    payment = payment - paid '(dbpayment - rcost)
                    updatedeleievery(drno, paid, itmpk)
                Next a1
                'End With
            End If
            rcost = 0
        Next a
        'End With
        IDgeneratorSave("collno", collno)
        savemain()
        populateitems()
        Cursor = Cursors.Default
    End Sub
    Private Sub finditmpk(ByVal pk As Integer)
        With dtgitem
            itmpk = .Item(0, pk).Value
            'Dim x As String = .Item(1, pk).Value
            'Dim y As String = .Item(2, pk).Value
            'Dim z As String = .Item(3, pk).Value
            'Dim u As String = .Item(4, pk).Value
        End With
    End Sub
    Private Sub updatedeleievery(ByVal del As String, ByVal tcost As Double, ByVal itmpk As String)
        Dim dtData As New clsDataManipulation
        Dim amnt As Double = Val(Replace(txtamount.Text, ",", ""))
        dtData.strSELECT = "SELECT * FROM tbldelievery WHERE delNo ='" & del & "' and pk = '" & itmpk & "'"
        dtData.strUpdate = "UPDATE tbldelievery SET " _
            & " datecol='" & dtpdate.Text & "',payment = payment + '" & tcost & "'," _
            & " collectionno = '" & collno & "', cashrecieved = cashrecieved + '" & Replace(txtamount.Text, ",", "") & "'," _
            & " PStatus='Paid',chkno = '" & txtcheckno.Text & "',particular = '" & txtrem.Text & "'" _
            & " WHERE delNo ='" & del & "' and pk = '" & itmpk & "'"
        dtData.strAdd = "SELECT * FROM tbldelievery"
        dtData.Save()
    End Sub

    Private Sub savemain()
        'Dim strDSno As String = txtpk.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        'dtData.IDGenValue = strDSno
        'dtData.IDGenCode = "DR"
        dtData.strSELECT = "SELECT * FROM tblcollection WHERE collno ='" & collno & "'"
        dtData.strUpdate = "UPDATE tblcollection SET " _
            & " cdate='" & dtpdate.Text & "', " _
            & " camount ='" & txtamount.Text & "'," _
            & " collno ='" & collno & "'," _
            & " custno ='" & clientno & "', " _
            & " custname ='" & cmbdesc.Text & "'," _
            & " checkno = '" & txtcheckno.Text & "'" _
            & " WHERE collno ='" & collno & "'"
        dtData.strAdd = "INSERT INTO tblcollection " _
            & " (cdate, camount, collno, custno,custname,checkno) " _
            & " VALUES('" & dtpdate.Text & "', " _
            & " '" & txtamount.Text & "','" & collno & "', " _
            & " '" & clientno & "'," _
            & " '" & cmbdesc.Text & "','" & txtcheckno.Text & "')"
        dtData.Save()
    End Sub

    Private Sub locateamount(ByVal delno As String, ByVal itmpk As String)
        'dtgitem.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbldelievery where delNo = '" & delno & "' and pk = '" & itmpk & "'"
        tabledtgdrcharge(strSELECT)
    End Sub
    Private Sub tabledtgdrcharge(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim Ramount As Integer = 0
        If DReader.nelReader.Read Then
            rcost = DReader.nelReader.Item("amount")
            dbpayment = DReader.nelReader.Item("payment")
        End If
        ' txttamount.Text = FormatNumber(SumItUp(dtgitemlist, 5), 2)
        DReader.nelReader.Close()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        frmcollection.Close()
        frmcollection.Show()
    End Sub
End Class