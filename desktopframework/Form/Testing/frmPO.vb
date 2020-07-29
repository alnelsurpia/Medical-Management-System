Imports WeifenLuo.WinFormsUI.Docking
Public Class frmPO
    Inherits DockContent
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtPOno.Text = IDgenerator("pono")
        newclick = True
        clear()
        dtgitems.Rows.Clear()
    End Sub
    Dim newclick As Boolean = False

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If newclick = True Then
            IDgeneratorSave("pono", txtPOno.Text)
            newclick = False
        End If

        updatepo()
        MessageBox.Show("Saved")
        Panel3.Enabled = True
        Populatemain()
    End Sub
    Private Sub clear()
        txtPODate.Text = Now.ToShortDateString
        txtSuppliername.Text = ""
        txtaddress.Text = ""
        txtContact.Text = ""
        txtLogistic.Text = ""
        txtRemarks.Text = ""
        txtSalesPerson.Text = ""
        txtsupcont.Text = ""
    End Sub
    Private Sub clearitm()
        cmbitemcode.Text = ""
        cmbdesc.Text = ""
        txtsize.Text = ""
        txtunit.Text = ""
        txtcost.Text = ""
        txtpk.Text = ""
        txtdesc2.Text = ""
        'clearmeitem
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Dim poexpdate As String = ""

    Private Sub savepo()
        'Dim strCustomerNo As String = patientno
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        'dtData.IDGenValue = strCustomerNo
        'dtData.IDGenCode = "EPro"

        dtData.strSELECT = "SELECT * FROM tblpo WHERE pk = '" & txtpk.Text & "'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " pono ='" & txtPOno.Text & "', " _
            & " tdate ='" & txtPODate.Text & "', " _
            & " suppname ='" & txtSuppliername.Text & "', " _
            & " salesperson ='" & txtSalesPerson.Text & "'," _
            & " address ='" & txtaddress.Text & "', " _
            & " contactno ='" & txtsupcont.Text & "'," _
            & " forwader ='" & txtLogistic.Text & "', " _
            & " fcontact = '" & txtContact.Text & "'," _
            & " remarks = '" & txtRemarks.Text & "'," _
            & " itemcode = '" & cmbitemcode.Text & "'," _
            & " itmdesc = '" & txtdesc2.Text & "'," _
            & " cost = '" & txtcost.Text & "', " _
            & " qty = '" & txtqty.Text & "', " _
            & " unit = '" & txtunit.Text & "'," _
            & " size = '" & txtsize.Text & "', " _
            & " expdate = '" & txtxpdate.Text & "', " _
            & " suppno = '" & txtsupno.Text & "'," _
            & " prepby = '" & cmbprepby.Text & "'," _
            & " appby = '" & cmbappby.Text & "'," _
            & " lotnumber = '" & txtlnbn.Text & "'" _
            & " WHERE pk = '" & txtpk.Text & "'"
        dtData.strAdd = "INSERT INTO tblpo " _
            & " (pono, tdate, suppname, salesperson, " _
            & " address, " _
            & " contactno, forwader, " _
            & " fcontact,remarks,itemcode,itmdesc,cost,qty,unit,size,expdate,suppno,prepby,appby,lotnumber,itmtype) " _
            & " VALUES('" & txtPOno.Text & "'," _
            & " '" & txtPODate.Text & "', " _
            & " '" & txtSuppliername.Text & "', " _
            & " '" & txtSalesPerson.Text & "', " _
            & " '" & txtaddress.Text & "','" & txtsupcont.Text & "', " _
            & " '" & txtLogistic.Text & "'," _
            & " '" & txtContact.Text & "'," _
            & " '" & txtRemarks.Text & "'," _
            & " '" & cmbitemcode.Text & "'," _
            & " '" & txtdesc2.Text & "'," _
            & " '" & txtcost.Text & "'," _
            & " '" & txtqty.Text & "','" & txtunit.Text & "'," _
            & " '" & txtsize.Text & "','" & txtxpdate.Text & "','" & txtsupno.Text & "','" & cmbprepby.Text & "','" & cmbappby.Text & "'," _
            & " '" & txtlnbn.Text & "','PO')"
        dtData.Save()
    End Sub
    Private Sub cmbok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbok.Click
        If txtPOno.Text <> "" Then
            savepo()
            PopulateItem()
            clearmeitem()
        End If
    End Sub
    Private Sub clearmeitem()
        cmbitemcode.Text = ""
        txtdesc2.Text = ""
        txtunit.Text = ""
        txtcost.Text = "0"
        txtxpdate.Text = ""
        txtlnbn.Text = ""
        txtqty.Text = "0"
        txtpk.Text = ""
    End Sub
    Private Sub PopulateItem()
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
                Try
                    .Rows.Add()
                    .Item(0, a).Value = DReader.nelReader.Item("pk")
                    .Item(1, a).Value = DReader.nelReader.Item("itmdesc")
                    .Item(2, a).Value = DReader.nelReader.Item("size")
                    .Item(3, a).Value = DReader.nelReader.Item("unit")
                    .Item(4, a).Value = DReader.nelReader.Item("expdate")
                    .Item(5, a).Value = DReader.nelReader.Item("lotnumber")
                    .Item(6, a).Value = FormatNumber(DReader.nelReader.Item("cost"), 2)
                    .Item(7, a).Value = DReader.nelReader.Item("qty")
                    .Item(8, a).Value = FormatNumber(Val(Replace(DReader.nelReader.Item("cost"), ",", "")) * Val(Replace(DReader.nelReader.Item("qty"), ",", "")), 2)
                    .Item(9, a).Value = Val(Replace(DReader.nelReader.Item("cost"), ",", "")) * Val(Replace(DReader.nelReader.Item("qty"), ",", ""))

                Catch
                    MessageBox.Show("This Entry has no item please add item")
                End Try
            End With
            a = a + 1
        Loop
        dtgitems.Rows.Add()
        dtgitems.Item(8, a).Value = FormatNumber(SumItUp(dtgitems, 9), 2)
        dtgitems.Item(8, a).Style.BackColor = Color.GreenYellow
        dtgitems.Item(7, a).Style.BackColor = Color.GreenYellow
        dtgitems.Item(6, a).Style.BackColor = Color.GreenYellow
        dtgitems.Item(5, a).Style.BackColor = Color.GreenYellow
        dtgitems.Item(4, a).Style.BackColor = Color.GreenYellow
        dtgitems.Item(3, a).Style.BackColor = Color.GreenYellow
        dtgitems.Item(2, a).Style.BackColor = Color.GreenYellow
        dtgitems.Item(1, a).Style.BackColor = Color.GreenYellow
        dtgitems.Item(1, a).Value = "TOTAL AMOUNT"
        DReader.nelReader.Close()
    End Sub
    Private Sub Populatemain()
        Dim dfrom As String = ConvertWinToLinDate(dtpfrm.Text)
        Dim dto As String = ConvertWinToLinDate(dtpto.Text)

        dtgpomain.Rows.Clear()
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tblpo where (STR_TO_DATE(tdate," _
           & " '%m/%d/%Y') >='" & dfrom & "' AND STR_TO_DATE(tdate, '%m/%d/%Y') <='" & dto & "') group by pono order by pono asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgpomain
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("pono")
                .Item(1, a).Value = DReader.nelReader.Item("tdate")
                .Item(2, a).Value = DReader.nelReader.Item("suppname")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub cmdfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfilter.Click
        Populatemain()
    End Sub

    Private Sub frmPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaditms()
        loadsupplier()
        txtPODate.Text = Now
        PopulateCombo(cmbprepby, "Select prepby from tblpo group by prepby")
        PopulateCombo(cmbappby, "Select appby from tblpo group by appby")

    End Sub
    Private Sub loaditms()
        Dim strSELECT As String = "SELECT concat(itemdesc, '/',size,'/' , manufacturer, ' (',classification,')','/',remarks,'/',expiration_D),itemcode,unit,size,cost,itemdesc,expiration_D,remarks,unitppcs FROM tblitemlist "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbdesc.Items.Clear()
        Do While DReader.nelReader.Read
            cmbdesc.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString, DReader.nelReader.Item(3).ToString, DReader.nelReader.Item(4).ToString, _
            DReader.nelReader.Item(5).ToString, DReader.nelReader.Item(6).ToString, DReader.nelReader.Item(7).ToString, DReader.nelReader.Item(8).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Dim descitm As String = ""
    Private Sub cmbdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesc.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbdesc.SelectedItem, SupplierInfo)
        cmbitemcode.Text = acc.SupplierNo
        'txtunit.Text = acc.SupplierAddress
        txtunit.Items.Clear()
        txtunit.Items.Add(acc.SupplierAddress)
        txtunit.Items.Add(acc.unitpcs)
        txtsize.Text = acc.SalesMan
        txtcost.Text = acc.fourth
        txtxpdate.Text = acc.classification
        descitm = acc.cat
        txtdesc2.Text = acc.cat & " " & acc.SalesMan
        txtlnbn.text = acc.unitbx
    End Sub

    Private Sub dtgitems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitems.CellClick
        With dtgitems.SelectedRows(0)
            Try
                txtpk.Text = .Cells(0).Value
                txtdesc2.Text = .Cells(1).Value
                txtsize.Text = .Cells(2).Value
                txtunit.Text = .Cells(3).Value
                txtlnbn.Text = .Cells(5).Value
                poexpdate = .Cells(4).Value
                txtcost.Text = .Cells(6).Value
                txtqty.Text = .Cells(7).Value
                txtxpdate.Text = .Cells(4).Value
                'descitm = .Cells(1).Value
            Catch
                MessageBox.Show("Invalid Action try again")
            End Try

        End With
    End Sub

    Private Sub dtgitems_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitems.CellContentClick
      
    End Sub
    Private Sub del()
        Dim strProfileNo As String = txtpk.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblpo WHERE pk='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tblpo WHERE pk='" & strProfileNo & "'"
        dtData.DELETE()
    End Sub

    Private Sub dtgitems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgitems.KeyDown
        If e.KeyData = Keys.Delete Then
            If txtpk.Text.Trim <> "" Then
                Dim ans As Long = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If ans = vbYes Then
                    del()
                    clearmeitem()
                    'clearitm()
                    PopulateItem()
                End If
            End If
        End If
    End Sub

    Private Sub dtgpomain_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgpomain.CellClick
        'On Error Resume Next

        With dtgpomain.SelectedRows(0)
            If .Cells(0).Value <> "" Then
                'cashpositionpk = .Cells(2).Value
                'frmcashpositionlogs.Show()
                txtPOno.Text = .Cells(0).Value
                Populatetxt(txtPOno.Text)
                PopulateItem()
                Panel3.Enabled = True
            End If
        End With
    End Sub
    Private Sub Populatetxt(ByVal pno As String)
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
            txtPODate.Text = DReader.nelReader.Item("tdate")
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

    Private Sub dtgpomain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgpomain.CellContentClick

    End Sub

    Private Sub txtSuppliername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuppliername.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(txtSuppliername.SelectedItem, SupplierInfo)
        txtSalesPerson.Text = acc.SupplierAddress
        txtaddress.Text = acc.SupplierNo
        txtsupno.Text = acc.SalesMan
    End Sub
    Private Sub delmain()
        Dim strProfileNo As String = txtPOno.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblpo WHERE pono ='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tblpo WHERE pono ='" & strProfileNo & "'"
        dtData.DELETE()
    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        If txtPOno.Text.Trim <> "" Then
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
    Private Sub updatepo()
        'Dim strCustomerNo As String = patientno
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        'dtData.IDGenValue = strCustomerNo
        'dtData.IDGenCode = "EPro"

        dtData.strSELECT = "SELECT * FROM tblpo WHERE pono = '" & txtPOno.Text & "'"
        dtData.strUpdate = "UPDATE tblpo SET " _
            & " pono ='" & txtPOno.Text & "', " _
            & " tdate ='" & txtPODate.Text & "', " _
            & " suppname ='" & txtSuppliername.Text & "', " _
            & " salesperson ='" & txtSalesPerson.Text & "'," _
            & " address ='" & txtaddress.Text & "', " _
            & " contactno ='" & txtsupcont.Text & "'," _
            & " forwader ='" & txtLogistic.Text & "', " _
            & " fcontact = '" & txtContact.Text & "'," _
            & " remarks = '" & txtRemarks.Text & "'," _
            & " itemcode = '" & cmbitemcode.Text & "'," _
            & " suppno = '" & txtsupno.Text & "'," _
            & " prepby = '" & cmbprepby.Text & "'," _
            & " appby = '" & cmbappby.Text & "'" _
            & " WHERE pk = '" & txtpk.Text & "'"
        dtData.strAdd = "SELECT * FROM tblpo"
        dtData.Save()
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged

    End Sub

    Private Sub expdate_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        If txtPOno.Text <> "" Then
            frmPOtosupplier.potosupp = txtPOno.Text
            frmPOtosupplier.Show(frmmain.DockPanel1)
        End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class