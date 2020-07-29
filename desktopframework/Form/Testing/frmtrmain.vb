Imports WeifenLuo.WinFormsUI.Docking
Public Class frmtrmain
    Inherits DockContent
    Dim unit As String
    Dim description As String
    Dim itmsize As String
    Dim itemcode As String
    Dim itmpk As String
    Dim manufacturer As String
    Dim brandname As String
    Dim ccode As String
    Dim suppadd As String
    Private Sub frmtrmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GradientPanelXP3.Enabled = False
        'TODO: This line of code loads data into the 'Dtssupplier.tblsupplier' table. You can move, or remove it, as needed.
        loaditms()
        loadclient()
        TblsupplierTableAdapter.Connection = conn
        Me.TblsupplierTableAdapter.Fill(Me.Dtssupplier.tblsupplier)
        PopulateCombo(txttr, "select trno from tbltrmain group by trno")
    End Sub
    Private Sub loadclient()
        Dim strSELECT As String = "SELECT suppname,suppNO,address FROM tblclient group by suppNO"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        txtcname.Items.Clear()
        Do While DReader.nelReader.Read
            txtcname.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    'Dim pk As String = ""
    Private Sub dtgItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgItems.CellClick
        With dtgItems.SelectedRows(0)
            itmpk = .Cells(0).Value
        End With
    End Sub
    Private Sub dtgItems_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgItems.DataError
        If e.Context = DataGridViewDataErrorContexts.Formatting Or e.Context = DataGridViewDataErrorContexts.PreferredSize Then
            e.ThrowException = False
        End If
    End Sub
    Private Sub loaditms()
        Dim strSELECT As String = "SELECT concat(itemdesc, '/',size,'/' , manufacturer, ' (',classification,')','/',unit,'/',remarks,'/',expiration_D)," _
        & " itemcode,unit,cost,itemdesc,size,manufacturer,classification,uprice,remarks,expiration_D,unitppcs,stocks,cpr,category FROM tblitemlist "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbdesc.Items.Clear()
        Do While DReader.nelReader.Read
            cmbdesc.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString, DReader.nelReader.Item(3).ToString, DReader.nelReader.Item(4).ToString, _
            DReader.nelReader.Item(5).ToString, DReader.nelReader.Item(6).ToString, DReader.nelReader.Item(7).ToString, DReader.nelReader.Item(8).ToString, _
            DReader.nelReader.Item(9).ToString, DReader.nelReader.Item(10).ToString, DReader.nelReader.Item(11).ToString, DReader.nelReader.Item(12).ToString, _
            DReader.nelReader.Item(13).ToString, DReader.nelReader.Item(14).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        Dim ans As Long = MessageBox.Show("Are you sure want to update this?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ans = vbYes Then
            updatethis()
            updatefrontpage()
            MessageBox.Show("Update Complete....")
            ProgressBar1.Visible = False
            lbltotal.Text = "Total: " & FormatNumber(SumItUp(dtgItems, 20), 2)
        End If
    End Sub

    Private Sub updatefrontpage()
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        Dim stpr As String
        Dim stpo As String
        Dim strpq As String
        Dim stci As String
        If txtpr.Text <> "" Then
            stpr = txtpr.Text & "-" & dtppr.Text
        Else
            stpr = ""
        End If
        If txtpono.Text <> "" Then
            stpo = txtpono.Text & "-" & dtppo.Text
        Else
            stpo = ""
        End If
        If txtpono.Text <> "" Then
            strpq = txtrpq.Text & "-" & dtprpq.Text
        Else
            strpq = ""
        End If
        If txtpono.Text <> "" Then
            stci = txtci.Text & "-" & dtpcidate.Text
        Else
            stci = ""
        End If

        dtData.strSELECT = "SELECT * FROM tbltrstaus WHERE trno = '" & txttr.Text & "'"
        dtData.strUpdate = "UPDATE tbltrstaus SET " _
            & " pr ='" & stpr & "'," _
              & " po ='" & stpo & "' ," _
                & " rpq ='" & strpq & "'," _
                  & " ci ='" & stci & "'," _
                    & " tdate ='" & dtptr.Text & "',cname = '" & txtcname.Text & "'" _
                & " WHERE trno = '" & txttr.Text & "'"
        dtData.strAdd = "INSERT INTO tbltrstaus " _
            & " (pr,po,rpq,ci,trno,tdate,cname) " _
            & " VALUES('" & stpr & "','" & stpo & "'," _
            & " '" & strpq & "','" & stci & "','" & txttr.Text & "','" & dtptr.Text & "','" & txtcname.Text & "')"
        dtData.Save()
    End Sub
    Private Sub updatethis()

        filterpk()
        PopulateItem()
        totalall()
        'MessageBox
    End Sub
    Private Sub filterpk()

        
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgItems.RowCount - 1
        Dim a As Integer
        Dim pk As String = ""
        Dim chk As Boolean = False
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = rCnt
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        With dtgItems
            For a = 0 To rCnt
                Dim pk1 As String = .Item(0, a).Value
                Dim prchk As String = .Item(1, a).Value
                Dim rpqchk As String = .Item(2, a).Value
                Dim pochk As String = .Item(3, a).Value
                Dim sp As String = .Item(11, a).Value
                Dim qty As String = .Item(12, a).Value
                Dim sp1 As String = .Item(15, a).Value
                Dim sp1price As String = .Item(16, a).Value
                Dim sp2 As String = .Item(17, a).Value
                Dim sp2price As String = .Item(18, a).Value
                Dim regprice As String = .Item(10, a).Value
                Dim tblunit As String = .Item(8, a).Value

                updatecontent(prchk, sp, qty, rpqchk, sp1, _
                              sp1price, sp2, sp2price, pk1, pochk, regprice, tblunit)
                Try
                    ProgressBar1.Value += 1
                Catch

                End Try
            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub updatecontent(ByVal prchk As String, _
                             ByVal sp As String, _
                             ByVal qty As String, _
                             ByVal rpqchk As String, _
                             ByVal sp1 As String, _
                             ByVal sp1price As String, _
                             ByVal sp2 As String, _
                             ByVal sp2price As String, _
                             ByVal pk1 As String, ByVal pochk As String, _
                             ByVal regprice As String, _
                             ByVal tblunit As String)
        'Try
        Dim valpoamt As Double = Val(qty) * Val(sp)
        Dim valpramnt As Double = Val(regprice) * Val(sp)
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True

        dtData.strSELECT = "SELECT * FROM tbltrmain WHERE pk = '" & pk1 & "'"
        dtData.strUpdate = "UPDATE tbltrmain SET " _
            & " prchk = '" & prchk & "', " _
            & " sp1 = '" & sp & "', " _
            & " qty = '" & qty & "', " _
            & " rpqchk = '" & rpqchk & "', " _
            & " supplier1 = '" & sp1 & "', " _
            & " supplier1price = '" & sp1price & "', " _
            & " supplier2 = '" & sp2 & "', " _
            & " supplier2price = '" & sp2price & "'," _
            & " rpqno = '" & txtrpq.Text & "'," _
            & " trno ='" & txttr.Text & "', " _
            & " tdatetr = '" & dtptr.Text & "', " _
            & " tdatepr = '" & dtppr.Text & "', " _
            & " tdaterpq = '" & dtprpq.Text & "'," _
            & " prno ='" & txtpr.Text & "', " _
            & " cname = '" & txtcname.Text & "', " _
            & " ccode = '" & ccode & "'," _
            & " cino = '" & txtci.Text & "', " _
            & " cidate = '" & dtpcidate.Text & "'," _
            & " appby = '" & cmbappby.Text & "'," _
            & " prepby = '" & cmbprepby.Text & "'," _
            & " pochk = '" & pochk & "'," _
            & " ponumb = '" & txtpono.Text & "'," _
            & " regprice = '" & regprice & "'," _
            & " cino = '" & txtci.Text & "',unit = '" & tblunit & "',potamount = '" & valpoamt & "',pramntrpt = '" & valpramnt & "'" _
            & " WHERE pk = '" & pk1 & "'"
        dtData.strAdd = ""
        dtData.Save()
        'MessageBox.Show("Updated")
        'Catch
        '    MessageBox.Show("An error had occured Please Inform the the Technical support")
        '    'IDgeneratorSave("itemcode", itemcode)
        'End Try
    End Sub
    Private Sub totalall()
        lbltr.Text = SumItUp(dtgItems, 11)
        'lblpr.Text = SumItUp(dtgItems,
        lblrpq2.Text = SumItUp(dtgItems, 15)
        lblrpq3.Text = SumItUp(dtgItems, 17)
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If itemcode <> "" And cmbunit.Text <> "" Then
            If txtprice.Text = "" Or txtprice.Text = " " Then
                txtprice.Text = "0"
            End If
            If txtsp1.Text = "" Or txtsp1.Text = " " Then
                txtsp1.Text = "0"
            End If
            savetitem()
            PopulateItem()
            totalall()
            clearthisadd()
        End If
    End Sub
    Private Sub clearthisadd()
        cmbdesc.Text = ""
        txtprice.Text = "0"
        txtsp1.Text = "0"
        txtlnbn.Text = ""
        txtexpdate.Text = ""
        txtqty.Text = "0"
        itmpk = ""
        cmbunit.Text = ""
    End Sub
    Private Sub savetitem()
        'Dim strCustomerNo As String = patientno
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        'dtData.IDGenValue = strCustomerNo
        'dtData.IDGenCode = "EPro"
        'recno
        Dim poamnt As Double = Val(txtsp1.Text) * Val(txtqty.Text)
        Dim tramnt As Double = Val(txtprice.Text) * Val(txtqty.Text)
        dtData.strSELECT = "SELECT * FROM tbltrmain WHERE pk = '" & itmpk & "'"
        dtData.strUpdate = "UPDATE tbltrmain SET " _
            & " trno ='" & txttr.Text & "', " _
            & " prno ='" & txtpr.Text & "', " _
            & " rpqno ='" & txtrpq.Text & "', " _
            & " itemcode ='" & itemcode & "', " _
            & " descripition ='" & description & "', " _
            & " size ='" & itmsize & "', " _
            & " unit ='" & cmbunit.Text & "', " _
            & " manufacturer ='" & manufacturer & "'," _
            & " brandname ='" & brandname & "', " _
            & " regprice ='" & txtprice.Text & "', " _
            & " qty ='" & txtqty.Text & "', " _
            & " sp1 = '" & txtsp1.Text & "', " _
            & " tdatetr = '" & dtptr.Text & "', " _
            & " tdatepr = '" & dtppr.Text & "', " _
            & " tdaterpq = '" & dtprpq.Text & "'," _
            & " cname = '" & txtcname.Text & "', " _
            & " lnbn = '" & txtlnbn.Text & "', " _
            & " expdate = '" & txtexpdate.Text & "', " _
            & " truedesc = '" & description & "', " _
            & " ponumb = '" & txtpono.Text & "', " _
            & " podate = '" & dtppo.Text & "', " _
            & " cino = '" & txtci.Text & "', " _
            & " cidate = '" & dtpcidate.Text & "', " _
            & " caddress = '" & suppadd & "', " _
            & " prepby = '" & cmbprepby.Text & "', " _
            & " appby = '" & cmbappby.Text & "', " _
            & " placeofdel = '" & cmbplaceofdel.Text & "'," _
            & " ccode = '" & ccode & "',cpr = '" & txtcpr.Text & "',potamount = '" & poamnt & "',pramntrpt = '" & tramnt & "',cat = '" & category & "' " _
            & " WHERE pk = '" & itmpk & "'"
        dtData.strAdd = "INSERT INTO tbltrmain " _
            & " (trno, prno, rpqno, itemcode, descripition, size," _
            & " unit, manufacturer, brandname, regprice," _
            & " qty, sp1, tdatetr, tdatepr, tdaterpq,cname," _
            & " ccode,lnbn,expdate,truedesc,ponumb,podate," _
            & " cino,cidate,caddress,prepby,appby,placeofdel,potamount,pramntrpt,cat) " _
            & " VALUES('" & txttr.Text & "'," _
            & " '" & txtpr.Text & "', " _
            & " '" & txtrpq.Text & "', " _
            & " '" & itemcode & "'," _
            & " '" & description & "'," _
            & " '" & itmsize & "'," _
            & " '" & cmbunit.Text & "'," _
            & " '" & manufacturer & "'," _
            & " '" & brandname & "'," _
            & " '" & txtprice.Text & "'," _
            & " '" & txtqty.Text & "'," _
            & " '" & txtsp1.Text & "'," _
            & " '" & dtptr.Text & "'," _
            & " '" & dtppr.Text & "'," _
            & " '" & dtprpq.Text & "'," _
            & " '" & txtcname.Text & "'," _
            & " '" & ccode & "'," _
            & " '" & txtlnbn.Text & "'," _
            & " '" & txtexpdate.Text & "'," _
            & " '" & description & "'," _
            & " '" & txtpono.Text & "'," _
            & " '" & dtppo.Text & "'," _
            & " '" & txtci.Text & "', " _
            & " '" & dtpcidate.Text & "'," _
            & " '" & suppadd & "'," _
            & " '" & cmbprepby.Text & "'," _
            & " '" & cmbappby.Text & "'," _
            & " '" & cmbplaceofdel.Text & "','" & poamnt & "','" & tramnt & "','" & category & "')"
        dtData.Save()
    End Sub
    Private Sub PopulateItem()
        dtgItems.Rows.Clear()
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tbltrmain where trno = '" & txttr.Text & "' order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgItems
                Dim prchkval As String = DReader.nelReader.Item("prchk")
                Dim rpqchkval As String = DReader.nelReader.Item("rpqchk")
                Dim pochkval As String = DReader.nelReader.Item("pochk")
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = prchkval
                .Item(2, a).Value = rpqchkval
                .Item(3, a).Value = pochkval
                .Item(4, a).Value = DReader.nelReader.Item("itemcode")
                .Item(5, a).Value = DReader.nelReader.Item("descripition")
                .Item(6, a).Value = DReader.nelReader.Item("brandname")
                .Item(7, a).Value = DReader.nelReader.Item("Size")
                .Item(8, a).Value = DReader.nelReader.Item("unit")
                .Item(9, a).Value = DReader.nelReader.Item("manufacturer")
                .Item(10, a).Value = DReader.nelReader.Item("regprice")
                .Item(11, a).Value = DReader.nelReader.Item("sp1")
                .Item(12, a).Value = DReader.nelReader.Item("qty")
                .Item(13, a).Value = FormatNumber(DReader.nelReader.Item("qty") * DReader.nelReader.Item("regprice"), 2)
                .Item(14, a).Value = FormatNumber(DReader.nelReader.Item("qty") * DReader.nelReader.Item("sp1"), 2)

                .Item(15, a).Value = DReader.nelReader.Item("supplier1")
                .Item(16, a).Value = DReader.nelReader.Item("supplier1price")
                .Item(17, a).Value = DReader.nelReader.Item("supplier2")
                .Item(18, a).Value = DReader.nelReader.Item("supplier2price")
                txttr.Text = DReader.nelReader.Item("trno")
                txtpr.Text = DReader.nelReader.Item("prno")
                txtrpq.Text = DReader.nelReader.Item("rpqno")
                txtcname.Text = DReader.nelReader.Item("cname")
                ccode = DReader.nelReader.Item("ccode")
                cmbplaceofdel.Text = DReader.nelReader.Item("placeofdel")
                cmbprepby.Text = DReader.nelReader.Item("prepby")
                cmbappby.Text = DReader.nelReader.Item("appby")
                txtpono.Text = DReader.nelReader.Item("ponumb")
                dtppo.Text = DReader.nelReader.Item("podate")
                txtci.Text = DReader.nelReader.Item("cino")
                dtpcidate.Text = DReader.nelReader.Item("cidate")
                dtppr.Text = DReader.nelReader.Item("tdatepr")
                .Item(20, a).Value = DReader.nelReader.Item("qty") * DReader.nelReader.Item("sp1")
            End With

            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    '"SELECT concat(itemdesc, '/',size,'/' , manufacturer, ' (',classification,')','/',unit),itemcode,unit,cost,itemdesc,size,manufacturer,classification

    Dim category As String = ""
    Private Sub cmbdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesc.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbdesc.SelectedItem, SupplierInfo)
        cmbunit.Items.Clear()
        cmbunit.Items.Add(acc.SupplierAddress)
        cmbunit.Items.Add(acc.bcost)
        'unit = acc.SupplierAddress
        description = acc.fourth
        itmsize = acc.cat
        itemcode = acc.SupplierNo
        manufacturer = acc.classification
        brandname = acc.unitbx
        txtprice.Text = acc.unitpcs
        txtsp1.Text = acc.unitpcs
        txtlnbn.Text = acc.pcsprice
        txtexpdate.Text = acc.pcscost
        txtremaning.Text = acc.tsize & " " & acc.SupplierAddress
        txtcpr.Text = acc.brefdesc
        category = acc.category
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        GradientPanelXP3.Enabled = False
        txttr.Text = IDgenerator("tr")
        clearitm()
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        'clearitm()
        clearthisadd()
    End Sub
    Private Sub clearitm()
        unit = ""
        description = ""
        itmsize = ""
        itemcode = ""
        cmbdesc.Text = ""
        txtcname.Text = ""
        cmbplaceofdel.Text = ""
        txttr.Text = ""
        txtpr.Text = ""
        txtrpq.Text = ""
        txtci.Text = ""
        txtci.Text = ""
        cmbprepby.Text = ""
        cmbappby.Text = ""
        cmbdesc.Focus()
        dtgItems.Rows.Clear()
    End Sub

    Private Sub dtgItems_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgItems.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PopulateItem()
        lbltotal.Text = "Total: " & FormatNumber(SumItUp(dtgItems, 20), 2)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txttr.Text <> "" Then
            IDgeneratorSave("tr", txttr.Text)
            GradientPanelXP3.Enabled = True
        End If
    End Sub
    Private Sub updatetr()
        Dim dtData As New clsDataManipulation
        dtData.strSELECT = "SELECT * FROM tbltrstaus WHERE trno ='" & txttr.Text & "'"
        dtData.strUpdate = "UPDATE tbltrstaus SET " _
            & " pr ='true',cname = '" & txtcname.Text & "'" _
            & " WHERE trno ='" & txttr.Text & "'"
        dtData.strAdd = "INSERT INTO tbltrstaus " _
            & " (trno,cname) " _
            & " VALUES('" & txttr.Text & "','" & txtcname.Text & "')"
        dtData.Save()
    End Sub

    Private Sub cmdprintRPQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprintRPQ.Click
        'frmRPQ.Close()
        'frmRPQ.Show(frmmain.DockPanel1)
        frmRPQ.Close()
        updaterpq()
        With frmRPQ
            .rpqno = txtrpq.Text
            .Show(frmmain.DockPanel1)
        End With
    End Sub
    Private Sub updaterpq()

        Dim dtData As New clsDataManipulation


        dtData.strSELECT = "SELECT * FROM tbltrstaus WHERE trno ='" & txttr.Text & "'"
        dtData.strUpdate = "UPDATE tbltrstaus SET " _
            & " rpq ='true',cname = '" & txtcname.Text & "'" _
            & " WHERE trno ='" & txttr.Text & "'"
        dtData.strAdd = "INSERT INTO tbltrstaus " _
            & " (rpq,trno,cname) " _
            & " VALUES('true','" & txttr.Text & "','" & txtcname.Text & "')"
        dtData.Save()
    End Sub
    Private Sub cmdprintpr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprintpr.Click
        frmprprint.Close()
        updatepr()
        With frmprprint
            .prnum = txtpr.Text
            .Show(frmmain.DockPanel1)
        End With
    End Sub
    Private Sub updatepr()

        Dim dtData As New clsDataManipulation


        dtData.strSELECT = "SELECT * FROM tbltrstaus WHERE trno ='" & txttr.Text & "'"
        dtData.strUpdate = "UPDATE tbltrstaus SET " _
            & " pr ='true',cname = '" & txtcname.Text & "'" _
            & " WHERE trno ='" & txttr.Text & "'"
        dtData.strAdd = "INSERT INTO tbltrstaus " _
            & " (pr,trno,cname) " _
            & " VALUES('true','" & txttr.Text & "','" & txtcname.Text & "')"
        dtData.Save()
    End Sub


    Private Sub cmdprinttr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprinttr.Click
        frmtrprint.Close()
        'ipdat()
        With frmtrprint
            .trnum = txttr.Text
            .Show(frmmain.DockPanel1)
        End With
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'updatethis()
        If txtpono.Text <> "" Then
            frmpoclientreport.Close()
            updatepo()
            With frmpoclientreport
                .ponum = txtpono.Text
                .Show(frmmain.DockPanel1)
            End With
        Else
            MessageBox.Show("Cant accept no PO number...")
        End If

    End Sub
    Private Sub updatepo()

        Dim dtData As New clsDataManipulation


        dtData.strSELECT = "SELECT * FROM tbltrstaus WHERE trno = '" & txttr.Text & "'"
        dtData.strUpdate = "UPDATE tbltrstaus SET " _
            & " po ='true',cname = '" & txtcname.Text & "'" _
            & " WHERE trno ='" & txttr.Text & "'"
        dtData.strAdd = "INSERT INTO tbltrstaus " _
            & " (po,trno,cname) " _
            & " VALUES('true','" & txttr.Text & "','" & txtcname.Text & "')"
        dtData.Save()
    End Sub

    Private Sub txtcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcname.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(txtcname.SelectedItem, SupplierInfo)
        ccode = acc.SupplierNo
        suppadd = acc.SupplierAddress
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click

        Dim ans As Long = MessageBox.Show("Are you sure to delete the Whole TR?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ans = vbYes Then
            Dim ans2 As Long = MessageBox.Show("Are you REALY sure you want to delete the Whole TR?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ans2 = vbYes Then
                'Dim strSupplierNo As String = txtRefno.Text
                Dim dtData As New clsDataManipulation
                dtData.IDGenSave = False
                dtData.strSELECT = "SELECT * FROM  tbltrmain where trno ='" & txttr.Text & "'"
                dtData.strDELETE = "DELETE FROM  tbltrmain where trno ='" & txttr.Text & "'"
                dtData.DELETE()
            End If
        End If

    End Sub

    Private Sub dtgItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgItems.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim ans As Long = MessageBox.Show("Are you sure want to delete items?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ans = vbYes Then
                'Dim strSupplierNo As String = txtRefno.Text
                Dim dtData As New clsDataManipulation
                dtData.IDGenSave = False
                dtData.strSELECT = "SELECT * FROM  tbltrmain where pk ='" & itmpk & "'"
                dtData.strDELETE = "DELETE FROM  tbltrmain where pk ='" & itmpk & "'"
                dtData.DELETE()
            End If
        End If
    End Sub

    Private Sub GradientPanelXP3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientPanelXP3.Click

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtci.Text <> "" Then
            frmci.Close()
            updateci()
            With frmci
                .rpqci = txtci.Text
                .Show(frmmain.DockPanel1)
            End With
        Else
            MessageBox.Show("No CI Number")
        End If
    End Sub
    Private Sub updateci()
        Dim dtData As New clsDataManipulation
        dtData.strSELECT = "SELECT * FROM tbltrstaus WHERE trno ='" & txttr.Text & "'"
        dtData.strUpdate = "UPDATE tbltrstaus SET " _
            & " ci ='true',cname = '" & txtcname.Text & "'" _
            & " WHERE trno ='" & txttr.Text & "'"
        dtData.strAdd = "INSERT INTO tbltrstaus " _
            & " (ci,trno,cname) " _
            & " VALUES('true','" & txttr.Text & "','" & txtcname.Text & "')"
        dtData.Save()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        updatepo()
    End Sub

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged
        'Dim n As Integer = txtprice.Text
        'txtprice.Text = txtprice.Text.ToString("##,##,###.00")
    End Sub


End Class