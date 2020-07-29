Imports WeifenLuo.WinFormsUI.Docking
Public Class frmimageprint
    Inherits DockContent
    Private Sub frmimageprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblimages' table. You can move, or remove it, as needed.
        tblimagesTableAdapter.Connection = conn
        Me.tblimagesTableAdapter.Fill(Me.DataSet1.tblimages, trimage)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class