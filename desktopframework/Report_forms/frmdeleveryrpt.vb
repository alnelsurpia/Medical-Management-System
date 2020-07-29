Imports WeifenLuo.WinFormsUI.Docking
Public Class frmdeleveryrpt
    Inherits DockContent
    Public delnumb As String
    Private Sub frmdeleveryrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblpurchase' table. You can move, or remove it, as needed.
        tblpurchaseTableAdapter.Connection = conn
        Me.tblpurchaseTableAdapter.Fill(Me.DataSet1.tblpurchase, delnumb)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class