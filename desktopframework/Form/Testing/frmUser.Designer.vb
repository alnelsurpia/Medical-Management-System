<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtretype = New System.Windows.Forms.TextBox
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.GradientPanelXP2 = New Lybra.Forms.Controls.GradientPanelXP
        Me.Label4 = New System.Windows.Forms.Label
        Me.GradientPanelXP1.SuspendLayout()
        Me.GradientPanelXP2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.DialogResult = System.Windows.Forms.DialogResult.No
        Me.cmdSave.Location = New System.Drawing.Point(75, 140)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(81, 23)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdDelete.Location = New System.Drawing.Point(162, 140)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 1
        Me.cmdDelete.Text = "Delete"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(67, 22)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(257, 20)
        Me.txtUsername.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(67, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(67, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(67, 63)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(257, 20)
        Me.txtPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(67, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Retype"
        '
        'txtretype
        '
        Me.txtretype.Location = New System.Drawing.Point(67, 108)
        Me.txtretype.Name = "txtretype"
        Me.txtretype.Size = New System.Drawing.Size(257, 20)
        Me.txtretype.TabIndex = 7
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSearch.Location = New System.Drawing.Point(243, 140)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 9
        Me.cmdSearch.Text = "Search"
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP1.Controls.Add(Me.Label4)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(436, 31)
        Me.GradientPanelXP1.TabIndex = 10
        '
        'GradientPanelXP2
        '
        Me.GradientPanelXP2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP2.Controls.Add(Me.txtUsername)
        Me.GradientPanelXP2.Controls.Add(Me.cmdDelete)
        Me.GradientPanelXP2.Controls.Add(Me.cmdSearch)
        Me.GradientPanelXP2.Controls.Add(Me.cmdSave)
        Me.GradientPanelXP2.Controls.Add(Me.Label3)
        Me.GradientPanelXP2.Controls.Add(Me.Label1)
        Me.GradientPanelXP2.Controls.Add(Me.txtretype)
        Me.GradientPanelXP2.Controls.Add(Me.txtPassword)
        Me.GradientPanelXP2.Controls.Add(Me.Label2)
        Me.GradientPanelXP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanelXP2.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP2.Location = New System.Drawing.Point(0, 31)
        Me.GradientPanelXP2.Name = "GradientPanelXP2"
        Me.GradientPanelXP2.Size = New System.Drawing.Size(436, 206)
        Me.GradientPanelXP2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Username"
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 237)
        Me.Controls.Add(Me.GradientPanelXP2)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUser"
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        Me.GradientPanelXP2.ResumeLayout(False)
        Me.GradientPanelXP2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtretype As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GradientPanelXP2 As Lybra.Forms.Controls.GradientPanelXP
End Class
