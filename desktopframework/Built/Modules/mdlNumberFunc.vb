Module mdlNumberFunc
    Public Sub NumericValue(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = True Then
        Else
            If e.KeyChar = "." Then
            Else
                e.KeyChar = ""
            End If
        End If
    End Sub

    Public Function WholeNumber(ByVal strNum As String) As String
        On Error GoTo err
        Dim intDotLoc As Integer = strNum.IndexOf(".")
        strNum = strNum.Substring(0, intDotLoc)
        Return strNum
        Exit Function
err:
        Return "0"
    End Function


    'Public Sub NumericValue(ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If IsNumeric(e.KeyCode) = True Then
    '    Else
    '        If e.KeyCode = "." Then
    '        Else
    '            MessageBox.Show("Number Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End If
    'End Sub
End Module
