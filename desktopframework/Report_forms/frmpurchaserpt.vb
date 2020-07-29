Public Class frmpurchaserpt

    Private Sub frmpurchaserpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblpurchase' table. You can move, or remove it, as needed.
        tblpurchaseTableAdapter.Connection = conn
        Me.tblpurchaseTableAdapter.Fill(Me.DataSet1.tblpurchase, delieveryno)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class