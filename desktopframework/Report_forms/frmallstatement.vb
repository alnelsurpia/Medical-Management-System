Imports WeifenLuo.WinFormsUI.Docking
Public Class frmallstatement
    Inherits DockContent
    Private Sub frmallstatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblallstatement' table. You can move, or remove it, as needed.
        tblallstatementTableAdapter.Connection = conn
        Me.tblallstatementTableAdapter.Fill(Me.DataSet1.tblallstatement, statecno, statfrm, statto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class