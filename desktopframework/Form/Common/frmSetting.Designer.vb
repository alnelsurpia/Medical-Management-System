<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServerIP = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.txtoldUsername = New System.Windows.Forms.TextBox
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdCaccount = New System.Windows.Forms.Button
        Me.cmdChange = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdCPassword = New System.Windows.Forms.Button
        Me.cboRestric = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtport = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CBWithdrawal = New System.Windows.Forms.ComboBox
        Me.lblV = New System.Windows.Forms.Label
        Me.GradientPanelXP1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server IP:"
        '
        'txtServerIP
        '
        Me.txtServerIP.Location = New System.Drawing.Point(30, 22)
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.Size = New System.Drawing.Size(160, 20)
        Me.txtServerIP.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(43, 156)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(77, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Old Username:"
        '
        'txtoldUsername
        '
        Me.txtoldUsername.Location = New System.Drawing.Point(123, 149)
        Me.txtoldUsername.Name = "txtoldUsername"
        Me.txtoldUsername.Size = New System.Drawing.Size(192, 20)
        Me.txtoldUsername.TabIndex = 3
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(123, 175)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtOldPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Old Password:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(123, 201)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtNewPassword.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "New Password:"
        '
        'cmdCaccount
        '
        Me.cmdCaccount.Location = New System.Drawing.Point(107, 242)
        Me.cmdCaccount.Name = "cmdCaccount"
        Me.cmdCaccount.Size = New System.Drawing.Size(171, 23)
        Me.cmdCaccount.TabIndex = 10
        Me.cmdCaccount.Text = "Change Password Account"
        Me.cmdCaccount.UseVisualStyleBackColor = True
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(30, 52)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(73, 27)
        Me.cmdChange.TabIndex = 11
        Me.cmdChange.Text = "&Change IP"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(221, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 27)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdCPassword
        '
        Me.cmdCPassword.Location = New System.Drawing.Point(109, 52)
        Me.cmdCPassword.Name = "cmdCPassword"
        Me.cmdCPassword.Size = New System.Drawing.Size(106, 27)
        Me.cmdCPassword.TabIndex = 13
        Me.cmdCPassword.Text = "&Change Password"
        Me.cmdCPassword.UseVisualStyleBackColor = True
        '
        'cboRestric
        '
        Me.cboRestric.FormattingEnabled = True
        Me.cboRestric.Items.AddRange(New Object() {"False", "True"})
        Me.cboRestric.Location = New System.Drawing.Point(30, 139)
        Me.cboRestric.Name = "cboRestric"
        Me.cboRestric.Size = New System.Drawing.Size(177, 21)
        Me.cboRestric.TabIndex = 14
        Me.cboRestric.Text = "False"
        Me.cboRestric.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Restric Item Supplier"
        Me.Label5.Visible = False
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.Green
        Me.GradientPanelXP1.Controls.Add(Me.Label7)
        Me.GradientPanelXP1.Controls.Add(Me.txtport)
        Me.GradientPanelXP1.Controls.Add(Me.Button2)
        Me.GradientPanelXP1.Controls.Add(Me.cmdCPassword)
        Me.GradientPanelXP1.Controls.Add(Me.cmdChange)
        Me.GradientPanelXP1.Controls.Add(Me.cboRestric)
        Me.GradientPanelXP1.Controls.Add(Me.Label5)
        Me.GradientPanelXP1.Controls.Add(Me.Label6)
        Me.GradientPanelXP1.Controls.Add(Me.CBWithdrawal)
        Me.GradientPanelXP1.Controls.Add(Me.lblV)
        Me.GradientPanelXP1.Controls.Add(Me.Label1)
        Me.GradientPanelXP1.Controls.Add(Me.txtServerIP)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(329, 84)
        Me.GradientPanelXP1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(193, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Port Number"
        '
        'txtport
        '
        Me.txtport.Location = New System.Drawing.Point(196, 22)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(98, 20)
        Me.txtport.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Restric Item Withdrawal"
        Me.Label6.Visible = False
        '
        'CBWithdrawal
        '
        Me.CBWithdrawal.FormattingEnabled = True
        Me.CBWithdrawal.Items.AddRange(New Object() {"False", "True"})
        Me.CBWithdrawal.Location = New System.Drawing.Point(30, 98)
        Me.CBWithdrawal.Name = "CBWithdrawal"
        Me.CBWithdrawal.Size = New System.Drawing.Size(177, 21)
        Me.CBWithdrawal.TabIndex = 16
        Me.CBWithdrawal.Text = "False"
        Me.CBWithdrawal.Visible = False
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.BackColor = System.Drawing.Color.Transparent
        Me.lblV.Location = New System.Drawing.Point(3, 145)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(42, 13)
        Me.lblV.TabIndex = 14
        Me.lblV.Text = "Version"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 84)
        Me.Controls.Add(Me.cmdCaccount)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtoldUsername)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection Settings"
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServerIP As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents txtoldUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdCaccount As System.Windows.Forms.Button
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdCPassword As System.Windows.Forms.Button
    Friend WithEvents cboRestric As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBWithdrawal As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtport As System.Windows.Forms.TextBox
End Class
