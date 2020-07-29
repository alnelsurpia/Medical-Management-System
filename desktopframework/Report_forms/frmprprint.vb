Imports WeifenLuo.WinFormsUI.Docking
Public Class frmprprint
    Inherits DockContent
    Public prnum As String
    Private Sub frmprprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsRPQ.tblprprint' table. You can move, or remove it, as needed.
        tblprprintTableAdapter.Connection = conn
        Me.tblprprintTableAdapter.Fill(Me.dtsRPQ.tblprprint, prnum)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class