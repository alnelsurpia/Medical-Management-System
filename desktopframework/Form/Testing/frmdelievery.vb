Imports WeifenLuo.WinFormsUI.Docking
Public Class frmdelievery
    Inherits DockContent
    Dim clientno As String = ""
    Private Sub frmdelievery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateCombo(cmbdelby, "Select prepby from tbldelievery group by prepby")
        'TODO: This line of code loads data into the 'Dtssupplier.tblitemlist' table. You can move, or remove it, as needed.
        lbluser.Text = "User: " & P_username
        lbldate.Text = "Date: " & P_ServerDate
        populate()
        populatedesc()
        populatemain()
        populateclient()
        loadtr()
    End Sub
    Private Sub loadtr()
        Dim strSELECT As String = "SELECT trno,prno FROM tbltrmain group by trno"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        txttr.Items.Clear()
        Do While DReader.nelReader.Read
            txttr.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub txttamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttamount.KeyDown
        If e.KeyData = Keys.Enter Then
            amount = Replace(txttamount.Text, ",", "")
            frmpayment.Close()
            frmpayment.ShowDialog()
        End If
    End Sub

  
    Private Sub txttamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttamount.TextChanged

    End Sub
    Private Sub populateclient()
        Dim strSELECT As String = "SELECT suppname,address,suppNO FROM tblclient "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbclientname.Items.Clear()
        Do While DReader.nelReader.Read
            cmbclientname.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub populate()
        Dim strSELECT As String = "SELECT itemcode,concat(itemdesc,'/', Size,'/',manufacturer,'/',classification),unit,uprice,category,classification FROM tblitemlist "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbitemcode.Items.Clear()
        Do While DReader.nelReader.Read
            cmbitemcode.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString, DReader.nelReader.Item(3).ToString, _
            DReader.nelReader.Item(4).ToString, DReader.nelReader.Item(5).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub populatedesc()
        Dim strSELECT As String = "SELECT cat(itemdesc, '/',size,'/' , manufacturer, ' (',classification,')','/',remarks,'/',expiration_D)," _
        & " itemcode,unit,uprice,category,classification,unit,unitppcs, " _
        & " pperpiece,costpiece,cost,qtyperunit,qtyperunit,qtyperunit,Size,itemdesc" _
        & " FROM tblitemlist "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbitmdesc.Items.Clear()
        Do While DReader.nelReader.Read
            cmbitmdesc.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString, DReader.nelReader.Item(3).ToString, _
            DReader.nelReader.Item(4).ToString, DReader.nelReader.Item(5).ToString, DReader.nelReader.Item(6).ToString, _
            DReader.nelReader.Item(7).ToString, DReader.nelReader.Item(8).ToString, DReader.nelReader.Item(9).ToString, _
            DReader.nelReader.Item(10).ToString, DReader.nelReader.Item(11).ToString, DReader.nelReader.Item(14).ToString, _
            DReader.nelReader.Item(15).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub cmbitemcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbitemcode.KeyDown
        If e.KeyData = Keys.F1 Then
            amount = Replace(txttamount.Text, ",", "")
            frmpayment.Close()
            frmpayment.ShowDialog()
        End If
    End Sub

    Private Sub cmbitemcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitemcode.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbitemcode.SelectedItem, SupplierInfo)
        cmbitemcode.Text = acc.Suppliername
        cmbitmdesc.Text = acc.SupplierNo
        lblunit.Text = acc.SupplierAddress
        txtprice.Text = acc.SalesMan
        lblcat.Text = acc.cat
        lblclass.Text = acc.classification
    End Sub

    Private Sub txtqty_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqty.Click
        txtqty.Text = ""
    End Sub

    Private Sub txtqty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqty.GotFocus
        'txtqty.Text = ""
        txtqty.Select()
    End Sub
    Dim purchseqty As Double = 0
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtqty.KeyDown
        Dim ans2 As Long
        If e.KeyData = Keys.Enter Then '1
            If txttr.Text = "" Then
                ans2 = MessageBox.Show("Are you REALY sure you want to continue without TR?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Else
                ans2 = vbYes
            End If
            If ans2 = vbYes Then
                If cmbunit.Text <> "" Then
                    If txtdelNO.Text <> "" Then '2
                        If cmbunit.Text = bundleunit Then '3

                            purchseqty = Val(txtqty.Text)
                        Else
                            purchseqty = Val(txtqty.Text) / Val(qtybndle)
                        End If '3

                        If cmbitemcode.Text <> "" Then '4
                            savedeleievery()
                            populateitems()
                            populatemain()
                            cmdnew.Enabled = True
                            cmbitmdesc.Focus()
                        End If '4
                        'cmbitemcode.Focus()
                    Else
                        MessageBox.Show("No Delivery Number")
                    End If '2
                    txtprice.Focus()
              
                End If
            Else
                MessageBox.Show("No Unit")
            End If '1
            If e.KeyData = Keys.F2 Then
                txtprice.Enabled = True
                txtprice.Focus()
            Else
                MessageBox.Show("Notsaved")
            End If
        End If
    End Sub
    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        newbtn()
        cmdnew.Enabled = False
    End Sub
    Private Sub newbtn()
        txtdelNO.Text = IDgenerator("del")
        IDgeneratorSave("del", txtdelNO.Text)
        'txtdelNO.Text = ""
        dtpdate.Text = Now.ToShortDateString
        cmbclientname.Text = ""
        cmbclientadd.Text = ""
        cmbdelby.Text = ""
        cmbitemcode.Text = ""
        cmbitmdesc.Text = ""
        lblunit.Text = "----"
        txtprice.Text = "0"
        txtqty.Text = "0"
        txtpk.Text = ""
        txttamount.Text = "0"
        cmbpicktype.Text = "Deliever"
        cmbpaytype.Text = "Cash"
        txtpayment.Text = "0"
        txtchange.Text = "0"
        cmbclientname.Focus()
        dtgitemlist.Rows.Clear()
    End Sub
    Private Sub cmbitmdesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbitmdesc.KeyDown
        If e.KeyData = Keys.F1 Then
            amount = Replace(txttamount.Text, ",", "")
            frmpayment.Close()
            frmpayment.ShowDialog()
        End If
    End Sub
    Private Sub txtpayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayment.KeyPress

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim cqty As Double = SumItUp(dtgitemlist, 4)
        If cqty <> 0 Then
            deducttoinventory()

            updatedeleievery()
            updatemain()

            MessageBox.Show("thank you!!!")
            newbtn()
        Else
            MessageBox.Show("No Item Purchased...")
        End If

    End Sub
    Private Sub deducttoinventory()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgitemlist.RowCount - 1
        Dim a As Integer
        With dtgitemlist
            For a = 0 To rCnt
                Dim itemcode As String = .Item(8, a).Value
                Dim tqty As Double = .Item(7, a).Value
                locatestocks(itemcode, tqty)
                updatetr(itemcode, tqty)
            Next a
        End With
        Cursor = Cursors.Default
    End Sub

    Private Sub updateitmlist(ByVal itemcode As String, ByVal stocks As Double, ByVal tqty As Double)
        'Dim DReader As New DataClassReader
        Dim totalaty As Double = stocks - tqty
        Dim dtData As New clsDataManipulation

        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblitemlist WHERE itemcode ='" & itemcode & "'"
        dtData.strUpdate = "UPDATE tblitemlist SET stocks = stocks + '" & totalaty & "'" _
            & " WHERE itemcode = '" & itemcode & "'"
        dtData.strAdd = "SELECT * FROM tblitemlist limit 1"
        dtData.Save()
        
    End Sub
    Private Sub updatetr(ByVal itemcode As String, ByVal tqty As Double)
        'Dim DReader As New DataClassReader
        Dim dtData As New clsDataManipulation

        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tbltrmain WHERE itemcode ='" & itemcode & "'"
        dtData.strUpdate = "UPDATE tbltrmain SET delevireditm = delevireditm + '" & tqty & "'" _
            & " WHERE itemcode = '" & itemcode & "'"
        dtData.strAdd = "SELECT * FROM tbltrmain limit 1"
        dtData.Save()
    End Sub
    Private Sub locatestocks(ByVal itemcode As String, ByVal qty As Double)
        Dim stocks As Double = 0
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblitemlist WHERE itemcode ='" & itemcode & "'"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        If DReader.nelReader.Read Then
            stocks = DReader.nelReader.Item("stocks")
        End If
        DReader.nelReader.Close()
        updateitmlist(itemcode, stocks, qty)
    End Sub
    Private Sub savedeleievery()
        Dim strDSno As String = txtpk.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.IDGenValue = strDSno
        'dtData.IDGenCode = "DR"
        Dim extra As Double = Val(Replace(txtprice.Text, ",", ""))
        Dim amnt As Double = Val(Replace(lbltotal.Text, ",", ""))
        dtData.strSELECT = "SELECT * FROM tbldelievery WHERE pk ='" & txtpk.Text & "'"
        dtData.strUpdate = "UPDATE tbldelievery SET " _
            & " delNo='" & txtdelNO.Text & "',tdate='" & dtpdate.Text & "', " _
            & " custname='" & cmbclientname.Text & "'," _
            & " custaddress='" & cmbclientadd.Text & "'," _
            & " prepby ='" & cmbdelby.Text & "', " _
            & " itemcode='" & cmbitemcode.Text & "'," _
            & " itemdesc='" & cmbitmdesc.Text & "', " _
            & " uprice ='" & extra & "'," _
            & " qty =  '-' & '" & txtqty.Text & "'," _
            & " amount ='" & amnt & "'," _
            & " clientno = '" & clientno & "'," _
            & " qty2 =  '-' & '" & purchseqty & "'," _
            & " unit = '" & cmbunit.Text & "'," _
            & " tsize = '" & deltsize & "'," _
            & " expdate = '" & maskeddate.Text & "' ," _
            & " lnbn = '" & txtlnbn.Text & "'," _
            & " tr = '" & txttr.Text & "' ," _
            & " pr = '" & txtpr.Text & "',brefdesc = '" & brefdesc & "'" _
            & " WHERE pk ='" & txtpk.Text & "'"
        dtData.strAdd = "INSERT INTO tbldelievery " _
            & " (delNo, tdate, custname, custaddress,prepby,itemcode, itemdesc, " _
            & " uprice, qty, amount,clientno,qty2,unit,tsize,expdate,lnbn,tr,pr,brefdesc) " _
            & " VALUES('" & txtdelNO.Text & "', " _
            & " '" & dtpdate.Text & "','" & cmbclientname.Text & "', " _
            & " '" & cmbclientadd.Text & "'," _
            & " '" & cmbdelby.Text & "'," _
            & "'" & cmbitemcode.Text & "'," _
            & " '" & cmbitmdesc.Text & "', " _
            & " '" & extra & "', " _
            & "  '-' & '" & txtqty.Text & "'," _
            & " '" & amnt & "','" & clientno & "'," _
            & "  '-' & '" & purchseqty & "'," _
            & " '" & cmbunit.Text & "'," _
            & " '" & deltsize & "'," _
            & " '" & maskeddate.Text & "'," _
            & " '" & txtlnbn.Text & "'," _
            & " '" & txttr.Text & "'," _
            & " '" & txtpr.Text & "','" & brefdesc & "')"
        dtData.Save()
    End Sub

    Private Sub updatedeleievery()
        Dim strDSno As String = txtpk.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.IDGenValue = strDSno
        dtData.IDGenCode = "DR"
        Dim extra As Double = Val(Replace(txtprice.Text, ",", ""))
        Dim amnt As Double = Val(Replace(lbltotal.Text, ",", ""))
        dtData.strSELECT = "SELECT * FROM tbldelievery WHERE delNo ='" & txtdelNO.Text & "'"
        dtData.strUpdate = "UPDATE tbldelievery SET " _
            & " picktype='" & cmbpicktype.Text & "',payment='" & txtpayment.Text & "', " _
            & " Ptype='" & cmbpaytype.Text & "'," _
            & " PStatus='Paid'," _
            & " tcost = '" & Replace(txttamount.Text, ",", "") & "'" _
            & " WHERE delNo ='" & txtdelNO.Text & "'"
        dtData.strAdd = "SELECT * FROM tbldelievery"
        dtData.Save()
    End Sub

    Private Sub populatemain()
        dtgdelieverymain.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbldelievery where delno like '%" & txtsearch.Text & "%' or custname like '%" & txtsearch.Text & "%'  group by delNo"
        tabledtgdr(strSELECT)
    End Sub
    Private Sub tabledtgdr(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgdelieverymain
                .Rows.Add()
                .Item(1, a).Value = DReader.nelReader.Item("delNo")
                .Item(2, a).Value = DReader.nelReader.Item("tdate")
                .Item(3, a).Value = DReader.nelReader.Item("custname")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub populateitems()
        dtgitemlist.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbldelievery where delNo = '" & txtdelNO.Text & "'"
        tabledtgdritem(strSELECT)
    End Sub
    Private Sub tabledtgdritem(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitemlist
                .Rows.Add()
                .Item(1, a).Value = DReader.nelReader.Item("pk")
                .Item(2, a).Value = DReader.nelReader.Item("itemdesc")
                .Item(3, a).Value = DReader.nelReader.Item("itemdesc")
                .Item(4, a).Value = DReader.nelReader.Item("qty")
                .Item(5, a).Value = FormatNumber(DReader.nelReader.Item("uprice"), 2)
                .Item(6, a).Value = FormatNumber(Val(DReader.nelReader.Item("qty")) * Val(DReader.nelReader.Item("uprice")), 2)
                .Item(7, a).Value = DReader.nelReader.Item("qty2")
                .Item(8, a).Value = DReader.nelReader.Item("itemcode")
            End With
            a = a + 1
        Loop
        txttamount.Text = FormatNumber(SumItUp(dtgitemlist, 5), 2)
        DReader.nelReader.Close()
    End Sub
    Private Sub cmbnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnew.Click
        itmnew()
    End Sub
    Private Sub itmnew()

        cmbitemcode.Text = ""
        cmbitmdesc.Text = ""
        lblunit.Text = "----"
        txtprice.Text = "0"
        txtqty.Text = "0"
        txtpk.Text = ""
        txttamount.Text = "0"
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        lbltotal.Text = FormatNumber(Val(Replace(txtprice.Text, ",", "")) * Val(txtqty.Text), 2)
    End Sub

    Private Sub txtprice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprice.KeyDown
        If e.KeyData = Keys.Enter Then
            txtqty.Focus()
        End If
    End Sub

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged
        lbltotal.Text = FormatNumber(Val(Replace(txtprice.Text, ",", "")) * Val(txtqty.Text), 2)
    End Sub
    Dim unitbx As String
    Dim unitpcs As String

    Dim pcsprice As Double

    Dim pcscost As Double
    Dim bcost As Double
    Dim bndlprice As Double
    Dim qtybndle As Double
    Dim bundleunit As String
    Dim deltsize As String
    Dim brefdesc As String
    Private Sub cmbitmdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitmdesc.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbitmdesc.SelectedItem, SupplierInfo)
        cmbitemcode.Text = acc.SupplierNo
        cmbitmdesc.Text = acc.Suppliername
        lblunit.Text = acc.SupplierAddress
        txtprice.Text = acc.SalesMan
        lblcat.Text = acc.fourth
        lblclass.Text = acc.cat
        unitbx = acc.unitbx
        unitpcs = acc.unitpcs
        pcsprice = acc.pcsprice
        pcscost = acc.pcscost
        bcost = acc.bcost
        qtybndle = acc.bcost ' QTYPERUNIT
        bndlprice = acc.SalesMan
        deltsize = acc.tsize
        brefdesc = acc.brefdesc
        cmbunit.Items.Clear()
        bundleunit = acc.SupplierAddress 'bundle unit
        cmbunit.Items.Add(unitbx)
        cmbunit.Items.Add(acc.SupplierAddress)
    End Sub

    Private Sub cmbunit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbunit.SelectedIndexChanged
        If cmbunit.Text = unitbx Then
            txtprice.Text = unitpcs
        Else
            txtprice.Text = bndlprice
        End If
    End Sub

    Private Sub dtgdelieverymain_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgdelieverymain.CellClick
        With dtgdelieverymain.SelectedRows(0)
            Dim drno As String = .Cells(1).Value
            populatetext(drno)
            populateitems()
        End With
    End Sub
    Private Sub populatetext(ByVal drno As String)
        'dtgitemlist.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbldelievery where delNo = '" & drno & "' group by delNo"
        poptext(strSELECT)
    End Sub
    Private Sub poptext(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            'DReader.nelReader.Item("pk")
            txtdelNO.Text = DReader.nelReader.Item("delNo")
            dtpdate.Text = DReader.nelReader.Item("tdate")
            cmbclientname.Text = DReader.nelReader.Item("custname")
            cmbclientadd.Text = DReader.nelReader.Item("custaddress")
            cmbdelby.Text = DReader.nelReader.Item("prepby")
            txtpayment.Text = DReader.nelReader.Item("payment")
            txttr.Text = DReader.nelReader.Item("tr")
            txtpr.Text = DReader.nelReader.Item("pr")
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub dtgitemlist_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitemlist.CellClick
        With dtgitemlist.SelectedRows(0)
            Dim pk As String = .Cells(1).Value
            populatetextitm(pk)
        End With
    End Sub

    Private Sub populatetextitm(ByVal pk As String)
        'dtgitemlist.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbldelievery where pk = '" & pk & "' "
        poptextitm(strSELECT)
    End Sub
    Private Sub poptextitm(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            'DReader.nelReader.Item("pk")
            txtpk.Text = DReader.nelReader.Item("pk")
            cmbitemcode.Text = DReader.nelReader.Item("itemcode")
            cmbitmdesc.Text = DReader.nelReader.Item("itemdesc")
            txtprice.Text = DReader.nelReader.Item("uprice")
            txtqty.Text = DReader.nelReader.Item("qty")
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub dtgdelieverymain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgdelieverymain.CellContentClick
        With dtgdelieverymain.SelectedRows(0)
            Dim drno As String = .Cells(1).Value
            populatetext(drno)
            populateitems()
        End With
    End Sub

    Private Sub dtgdelieverymain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgdelieverymain.Click
        With dtgdelieverymain.SelectedRows(0)
            Dim drno As String = .Cells(1).Value
            populatetext(drno)
            populateitems()
        End With
    End Sub

    Private Sub dtgdelieverymain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgdelieverymain.KeyDown
        With dtgdelieverymain.SelectedRows(0)
            Dim drno As String = .Cells(1).Value
            populatetext(drno)
            populateitems()
        End With
        check_checkedmain()
    End Sub
    Private Sub check_checkedmain()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgdelieverymain.RowCount - 1
        Dim a As Integer

        Dim drno As String = ""
        With dtgdelieverymain

            For a = 0 To rCnt
                'On Error Resume Next
                Dim b As String = .Item(0, a).Value
                If b = "True" Then
                    drno = .Item(1, a).Value
                    deletedrno(drno)
                End If
            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub deletedrno(ByVal itmdr As String)
        Dim ans As Long = MessageBox.Show("Are you sure want to Delete?" & itmdr, "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ans = vbYes Then
            del(itmdr)
            populatemain()
            'populategrid()
        End If
    End Sub
    Private Sub del(ByVal itmdr As String)
        Dim strProfileNo As String = itmdr
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tbldelievery WHERE delNo ='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tbldelievery WHERE delNo ='" & strProfileNo & "'"
        dtData.DELETE()
    End Sub
    Private Sub dtgitemlist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgitemlist.KeyDown
        With dtgitemlist.SelectedRows(0)
            Dim pk As String = .Cells(1).Value
            populatetextitm(pk)
        End With
        check_checkeditm()
    End Sub
    Private Sub check_checkeditm()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgitemlist.RowCount - 1
        Dim a As Integer
        Dim pk As String = ""
        With dtgitemlist

            Dim c As String = .Item(2, a).Value
            For a = 0 To rCnt
                Dim b As String = .Item(0, a).Value
                'On Error Resume Next
                If b = "True" Then
                    pk = .Item(1, a).Value
                    deletepk(pk, c)
                End If
            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub deletepk(ByVal itmdr As String, ByVal desc As String)
        Dim ans As Long = MessageBox.Show("Are you sure want to Delete? " & desc, "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ans = vbYes Then
            delitm(itmdr)
            populateitems()
            'populategrid()
        End If
    End Sub
    Private Sub delitm(ByVal itmdr As String)
        Dim strProfileNo As String = itmdr
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tbldelievery WHERE pk ='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tbldelievery WHERE pk ='" & strProfileNo & "'"
        dtData.DELETE()
    End Sub
    Private Sub dtgitemlist_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgitemlist.Click
        On Error Resume Next
        With dtgitemlist.SelectedRows(0)
            Dim pk As String = .Cells(1).Value
            populatetextitm(pk)
        End With
    End Sub

    Private Sub dtgitemlist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitemlist.CellContentClick
        With dtgitemlist.SelectedRows(0)
            Dim pk As String = .Cells(1).Value
            populatetextitm(pk)
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        check_checkeditm()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        check_checkedmain()
    End Sub

    Private Sub txtpayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpayment.TextChanged
        txtchange.Text = FormatNumber(Val(Replace(txtpayment.Text, ",", "")) - Val(Replace(txttamount.Text, ",", "")))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        populatemain()
    End Sub

    Private Sub cmbclientname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclientname.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbclientname.SelectedItem, SupplierInfo)
        cmbclientadd.Text = acc.SupplierNo
        clientno = acc.SupplierAddress
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmsalesrpt.Close()
        frmsalesrpt.Show()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        'delieveryno = txtdelNO.Text
        frmpurchaserpt.Close()
        'frmpurchaserpt.Show()
        With frmdeleveryrpt
            .delnumb = txtdelNO.Text
            .Show()
        End With
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmrecieveblebyclient.Close()
        frmrecieveblebyclient.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmcollectionrec.Close()
        frmcollectionrec.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmcollection.Close()
        frmcollection.Show()
    End Sub

    Private Sub GradientPanelXP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientPanelXP1.Click

    End Sub

    Private Sub cmbsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsave.Click
        If txtdelNO.Text <> "" Then
            savemain()
            MessageBox.Show("Saved")
            cmdnew.Enabled = True
        End If
    End Sub
    Private Sub savemain()
        Dim strDSno As String = txtpk.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.IDGenValue = strDSno
        'dtData.IDGenCode = "DR"
        Dim extra As Double = Val(Replace(txtprice.Text, ",", ""))
        Dim amnt As Double = Val(Replace(lbltotal.Text, ",", ""))
        dtData.strSELECT = "SELECT * FROM tbldelieverymain WHERE delno ='" & txtdelNO.Text & "'"
        dtData.strUpdate = "UPDATE tbldelieverymain SET " _
            & " delNo='" & txtdelNO.Text & "',Ddate='" & dtpdate.Text & "', " _
            & " clientname='" & cmbclientname.Text & "'," _
            & " custaddress='" & cmbclientadd.Text & "'," _
            & " deliveredby ='" & cmbdelby.Text & "', " _
            & " tcost ='" & Val(Replace(txttamount.Text, ",", "")) & "'," _
            & " tpayment ='" & Val(Replace(txtpayment.Text, ",", "")) & "'," _
            & " clientno = '" & clientno & "'," _
            & " paytype = '" & cmbpaytype.Text & "' " _
            & " WHERE delno ='" & txtdelNO.Text & "'"
        dtData.strAdd = "INSERT INTO tbldelieverymain " _
            & " (delNo, Ddate, clientname, custaddress,deliveredby,tcost, tpayment,clientno,paytype) " _
            & " VALUES('" & txtdelNO.Text & "', " _
            & " '" & dtpdate.Text & "','" & cmbclientname.Text & "', " _
            & " '" & cmbclientadd.Text & "'," _
            & " '" & cmbdelby.Text & "'," _
            & " '" & Val(Replace(txttamount.Text, ",", "")) & "'," _
            & " '" & Val(Replace(txtpayment.Text, ",", "")) & "', " _
            & " '" & clientno & "', " _
            & " '" & cmbpaytype.Text & "')"
        dtData.Save()
    End Sub
    Private Sub cmbpicktype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpicktype.SelectedIndexChanged

    End Sub

    Private Sub cmbpicktype_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpicktype.SelectedValueChanged

    End Sub

    Private Sub cmbpaytype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpaytype.SelectedIndexChanged

    End Sub

    Private Sub cmbpaytype_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpaytype.SelectedValueChanged
        If cmbpicktype.Text = "Charge" Then
            txtpayment.Text = "0"
        End If
    End Sub
    Private Sub updatemain()
        Dim strDSno As String = txtpk.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.IDGenValue = strDSno
        'dtData.IDGenCode = "DR"
        Dim extra As Double = Val(Replace(txtprice.Text, ",", ""))
        Dim amnt As Double = Val(Replace(lbltotal.Text, ",", ""))
        dtData.strSELECT = "SELECT * FROM tbldelieverymain WHERE delno ='" & txtdelNO.Text & "'"
        dtData.strUpdate = "UPDATE tbldelieverymain SET " _
            & " Ddate='" & dtpdate.Text & "', " _
            & " clientname='" & cmbclientname.Text & "'," _
            & " custaddress='" & cmbclientadd.Text & "'," _
            & " deliveredby ='" & cmbdelby.Text & "', " _
            & " tcost ='" & Val(Replace(txttamount.Text, ",", "")) & "'," _
            & " tpayment ='" & Val(Replace(txtpayment.Text, ",", "")) & "'," _
            & " clientno = '" & clientno & "'," _
            & " paytype = '" & cmbpaytype.Text & "' " _
            & " WHERE delno ='" & txtdelNO.Text & "'"
        dtData.strAdd = "SELECT * FROM tbldelieverymain"
        dtData.Save()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmrecievables.Close()
        frmrecievables.Show()
    End Sub

    Private Sub txttr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttr.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(txttr.SelectedItem, SupplierInfo)
        txtpr.Text = acc.SupplierNo
        'cmbitmdesc.Text = acc.SupplierNo
    End Sub
End Class