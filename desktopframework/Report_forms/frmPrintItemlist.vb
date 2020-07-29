Imports WeifenLuo.WinFormsUI.Docking
Public Class frmPrintItemlist
    Inherits DockContent
    Private Sub frmPrintItemlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsitemlist.tblitemlist' table. You can move, or remove it, as needed.
        tblitemlistTableAdapter.Connection = conn
        Me.tblitemlistTableAdapter.Fill(Me.dtsitemlist.tblitemlist, "%" & itmmanufacturer & "%", "%" & itmcategory & "%", "%" & itmlistcode & "%")

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class