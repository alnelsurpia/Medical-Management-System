Imports WeifenLuo.WinFormsUI.Docking
Public Class frmcollected
    Inherits DockContent
    Private Sub frmstatement2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblcollected' table. You can move, or remove it, as needed.
        tblcollectedTableAdapter.Connection = conn
        Me.tblcollectedTableAdapter.Fill(Me.DataSet1.tblcollected, statecno, statfrm, statto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class