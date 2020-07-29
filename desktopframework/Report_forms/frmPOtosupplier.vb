Imports WeifenLuo.WinFormsUI.Docking
Public Class frmPOtosupplier
    Inherits DockContent
    Public potosupp As String = ""
    Private Sub frmPOtosupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtspotoclient.tblpo' table. You can move, or remove it, as needed.
        Dim instance As DataSet = dtspotoclient
        instance.EnforceConstraints = False
        tblpoTableAdapter.Connection = conn
        Me.tblpoTableAdapter.Fill(Me.dtspotoclient.tblpo, potosupp)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class