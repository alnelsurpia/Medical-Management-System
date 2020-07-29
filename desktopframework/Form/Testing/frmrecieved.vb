Imports WeifenLuo.WinFormsUI.Docking
Public Class frmrecieved
    Inherits DockContent
    Private Sub frmrecieved_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaditms()
        loadsupplier()
        PopulateCombo(txtPOno, "Select pono from tblpo where received = 'Pending' group by pono ")
    End Sub
    Private Sub loaditms()
        Dim strSELECT As String = "SELECT concat(itemdesc, '/',size,'/' , manufacturer, ' (',classification,')','/',remarks,'/',expiration_D)," _
        & " itemcode,cost,remarks,expiration_D,unitppcs,unit,remarks,itemdesc,size FROM tblitemlist "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbdesc.Items.Clear()
        Do While DReader.nelReader.Read
            cmbdesc.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString, _
            DReader.nelReader.Item(3).ToString, DReader.nelReader.Item(4).ToString, _
            DReader.nelReader.Item(5).ToString, DReader.nelReader.Item(6).ToString, _
            DReader.nelReader.Item(7).ToString, DReader.nelReader.Item(8).ToString, _
            DReader.nelReader.Item(9).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub loadsupplier()
        Dim strSELECT As String = "SELECT suppname,address,suppcontactP,suppNO FROM tblsupplier "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        txtSuppliername.Items.Clear()
        Do While DReader.nelReader.Read
            txtSuppliername.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString, DReader.nelReader.Item(3).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub

  
    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        txtrecno.Text = IDgenerator("recno")
        clear()
        dtgitems.Rows.Clear()
    End Sub
    Private Sub clear()
        txtPODate.Text = Now.ToShortDateString
        'txtrecno.Text = ""
        txtSuppliername.Text = ""
        txtaddress.Text = ""
        txtContact.Text = ""
        txtLogistic.Text = ""
        txtRemarks.Text = ""
        txtSalesPerson.Text = ""
        txtsupcont.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        uptadebtn()
        PopulateItempo()
    End Sub
    Private Sub uptadebtn()
        IDgeneratorSave("recno", txtrecno.Text)
        updatepo()
        filterpk()
        deducttoinventory()
        'MessageBox.Show("Saved")
        Populatemain()
        Button3.Enabled = False
    End Sub
    Private Sub filterpk()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgitems.RowCount - 1
        Dim a As Integer
        Dim pk As String = ""
        Dim chk As Boolean = False
        With dtgitems
            For a = 0 To rCnt
               
                Dim rpk As String = .Item(0, a).Value
                Dim runit As String = .Item(3, a).Value
                Dim rcost As String = .Item(5, a).Value
                Dim recqty As String = .Item(7, a).Value
                Dim expdate As String = .Item(4, a).Value
                Dim lnbn As String = .Item(11, a).Value
                savetitem(rpk, runit, rcost, recqty, expdate, lnbn)
              
            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub savetitem(ByVal rpk As String, _
                          ByVal runit As String, _
                          ByVal rcost As String, _
                          ByVal recqty As String, ByVal expdate As String, ByVal lnbn As String)

        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblpo WHERE pk = '" & rpk & "' and received = 'Pending'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " unit = '" & runit & "'," _
            & " recqty = '" & recqty & "'," _
            & " cost = '" & rcost & "',expdate = '" & expdate & "',lotnumber = '" & lnbn & "',received = 'Approved' " _
            & " WHERE pk = '" & rpk & "' and received = 'Pending'"
        dtData.strAdd = "SELECT * FROM tblpo"
        dtData.Save()
    End Sub
    Private Sub updatepo()
        If txtPOno.Text = "" And txtrecno.Text <> "" Then
            poempty()
            updatethis2()
        ElseIf txtrecno.Text <> "" And txtPOno.Text <> "" Then
            ponotempty()
            updatethis()
        End If
    End Sub
    Private Sub poempty()
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblpo WHERE  recno = '" & txtrecno.Text & "'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " recno ='" & txtrecno.Text & "', " _
            & " tdate ='" & txtPODate.Text & "', " _
            & " suppname ='" & txtSuppliername.Text & "', " _
            & " salesperson ='" & txtSalesPerson.Text & "'," _
            & " address ='" & txtaddress.Text & "', " _
            & " contactno ='" & txtsupcont.Text & "'," _
            & " forwader ='" & txtLogistic.Text & "', " _
            & " fcontact = '" & txtContact.Text & "'," _
            & " remarks = '" & txtRemarks.Text & "'," _
            & " suppno = '" & txtsupno.Text & "'," _
            & " prepby = '" & cmbprepby.Text & "'," _
            & " received = 'Approved'," _
            & " appby = '" & cmbappby.Text & "'" _
            & " WHERE recno = '" & txtrecno.Text & "'"
        dtData.strAdd = "SELECT * FROM tblpo"
        dtData.Save()
    End Sub
    Private Sub ponotempty()
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblpo WHERE  pono= '" & txtPOno.Text & "'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " recno ='" & txtrecno.Text & "', " _
            & " tdate ='" & txtPODate.Text & "', " _
            & " suppname ='" & txtSuppliername.Text & "', " _
            & " salesperson ='" & txtSalesPerson.Text & "'," _
            & " address ='" & txtaddress.Text & "', " _
            & " contactno ='" & txtsupcont.Text & "'," _
            & " forwader ='" & txtLogistic.Text & "', " _
            & " fcontact = '" & txtContact.Text & "'," _
            & " remarks = '" & txtRemarks.Text & "'," _
            & " suppno = '" & txtsupno.Text & "'," _
            & " prepby = '" & cmbprepby.Text & "'," _
            & " received = 'Approved'," _
            & " appby = '" & cmbappby.Text & "'" _
            & " WHERE pono= '" & txtPOno.Text & "'"
        dtData.strAdd = "SELECT * FROM tblpo"
        dtData.Save()
    End Sub
    Private Sub Populatemain()
        Dim dfrom As String = ConvertWinToLinDate(dtpfrm.Text)
        Dim dto As String = ConvertWinToLinDate(dtpto.Text)
        dtgrecmain.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblpo where (STR_TO_DATE(rdate," _
           & " '%m/%d/%Y') >='" & dfrom & "' AND STR_TO_DATE(rdate, '%m/%d/%Y') <='" & dto & "') and recno <> ' ' GROUP by recno order by recno asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgrecmain
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("recno")
                .Item(1, a).Value = DReader.nelReader.Item("rdate")
                .Item(2, a).Value = DReader.nelReader.Item("suppname")
                .Item(3, a).Value = DReader.nelReader.Item("received")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        If txtrecno.Text.Trim <> "" Then
            Dim ans As Long = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ans = vbYes Then
                delmain()
                clear()
                clearitm()
                dtgitems.Rows.Clear()
                Populatemain()
            End If
        End If
    End Sub
    Private Sub delmain()
        Dim strProfileNo As String = txtrecno.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblpo WHERE recno ='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tblpo WHERE recno ='" & strProfileNo & "'"
        dtData.DELETE()
    End Sub

    Private Sub clearitm()
        cmbitemcode.Text = ""
        cmbdesc.Text = ""
        txtsize.Text = ""
        txtunit.Text = ""
        txtcost.Text = ""
    End Sub

    Private Sub dtgrecmain_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrecmain.CellClick
        With dtgrecmain.SelectedRows(0)
            If .Cells(0).Value <> "" Then
                'cashpositionpk = .Cells(2).Value
                'frmcashpositionlogs.Show()
                txtrecno.Text = .Cells(0).Value
                Populatetxt(txtrecno.Text)
                PopulateItem()
                Label9.Text = .Cells(3).Value
            End If
        End With
    End Sub
    Private Sub Populatetxt(ByVal pno As String)
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tblpo where recno = '" & pno & "'"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            txtSuppliername.Text = DReader.nelReader.Item("suppname")
            txtPODate.Text = DReader.nelReader.Item("rdate")
            txtSalesPerson.Text = DReader.nelReader.Item("salesperson")
            txtaddress.Text = DReader.nelReader.Item("address")

            txtsupcont.Text = DReader.nelReader.Item("contactno")
            txtLogistic.Text = DReader.nelReader.Item("forwader")
            txtContact.Text = DReader.nelReader.Item("fcontact")
            txtRemarks.Text = DReader.nelReader.Item("remarks")
            cmbprepby.Text = DReader.nelReader.Item("prepby")
            cmbappby.Text = DReader.nelReader.Item("appby")
            txtPOno.Text = DReader.nelReader.Item("pono")
            dtpnewpo.Text = DReader.nelReader.Item("tdate")
            'PopulateItem()
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub PopulateItem()
        dtgitems.Rows.Clear()
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tblpo where recno = '" & txtrecno.Text & "' order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitems
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = DReader.nelReader.Item("itmdesc")
                .Item(2, a).Value = DReader.nelReader.Item("size")
                .Item(3, a).Value = DReader.nelReader.Item("unit")
                .Item(4, a).Value = DReader.nelReader.Item("expdate")
                .Item(5, a).Value = DReader.nelReader.Item("cost")
                .Item(6, a).Value = DReader.nelReader.Item("qty")
                .Item(7, a).Value = DReader.nelReader.Item("recqty")
                .Item(8, a).Value = Val(Replace(DReader.nelReader.Item("cost"), ",", "")) * Val(Replace(DReader.nelReader.Item("qty"), ",", ""))
                .Item(9, a).Value = DReader.nelReader.Item("received")
                .Item(10, a).Value = DReader.nelReader.Item("itemcode")
                .Item(11, a).Value = DReader.nelReader.Item("lnbn")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub dtgrecmain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrecmain.CellContentClick

    End Sub

    Private Sub dtgitems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitems.CellClick
        'With dtgitems.SelectedRows(0)
        '    'If .Cells(0).Value <> "" Then
        '    'cashpositionpk = .Cells(2).Value
        '    'frmcashpositionlogs.Show()
        '    txtpk.Text = .Cells(0).Value
        '    cmbdesc.Text = .Cells(1).Value
        '    txtsize.Text = .Cells(2).Value
        '    txtunit.Text = .Cells(3).Value
        '    expdate.Text = .Cells(4).Value
        '    txtcost.Text = .Cells(5).Value
        '    txtqty.Text = .Cells(6).Value
        '    ' End If
        'End With
    End Sub

    Private Sub dtgitems_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitems.CellContentClick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub cmbok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbok.Click
        If txtrecno.Text <> "" Then
            savepo()
            'updateitemlist(cmbitemcode.Text, Val(txtqty.Text))
            'PopulateItem()
            'PopulateItempo()
            PopulateItemrec()
            Button3.Enabled = True
        End If
    End Sub
    Private Sub updateitemlist(ByVal itemcode As String, ByVal qty As Double)

        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True

        dtData.strSELECT = "SELECT * FROM tblitemlist WHERE itemcode = '" & itemcode & "'"
        dtData.strUpdate = "UPDATE tblitemlist SET " _
            & " stocks = stocks + '" & qty & "' " _
            & " WHERE itemcode = '" & itemcode & "'"
        dtData.strAdd = "SELECT * FROM tblitemlist"
        dtData.Save()
    End Sub
    Private Sub savepo()
        'Dim strCustomerNo As String = patientno
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        'dtData.IDGenValue = strCustomerNo
        'dtData.IDGenCode = "EPro"
        'recno
        dtData.strSELECT = "SELECT * FROM tblpo WHERE pk = '" & txtpk.Text & "'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " pono ='" & txtPOno.Text & "', " _
            & " rdate ='" & txtPODate.Text & "', " _
            & " suppname ='" & txtSuppliername.Text & "', " _
            & " salesperson ='" & txtSalesPerson.Text & "'," _
            & " address ='" & txtaddress.Text & "', " _
            & " contactno ='" & txtsupcont.Text & "'," _
            & " forwader ='" & txtLogistic.Text & "', " _
            & " fcontact = '" & txtContact.Text & "'," _
            & " remarks = '" & txtRemarks.Text & "'," _
            & " itemcode = '" & cmbitemcode.Text & "'," _
            & " itmdesc = '" & descriptionvar & "'," _
            & " cost = '" & txtcost.Text & "', " _
            & " recqty = '" & txtqty.Text & "', " _
            & " unit = '" & txtunit.Text & "'," _
            & " size = '" & txtsize.Text & "', " _
            & " expdate = '" & expdate.Text & "', " _
            & " suppno = '" & txtsupno.Text & "'," _
            & " prepby = '" & cmbprepby.Text & "'," _
             & " prepby = '" & cmbprepby.Text & "'," _
             & " lnbn = '" & lnbn & "'" _
            & " recno = '" & txtrecno.Text & "'" _
            & " WHERE pk = '" & txtpk.Text & "'"
        dtData.strAdd = "INSERT INTO tblpo " _
            & " (pono, rdate, suppname, salesperson, " _
            & " address, " _
            & " contactno, forwader, " _
            & " fcontact,remarks,itemcode,itmdesc,cost,recqty,unit,size,expdate,suppno,prepby,appby,recno,lnbn,itmtype) " _
            & " VALUES('" & txtPOno.Text & "'," _
            & " '" & txtPODate.Text & "', " _
            & " '" & txtSuppliername.Text & "', " _
            & " '" & txtSalesPerson.Text & "', " _
            & " '" & txtaddress.Text & "','" & txtsupcont.Text & "', " _
            & " '" & txtLogistic.Text & "'," _
            & " '" & txtContact.Text & "'," _
            & " '" & txtRemarks.Text & "'," _
            & " '" & cmbitemcode.Text & "'," _
            & " '" & descriptionvar & "'," _
            & " '" & txtcost.Text & "'," _
            & " '" & txtqty.Text & "','" & txtunit.Text & "'," _
            & " '" & txtsize.Text & "','" & expdate.Text & "'," _
            & " '" & txtsupno.Text & "','" & cmbprepby.Text & "'," _
            & " '" & cmbappby.Text & "','" & txtrecno.Text & "'," _
            & " '" & lnbn & "','Recieved')"
        dtData.Save()
    End Sub
   

    Private Sub txtSuppliername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuppliername.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(txtSuppliername.SelectedItem, SupplierInfo)
        txtSalesPerson.Text = acc.SupplierAddress
        txtaddress.Text = acc.SupplierNo
        txtsupno.Text = acc.SalesMan
    End Sub
    'Dim Suppliername As String
    'Dim SupplierNo As String
    'Dim SupplierAddress As String
    'Dim SalesMan As String
    'Dim fourth As String

    'concat(itemdesc, ' -',size,'- ' , manufacturer, ' (',classification,')','-',unit),itemcode,unit,cost,itemdesc
    Dim descriptionvar As String
    Dim lnbn As String = ""
    Private Sub cmbdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesc.SelectedIndexChanged

        Dim acc As SupplierInfo = CType(cmbdesc.SelectedItem, SupplierInfo)

        descriptionvar = acc.unitpcs
        cmbitemcode.Text = acc.SupplierNo
        'txtunit.Text = acc.SupplierAddress
        txtsize.Text = acc.pcsprice
        txtcost.Text = acc.SupplierAddress
        expdate.Text = acc.fourth
        lnbn = acc.SalesMan
        txtunit.Items.Clear()
        txtunit.Items.Add(acc.cat)
        txtunit.Items.Add(acc.classification)
    End Sub

    Private Sub cmdfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfilter.Click
        Populatemain()
    End Sub

    Private Sub dtgitems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgitems.KeyDown
        If e.KeyData = Keys.Delete Then
            If txtpk.Text.Trim <> "" Then
                Dim ans As Long = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If ans = vbYes Then
                    del()

                    PopulateItem()
                    clearitm()
                End If
            End If
        End If
    End Sub
    Private Sub del()
        Dim strProfileNo As String = txtpk.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblpo WHERE pk='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tblpo WHERE pk='" & strProfileNo & "'"
        dtData.DELETE()
    End Sub

    Private Sub cmbloadpo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbloadpo.Click
        Populatetxtpo(txtPOno.Text)
        PopulateItempo()
    End Sub
    Private Sub Populatetxtpo(ByVal pno As String)
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tblpo where pono = '" & pno & "'"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            txtSuppliername.Text = DReader.nelReader.Item("suppname")
            dtpnewpo.Text = DReader.nelReader.Item("tdate")
            txtSalesPerson.Text = DReader.nelReader.Item("salesperson")
            txtaddress.Text = DReader.nelReader.Item("address")

            txtsupcont.Text = DReader.nelReader.Item("contactno")
            txtLogistic.Text = DReader.nelReader.Item("forwader")
            txtContact.Text = DReader.nelReader.Item("fcontact")
            txtRemarks.Text = DReader.nelReader.Item("remarks")
            cmbprepby.Text = DReader.nelReader.Item("prepby")
            cmbappby.Text = DReader.nelReader.Item("appby")
            'PopulateItem()
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub PopulateItempo()
        dtgitems.Rows.Clear()
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tblpo where pono = '" & txtPOno.Text & "' order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitems
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = DReader.nelReader.Item("itmdesc")
                .Item(2, a).Value = DReader.nelReader.Item("size")
                .Item(3, a).Value = DReader.nelReader.Item("unit")
                .Item(4, a).Value = DReader.nelReader.Item("expdate")
                .Item(5, a).Value = DReader.nelReader.Item("cost")
                .Item(6, a).Value = DReader.nelReader.Item("qty")
                .Item(7, a).Value = DReader.nelReader.Item("recqty")
                .Item(8, a).Value = FormatNumber(Val(Replace(DReader.nelReader.Item("cost"), ",", "")) * Val(Replace(DReader.nelReader.Item("qty"), ",", "")), 2)
                .Item(9, a).Value = DReader.nelReader.Item("received")
                .Item(10, a).Value = DReader.nelReader.Item("itemcode")
                .Item(11, a).Value = DReader.nelReader.Item("lotnumber")

            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub PopulateItemrec()
        dtgitems.Rows.Clear()
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tblpo where recno = '" & txtrecno.Text & "' order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitems
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = DReader.nelReader.Item("itmdesc")
                .Item(2, a).Value = DReader.nelReader.Item("size")
                .Item(3, a).Value = DReader.nelReader.Item("unit")
                .Item(4, a).Value = DReader.nelReader.Item("expdate")
                .Item(5, a).Value = DReader.nelReader.Item("cost")
                .Item(6, a).Value = DReader.nelReader.Item("qty")
                .Item(7, a).Value = DReader.nelReader.Item("recqty")
                .Item(8, a).Value = FormatNumber(Val(Replace(DReader.nelReader.Item("cost"), ",", "")) * Val(Replace(DReader.nelReader.Item("qty"), ",", "")), 2)
                .Item(9, a).Value = DReader.nelReader.Item("received")
                .Item(10, a).Value = DReader.nelReader.Item("itemcode")
                .Item(11, a).Value = DReader.nelReader.Item("lotnumber")

            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub cmdrecivethispo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrecivethispo.Click
        If txtPOno.Text <> "" Or txtrecno.Text <> "" Then
            If txtrecno.Text <> "" Then
                uptadebtn()

                'filtettorec()
                MessageBox.Show("Saved")
                PopulateItemrec()
            Else
                MessageBox.Show("No Recieved Number")
            End If
        Else
            MessageBox.Show("No PO Number")
        End If
    End Sub
    Dim counter As Integer = 0
    Private Sub councounter()
        counter = dtgitems.RowCount - 1
    End Sub
    Private Sub deducttoinventory()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgitems.RowCount - 1
        Dim a As Integer
        With dtgitems
            For a = 0 To rCnt
                Dim chkitm As String = .Item(9, a).Value
                If chkitm = "Pending" Then
                    Dim itemcode As String = .Item(10, a).Value
                    Dim tqty As Double = .Item(7, a).Value
                    Dim tblunit As String = .Item(3, a).Value
                    'Dim units As Double = .Item(3, a).Value

                    locatestocks(itemcode, tqty, tblunit)
                    'updatetr(itemcode, tqty)
                End If
            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    'Dim loaddrclick As Boolean = False
    Private Sub locatestocks(ByVal itemcode As String, ByVal qty As Double, ByVal tblunit As String)
        'If loaddrclick = False Then
        Dim stocks As Double = 0
        Dim strSELECT As String = ""
        Dim dbbundleunit As String = ""
        Dim dbpcsunit As String = ""
        Dim budleqty As Double = 0

        strSELECT = "SELECT * FROM tblitemlist WHERE itemcode ='" & itemcode & "'"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        If DReader.nelReader.Read Then
            stocks = DReader.nelReader.Item("stocks")
            Dim shortdesc As String = DReader.nelReader.Item("itemdesc")
            dbbundleunit = DReader.nelReader.Item("unit")
            dbpcsunit = DReader.nelReader.Item("unitppcs")
            budleqty = DReader.nelReader.Item("qtyperunit")

            If tblunit = dbbundleunit Then
                If stocks >= qty Then
                    stocks = stocks + qty
                    'Else
                    '    MessageBox.Show("Cant DR this " & shortdesc & " Insufecient Stocks")
                End If
            Else
                stocks = stocks * budleqty
                'If stocks >= qty Then
                stocks = stocks + qty
                stocks = stocks / budleqty
                'Else
                'MessageBox.Show("Cant DR this " & shortdesc & " Insufecient Stocks")
                'End If
            End If
        End If
        DReader.nelReader.Close()
        updateitmlist(itemcode, stocks, tblunit)
        ' End If
    End Sub
    Private Sub updateitmlist(ByVal itemcode As String, ByVal stocks As Double, ByVal tblunit As String)
        Dim dtData As New clsDataManipulation

        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblitemlist WHERE itemcode ='" & itemcode & "'"
        dtData.strUpdate = "UPDATE tblitemlist SET stocks = '" & stocks & "'" _
            & " WHERE itemcode = '" & itemcode & "'"
        dtData.strAdd = "SELECT * FROM tblitemlist limit 1"
        dtData.Save()
    End Sub
    Private Sub updatethis()
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblpo WHERE pono = '" & txtPOno.Text & "'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " recno ='" & txtrecno.Text & "', " _
            & " recprep = '" & cmbprepby.Text & "', " _
            & " rdate = '" & txtPODate.Text & "', " _
            & " recchek ='" & cmbappby.Text & "' " _
            & " WHERE pono = '" & txtPOno.Text & "'"
        dtData.strAdd = "SELECT * FROM tblpo"
        dtData.Save()
        Label9.Text = "Approved"
    End Sub
    Private Sub updatethis2()
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblpo WHERE recno = '" & txtrecno.Text & "'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " recno ='" & txtrecno.Text & "', " _
            & " recprep = '" & cmbprepby.Text & "', " _
            & " rdate = '" & txtPODate.Text & "', " _
            & " recchek ='" & cmbappby.Text & "' " _
            & " WHERE recno = '" & txtrecno.Text & "'"
        dtData.strAdd = "SELECT * FROM tblpo"
        dtData.Save()
        Label9.Text = "Approved"
    End Sub
    Private Sub txtPOno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOno.SelectedIndexChanged

    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        receivedno = txtrecno.Text
        frmrecivedrpt.Close()
        frmrecivedrpt.Show(frmmain.DockPanel1)
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtPOno.Text <> "" And txtrecno.Text <> "" Then
            'deducttoinventory()
            PopulateItem()
            Populatemain()
            Label9.Text = "Approved"
        Else
            MessageBox.Show("Lacking Input")
        End If

    End Sub
    Private Sub updaterecstatus(ByVal reno As String, ByVal itmcode As String)
        'Dim strCustomerNo As String = patientno
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        'dtData.IDGenValue = strCustomerNo
        'dtData.IDGenCode = "EPro"

        dtData.strSELECT = "SELECT * FROM tblpo WHERE recno = '" & txtrecno.Text & "' and itemcode = '" & itmcode & "'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " received = 'Approved'" _
            & " WHERE recno = '" & txtrecno.Text & "' and itemcode = '" & itmcode & "'"
        dtData.strAdd = "SELECT * FROM tblpo"
        dtData.Save()
    End Sub

    Private Sub cmdscan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscan.Click
        frmuploaded.Show()
    End Sub
End Class