Imports WeifenLuo.WinFormsUI.Docking
Public Class frmitemlist
    Inherits DockContent
    Private Sub frmitemlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtssupplier.tblmanufacturer' table. You can move, or remove it, as needed.
        TblmanufacturerTableAdapter.Connection = conn
        Me.TblmanufacturerTableAdapter.Fill(Me.Dtssupplier.tblmanufacturer)
        'TODO: This line of code loads data into the 'Dtssupplier.tblsupplier' table. You can move, or remove it, as needed.

        TblsupplierTableAdapter.Connection = conn
        Me.TblsupplierTableAdapter.Fill(Me.Dtssupplier.tblsupplier)
        PopulateCombo(cmbcat, "Select category from tblitemlist group by category")
        PopulateCombo(cmbclass, "Select manufacturer from tblitemlist group by manufacturer")
        PopulateCombo(cmbsupp, "Select supplier from tblitemlist group by supplier")
        populatedtr()
        populateitmcode()
    End Sub
    Private Sub populateitmcode()
        Dim strSELECT As String = "SELECT itemdesc,itemcode FROM tblitemlist "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbdesc.Items.Clear()
        Do While DReader.nelReader.Read
            cmbdesc.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub dtgitemlist_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgitemlist.DataError
        If e.Context = DataGridViewDataErrorContexts.Formatting Or e.Context = DataGridViewDataErrorContexts.PreferredSize Then
            e.ThrowException = False
        End If
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        filterpk()
        populatedtr()
    End Sub
    Private Sub populatedtr()
        dtgitemlist.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tblitemlist where itemdesc like '%" & cmbdesc.Text & "%' " _
        & " and manufacturer like '%" & cmbclass.Text & "%' and category like '%" & cmbcat.Text & "%' and supplier like '%" & cmbsupp.Text & "%'"
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
                .Item(1, a).Value = DReader.nelReader.Item("pk")
                .Item(2, a).Value = DReader.nelReader.Item("itemcode")
                .Item(3, a).Value = DReader.nelReader.Item("itemdesc")
                .Item(4, a).Value = DReader.nelReader.Item("classification")
                .Item(5, a).Value = DReader.nelReader.Item("size")

                .Item(6, a).Value = DReader.nelReader.Item("unit")
                .Item(7, a).Value = DReader.nelReader.Item("unitppcs")
                'On Error Resume Next
                Dim mantemp As String = DReader.nelReader.Item("qtyperunit")
                .Item(8, a).Value = mantemp

                .Item(9, a).Value = DReader.nelReader.Item("remarks")
                .Item(10, a).Value = DReader.nelReader.Item("stocks")

                .Item(11, a).Value = DReader.nelReader.Item("expiration_D")
                .Item(12, a).Value = DReader.nelReader.Item("uprice")
                .Item(13, a).Value = DReader.nelReader.Item("pperpiece")
                .Item(14, a).Value = DReader.nelReader.Item("cost")
                .Item(15, a).Value = DReader.nelReader.Item("costpiece")
                .Item(16, a).Value = DReader.nelReader.Item("category")

                Dim supptemp As String = DReader.nelReader.Item("manufacturer")
                On Error Resume Next
                .Item(17, a).Value = supptemp.ToString
                .Item(18, a).Value = DReader.nelReader.Item("supplier")
                .Item(19, a).Value = DReader.nelReader.Item("cpr")

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
                chk = .Item(0, a).Value
                pk = .Item(1, a).Value
                Dim itemcode As String = ""
                Dim itemdesc As String = .Item(3, a).Value
                Dim classification As String = .Item(4, a).Value
                Dim tsize As String = .Item(5, a).Value
                Dim unit As String = .Item(6, a).Value
                Dim pcsunit As String = .Item(7, a).Value
                Dim qtyperunit As Double = .Item(8, a).Value
                Dim remarks As String = .Item(9, a).Value

                Dim stocks As Double = .Item(10, a).Value
                Dim expiration_D As String = .Item(11, a).Value

                Dim price As Double = .Item(12, a).Value
                Dim pcsprice As Double = .Item(13, a).Value
                Dim cost As Double = .Item(14, a).Value
                Dim costpcs As Double = .Item(15, a).Value
                Dim category As String = .Item(16, a).Value

                Dim manu As String = .Item(17, a).Value
                Dim Supplier As String = .Item(18, a).Value
                Dim cpr As String = .Item(19, a).Value





                If pk = "" Or chk = True Then
                    itemcode = IDgenerator("itemcode")
                    updatecontent(itemcode, itemdesc, unit, qtyperunit, price, cost, _
                                  stocks, expiration_D, Supplier, remarks, pk, tsize, _
                                  classification, category, manu, pcsunit, pcsprice, costpcs, cpr)

                End If

            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Private Sub updatecontent(ByVal itemcode As String, _
                              ByVal itemdesc As String, _
                              ByVal unit As String, _
                              ByVal qtyperunit As Double, _
                              ByVal price As Double, _
                              ByVal cost As Double, _
                              ByVal stocks As Double, _
                              ByVal expiration_D As String, _
                              ByVal Supplier As String, _
                              ByVal remarks As String, ByVal pk As String, ByVal tsize As String, _
                              ByVal classification As String, _
                              ByVal category As String, ByVal manu As String, _
                              ByVal pcunit As String, ByVal pcsprice As Double, ByVal costpcs As Double, _
                              ByVal cpr As String)

        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True

        dtData.strSELECT = "SELECT * FROM tblitemlist WHERE pk = '" & pk & "'"
        dtData.strUpdate = "UPDATE tblitemlist SET " _
            & " itemcode = '" & itemcode & "', " _
            & " itemdesc = '" & itemdesc & "', " _
            & " unit = '" & unit & "', " _
            & " qtyperunit = '" & qtyperunit & "', " _
            & " uprice = '" & price & "', " _
             & " cost = '" & cost & "', " _
            & " stocks = '" & stocks & "', " _
            & " expiration_D = '" & expiration_D & "', " _
            & " supplier = '" & Supplier & "', " _
            & " remarks = '" & remarks & "',size = '" & tsize & "', " _
            & " category =  '" & category & "', classification = '" & classification & "',manufacturer = '" & manu & "'," _
            & " unitppcs = '" & pcunit & "',pperpiece = '" & pcsprice & "',costpiece = '" & costpcs & "',cpr = '" & cpr & "'" _
            & " WHERE pk = '" & pk & "'"
        dtData.strAdd = "INSERT INTO tblitemlist " _
            & " (itemcode," _
            & " itemdesc," _
            & " unit," _
            & " qtyperunit," _
            & " uprice," _
            & " cost," _
            & " stocks," _
            & " expiration_D," _
            & " supplier," _
            & " remarks,size,category,classification,manufacturer,unitppcs,pperpiece,costpiece,cpr) " _
            & " VALUES('" & itemcode & "'," _
            & " '" & itemdesc & "'," _
            & " '" & unit & "'," _
            & " '" & qtyperunit & "'," _
            & " '" & price & "'," _
            & " '" & cost & "'," _
            & " '" & stocks & "'," _
            & " '" & expiration_D & "'," _
            & " '" & Supplier & "'," _
            & " '" & remarks & "','" & tsize & "','" & category & "','" & classification & "','" & manu & "', " _
            & " '" & pcunit & "','" & pcsprice & "','" & costpcs & "','" & cpr & "')"
        dtData.Save()
        IDgeneratorSave("itemcode", itemcode)
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        populatedtr()
    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        Dim ans As Long = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ans = vbYes Then
            delfilter()
            populatedtr()
        End If

    End Sub
    Private Sub delfilter()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgitemlist.RowCount - 1
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
            'Dim ans As Long = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            'If ans = vbYes Then
            DeleteLogistic(pk)
            'populatedtr()
            'End If
        End If
    End Sub
    Private Sub DeleteLogistic(ByVal pk As String)
        Dim strProfileNo As String = pk
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblitemlist WHERE pk='" & strProfileNo & "'"
        dtData.strDELETE = "DELETE FROM tblitemlist WHERE pk='" & strProfileNo & "'"
        dtData.DELETE()
        'ActionLog("Emplyee Profile deleted Ref: " & txtProfileNo.Text & " Emplyee Name: " & txtName.Text, Me.Text)
    End Sub

    Private Sub cmbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclass.SelectedIndexChanged

    End Sub

    Private Sub dtgitemlist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgitemlist.CellContentClick

    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        itmlistcode = cmbdesc.Text
        itmcategory = cmbcat.Text
        itmmanufacturer = cmbclass.Text
        frmPrintItemlist.Close()
        frmPrintItemlist.Show(frmmain.DockPanel1)
    End Sub
    Dim Litemcode As String = ""
    Private Sub cmbdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesc.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbdesc.SelectedItem, SupplierInfo)

        Litemcode = acc.SupplierNo
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
         dtgitemlist.Rows.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            Dim rCnt As Integer = dtgitemlist.RowCount - 2
            Dim a As Integer
            With dtgitemlist
                For a = 0 To rCnt
                    .Item(0, a).Value = 1
                Next a
            End With
        Else
            Dim rCnt As Integer = dtgitemlist.RowCount - 2
            Dim a As Integer
            With dtgitemlist
                For a = 0 To rCnt
                    .Item(0, a).Value = 0
                Next a
            End With
        End If
    End Sub
End Class