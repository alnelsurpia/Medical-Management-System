Module mdlpanel
    Public Sub EnablePanel(ByVal pnl As Panel, ByVal blvalue As Boolean)
        If P_StockOfficer = False Then
            pnl.Enabled = False
        Else
            pnl.Enabled = blvalue
        End If

    End Sub
End Module
