Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Module IPSettings
    Public ServerIP As String
    Sub AddRegistry()
        Try
            Using key As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("Software")
                key.DeleteSubKey("med\IP")
            End Using
        Catch ex As Exception
            'no existing key
        End Try
        Dim newKey As RegistryKey
        newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\med")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\med\IP", "ServerIP", "" + ServerIP)
        'refreshAdaptors()
    End Sub

    'Sub ChangeServerIP(ByVal tbladaptor As Object)
    '    Dim holder As String
    '    holder = "server=" + ServerIP + ";user id=inventory;persist security info=True;password=asdlkj;database=dbpos2a"
    '    tbladaptor.ConnectionString = holder
    'End Sub
    'Sub refreshAdaptors()
    '    'all table adaptors
    '    ChangeServerIP(frmAccountReceivable.tblAccountReceivableTableAdapter.Connection)
    '    ChangeServerIP(frmCashierSalesDetail.tblcustomerarticlesTableAdapter.Connection)
    '    ChangeServerIP(frmCollectionReport.tblcollectionreportTableAdapter.Connection)
    '    ChangeServerIP(frmCustomerStatement.tblstatementTableAdapter.Connection)
    '    ChangeServerIP(frmDailyTransactionReport.tblDailyTransactionTableAdapter.Connection)
    '    ChangeServerIP(frmDisposalReport.tbldisposalTableAdapter.Connection)
    '    ChangeServerIP(frmInventoryReportPrint.tblinventoryreportTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyCustomerDeliveryReport.tblMonthlyCustomerDeliveryTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyDefective.tbldefectiveMOnthlyTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyDeliveryReport.tblDeliveryMOnthlyTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyDisposalReport.tbldisposalMonthlyTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyPO.tblpomonthlyTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyPullout.tblpulloutmonthlyTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyReceived.tblreceivedMonthlyTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyReceived_P.tblreceived_PMonthlyTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlySalesReport.tblMonthlySalesReportTableAdapter.Connection)
    '    ChangeServerIP(frmMonthlyStockReturn.tbldisposalStockReturnMonthlyTableAdapter.Connection)
    '    ChangeServerIP(frmPOReport.tblpoTableAdapter.Connection)
    '    ChangeServerIP(frmPOReportNew.tblpoitemTableAdapter.Connection)
    '    ChangeServerIP(frmPOReportNew.tblpoNewTableAdapter.Connection)
    '    ChangeServerIP(frmPOWPendingRepots.tblpoPendingReportTableAdapter.Connection)
    '    ChangeServerIP(frmPulloutReport.tblpulloutTableAdapter.Connection)
    '    ChangeServerIP(frmPulloutwPendingReports.tblpulloutwpendingTableAdapter.Connection)
    '    ChangeServerIP(frmReceived_PReport.tblreceived_pTableAdapter.Connection)
    '    ChangeServerIP(frmReceivedReport.tblreceivedTableAdapter.Connection)
    '    ChangeServerIP(frmStockConvertionReport1.tblconvertionfromTableAdapter.Connection)
    '    ChangeServerIP(frmStockConvertionReport1.tblconvertiontoTableAdapter.Connection)
    '    ChangeServerIP(frmStockConvertionReport1.tblstockconvertionTableAdapter.Connection)
    '    ChangeServerIP(frmStockReturnReport.tblstockreturnTableAdapter.Connection)
    '    ChangeServerIP(frmSummarySalesReport.tblSummarySalesReportTableAdapter.Connection)
    '    ChangeServerIP(frmTransferReportPrint.tbltransferTableAdapter.Connection)
    '    ChangeServerIP(frmTry.tbldisposalMatriTableAdapter.Connection)
    'End Sub
End Module
