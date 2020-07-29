Imports WeifenLuo.WinFormsUI.Docking
Public Class frmtrprint
    Inherits DockContent
    Public trnum As String
    Private Sub frmtrprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsRPQ.tbltrprint' table. You can move, or remove it, as needed.
        tbltrprintTableAdapter.Connection = conn
        Me.tbltrprintTableAdapter.Fill(Me.dtsRPQ.tbltrprint, trnum)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class