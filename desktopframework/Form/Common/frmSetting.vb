Public Class frmSetting

    Private Sub cmdCPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCPassword.Click
        If cmdCPassword.Text = "Hide Password" Then
            Me.Width = 361
            Me.Height = 141
            cmdCPassword.Text = "Change Password"
        Else
            Me.Width = 361
            Me.Height = 304
            cmdCPassword.Text = "Hide Password"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        Try
            My.Settings.port = txtport.Text
            My.Settings.Save()
            If DBConnect(txtServerIP.Text) = True Then
                ServerIP = txtServerIP.Text
                'My.Settings.pRestricItemSupplier = cboRestric.Text
                'My.Settings.pRestrictWithD = CBool(CBWithdrawal.Text)
                'My.Settings.Save()
                ServerIP = txtServerIP.Text

                AddRegistry()
                My.Settings.port = txtport.Text
                'My.Settings.scheduler = txtscked.Text
                My.Settings.Save()
                MessageBox.Show("Success", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Successfully Connect to Server: ", "Connected server", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ServerIP = txtServerIP.Text
                'My.Settings.pRestricItemSupplier = cboRestric.Text
                'My.Settings.pRestrictWithD = CBool(CBWithdrawal.Text)
                My.Settings.Save()
                MessageBox.Show("Error Connecting to Server" + Chr(13) + "It will temporarily change the IP", "Cannot Connect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtServerIP.Select()
            End If
        Catch err As Exception
            MessageBox.Show("Error Ping Connection!", "Cannot Change IP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function DBConnect(ByVal strIP As String) As Boolean
        ConnectDatabase(strIP)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            Return True
        Else
            conn.Close()
            Return False
        End If
    End Function

    Private Sub cmdCaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCaccount.Click
        If My.Settings.username = txtoldUsername.Text And My.Settings.password = txtOldPassword.Text Then
            If txtNewPassword.Text <> "" Then
                conn.ConnectionString = "DATABASE=dbmiki;" _
                 & "SERVER=" & ServerIP & ";user id=" & My.Settings.username _
                 & ";password=" & txtNewPassword.Text & ";charset=utf8"
                Try
                    conn.Open()
                Catch myerror As MySql.Data.MySqlClient.MySqlException
                    MessageBox.Show("Error Changing Password: " & myerror.Message)
                Finally
                    My.Settings.password = txtNewPassword.Text
                    My.Settings.password = txtoldUsername.Text
                    My.Settings.Save()
                    txtoldUsername.Text = ""
                    txtOldPassword.Text = ""
                    txtNewPassword.Text = ""
                End Try
            Else
                MessageBox.Show("Empty Password not accepted!", "Cannot Change Accounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid Username and Password!", "Cannot Change Accounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtServerIP.Text = ServerIP
        txtport.Text = My.Settings.port
        ' txtscked.Text = My.Settings.scheduler
        'cboRestric.Text = My.Settings.pRestricItemSupplier
        'CBWithdrawal.Text = My.Settings.pRestrictWithD
    End Sub

    Private Sub txtServerIP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtServerIP.KeyDown
        If e.Control = True And e.KeyCode = Keys.Space Then
            'frmSetup.Show()
        End If
    End Sub

    Private Sub txtServerIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServerIP.TextChanged

    End Sub
End Class