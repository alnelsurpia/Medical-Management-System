Imports WeifenLuo.WinFormsUI.Docking
Public Class frmstatus
    Inherits DockContent
    Private Sub frmstatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateCombo(cmbtrno, "Select trno from tbltrstaus group by trno")
        filterdate()
    End Sub
    Private Sub filterdate()
        Dim dfrom As String = dtpfrom.Text 'ConvertWinToLinDate(dtpfrom.Text)
        Dim dto As String = dtpto.Text 'ConvertWinToLinDate(dtpto.Text)
        Dim strSELECT As String
        strSELECT = "SELECT * FROM tbltrstaus where trno like '%" & cmbtrno.Text & "%' and (STR_TO_DATE(tdate," _
        & " '%m/%d/%Y') >='" & dfrom & "' AND STR_TO_DATE(tdate, '%m/%d/%Y') <='" & dto & "') order by trno"
        PopulateItem(strSELECT)
    End Sub
    Private Sub PopulateItem(ByVal statment As String)
        trstat.Rows.Clear()
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        strSELECT = statment
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With trstat
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("trno")
                .Item(1, a).Value = DReader.nelReader.Item("cname")
                .Item(2, a).Value = DReader.nelReader.Item("pr")
                .Item(3, a).Value = DReader.nelReader.Item("rpq")
                .Item(4, a).Value = DReader.nelReader.Item("po")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub cmdfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfilter.Click
        filterdate()
    End Sub

    Private Sub trstat_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles trstat.CellClick
        With trstat.SelectedRows(0)
            maintr = .Cells(0).Value
            assestr = .Cells(0).Value
            frmchargeinv.cmbtrno.Text = .Cells(0).Value
        End With
    End Sub

    Private Sub trstat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles trstat.CellContentClick

    End Sub

    Private Sub InputORDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputORDetailsToolStripMenuItem.Click
        frmOR.Close()
        frmOR.ShowDialog()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub IssueChargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueChargeToolStripMenuItem.Click
        frmchargeinv.Close()
        frmchargeinv.ShowDialog()
    End Sub

    Private Sub GenerateAssesmentSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateAssesmentSlipToolStripMenuItem.Click
        frmcogprint.Close()
        frmcogprint.Show()
    End Sub

    Private Sub GenerateTransactionSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateTransactionSlipToolStripMenuItem.Click
        'maintr = 
        frmtransactionref.Close()
        frmtransactionref.Show()
    End Sub
End Class