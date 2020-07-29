Imports WeifenLuo.WinFormsUI.Docking
Public Class frmci
    Inherits DockContent
    Public rpqci As String
    Private Sub frmci_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dtsRPQ.tblcino' table. You can move, or remove it, as needed.
        'Me.tblcinoTableAdapter.Fill(Me.dtsRPQ.tblcino)
        'TODO: This line of code loads data into the 'dtsRPQ.tbltrmain' table. You can move, or remove it, as needed.
        Dim instance As DataSet = dtsRPQ
        instance.EnforceConstraints = False
        tblcinoTableAdapter.Connection = conn
        Me.tblcinoTableAdapter.Fill(Me.dtsRPQ.tblcino, rpqci)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class