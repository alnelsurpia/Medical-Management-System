Public Class frmcollection
    Dim clientno As String
    Private Sub frmcollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Collection' table. You can move, or remove it, as needed.
        populateclient()
        filter()
      
    End Sub
    Private Sub filter()
        CollectionTableAdapter.Connection = conn
        Me.CollectionTableAdapter.Fill(Me.DataSet1.Collection, dtpfrom.Text, dtpto.Text, "%" & clientno & "%")
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub populateclient()
        Dim strSELECT As String = "SELECT suppname,address,suppNO FROM tblclient "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbdesc.Items.Clear()
        Do While DReader.nelReader.Read
            cmbdesc.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub cmbdesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesc.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbdesc.SelectedItem, SupplierInfo)
        'cmbclientadd.Text = acc.SupplierNo
        clientno = acc.SupplierAddress
    End Sub

    Private Sub btnfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        Filter()
    End Sub
End Class