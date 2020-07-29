Module mdlUtilities
    Public Sub HighLightTextBox(ByVal txt As TextBox)
        txt.Select(0, txt.Text.Length - 1)
    End Sub
End Module
