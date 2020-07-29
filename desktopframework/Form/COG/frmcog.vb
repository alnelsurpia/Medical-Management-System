Imports WeifenLuo.WinFormsUI.Docking
Public Class frmcog
    Inherits DockContent
    Private Sub frmcog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub
    Private Sub populateitems()
        dtgcog.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM txtcog where trno = '" & cmbtrno.Text & "' "
        tabled(strSELECT)
    End Sub
    Private Sub tabled(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgcog
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = DReader.nelReader.Item("trno")
                .Item(2, a).Value = DReader.nelReader.Item("tdate")
                .Item(3, a).Value = DReader.nelReader.Item("ttype")
                .Item(4, a).Value = DReader.nelReader.Item("description")
                .Item(5, a).Value = FormatNumber(DReader.nelReader.Item("amount"))
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        save()
        populateitems()
        clear()
        popdtgmain()
    End Sub
  
    Private Sub popdtgmain()
        Dim dfrom As String = ConvertWinToLinDate(dtpfrom.Text)
        Dim dto As String = ConvertWinToLinDate(dtpto.Text)
        dtgmain.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM txtcog where (STR_TO_DATE(tdate," _
           & " '%m/%d/%Y') >='" & dfrom & "' AND STR_TO_DATE(tdate, '%m/%d/%Y') <='" & dto & "') group by trno order by pk asc"
        'SELECT * FROM tblpo where (STR_TO_DATE(tdate," _
        '   & " '%m/%d/%Y') >='" & dfrom & "' AND STR_TO_DATE(tdate, '%m/%d/%Y') <='" & dto & "') group by pono order by pono asc

        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgmain
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("tdate")
                .Item(1, a).Value = DReader.nelReader.Item("trno")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub
    Private Sub clear()
        txtpk.Text = ""
        'cmbtrno.Text = ""
        dtpdate.Text = Now.ToString
        cmbtype.Text = ""
        cmbdesc.Text = ""
        txtamount.Text = "0"
        PopulateCombo(cmbtrno, "select trno from tbltrmain group by trno")
    End Sub
    Private Sub save()
        If cmbtrno.Text <> "" Then
            Dim strtrno As String = txtpk.Text
            Dim dtData As New clsDataManipulation
            'Dim rebateapplied As String = "." & txtapprebate.Text

            dtData.strSELECT = "SELECT * FROM txtcog WHERE pk ='" & strtrno & "'"
            dtData.strUpdate = "UPDATE txtcog SET " _
                & " trno ='" & Replace(cmbtrno.Text, ",", "") & "'," _
                & " tdate = '" & dtpdate.Text & "', " _
                & " ttype = '" & cmbtype.Text & "'," _
                & " description = '" & cmbdesc.Text & "', " _
                & " amount ='" & txtamount.Text & "'" _
                & " WHERE pk ='" & strtrno & "'"
            dtData.strAdd = "INSERT INTO txtcog " _
                & " (trno, " _
                & " tdate," _
                & " description, " _
                & " amount, " _
                & " ttype) " _
                & " VALUES('" & Replace(cmbtrno.Text, ",", "") & "'," _
                & " '" & dtpdate.Text & "'," _
                & " '" & cmbdesc.Text & "', " _
                & " '" & txtamount.Text & "', " _
                & " '" & cmbtype.Text & "')"
            dtData.Save()
        End If
        
    End Sub
    Private Sub cmbtrno_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtrno.SelectedValueChanged
        populateitems()
    End Sub

    Private Sub dtgcog_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgcog.CellClick
        With dtgcog.SelectedRows(0)
            txtpk.Text = .Cells(0).Value
            cmbtrno.Text = .Cells(1).Value
            dtpdate.Text = .Cells(2).Value
            cmbtype.Text = .Cells(3).Value
            cmbdesc.Text = .Cells(4).Value
            txtamount.Text = .Cells(5).Value
        End With
    End Sub

    Private Sub dtgcog_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgcog.CellContentClick

    End Sub

    Private Sub cmdfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfilter.Click
        popdtgmain()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        assestr = cmbtrno.Text
        frmcogprint.Close()
        frmcogprint.Show()
    End Sub
End Class