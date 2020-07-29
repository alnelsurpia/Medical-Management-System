Public Class frmsalesrpt

    Private Sub frmsalesrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbldelievery' table. You can move, or remove it, as needed.
        filter()
    End Sub
    Private Sub filter()
        tbldelieveryTableAdapter.Connection = conn
        Me.tbldelieveryTableAdapter.Fill(Me.DataSet1.tbldelievery, dtpfrom.Text, dtpto.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        filter()
    End Sub
End Class