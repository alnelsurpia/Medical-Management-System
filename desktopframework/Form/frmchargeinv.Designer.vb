<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchargeinv
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtgdrlist = New System.Windows.Forms.DataGridView
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.c12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GradientPanelXP2 = New Lybra.Forms.Controls.GradientPanelXP
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkselectall = New System.Windows.Forms.CheckBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtcino = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpdrdate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmdprint = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbltr = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdapproved = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblpr = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbtrno = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmdfilter = New System.Windows.Forms.Button
        Me.lblpo = New System.Windows.Forms.Label
        Me.txtsoldto = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.cmdnew = New System.Windows.Forms.Button
        Me.GradientPanelXP3 = New Lybra.Forms.Controls.GradientPanelXP
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.cmbflterbox = New System.Windows.Forms.ComboBox
        Me.cmdfiltermain = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtgcimain = New System.Windows.Forms.DataGridView
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtdrs = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dtgdrlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanelXP2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GradientPanelXP1.SuspendLayout()
        CType(Me.dtgcimain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column6
        '
        Me.Column6.HeaderText = "cpr"
        Me.Column6.Name = "Column6"
        '
        'Column9
        '
        Me.Column9.HeaderText = "LNBN"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Expiration Date"
        Me.Column10.Name = "Column10"
        '
        'Column3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "0"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "QTY to DR"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "Unit"
        Me.Column8.Name = "Column8"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item Description"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 200
        '
        'dtgdrlist
        '
        Me.dtgdrlist.AllowUserToAddRows = False
        Me.dtgdrlist.AllowUserToDeleteRows = False
        Me.dtgdrlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgdrlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column11, Me.Column2, Me.Column8, Me.Column6, Me.Column9, Me.Column10, Me.Column3, Me.Column4, Me.Column5, Me.c12, Me.Column12, Me.Column13})
        Me.dtgdrlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgdrlist.Location = New System.Drawing.Point(0, 304)
        Me.dtgdrlist.Name = "dtgdrlist"
        Me.dtgdrlist.RowHeadersVisible = False
        Me.dtgdrlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgdrlist.Size = New System.Drawing.Size(1165, 141)
        Me.dtgdrlist.TabIndex = 8
        '
        'Column7
        '
        Me.Column7.HeaderText = "itemcode"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "[ ]"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 30
        '
        'Column11
        '
        Me.Column11.HeaderText = "pk"
        Me.Column11.Name = "Column11"
        Me.Column11.Visible = False
        '
        'Column4
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 120
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        '
        'c12
        '
        Me.c12.HeaderText = "Qty to be meet"
        Me.c12.Name = "c12"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Status"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "dr"
        Me.Column13.Name = "Column13"
        Me.Column13.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'GradientPanelXP2
        '
        Me.GradientPanelXP2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP2.Controls.Add(Me.GroupBox2)
        Me.GradientPanelXP2.Controls.Add(Me.chkselectall)
        Me.GradientPanelXP2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP2.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP2.Location = New System.Drawing.Point(0, 263)
        Me.GradientPanelXP2.Name = "GradientPanelXP2"
        Me.GradientPanelXP2.Size = New System.Drawing.Size(1165, 41)
        Me.GradientPanelXP2.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(134, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 34)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Note"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(390, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Please check the check box of the items you want to Charge."
        '
        'chkselectall
        '
        Me.chkselectall.AutoSize = True
        Me.chkselectall.BackColor = System.Drawing.Color.Transparent
        Me.chkselectall.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkselectall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkselectall.Location = New System.Drawing.Point(3, 17)
        Me.chkselectall.Name = "chkselectall"
        Me.chkselectall.Size = New System.Drawing.Size(85, 21)
        Me.chkselectall.TabIndex = 5
        Me.chkselectall.Text = "Select All"
        Me.chkselectall.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtcino)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpdrdate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(6, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 62)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DR Details"
        '
        'txtcino
        '
        Me.txtcino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcino.FormattingEnabled = True
        Me.txtcino.Location = New System.Drawing.Point(138, 30)
        Me.txtcino.Name = "txtcino"
        Me.txtcino.Size = New System.Drawing.Size(141, 28)
        Me.txtcino.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "DR Date"
        '
        'dtpdrdate
        '
        Me.dtpdrdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdrdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdrdate.Location = New System.Drawing.Point(7, 32)
        Me.dtpdrdate.Name = "dtpdrdate"
        Me.dtpdrdate.Size = New System.Drawing.Size(125, 26)
        Me.dtpdrdate.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Charge Invoice No."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 236)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "PO"
        '
        'cmdprint
        '
        Me.cmdprint.Location = New System.Drawing.Point(379, 57)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(79, 61)
        Me.cmdprint.TabIndex = 3
        Me.cmdprint.Text = "Print this selected on invoice"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "PR"
        '
        'lbltr
        '
        Me.lbltr.AutoSize = True
        Me.lbltr.BackColor = System.Drawing.Color.Transparent
        Me.lbltr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltr.ForeColor = System.Drawing.Color.Red
        Me.lbltr.Location = New System.Drawing.Point(84, 201)
        Me.lbltr.Name = "lbltr"
        Me.lbltr.Size = New System.Drawing.Size(18, 17)
        Me.lbltr.TabIndex = 15
        Me.lbltr.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "TR"
        '
        'cmdapproved
        '
        Me.cmdapproved.Location = New System.Drawing.Point(296, 84)
        Me.cmdapproved.Name = "cmdapproved"
        Me.cmdapproved.Size = New System.Drawing.Size(84, 34)
        Me.cmdapproved.TabIndex = 4
        Me.cmdapproved.Text = "&Save Charge"
        Me.cmdapproved.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Address"
        '
        'lblpr
        '
        Me.lblpr.AutoSize = True
        Me.lblpr.BackColor = System.Drawing.Color.Transparent
        Me.lblpr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpr.ForeColor = System.Drawing.Color.Red
        Me.lblpr.Location = New System.Drawing.Point(84, 218)
        Me.lblpr.Name = "lblpr"
        Me.lblpr.Size = New System.Drawing.Size(18, 17)
        Me.lblpr.TabIndex = 16
        Me.lblpr.Text = "--"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Charge to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "TR"
        '
        'cmbtrno
        '
        Me.cmbtrno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtrno.FormattingEnabled = True
        Me.cmbtrno.Location = New System.Drawing.Point(6, 20)
        Me.cmbtrno.Name = "cmbtrno"
        Me.cmbtrno.Size = New System.Drawing.Size(218, 28)
        Me.cmbtrno.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 17)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "TR Number"
        '
        'cmdfilter
        '
        Me.cmdfilter.Location = New System.Drawing.Point(230, 20)
        Me.cmdfilter.Name = "cmdfilter"
        Me.cmdfilter.Size = New System.Drawing.Size(75, 28)
        Me.cmdfilter.TabIndex = 2
        Me.cmdfilter.Text = "&Filter"
        Me.cmdfilter.UseVisualStyleBackColor = True
        '
        'lblpo
        '
        Me.lblpo.AutoSize = True
        Me.lblpo.BackColor = System.Drawing.Color.Transparent
        Me.lblpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpo.ForeColor = System.Drawing.Color.Red
        Me.lblpo.Location = New System.Drawing.Point(84, 236)
        Me.lblpo.Name = "lblpo"
        Me.lblpo.Size = New System.Drawing.Size(18, 17)
        Me.lblpo.TabIndex = 17
        Me.lblpo.Text = "--"
        '
        'txtsoldto
        '
        Me.txtsoldto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsoldto.Location = New System.Drawing.Point(80, 120)
        Me.txtsoldto.Name = "txtsoldto"
        Me.txtsoldto.Size = New System.Drawing.Size(247, 26)
        Me.txtsoldto.TabIndex = 10
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(80, 146)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(247, 26)
        Me.txtaddress.TabIndex = 11
        '
        'cmdnew
        '
        Me.cmdnew.Location = New System.Drawing.Point(296, 57)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(84, 28)
        Me.cmdnew.TabIndex = 18
        Me.cmdnew.Text = "&New"
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'GradientPanelXP3
        '
        Me.GradientPanelXP3.BackColor1 = System.Drawing.Color.Gray
        Me.GradientPanelXP3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP3.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP3.Location = New System.Drawing.Point(462, 21)
        Me.GradientPanelXP3.Name = "GradientPanelXP3"
        Me.GradientPanelXP3.Size = New System.Drawing.Size(2, 223)
        Me.GradientPanelXP3.TabIndex = 19
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GradientPanelXP1.Controls.Add(Me.cmbflterbox)
        Me.GradientPanelXP1.Controls.Add(Me.cmdfiltermain)
        Me.GradientPanelXP1.Controls.Add(Me.Label3)
        Me.GradientPanelXP1.Controls.Add(Me.dtgcimain)
        Me.GradientPanelXP1.Controls.Add(Me.txtdrs)
        Me.GradientPanelXP1.Controls.Add(Me.Label1)
        Me.GradientPanelXP1.Controls.Add(Me.GradientPanelXP3)
        Me.GradientPanelXP1.Controls.Add(Me.cmdnew)
        Me.GradientPanelXP1.Controls.Add(Me.txtaddress)
        Me.GradientPanelXP1.Controls.Add(Me.txtsoldto)
        Me.GradientPanelXP1.Controls.Add(Me.lblpo)
        Me.GradientPanelXP1.Controls.Add(Me.cmdfilter)
        Me.GradientPanelXP1.Controls.Add(Me.Label16)
        Me.GradientPanelXP1.Controls.Add(Me.cmbtrno)
        Me.GradientPanelXP1.Controls.Add(Me.Label7)
        Me.GradientPanelXP1.Controls.Add(Me.Label12)
        Me.GradientPanelXP1.Controls.Add(Me.lblpr)
        Me.GradientPanelXP1.Controls.Add(Me.Label11)
        Me.GradientPanelXP1.Controls.Add(Me.cmdapproved)
        Me.GradientPanelXP1.Controls.Add(Me.Label10)
        Me.GradientPanelXP1.Controls.Add(Me.lbltr)
        Me.GradientPanelXP1.Controls.Add(Me.Label9)
        Me.GradientPanelXP1.Controls.Add(Me.cmdprint)
        Me.GradientPanelXP1.Controls.Add(Me.Label17)
        Me.GradientPanelXP1.Controls.Add(Me.GroupBox1)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(1165, 263)
        Me.GradientPanelXP1.TabIndex = 6
        '
        'cmbflterbox
        '
        Me.cmbflterbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbflterbox.FormattingEnabled = True
        Me.cmbflterbox.Location = New System.Drawing.Point(591, 12)
        Me.cmbflterbox.Name = "cmbflterbox"
        Me.cmbflterbox.Size = New System.Drawing.Size(251, 28)
        Me.cmbflterbox.TabIndex = 28
        '
        'cmdfiltermain
        '
        Me.cmdfiltermain.Location = New System.Drawing.Point(848, 12)
        Me.cmdfiltermain.Name = "cmdfiltermain"
        Me.cmdfiltermain.Size = New System.Drawing.Size(31, 28)
        Me.cmdfiltermain.TabIndex = 27
        Me.cmdfiltermain.Text = "&..."
        Me.cmdfiltermain.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(471, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "CI No., Client No"
        '
        'dtgcimain
        '
        Me.dtgcimain.AllowUserToAddRows = False
        Me.dtgcimain.AllowUserToDeleteRows = False
        Me.dtgcimain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcimain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column14, Me.Column15, Me.Column16})
        Me.dtgcimain.Location = New System.Drawing.Point(470, 45)
        Me.dtgcimain.Name = "dtgcimain"
        Me.dtgcimain.ReadOnly = True
        Me.dtgcimain.RowHeadersVisible = False
        Me.dtgcimain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgcimain.Size = New System.Drawing.Size(409, 199)
        Me.dtgcimain.TabIndex = 25
        '
        'Column14
        '
        Me.Column14.HeaderText = "Date"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "CI no."
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "Client Name"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 200
        '
        'txtdrs
        '
        Me.txtdrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrs.Location = New System.Drawing.Point(80, 172)
        Me.txtdrs.Name = "txtdrs"
        Me.txtdrs.Size = New System.Drawing.Size(247, 26)
        Me.txtdrs.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "DR No's."
        '
        'frmchargeinv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 445)
        Me.Controls.Add(Me.dtgdrlist)
        Me.Controls.Add(Me.GradientPanelXP2)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmchargeinv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge Invioce"
        CType(Me.dtgdrlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanelXP2.ResumeLayout(False)
        Me.GradientPanelXP2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        CType(Me.dtgcimain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgdrlist As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GradientPanelXP2 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkselectall As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents GradientPanelXP3 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtsoldto As System.Windows.Forms.TextBox
    Friend WithEvents lblpo As System.Windows.Forms.Label
    Friend WithEvents cmdfilter As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbtrno As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblpr As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdapproved As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbltr As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcino As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpdrdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdrs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbflterbox As System.Windows.Forms.ComboBox
    Friend WithEvents cmdfiltermain As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtgcimain As System.Windows.Forms.DataGridView
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
