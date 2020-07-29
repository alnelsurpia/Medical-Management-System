Module mdlComputations

    Public Function SumItUp(ByVal dtg As DataGridView, ByVal col As Integer) As String
        With dtg
            col = Replace(col, ",", "")
            Dim dblAmount As Double = 0
            Dim a As Integer = 0
            For a = 0 To .Rows.Count - 1
                Dim TempdblAmount As Double = Val(Replace(.Rows.Item(a).Cells(col).Value, ",", ""))
                dblAmount = dblAmount + TempdblAmount
            Next
            SumItUp = Math.Round(dblAmount, 2)
        End With
    End Function

    Public Function MultiItUp(ByVal dtg As DataGridView, ByVal col1 As Integer, ByVal col2 As Integer, ByVal colPlus As Integer) As String
        With dtg
            Dim dblAmount As Double = 0
            Dim a As Integer = 0
            For a = 0 To .Rows.Count - 1
                Dim TempdblAmount As Double = (Val(.Rows.Item(a).Cells(col1).Value) * (Val(.Rows.Item(a).Cells(col2).Value) + Val(.Rows.Item(a).Cells(colPlus).Value)))
                dblAmount = dblAmount + TempdblAmount
            Next
            MultiItUp = Math.Round(dblAmount, 2)
        End With
    End Function

End Module
