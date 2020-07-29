Imports WeifenLuo.WinFormsUI.Docking
Public Class frmdelprint
    Inherits DockContent
    Private Sub frmdelprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class