Public Class frmmain

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Server IP: " & ServerIP & " Port: " & My.Settings.port.ToString & " Current User is: " & P_username
        frmLogin.Hide()
        'frmLogin.ShowDialog()
        'frmdelievery.Close()
        'frmdelievery.ShowDialog()
        frmstatus.Show(DockPanel1)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmitemlist.Close()
        frmitemlist.Show(DockPanel1)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'frmmanufacturerinfo.Close()
        frmmanufacturerinfo.Show(DockPanel1)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        'frmdelievery.Close()
        'frmdelievery.Show(DockPanel1)
        frmnewDR.Close()
        frmnewDR.Show(DockPanel1)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmPO.Close()
        frmPO.Show(DockPanel1)
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmrecieved.Close()
        frmrecieved.Show(DockPanel1)
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmclient.Close()
        frmclient.Show(DockPanel1)
    End Sub

    Private Sub DockPanel1_ActiveContentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DockPanel1.ActiveContentChanged

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmtrmain.Close()
        frmtrmain.Show(DockPanel1)
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        frmuploaded.Close()
        frmuploaded.Show(DockPanel1)
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        frmstatus.Close()
        frmstatus.Show()
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        frmOR.Close()
        frmOR.ShowDialog()
    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If ToolStripComboBox1.Text = "View Lacking Report" Then
            frmviewlacking.Close()
            frmviewlacking.Show(DockPanel1)
        ElseIf ToolStripComboBox1.Text = "Rebate slip" Then
            frmrebate.Close()
            frmrebate.Show(DockPanel1)
        ElseIf ToolStripComboBox1.Text = "COG" Then
            frmcog.Close()
            frmcog.Show(DockPanel1)
        End If
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        frmextra.Close()
        frmextra.Show()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        frmcristalreport.Show()
    End Sub
End Class