Public Class Statement

    Private Sub Statement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblstatement' table. You can move, or remove it, as needed.
        'cmbclientname.Text = 
        dtpfrom.Text = statfrm
        dtpto.Text = statto
        filter()
        populateclient()

    End Sub
    Private Sub populateclient()
        Dim strSELECT As String = "SELECT suppname,address,suppNO FROM tblclient "
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cmbclientname.Items.Clear()
        Do While DReader.nelReader.Read
            cmbclientname.Items.Add(New SupplierInfo(DReader.nelReader.Item(0).ToString, _
            DReader.nelReader.Item(1).ToString, DReader.nelReader.Item(2).ToString))
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub cmbclientname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclientname.SelectedIndexChanged
        Dim acc As SupplierInfo = CType(cmbclientname.SelectedItem, SupplierInfo)
        'cmbclientadd.Text = acc.SupplierNo
        statecno = acc.SupplierAddress
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        filter()
    End Sub
    Private Sub filter()
        'statfrm = ConvertWinToLinDate(statfrm)
        'statto = ConvertWinToLinDate(statto)
        tblstatementTableAdapter.Connection = conn
        Me.tblstatementTableAdapter.Fill(Me.DataSet1.tblstatement, statecno, dtpfrom.Text, dtpto.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class