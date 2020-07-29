Public Class frmOR

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        updatepr()
    End Sub
    Private Sub updatepr()
        Dim strtrno As String = maintr
        Dim dtData As New clsDataManipulation

        dtData.strSELECT = "SELECT * FROM tbltrstaus WHERE trno ='" & strtrno & "'"
        dtData.strUpdate = "UPDATE tbltrstaus SET " _
            & " ORno = '" & txtor.Text & "', ordate = '" & txtdate.Text & "',oramount = '" & txtoramount.Text & "',orstatus = '" & cmbstat.Text & "'," _
            & " chknumber = '" & txtcheckno.Text & "',checkd = '" & dtpchkdate.Text & "',checkamnt = '" & txtcheckamnt.Text & "',bankname = '" & cmbbank.Text & "'" _
            & " WHERE trno = '" & strtrno & "'"
        dtData.strAdd = "SELECT * FROM tbltrstaus"
        dtData.Save()
        MessageBox.Show("Saved")
    End Sub

    Private Sub frmOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdscan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscan.Click
        frmuploaded.Close()
        With frmuploaded
            .txttrno.Text = maintr
            .txttype.Text = "OR"
        End With
        frmuploaded.Show(frmmain.DockPanel1)
    End Sub

    Private Sub GradientPanelXP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientPanelXP1.Click

    End Sub
End Class