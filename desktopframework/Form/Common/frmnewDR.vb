Imports WeifenLuo.WinFormsUI.Docking
Public Class frmnewDR
    Inherits DockContent
    Private Sub frmnewDR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateCombo(cmbtrno, "Select trno from tbltrmain group by trno")
        PopulateCombo(txtdr, "Select drno from tbltempdr group by drno")
        PopulateCombo(cmbflterbox, "Select drno from tblchargenew group by drno")

        PopulateItem()
    End Sub
    Private Sub PopulateItem()
        dtgdrlist.Rows.Clear()
        Dim strSELECT As String = ""
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
                .Item(6, a).Value = DReader.nelReader.Item("lnbn")
                .Item(7, a).Value = DReader.nelReader.Item("expdate")
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
                .Item(14, a).Value = DReader.nelReader.Item("cpr")
                txtdr.Text = DReader.nelReader.Item("drno")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub chkselectall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselectall.CheckedChanged

    End Sub

    Private Sub chkselectall_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkselectall.Click
        If chkselectall.Checked = True Then
            Dim rCnt As Integer = dtgdrlist.RowCount - 1
            Dim a As Integer
            With dtgdrlist
                For a = 0 To rCnt
                    .Item(1, a).Value = 1
                Next a
            End With
        Else
            Dim rCnt As Integer = dtgdrlist.RowCount - 1
            Dim a As Integer
            With dtgdrlist
                For a = 0 To rCnt
                    .Item(1, a).Value = 0
                Next a
            End With
        End If
    End Sub

    Private Sub cmdapproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdapproved.Click
        checkdrifexsist()
        cmdapproved.Enabled = False
        If found = True Then
            Dim ans As Long = MessageBox.Show("This DR already exist wanna continue", "Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ans = vbYes Then
                If cmbtrno.Text <> "" And cmbtrno.Text <> " " Then
                    Try
                        deducttoinventory()
                        filterpk()
                        GroupBox1.Enabled = False
                        IDgeneratorSave("tempdr", gendr)
                        MessageBox.Show("SAVED!!!")
                        PopulateItem()
                    Catch
                        GroupBox1.Enabled = True
                        MessageBox.Show("there was an error")
                    End Try

                Else
                    ErrorProvider1.SetError(cmbtrno, "no Input")
                    Timer1.Enabled = True
                End If
            End If
        Else
            If cmbtrno.Text <> "" And cmbtrno.Text <> " " Then
                'Try
                deducttoinventory()
                filterpk()
                GroupBox1.Enabled = False
                IDgeneratorSave("tempdr", gendr)
                MessageBox.Show("SAVED!!!")
                PopulateItem()
                'Catch
                'GroupBox1.Enabled = True
                'End Try
            Else
                ErrorProvider1.SetError(cmbtrno, "no Input")
                Timer1.Enabled = True
            End If
        End If

      
    End Sub
    Dim found As Boolean = False
    Private Sub checkdrifexsist()
        Dim stocks As Double = 0
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbltempdr WHERE drno = '" & txtdr.Text & "'"
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
    Private Sub deducttoinventory()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgdrlist.RowCount - 1
        Dim a As Integer
        With dtgdrlist
            For a = 0 To rCnt
                Dim chkitm As Boolean = .Item(1, a).Value
                If chkitm = True Then
                    Dim itemcode As String = .Item(0, a).Value
                    Dim tqty As Double = .Item(8, a).Value
                    Dim tblunit As String = .Item(4, a).Value
                    'Dim units As Double = .Item(3, a).Value
                    Dim qtytomeet As Double = .Item(11, a).Value
                    If qtytomeet >= tqty Then
                        locatestocks(itemcode, tqty, tblunit)
                        updatetr(itemcode, tqty)
                    End If

                End If
            Next a
        End With
        Cursor = Cursors.Default
    End Sub
    Dim loaddrclick As Boolean = False
    Private Sub locatestocks(ByVal itemcode As String, ByVal qty As Double, ByVal tblunit As String)
        If loaddrclick = False Then
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
                        stocks = stocks - qty
                    Else
                        MessageBox.Show("Cant DR this " & shortdesc & " Insufecient Stocks")
                    End If
                Else
                    stocks = stocks * budleqty
                    If stocks >= qty Then
                        stocks = stocks - qty
                        stocks = stocks / budleqty
                    Else
                        MessageBox.Show("Cant DR this " & shortdesc & " Insufecient Stocks")
                    End If
                End If
            End If
            DReader.nelReader.Close()
            updateitmlist(itemcode, stocks, tblunit)
        End If
    End Sub
   
    Private Sub updateitmlist(ByVal itemcode As String, ByVal stocks As Double, ByVal tblunit As String)
        'Dim DReader As New DataClassReader
        'Dim totalaty As Double = stocks - tqty
        Dim dtData As New clsDataManipulation

        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tblitemlist WHERE itemcode ='" & itemcode & "'"
        dtData.strUpdate = "UPDATE tblitemlist SET stocks = '" & stocks & "'" _
            & " WHERE itemcode = '" & itemcode & "'"
        dtData.strAdd = "SELECT * FROM tblitemlist limit 1"
        dtData.Save()

    End Sub
    Private Sub updatetr(ByVal itemcode As String, ByVal tqty As Double)
        'Dim DReader As New DataClassReader
        Dim dtData As New clsDataManipulation

        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tbltrmain WHERE itemcode ='" & itemcode & "' and trno = '" & cmbtrno.Text & "'"
        dtData.strUpdate = "UPDATE tbltrmain SET drqty = drqty + '" & tqty & "',drno = '" & txtdr.Text & "'" _
            & " WHERE itemcode = '" & itemcode & "' and trno = '" & cmbtrno.Text & "'"
        dtData.strAdd = "SELECT * FROM tbltrmain limit 1"
        dtData.Save()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ErrorProvider1.Clear()
    End Sub
    'delete codes
    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        If txtdr.Text <> "" Then
            'deleteskedule()
            filterpk()
            tempdr = txtdr.Text
            frmtempdr.Close()
            frmtempdr.ShowDialog()
        Else
            MessageBox.Show("No DR Number")
        End If
    End Sub
    Private Sub deleteskedule()
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "DELETE FROM tbltempdr"
        dtData.strDELETE = "DELETE FROM tbltempdr"
        dtData.DELETE()
    End Sub
    Private Sub filterpk()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgdrlist.RowCount - 1
        Dim a As Integer
        Dim pk As String = ""
        Dim chk As Boolean = False
        With dtgdrlist
            For a = 0 To rCnt
                Dim chkitm As Boolean = .Item(1, a).Value
                If chkitm = True Then
                    Dim drqty As String = .Item(8, a).Value
                    Dim drdesc As String = .Item(3, a).Value
                    Dim drunit As String = .Item(4, a).Value
                    Dim dritemcode As String = .Item(0, a).Value
                    Dim drcpr As String = .Item(5, a).Value
                    Dim drlnbn As String = .Item(6, a).Value
                    Dim drexpdate As String = .Item(7, a).Value
                    Dim drunitprice As String = .Item(9, a).Value
                    Dim chkbxs As Boolean = .Item(1, a).Value
                    'Dim pk1 As String = .Item(0, a).Value
                    If chkbxs = True Then
                        savetitem(drqty, drdesc, drunit, dritemcode, drcpr, _
                                      drlnbn, drexpdate, drunitprice, txtsoldto.Text, _
                                      txtaddress.Text, dtpdrdate.Text)
                    End If
                End If
            Next a
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

        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = True
        dtData.strSELECT = "SELECT * FROM tbltempdr WHERE drno = '" & txtdr.Text & "' and prodcode = '" & dritemcode & "'"
        dtData.strUpdate = "UPDATE tbltempdr SET " _
            & " soldto = '" & txtsoldto.Text & "'," _
            & " address = '" & txtaddress.Text & "'," _
            & " prno = '" & lblpr.Text & "'," _
            & " trno = '" & lbltr.Text & "'," _
            & " pono = '" & lblpo.Text & "'," _
            & " qty = '" & drqty & "'," _
            & " drdate = '" & dtpdrdate.Text & "'," _
            & " drno = '" & txtdr.Text & "'," _
            & " description = '" & drdesc & "'," _
            & " unit = '" & drunit & "'," _
            & " prodcode = '" & dritemcode & "'," _
            & " cpr = '" & drcpr & "'," _
            & " lnbn = '" & drlnbn & "'," _
            & " expdate = '" & drexpdate & "'," _
            & " unitprice = '" & drunitprice & "',drgroupnum = '" & gendr & "'" _
            & " WHERE drno = '" & txtdr.Text & "' and prodcode = '" & dritemcode & "'"
        dtData.strAdd = "INSERT INTO tbltempdr " _
            & " (soldto,address,prno,trno,pono,qty,drdate," _
            & " drno,description,unit,prodcode,cpr,lnbn,expdate," _
            & " unitprice,drgroupnum) " _
            & " VALUES( '" & txtsoldto.Text & "'," _
            & " '" & txtaddress.Text & "'," _
            & " '" & lblpr.Text & "', " _
            & " '" & lbltr.Text & "'," _
            & " '" & lblpo.Text & "', " _
            & " '" & drqty & "', " _
            & " '" & dtpdrdate.Text & "'," _
            & " '" & txtdr.Text & "', " _
            & " '" & drdesc & "'," _
            & " '" & drunit & "', " _
            & " '" & dritemcode & "'," _
            & " '" & drcpr & "'," _
            & " '" & drlnbn & "'," _
            & " '" & drexpdate & "'," _
            & " '" & drunitprice & "','" & gendr & "')"
        dtData.Save()
    End Sub
    Private Sub savetotempdr()
        Cursor = Cursors.WaitCursor
        Dim rCnt As Integer = dtgdrlist.RowCount - 1
        Dim a As Integer
        With dtgdrlist
            For a = 0 To rCnt
                Dim itemcode As String = .Item(0, a).Value
                Dim tqty As Double = .Item(7, a).Value
                Dim itmqty As String = .Item(4, a).Value
                locatestocks(itemcode, tqty, itmqty)
                updatetr(itemcode, tqty)
            Next a
        End With
        Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfilter.Click
        PopulateItem()
    End Sub

    Private Sub dtgdrlist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgdrlist.CellContentClick

    End Sub

    Private Sub GradientPanelXP3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim gendr As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        GroupBox1.Enabled = True
        cmdapproved.Enabled = True
        gendr = IDgenerator("tempdr")
        loaddrclick = False
    End Sub

    Private Sub GradientPanelXP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientPanelXP1.Click

    End Sub

    Private Sub cmdfiltermain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfiltermain.Click
        PopulateItemmain()
    End Sub
    Private Sub PopulateItemmain()
        dtgdrmain.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbltempdr where drno like '%" & cmbflterbox.Text & "%' or soldto like '%" & cmbflterbox.Text & "%' group by drno order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgdrmain
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("drdate")
                .Item(1, a).Value = DReader.nelReader.Item("drno")
                .Item(2, a).Value = DReader.nelReader.Item("soldto")
                .Item(3, a).Value = DReader.nelReader.Item("trno")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub dtgdrmain_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgdrmain.CellClick
        With dtgdrmain.SelectedRows(0)
            txtdr.Text = .Cells(1).Value
            loadtempdr()
        End With
    End Sub

    Private Sub dtgdrmain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgdrmain.CellContentClick

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loadtempdr()
        loaddrclick = True
    End Sub
    Private Sub loadtempdr()
        dtgdrlist.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbltempdr where drno = '" & txtdr.Text & "' order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgdrlist
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("prodcode")
                .Item(2, a).Value = DReader.nelReader.Item("pk")
                .Item(3, a).Value = DReader.nelReader.Item("description")
                .Item(4, a).Value = DReader.nelReader.Item("unit")
                .Item(6, a).Value = DReader.nelReader.Item("lnbn")
                .Item(7, a).Value = DReader.nelReader.Item("expdate")
                .Item(8, a).Value = DReader.nelReader.Item("qty")
                .Item(9, a).Value = "0"
                .Item(10, a).Value = "0"
                '.Item(11, a).Value = Val(Replace(DReader.nelReader.Item("qty"), ",", "")) - Val(Replace(DReader.nelReader.Item("drqty"), ",", ""))
                lbltr.Text = DReader.nelReader.Item("trno")
                lblpr.Text = DReader.nelReader.Item("prno")
                lblpo.Text = DReader.nelReader.Item("pono")
                txtsoldto.Text = DReader.nelReader.Item("soldto")
                txtaddress.Text = DReader.nelReader.Item("address")
                'If Val(.Item(11, a).Value) > 0 Then
                '    .Item(12, a).Value = "Incomplete"
                'ElseIf Val(.Item(11, a).Value) <= 0 Then
                '    .Item(12, a).Value = "Complete"
                'End If
                .Item(13, a).Value = DReader.nelReader.Item("drno")
                txtdr.Text = DReader.nelReader.Item("drno")
                gendr = DReader.nelReader.Item("drgroupnum")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
End Class