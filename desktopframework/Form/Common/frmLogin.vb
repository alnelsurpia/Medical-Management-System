Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        Dim F2 As New frmSetting()
        F2.ShowDialog(Me)
    End Sub


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        StartInventory()
    End Sub
    Private Sub StartInventory()
        ConnectDatabase()
        Dim catCMD As MySqlCommand
        Dim strPassword As String
        Dim myReader As MySqlDataReader

        Try
            catCMD = conn.CreateCommand()
            catCMD.CommandText = "SELECT username,password,restirction,userno " _
            & " FROM tblusers WHERE username='" & UsernameTextBox.Text & "'"
            myReader = catCMD.ExecuteReader
        Catch myerror As ArgumentException    'MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
            Exit Sub
            '    'Finally
            '    '    MessageBox.Show("Disposed: ")
            '    '    conn.Dispose()
        End Try

        If myReader.Read() Then
            strPassword = myReader.Item(1).ToString
            userno = myReader.Item(3).ToString
            'P_ReportAccess = myReader.Item(2).ToString
            If strPassword = PasswordTextBox.Text Then
                myReader.Close()
               
                P_ServerDate = GetServerDate()
                P_ServerTime = GetServerTime()
                P_username = UsernameTextBox.Text
               
                ActionLog("System Opened", Me.Text)
                frmmain.Show()
                Me.Hide()


            Else
                MessageBox.Show("Invalid Password", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PasswordTextBox.Text = ""
                PasswordTextBox.Select()
            End If
            myReader.Close()
        Else
            MessageBox.Show("Invalid Username", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UsernameTextBox.Text = ""
            UsernameTextBox.Select()
        End If
        myReader.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            StartInventory()
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim keyValue As String
            keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\med\IP", "ServerIP", "")
            If keyValue = "" Then
                keyValue = "localhost"
            End If
            ServerIP = keyValue
        Catch

        End Try
    End Sub
End Class
