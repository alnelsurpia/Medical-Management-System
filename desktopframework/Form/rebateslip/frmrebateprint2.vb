Imports WeifenLuo.WinFormsUI.Docking
Public Class frmrebateprint2
    Inherits DockContent
    Private Sub frmrebateprint2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsrebate.tblrebate' table. You can move, or remove it, as needed.

        tblrebateTableAdapter.Connection = conn
        Me.tblrebateTableAdapter.Fill(Me.dtsrebate.tblrebate, prtrebate)
        'Me.ReportViewer1.Size.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class