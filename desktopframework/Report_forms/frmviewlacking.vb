Imports WeifenLuo.WinFormsUI.Docking
Public Class frmviewlacking
    Inherits DockContent
    Private Sub frmviewlacking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtslacking.tbltrmain' table. You can move, or remove it, as needed.
        filter()
    End Sub

    Private Sub cmdfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfilter.Click
        filter()
    End Sub
    Private Sub filter()
        tbltrmainTableAdapter.Connection = conn
        Me.tbltrmainTableAdapter.Fill(Me.dtslacking.tbltrmain, dtpfrom.Text, dtpto.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class