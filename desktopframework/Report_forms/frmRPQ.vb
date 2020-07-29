Imports WeifenLuo.WinFormsUI.Docking
Public Class frmRPQ
    Inherits DockContent
    Public rpqno As String
    Private Sub frmRPQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsRPQ.tbltrmain' table. You can move, or remove it, as needed.
        tbltrmainTableAdapter.Connection = conn
        Me.tbltrmainTableAdapter.Fill(Me.dtsRPQ.tbltrmain, rpqno)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class