Imports WeifenLuo.WinFormsUI.Docking
Public Class frmtempdr
    Inherits DockContent
    Private Sub frmtempdr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsitemlist.tbltempdr' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet1.tbldrreport' table. You can move, or remove it, as needed.
        Dim instance As DataSet = dtsitemlist
        instance.EnforceConstraints = False
        tbltempdrTableAdapter.Connection = conn
        'Me.tbldrreportTableAdapter.Fill(Me.DataSet1.tbldrreport, )
        Me.tbltempdrTableAdapter.Fill(Me.dtsitemlist.tbltempdr, tempdr)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class