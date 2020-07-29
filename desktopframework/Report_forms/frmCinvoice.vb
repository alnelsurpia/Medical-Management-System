Public Class frmCinvoice

    Private Sub frmCinvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblchargenew' table. You can move, or remove it, as needed.
        tblchargenewTableAdapter.Connection = conn
        Me.tblchargenewTableAdapter.Fill(Me.DataSet1.tblchargenew, CHinvoiceno)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class