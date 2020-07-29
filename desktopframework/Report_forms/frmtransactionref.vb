Imports WeifenLuo.WinFormsUI.Docking
Public Class frmtransactionref
    Inherits DockContent
    Private Sub frmtransactionref_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tblrebateTableAdapter.Connection = conn
        Me.tblrebateTableAdapter.Fill(Me.dtslacking.tblrebate, maintr)
        tbltrstausTableAdapter.Connection = conn
        Me.tbltrstausTableAdapter.Fill(Me.dtslacking.tbltrstaus, maintr)
        tbltransacDRTableAdapter.Connection = conn
        Me.tbltransacDRTableAdapter.Fill(Me.dtstransref.tbltransacDR, maintr)
        tbltrmainTableAdapter.Connection = conn
        Me.tbltrmainTableAdapter.Fill(Me.dtstransref.tbltrmain, maintr)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class