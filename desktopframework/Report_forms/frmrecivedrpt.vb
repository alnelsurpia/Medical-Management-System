Imports WeifenLuo.WinFormsUI.Docking
Public Class frmrecivedrpt
    Inherits DockContent
    Private Sub frmrecivedrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblrecieved' table. You can move, or remove it, as needed.
        filter()
    End Sub
    Private Sub filter()
        tblrecievedTableAdapter.Connection = conn
        Me.tblrecievedTableAdapter.Fill(Me.DataSet1.tblrecieved, receivedno)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class