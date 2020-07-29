Imports WeifenLuo.WinFormsUI.Docking
Public Class frmpoclientreport
    Inherits DockContent
    Public ponum As String
    Private Sub frmpoclientreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsRPQ.tbltrmain' table. You can move, or remove it, as needed.
        Dim instance As DataSet = dtsRPQ
        instance.EnforceConstraints = False
        tbltrmainTableAdapter.Connection = conn
        Me.tbltrmainTableAdapter.Fill(Me.dtsRPQ.tbltrmain, ponum)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class