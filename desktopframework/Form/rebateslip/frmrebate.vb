Imports WeifenLuo.WinFormsUI.Docking
Public Class frmrebate
    Inherits DockContent
    Private Sub frmrebate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
        txtrebate.Text = IDgenerator("Rebate")
        populaterebateitems()
        populateallrebate()
        loadpo()
        populateallrebate()
        'PopulateCombo(txtrecipient, "Select recipient from tblrecipient group by recipient")
    End Sub
    Private Sub loadpo()
        Dim strSELECT As String = "SELECT trno,ponumb,podate FROM tbltrmain group by trno"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        txttrno.Items.Clear()
        Do While DReader.nelReader.Read
            txttrno.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub try_to_find_po_amnt()
        Dim apvat As String = "0.0" & cmbvat.Text
        Dim apwht As String = "0.0" & cmbwht.Text
        Dim xvat As Double = Val(apvat)
        Dim xwht As Double = Val(apwht)
        Dim strSELECT As String = ""
        strSELECT = "SELECT sum(potamount), FROM tbltrmain WHERE " _
  & " pochk ='true' and trno = '" & txttrno.Text & "' group by trno"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        If DReader.nelReader.Read Then
            'On Error Resume Next
            Dim grosspo As Double = Val(DReader.nelReader.Item("potamount"))
            txtgrossamnt.Text = FormatNumber(DReader.nelReader.Item("potamount"), 2)
            'txtcheckno.Text = DReader.nelReader.Item("chkno")
            dtppodate.Text = DReader.nelReader.Item("podate")
            txtamntcheck.Text = FormatNumber((grosspo) - ((((grosspo * 100) / 112) * xvat) + (((grosspo * 100) / 112) * xwht)), 2)
        End If
        DReader.nelReader.Close()
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        txtrebate.Text = IDgenerator("Rebate")
        txtpono.Text = ""
        clear()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtrebate.Text <> "" Then
            'save()
            IDgeneratorSave("Rebate", txtrebate.Text)
            populaterebateitems()
            populateallrebate()
        End If
    End Sub
    Private Sub save(ByVal classification As String, _
                     ByVal grossamnt As String, ByVal vat As String, ByVal wht As String, _
                     ByVal net As String, ByVal appreb As String, ByVal rebamnt As String, ByVal pk As String, ByVal recepttbl As String)
        Dim strtrno As String = pk
        Dim dtData As New clsDataManipulation
        Dim rebateapplied As String = "." & txtapprebate.Text

        dtData.strSELECT = "SELECT * FROM tblrebate WHERE pk ='" & strtrno & "' and recepient = '" & recepttbl & "'"
        dtData.strUpdate = "UPDATE tblrebate SET " _
            & " grossamtof_C ='" & Replace(txtgrossamnt.Text, ",", "") & "'," _
            & " trno = '" & txttrno.Text & "', " _
            & " tdate ='" & dtpRdate.Text & "'," _
            & " pono='" & txtpono.Text & "', " _
            & " podate ='" & dtppodate.Text & "'," _
            & " chkno ='" & txtcheckno.Text & "'," _
            & " chkdate = '" & dtpchkdate.Text & "'," _
            & " recepient = '" & recepttbl & "'," _
            & " classification = '" & classification & "'," _
            & " gross = '" & Replace(grossamnt, ",", "") & "'," _
            & " prepby = '" & cmbprepby.Text & "'," _
            & " chkby = '" & cmbcheckby.Text & "'," _
            & " rebateno = '" & txtrebate.Text & "'," _
            & " appliedR = '" & appreb & "'," _
            & " amntofchk = '" & Replace(txtamntcheck.Text, ",", "") & "'," _
            & " vat = '" & vat & "'," _
            & " wht = '" & Replace(wht, ",", "") & "'," _
            & " rebateamnt = '" & Val(Replace(rebamnt, ",", "")) & "'," _
            & " net = '" & Replace(net, ",", "") & "',apvat = '" & cmbvat.Text & "',apwht = '" & cmbwht.Text & "'" _
            & " WHERE pk ='" & strtrno & "' and recepient = '" & recepttbl & "'"
        dtData.strAdd = "INSERT INTO tblrebate " _
            & " (grossamtof_C, " _
            & " trno," _
            & " tdate, " _
            & " pono, " _
            & " podate, " _
            & " chkno, " _
            & " chkdate, " _
            & " recepient," _
            & " classification," _
            & " gross, " _
            & " prepby, " _
            & " chkby,rebateno,appliedR,amntofchk,rebateamnt,vat,wht,net,apvat,apwht) " _
            & " VALUES('" & Replace(txtgrossamnt.Text, ",", "") & "'," _
            & " '" & txttrno.Text & "'," _
            & " '" & dtpRdate.Text & "', " _
            & " '" & txtpono.Text & "', " _
            & " '" & dtppodate.Text & "', " _
            & " '" & txtcheckno.Text & "', " _
            & " '" & dtpchkdate.Text & "'," _
            & " '" & recepttbl & "'," _
            & " '" & classification & "'," _
            & " '" & Replace(grossamnt, ",", "") & "'," _
            & " '" & cmbprepby.Text & "'," _
            & " '" & cmbcheckby.Text & "'," _
            & " '" & txtrebate.Text & "'," _
            & " '" & appreb & "','" & Replace(txtamntcheck.Text, ",", "") & "'," _
            & " '" & Val(Replace(rebamnt, ",", "")) & "'," _
            & " '" & vat & "','" & wht & "','" & Replace(net, ",", "") & "','" & cmbvat.Text & "','" & cmbwht.Text & "')"
        dtData.Save()
    End Sub
    Private Sub clear()
        txtapprebate.Text = "0"
        txtcheckno.Text = ""
        txtgross.Text = "0"
        txtpk.Text = ""
        txttrno.Text = ""
    End Sub

    Private Sub deleteall()
        If txtrebate.Text.Trim <> "" Then
            Dim ans As Long = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ans = vbYes Then
                del()
                populaterebateitems()
                clear()
            End If
        End If
    End Sub
    Private Sub del()
        Dim strProfileNo As String = txtrebate.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblrebate WHERE rebateno ='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tblrebate WHERE rebateno ='" & strProfileNo & "'"
        dtData.DELETE()
    End Sub

    Private Sub cmddelall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelall.Click
        deleteall()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        delitm()
        populaterebateitems()
        txtpk.Text = ""
    End Sub
    Private Sub delitm()
        Dim strProfileNo As String = txtrebate.Text
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblrebate WHERE pk ='" & txtpk.Text & "'"
        dtData.strDELETE = "DELETE FROM tblrebate WHERE pk ='" & txtpk.Text & "'"
        dtData.DELETE()
    End Sub
    Private Sub populaterebateitems()
        dtgitems.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblrebate where rebateno = '" & txtrebate.Text & "' group by classification"
        tabledrebate(strSELECT)
    End Sub
    Private Sub tabledrebate(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitems
                .Rows.Add()
                'gross = Val(DReader.nelReader.Item("gross"))
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(2, a).Value = DReader.nelReader.Item("classification")
                .Item(3, a).Value = FormatNumber(DReader.nelReader.Item("gross"), 2)
                '.Item(4, a).Value = DReader.nelReader.Item("recepient")
                .Item(5, a).Value = FormatNumber(DReader.nelReader.Item("vat"), 2)
                .Item(6, a).Value = FormatNumber(DReader.nelReader.Item("wht"), 2)
                .Item(7, a).Value = FormatNumber(DReader.nelReader.Item("net"), 2)
                .Item(8, a).Value = DReader.nelReader.Item("appliedR")
                .Item(9, a).Value = FormatNumber(DReader.nelReader.Item("rebateamnt"), 2)

            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
        'lbltotal.Text = FormatNumber(SumItUp(dtgpritems, 7), 2)
    End Sub
    Private Sub populaterecipient()
        dtgricipient.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblrebate where trno = '" & txttrno.Text & "' "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgricipient
                .Rows.Add()
                'gross = Val(DReader.nelReader.Item("gross"))
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = DReader.nelReader.Item("recepient")
                .Item(2, a).Value = DReader.nelReader.Item("classification")
                .Item(3, a).Value = FormatNumber(DReader.nelReader.Item("gross"), 2)
                .Item(4, a).Value = DReader.nelReader.Item("appliedR")
                .Item(5, a).Value = FormatNumber(DReader.nelReader.Item("rebateamnt"), 2)
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub


    Private Sub populateallrebate()
        dtgallrebate.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblrebate group by rebateno"
        tabledrebateall(strSELECT)
    End Sub
    Private Sub tabledrebateall(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgallrebate
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("rebateno")
                .Item(1, a).Value = DReader.nelReader.Item("trno")
                .Item(2, a).Value = DReader.nelReader.Item("tdate")
                .Item(3, a).Value = DReader.nelReader.Item("apvat")
                .Item(4, a).Value = DReader.nelReader.Item("apwht")
                '.Item(3, a).Value = DReader.nelReader.Item(" ")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
        'lbltotal.Text = FormatNumber(SumItUp(dtgpritems, 7), 2)
    End Sub

    Private Sub dtgitems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitems.CellClick
        With dtgitems.SelectedRows(0)

            'txtpk.Text = .Cells(0).Value
            'cmbitemclass.Text = .Cells(1).Value
            'txtgross.Text = .Cells(2).Value
            'txtapprebate.Text = .Cells(7).Value

        End With
    End Sub

    Private Sub dtgitems_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitems.CellContentClick

    End Sub

    Private Sub dtgallrebate_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgallrebate.CellClick
        With dtgallrebate.SelectedRows(0)
            cmbvat.Text = .Cells(3).Value
            cmbwht.Text = .Cells(4).Value
            txttrno.Text = .Cells(1).Value
            txtrebate.Text = .Cells(0).Value
            'findall(txtrebate.Text)
            populaterebateitems()
            lblramount.Text = FormatNumber(SumItUp(dtgitems, 9), 2)
            populaterecipient()
        End With
    End Sub
    Private Sub findall(ByVal reb As String)
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblrebate WHERE " _
  & " rebateno = '" & reb & "'"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        If DReader.nelReader.Read Then
            'On Error Resume Next
            txtamntcheck.Text = FormatNumber(DReader.nelReader.Item("amntofchk"), 2)
            txtcheckno.Text = DReader.nelReader.Item("chkno")
            txtgrossamnt.Text = FormatNumber(DReader.nelReader.Item("grossamtof_C"), 2)
            txtpono.Text = DReader.nelReader.Item("pono")
            txtrebate.Text = DReader.nelReader.Item("rebateno")
            dtpchkdate.Text = DReader.nelReader.Item("chkdate")
            dtppodate.Text = DReader.nelReader.Item("podate")
            txttrno.Text = DReader.nelReader.Item("trno")
            dtpRdate.Text = DReader.nelReader.Item("tdate")
            'txtrecipient.Text = DReader.nelReader.Item("recepient")
            'txtsupplier.Text = DReader.nelReader.Item("suppleir")
            'txtamntcheck.Text = FormatNumber(DReader.nelReader.Item("amntofchk"), 2)
            'prno = DReader.nelReader.Item("pr_no")
        Else
            clear()
        End If
        DReader.nelReader.Close()
    End Sub

    Private Sub dtgallrebate_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgallrebate.CellContentClick

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'rebateno = txtrebate.Text
        'frmrebateprint.Close()
        'frmrebateprint.Show()
        prtrebate = txtrebate.Text
        frmrebateprint2.Close()
        frmrebateprint2.Show(frmmain.DockPanel1)
    End Sub
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
    Private Sub txttrno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttrno.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(txttrno.SelectedItem, SupplierInfo)
        If cmbvat.Text <> "" Then
            txtpono.Text = acc.SupplierNo
            dtppodate.Text = acc.SupplierAddress
            Populategetsum("select potamount from tbltrmain where trno = '" & txttrno.Text & "'")
            txtgrossamnt.Text = FormatNumber(sumcollector, 2)
            Dim apvat As String = "0.0" & cmbvat.Text
            Dim apwht As String = "0.0" & cmbwht.Text
            Dim xvat As Double = Val(apvat)
            Dim xwht As Double = Val(apwht)

            Dim amntvat As Double = (Replace(txtgrossamnt.Text, ",", "") * 100 / 112) * Val(apvat)
            Dim amntwht As Double = (Replace(txtgrossamnt.Text, ",", "") * 100 / 112) * Val(xwht)

            txtamntcheck.Text = FormatNumber(Replace(txtgrossamnt.Text, ",", "") - (amntvat + amntwht), 2)
            populateitems()
            copycat()
            lblramount.Text = FormatNumber(SumItUp(dtgitems, 9), 2)
        Else
            MessageBox.Show("No Tax Inputed")
        End If

    End Sub
    Private Sub populateitems()
        Dim apvat As String = "0.0" & cmbvat.Text
        Dim apwht As String = "0.0" & cmbwht.Text
        Dim xvat As Double = Val(apvat)
        Dim xwht As Double = Val(apwht)
        Dim vat As Double = 0
        Dim wht As Double = 0
        Dim gross As Double = 0
        dtgitems.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT cat, sum(potamount)as total FROM tbltrmain where trno = '" & txttrno.Text & "' group by cat"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitems
                .Rows.Add()
                '.Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(2, a).Value = DReader.nelReader.Item("cat")
                .Item(3, a).Value = FormatNumber(DReader.nelReader.Item("total"), 2)
                gross = Replace(.Item(3, a).Value, ",", "")
                vat = ((gross * 100) / 112) * Val(apvat)
                wht = ((gross * 100) / 112) * Val(apwht)
                .Item(5, a).Value = FormatNumber(vat, 2)
                .Item(6, a).Value = FormatNumber(wht, 2)
                .Item(7, a).Value = FormatNumber(gross - (vat + wht), 2)
            End With
            lblgross.Text = FormatNumber(SumItUp(dtgitems, 3), 2)
            lblvat.Text = FormatNumber(SumItUp(dtgitems, 5), 2)
            lblwht.Text = FormatNumber(SumItUp(dtgitems, 6), 2)
            lblnet.Text = FormatNumber(SumItUp(dtgitems, 7), 2)
            a = a + 1
        Loop
        DReader.nelReader.Close()
        
    End Sub

    Private Sub cmbvat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvat.SelectedIndexChanged
        Populategetsum("select potamount from tbltrmain where trno = '" & txttrno.Text & "'")
        txtgrossamnt.Text = FormatNumber(sumcollector, 2)
        populateitems()
        copycat()
        lblramount.Text = FormatNumber(SumItUp(dtgitems, 9), 2)
    End Sub

    Private Sub cmbwht_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbwht.SelectedIndexChanged
        Populategetsum("select potamount from tbltrmain where trno = '" & txttrno.Text & "'")
        txtgrossamnt.Text = FormatNumber(sumcollector, 2)
        populateitems()
        copycat()
        lblramount.Text = FormatNumber(SumItUp(dtgitems, 9), 2)
    End Sub

    Private Sub cmdcompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcompute.Click
        saveandcompute()
    End Sub
    Private Sub saveandcompute()
        copycat()
        lblramount.Text = FormatNumber(SumItUp(dtgitems, 9), 2)
        savetbl()
        updatetrmain()
        IDgeneratorSave("Rebate", txtrebate.Text)
        populateallrebate()
        populaterecipient()
        loadpo()
    End Sub
    Private Sub copycat()
        Dim rCnt As Integer = dtgitems.RowCount - 1
        Dim a As Integer
        Dim groosamnt As Double = 0
        Dim appreb As String = ""
        Dim netholder As Double = 0
        Dim pk As String = ""
        Dim cat As String = ""
        With dtgitems
            For a = 0 To rCnt
                groosamnt = Val(Replace(.Item(3, a).Value, ",", ""))
                appreb = .Item(8, a).Value
                netholder = FormatNumber(groosamnt - (Val(Replace(.Item(5, a).Value, ",", "")) + Val(Replace(.Item(6, a).Value, ",", ""))), 2)
                .Item(9, a).Value = FormatNumber((netholder) * (.Item(8, a).Value), 2)
            Next a
            'MessageBox.Show("Done!")
        End With
    End Sub
    Private Sub savetbl()
        Dim rCnt As Integer = dtgitems.RowCount - 1
        With dtgitems
            For a = 0 To rCnt
                Dim chk As Boolean = .Item(1, a).Value
                If chk = "true" Then
                    save(.Item(2, a).Value, .Item(3, a).Value, .Item(5, a).Value, .Item(6, a).Value, .Item(7, a).Value, .Item(8, a).Value, .Item(9, a).Value, .Item(0, a).Value, _
                                         .Item(4, a).Value)
                    Dim varex1 As String = .Item(8, a).Value
                End If
            Next a
            MessageBox.Show("Saved!")
        End With
    End Sub
    Private Sub updatetrmain()
        Dim dtData As New clsDataManipulation
        dtData.strSELECT = "SELECT * FROM tbltrmain WHERE trno = '" & txttrno.Text & "'"
        dtData.strUpdate = "UPDATE tbltrmain SET " _
            & " rebatestat ='Finished'" _
                & " WHERE trno = '" & txttrno.Text & "'"
        dtData.strAdd = "SELECT * FROM tbltrmain"
        dtData.Save()
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        saveandcompute()
        saverecipient()
        populaterebate()
        clearreb()
    End Sub
    Private Sub saverecipient()
        'Dim dtData As New clsDataManipulation

        'dtData.strSELECT = "SELECT * FROM tblrecipient WHERE pk ='" & txtrpk.Text & "'"
        'dtData.strUpdate = "UPDATE tblrecipient SET " _
        '    & " trno ='" & txttrno.Text & "'," _
        '    & " recipient = '" & txtrecipient.Text & "', " _
        '    & " rebateapp ='" & txtrebapp.Text & "'," _
        '    & " tamount='" & Replace(txtrebamount.Text, ",", "") & "' " _
        '    & " WHERE pk ='" & txtrpk.Text & "'"
        'dtData.strAdd = "INSERT INTO tblrecipient " _
        '    & " (trno, " _
        '    & " recipient," _
        '    & " rebateapp, " _
        '    & " tamount) " _
        '    & " VALUES('" & txttrno.Text & "'," _
        '    & " '" & txtrecipient.Text & "'," _
        '    & " '" & txtrebapp.Text & "', " _
        '    & " '" & Replace(txtrebamount.Text, ",", "") & "')"
        'dtData.Save()
    End Sub
    Private Sub clearreb()
        'txtrecipient.Text = ""
        'txtrebapp.Text = ""
        'txtrebamount.Text = ""
        'txtrpk.Text = ""
        'txtrecipient.Focus()
    End Sub
    Private Sub populaterebate()
        'dtgrecipient.Rows.Clear()
        'Dim strSELECT As String = ""
        'strSELECT = "SELECT * FROM tblrecipient where trno = '" & txttrno.Text & "'"
        'tblrebatepop(strSELECT)
    End Sub
    Private Sub tblrebatepop(ByVal strq As String)
        'Dim DReader As New DataClassReader
        'DReader.strSELECTSQL = strq
        'DReader.ReadData()
        'Dim a As Integer = 0
        'Do While DReader.nelReader.Read
        '    With dtgrecipient
        '        .Rows.Add()
        '        'gross = Val(DReader.nelReader.Item("gross"))
        '        .Item(0, a).Value = DReader.nelReader.Item("pk")
        '        .Item(1, a).Value = DReader.nelReader.Item("recipient")
        '        .Item(2, a).Value = FormatNumber(DReader.nelReader.Item("rebateapp"), 2)
        '        .Item(3, a).Value = FormatNumber(DReader.nelReader.Item("tamount"), 2)
        '    End With
        '    a = a + 1
        'Loop
        'DReader.nelReader.Close()
        'lbltotal.Text = FormatNumber(SumItUp(dtgpritems, 7), 2)
    End Sub


    Private Sub txtrebapp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'groosamnt = Val(Replace(.Item(2, a).Value, ",", ""))
        'appreb = .Item(6, a).Value
        'netholder = FormatNumber(groosamnt - (Val(Replace(.Item(3, a).Value, ",", "")) + Val(Replace(.Item(4, a).Value, ",", ""))), 2)
        '.Item(7, a).Value = FormatNumber((netholder) * (.Item(6, a).Value), 2)

        'Dim apvat As String = "0.0" & cmbvat.Text
        'Dim apwht As String = "0.0" & cmbwht.Text
        'Dim xvat As Double = Val(apvat)
        'Dim xwht As Double = Val(apwht)



        'txtrebamount.Text = Val(Replace(lblramount.Text, ",", ""))
        'Dim amntvat As Double = (Replace(txtrebamount.Text, ",", "") * 100 / 112) * Val(apvat)
        'Dim amntwht As Double = (Replace(txtrebamount.Text, ",", "") * 100 / 112) * Val(xwht)
        'txtrebamount.Text = (txtrebamount.Text - Val(amntvat)) + Val(amntwht)

        'txtrebamount.Text = FormatNumber(txtrebamount.Text * Val(txtrebapp.Text), 2)
    End Sub

    Private Sub cmdaddres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddres.Click
        addnewrecipient()
    End Sub
    Private Sub addnewrecipient()
        Dim rCnt As Integer = dtgitems.RowCount - 1
        With dtgitems
            For a = 0 To rCnt
                Dim chk As Boolean = .Item(1, a).Value
                'If chk = "true" Then
                .Item(4, a).Value = ""
                .Item(4, a).Style.BackColor = Color.YellowGreen
                .Item(8, a).Value = "0"
                .Item(8, a).Style.BackColor = Color.YellowGreen
                .Item(1, a).Style.BackColor = Color.YellowGreen
                'End If
            Next a
            MessageBox.Show("please check the checkboxes you want to add recipient and fill the necessary field!")
        End With
    End Sub
End Class