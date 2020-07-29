Public Class frmrecieveblebyclient

    Private Sub frmrecieveblebyclient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsitemlist.tbldelievery' table. You can move, or remove it, as needed.
        PopulateCombo(cmbclientsname, "Select suppname from tblclient group by suppNO")
        filter()
    End Sub
    Private Sub filter()
        tbldelieveryTableAdapter.Connection = conn
        Me.tbldelieveryTableAdapter.Fill(Me.dtsitemlist.tbldelievery, dtpfrom.Text, dtpto.Text, "%" & cmbclientsname.Text & "%")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        filter()
    End Sub
End Class