Public Class frmcogprint
    Private Sub frmcogprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbltrmainTableAdapter.Connection = conn
        Me.tbltrmainTableAdapter.Fill(Me.dtsassesmentslip.tbltrmain, assestr)
        txtcogTableAdapter.Connection = conn
        Me.txtcogTableAdapter.Fill(Me.dtslacking.txtcog, assestr)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class