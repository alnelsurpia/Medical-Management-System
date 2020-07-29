Public Class frmrecievables

    Private Sub frmrecievables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateCombo(cmbclientsname, "Select suppname from tblclient group by suppNO")
        'TODO: This line of code loads data into the 'DataSet1.tblrecievables' table. You can move, or remove it, as needed.
        tblrecievablesTableAdapter.Connection = conn
        Me.tblrecievablesTableAdapter.Fill(Me.DataSet1.tblrecievables, dtpfrom.Text, dtpto.Text, "%" & cmbclientsname.Text & "%")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class