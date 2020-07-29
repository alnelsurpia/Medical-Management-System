<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmuploaded
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmuploaded))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dtglistimg = New System.Windows.Forms.DataGridView
        Me.GradientPanelXP3 = New Lybra.Forms.Controls.GradientPanelXP
        Me.cmbprint = New Lybra.Forms.Controls.HoverGradientButton
        Me.cmbclose = New Lybra.Forms.Controls.HoverGradientButton
        Me.gpup = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.txttrno = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttype = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.cmdok = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbsearch = New Lybra.Forms.Controls.HoverGradientButton
        Me.cmdaddnew = New Lybra.Forms.Controls.HoverGradientButton
        Me.GradientPanelXP2 = New Lybra.Forms.Controls.GradientPanelXP
        Me.primage = New System.Windows.Forms.PictureBox
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtglistimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanelXP3.SuspendLayout()
        Me.gpup.SuspendLayout()
        Me.GradientPanelXP2.SuspendLayout()
        CType(Me.primage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtglistimg)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GradientPanelXP3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GradientPanelXP2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1238, 538)
        Me.SplitContainer1.SplitterDistance = 347
        Me.SplitContainer1.TabIndex = 1
        '
        'dtglistimg
        '
        Me.dtglistimg.AllowUserToAddRows = False
        Me.dtglistimg.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtglistimg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtglistimg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistimg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Type, Me.Column1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtglistimg.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtglistimg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglistimg.Location = New System.Drawing.Point(0, 197)
        Me.dtglistimg.Name = "dtglistimg"
        Me.dtglistimg.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtglistimg.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtglistimg.RowHeadersVisible = False
        Me.dtglistimg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtglistimg.Size = New System.Drawing.Size(347, 341)
        Me.dtglistimg.TabIndex = 2
        '
        'GradientPanelXP3
        '
        Me.GradientPanelXP3.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP3.Controls.Add(Me.cmbprint)
        Me.GradientPanelXP3.Controls.Add(Me.cmbclose)
        Me.GradientPanelXP3.Controls.Add(Me.gpup)
        Me.GradientPanelXP3.Controls.Add(Me.cmbsearch)
        Me.GradientPanelXP3.Controls.Add(Me.cmdaddnew)
        Me.GradientPanelXP3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP3.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP3.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP3.Name = "GradientPanelXP3"
        Me.GradientPanelXP3.Size = New System.Drawing.Size(347, 197)
        Me.GradientPanelXP3.TabIndex = 1
        '
        'cmbprint
        '
        Me.cmbprint.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cmbprint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmbprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbprint.Location = New System.Drawing.Point(139, 3)
        Me.cmbprint.Name = "cmbprint"
        Me.cmbprint.Size = New System.Drawing.Size(70, 33)
        Me.cmbprint.TabIndex = 6
        Me.cmbprint.Text = "Print"
        '
        'cmbclose
        '
        Me.cmbclose.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cmbclose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmbclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclose.Location = New System.Drawing.Point(213, 3)
        Me.cmbclose.Name = "cmbclose"
        Me.cmbclose.Size = New System.Drawing.Size(87, 33)
        Me.cmbclose.TabIndex = 5
        Me.cmbclose.Text = "Close"
        '
        'gpup
        '
        Me.gpup.BackColor = System.Drawing.Color.Transparent
        Me.gpup.Controls.Add(Me.Button2)
        Me.gpup.Controls.Add(Me.cmdsave)
        Me.gpup.Controls.Add(Me.txttrno)
        Me.gpup.Controls.Add(Me.Label3)
        Me.gpup.Controls.Add(Me.Label2)
        Me.gpup.Controls.Add(Me.txttype)
        Me.gpup.Controls.Add(Me.Label1)
        Me.gpup.Controls.Add(Me.txtdescription)
        Me.gpup.Controls.Add(Me.cmdok)
        Me.gpup.Controls.Add(Me.Button1)
        Me.gpup.Location = New System.Drawing.Point(3, 45)
        Me.gpup.Name = "gpup"
        Me.gpup.Size = New System.Drawing.Size(316, 149)
        Me.gpup.TabIndex = 3
        Me.gpup.TabStop = False
        Me.gpup.Text = "Upload"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button2.BackgroundImage = Global.desktopframework.My.Resources.Resources.eraser
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(267, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(83, 120)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 9
        Me.cmdsave.Text = "&Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'txttrno
        '
        Me.txttrno.FormattingEnabled = True
        Me.txttrno.Items.AddRange(New Object() {"TR", "PR", "PO", "RPQ", "Bill Of Quantity", "Disbursement Voucher", "Production Delivery Schedule"})
        Me.txttrno.Location = New System.Drawing.Point(12, 35)
        Me.txttrno.Name = "txttrno"
        Me.txttrno.Size = New System.Drawing.Size(112, 21)
        Me.txttrno.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Type"
        '
        'txttype
        '
        Me.txttype.FormattingEnabled = True
        Me.txttype.Items.AddRange(New Object() {"TR", "PR", "PO", "RPQ", "Bill Of Quantity", "Disbursement Voucher", "Production Delivery Schedule", "OR"})
        Me.txttype.Location = New System.Drawing.Point(130, 35)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(180, 21)
        Me.txttype.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TR Number"
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(12, 75)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(298, 40)
        Me.txtdescription.TabIndex = 3
        '
        'cmdok
        '
        Me.cmdok.Location = New System.Drawing.Point(159, 120)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(75, 23)
        Me.cmdok.TabIndex = 1
        Me.cmdok.Text = "Upload"
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(235, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbsearch
        '
        Me.cmbsearch.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cmbsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmbsearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmbsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsearch.Image = Global.desktopframework.My.Resources.Resources.sd
        Me.cmbsearch.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbsearch.Location = New System.Drawing.Point(74, 3)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(61, 33)
        Me.cmbsearch.TabIndex = 2
        Me.cmbsearch.Text = "Search"
        Me.cmbsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmbsearch.TextQuality = Lybra.Forms.Controls.LybraEnums.TextRendering.ClearType
        '
        'cmdaddnew
        '
        Me.cmdaddnew.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cmdaddnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdaddnew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdaddnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaddnew.Image = Global.desktopframework.My.Resources.Resources.upload
        Me.cmdaddnew.Location = New System.Drawing.Point(3, 3)
        Me.cmdaddnew.Name = "cmdaddnew"
        Me.cmdaddnew.Size = New System.Drawing.Size(68, 33)
        Me.cmdaddnew.TabIndex = 1
        Me.cmdaddnew.Text = "Upload"
        Me.cmdaddnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GradientPanelXP2
        '
        Me.GradientPanelXP2.AutoScroll = True
        Me.GradientPanelXP2.BackColor1 = System.Drawing.Color.Transparent
        Me.GradientPanelXP2.BackColor2 = System.Drawing.Color.Transparent
        Me.GradientPanelXP2.BackgroundImage = Global.desktopframework.My.Resources.Resources.noimage3
        Me.GradientPanelXP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GradientPanelXP2.Controls.Add(Me.primage)
        Me.GradientPanelXP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanelXP2.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP2.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP2.Name = "GradientPanelXP2"
        Me.GradientPanelXP2.Size = New System.Drawing.Size(887, 538)
        Me.GradientPanelXP2.TabIndex = 1
        '
        'primage
        '
        Me.primage.BackColor = System.Drawing.Color.Transparent
        Me.primage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.primage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primage.Location = New System.Drawing.Point(0, 0)
        Me.primage.Name = "primage"
        Me.primage.Size = New System.Drawing.Size(887, 538)
        Me.primage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.primage.TabIndex = 0
        Me.primage.TabStop = False
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(1238, 28)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "TR #"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "Description"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 250
        '
        'frmuploaded
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1238, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmuploaded"
        Me.TabText = "Uploaded"
        Me.Text = "Uploaded"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtglistimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanelXP3.ResumeLayout(False)
        Me.gpup.ResumeLayout(False)
        Me.gpup.PerformLayout()
        Me.GradientPanelXP2.ResumeLayout(False)
        CType(Me.primage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GradientPanelXP2 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents primage As System.Windows.Forms.PictureBox
    Friend WithEvents dtglistimg As System.Windows.Forms.DataGridView
    Friend WithEvents GradientPanelXP3 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents gpup As System.Windows.Forms.GroupBox
    Friend WithEvents cmbsearch As Lybra.Forms.Controls.HoverGradientButton
    Friend WithEvents cmdaddnew As Lybra.Forms.Controls.HoverGradientButton
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbclose As Lybra.Forms.Controls.HoverGradientButton
    Friend WithEvents cmbprint As Lybra.Forms.Controls.HoverGradientButton
    Friend WithEvents txttrno As System.Windows.Forms.ComboBox
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
