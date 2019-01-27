<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtPD = New System.Windows.Forms.TextBox()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPA = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pnlDatosProd = New System.Windows.Forms.Panel()
        Me.txtSM = New System.Windows.Forms.TextBox()
        Me.txtSuperficie = New System.Windows.Forms.TextBox()
        Me.txtAncho = New System.Windows.Forms.TextBox()
        Me.lslSuperficie = New System.Windows.Forms.Label()
        Me.lblSM = New System.Windows.Forms.Label()
        Me.txtAlto = New System.Windows.Forms.TextBox()
        Me.lblAncho = New System.Windows.Forms.Label()
        Me.lblAlto = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.cbTipoPlancha = New System.Windows.Forms.ComboBox()
        Me.lblTipoPL = New System.Windows.Forms.Label()
        Me.cbColores = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEspesor = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblEspesor = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbTemplados = New System.Windows.Forms.RadioButton()
        Me.rbPlanchas = New System.Windows.Forms.RadioButton()
        Me.rbPerfiles = New System.Windows.Forms.RadioButton()
        Me.rbHerrajes = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlDatosProd.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1247, 57)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(357, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANTENIMIENTO  PRODUCTOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgvProductos)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(25, 572)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(9, 11, 9, 11)
        Me.GroupBox1.Size = New System.Drawing.Size(1194, 393)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos Guardados"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvProductos.Location = New System.Drawing.Point(9, 31)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1176, 351)
        Me.dgvProductos.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.pnlDatosProd)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(25, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(9, 11, 9, 11)
        Me.GroupBox2.Size = New System.Drawing.Size(1194, 335)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS PRODUCTO"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtPD)
        Me.Panel6.Controls.Add(Me.txtPC)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.txtPB)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.txtPA)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Location = New System.Drawing.Point(33, 241)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1135, 66)
        Me.Panel6.TabIndex = 6
        '
        'txtPD
        '
        Me.txtPD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPD.Location = New System.Drawing.Point(940, 14)
        Me.txtPD.Name = "txtPD"
        Me.txtPD.Size = New System.Drawing.Size(171, 27)
        Me.txtPD.TabIndex = 12
        Me.txtPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPC
        '
        Me.txtPC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPC.Location = New System.Drawing.Point(669, 14)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(171, 27)
        Me.txtPC.TabIndex = 11
        Me.txtPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(846, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 20)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Precio D"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(582, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Precio C"
        '
        'txtPB
        '
        Me.txtPB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPB.Location = New System.Drawing.Point(386, 14)
        Me.txtPB.Name = "txtPB"
        Me.txtPB.Size = New System.Drawing.Size(171, 27)
        Me.txtPB.TabIndex = 10
        Me.txtPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(300, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Precio B"
        '
        'txtPA
        '
        Me.txtPA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPA.Location = New System.Drawing.Point(105, 14)
        Me.txtPA.Name = "txtPA"
        Me.txtPA.Size = New System.Drawing.Size(171, 27)
        Me.txtPA.TabIndex = 9
        Me.txtPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(15, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 20)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Precio A"
        '
        'pnlDatosProd
        '
        Me.pnlDatosProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDatosProd.Controls.Add(Me.txtSM)
        Me.pnlDatosProd.Controls.Add(Me.txtSuperficie)
        Me.pnlDatosProd.Controls.Add(Me.txtAncho)
        Me.pnlDatosProd.Controls.Add(Me.lslSuperficie)
        Me.pnlDatosProd.Controls.Add(Me.lblSM)
        Me.pnlDatosProd.Controls.Add(Me.txtAlto)
        Me.pnlDatosProd.Controls.Add(Me.lblAncho)
        Me.pnlDatosProd.Controls.Add(Me.lblAlto)
        Me.pnlDatosProd.Location = New System.Drawing.Point(33, 167)
        Me.pnlDatosProd.Name = "pnlDatosProd"
        Me.pnlDatosProd.Size = New System.Drawing.Size(1135, 58)
        Me.pnlDatosProd.TabIndex = 5
        Me.pnlDatosProd.Visible = False
        '
        'txtSM
        '
        Me.txtSM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSM.Location = New System.Drawing.Point(881, 12)
        Me.txtSM.Name = "txtSM"
        Me.txtSM.Size = New System.Drawing.Size(234, 27)
        Me.txtSM.TabIndex = 8
        Me.txtSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSuperficie
        '
        Me.txtSuperficie.Enabled = False
        Me.txtSuperficie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuperficie.Location = New System.Drawing.Point(650, 12)
        Me.txtSuperficie.Name = "txtSuperficie"
        Me.txtSuperficie.Size = New System.Drawing.Size(106, 27)
        Me.txtSuperficie.TabIndex = 7
        Me.txtSuperficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAncho
        '
        Me.txtAncho.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAncho.Location = New System.Drawing.Point(382, 9)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.Size = New System.Drawing.Size(106, 27)
        Me.txtAncho.TabIndex = 6
        Me.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lslSuperficie
        '
        Me.lslSuperficie.AutoSize = True
        Me.lslSuperficie.BackColor = System.Drawing.Color.Transparent
        Me.lslSuperficie.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lslSuperficie.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lslSuperficie.Location = New System.Drawing.Point(518, 12)
        Me.lslSuperficie.Name = "lslSuperficie"
        Me.lslSuperficie.Size = New System.Drawing.Size(113, 20)
        Me.lslSuperficie.TabIndex = 2
        Me.lslSuperficie.Text = "Superficie(mm)"
        '
        'lblSM
        '
        Me.lblSM.AutoSize = True
        Me.lblSM.BackColor = System.Drawing.Color.Transparent
        Me.lblSM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSM.Location = New System.Drawing.Point(794, 9)
        Me.lblSM.Name = "lblSM"
        Me.lblSM.Size = New System.Drawing.Size(62, 40)
        Me.lblSM.TabIndex = 2
        Me.lblSM.Text = "Stock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mínimo"
        '
        'txtAlto
        '
        Me.txtAlto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlto.Location = New System.Drawing.Point(123, 9)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.Size = New System.Drawing.Size(106, 27)
        Me.txtAlto.TabIndex = 5
        Me.txtAlto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAncho
        '
        Me.lblAncho.AutoSize = True
        Me.lblAncho.BackColor = System.Drawing.Color.Transparent
        Me.lblAncho.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAncho.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAncho.Location = New System.Drawing.Point(257, 12)
        Me.lblAncho.Name = "lblAncho"
        Me.lblAncho.Size = New System.Drawing.Size(89, 20)
        Me.lblAncho.TabIndex = 2
        Me.lblAncho.Text = "Ancho(mm)"
        '
        'lblAlto
        '
        Me.lblAlto.AutoSize = True
        Me.lblAlto.BackColor = System.Drawing.Color.Transparent
        Me.lblAlto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAlto.Location = New System.Drawing.Point(28, 12)
        Me.lblAlto.Name = "lblAlto"
        Me.lblAlto.Size = New System.Drawing.Size(73, 20)
        Me.lblAlto.TabIndex = 2
        Me.lblAlto.Text = "Alto(mm)"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtCosto)
        Me.Panel4.Controls.Add(Me.cbTipoPlancha)
        Me.Panel4.Controls.Add(Me.lblTipoPL)
        Me.Panel4.Controls.Add(Me.cbColores)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtEspesor)
        Me.Panel4.Controls.Add(Me.txtDesc)
        Me.Panel4.Controls.Add(Me.lblcolor)
        Me.Panel4.Controls.Add(Me.txtCodigo)
        Me.Panel4.Controls.Add(Me.lblEspesor)
        Me.Panel4.Controls.Add(Me.lblDesc)
        Me.Panel4.Controls.Add(Me.lblCod)
        Me.Panel4.Location = New System.Drawing.Point(32, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1135, 116)
        Me.Panel4.TabIndex = 0
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(875, 14)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(239, 27)
        Me.txtCosto.TabIndex = 8
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbTipoPlancha
        '
        Me.cbTipoPlancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPlancha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoPlancha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoPlancha.FormattingEnabled = True
        Me.cbTipoPlancha.Location = New System.Drawing.Point(875, 67)
        Me.cbTipoPlancha.Name = "cbTipoPlancha"
        Me.cbTipoPlancha.Size = New System.Drawing.Size(241, 28)
        Me.cbTipoPlancha.TabIndex = 6
        Me.cbTipoPlancha.Visible = False
        '
        'lblTipoPL
        '
        Me.lblTipoPL.AutoSize = True
        Me.lblTipoPL.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoPL.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTipoPL.Location = New System.Drawing.Point(795, 64)
        Me.lblTipoPL.Name = "lblTipoPL"
        Me.lblTipoPL.Size = New System.Drawing.Size(63, 40)
        Me.lblTipoPL.TabIndex = 5
        Me.lblTipoPL.Text = "Tipo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plancha"
        Me.lblTipoPL.Visible = False
        '
        'cbColores
        '
        Me.cbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbColores.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbColores.FormattingEnabled = True
        Me.cbColores.Location = New System.Drawing.Point(545, 67)
        Me.cbColores.Name = "cbColores"
        Me.cbColores.Size = New System.Drawing.Size(228, 28)
        Me.cbColores.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(794, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo"
        '
        'txtEspesor
        '
        Me.txtEspesor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspesor.Location = New System.Drawing.Point(545, 14)
        Me.txtEspesor.Name = "txtEspesor"
        Me.txtEspesor.Size = New System.Drawing.Size(228, 27)
        Me.txtEspesor.TabIndex = 6
        Me.txtEspesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(124, 67)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(264, 27)
        Me.txtDesc.TabIndex = 2
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcolor
        '
        Me.lblcolor.AutoSize = True
        Me.lblcolor.BackColor = System.Drawing.Color.Transparent
        Me.lblcolor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcolor.Location = New System.Drawing.Point(409, 70)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.Size = New System.Drawing.Size(46, 20)
        Me.lblcolor.TabIndex = 2
        Me.lblcolor.Text = "Color"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(124, 14)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(264, 27)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEspesor
        '
        Me.lblEspesor.AutoSize = True
        Me.lblEspesor.BackColor = System.Drawing.Color.Transparent
        Me.lblEspesor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEspesor.Location = New System.Drawing.Point(409, 17)
        Me.lblEspesor.Name = "lblEspesor"
        Me.lblEspesor.Size = New System.Drawing.Size(97, 20)
        Me.lblEspesor.TabIndex = 2
        Me.lblEspesor.Text = "Espesor(mm)"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDesc.Location = New System.Drawing.Point(16, 70)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(89, 20)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "Descripción"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCod.Location = New System.Drawing.Point(16, 17)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(58, 20)
        Me.lblCod.TabIndex = 2
        Me.lblCod.Text = "Código"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.19028!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.80972!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(25, 488)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1194, 62)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 60)
        Me.Panel2.TabIndex = 0
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificar.Location = New System.Drawing.Point(415, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(122, 38)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Location = New System.Drawing.Point(578, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 38)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Location = New System.Drawing.Point(262, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 38)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Location = New System.Drawing.Point(45, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(184, 38)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtBusqueda)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(730, 1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(463, 60)
        Me.Panel3.TabIndex = 1
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(108, 18)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(311, 27)
        Me.txtBusqueda.TabIndex = 13
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(29, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar"
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbTemplados)
        Me.gbTipo.Controls.Add(Me.rbPlanchas)
        Me.gbTipo.Controls.Add(Me.rbPerfiles)
        Me.gbTipo.Controls.Add(Me.rbHerrajes)
        Me.gbTipo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbTipo.Location = New System.Drawing.Point(26, 63)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(1195, 61)
        Me.gbTipo.TabIndex = 6
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Tipo de Producto"
        '
        'rbTemplados
        '
        Me.rbTemplados.AutoSize = True
        Me.rbTemplados.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTemplados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbTemplados.Location = New System.Drawing.Point(692, 26)
        Me.rbTemplados.Name = "rbTemplados"
        Me.rbTemplados.Size = New System.Drawing.Size(97, 24)
        Me.rbTemplados.TabIndex = 1
        Me.rbTemplados.Text = "Templado"
        Me.rbTemplados.UseVisualStyleBackColor = True
        '
        'rbPlanchas
        '
        Me.rbPlanchas.AutoSize = True
        Me.rbPlanchas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPlanchas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbPlanchas.Location = New System.Drawing.Point(555, 26)
        Me.rbPlanchas.Name = "rbPlanchas"
        Me.rbPlanchas.Size = New System.Drawing.Size(90, 24)
        Me.rbPlanchas.TabIndex = 2
        Me.rbPlanchas.Text = "Planchas"
        Me.rbPlanchas.UseVisualStyleBackColor = True
        '
        'rbPerfiles
        '
        Me.rbPerfiles.AutoSize = True
        Me.rbPerfiles.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPerfiles.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbPerfiles.Location = New System.Drawing.Point(427, 26)
        Me.rbPerfiles.Name = "rbPerfiles"
        Me.rbPerfiles.Size = New System.Drawing.Size(79, 24)
        Me.rbPerfiles.TabIndex = 3
        Me.rbPerfiles.Text = "Perfiles"
        Me.rbPerfiles.UseVisualStyleBackColor = True
        '
        'rbHerrajes
        '
        Me.rbHerrajes.AutoSize = True
        Me.rbHerrajes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHerrajes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbHerrajes.Location = New System.Drawing.Point(293, 26)
        Me.rbHerrajes.Name = "rbHerrajes"
        Me.rbHerrajes.Size = New System.Drawing.Size(87, 24)
        Me.rbHerrajes.TabIndex = 4
        Me.rbHerrajes.Text = "Herrajes"
        Me.rbHerrajes.UseVisualStyleBackColor = True
        '
        'ProductoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1247, 977)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnlDatosProd.ResumeLayout(False)
        Me.pnlDatosProd.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pnlDatosProd As Panel
    Friend WithEvents txtAlto As TextBox
    Friend WithEvents lblAlto As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbColores As ComboBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblcolor As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblCod As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtPD As TextBox
    Friend WithEvents txtPC As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPB As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPA As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSM As TextBox
    Friend WithEvents txtSuperficie As TextBox
    Friend WithEvents lblSM As Label
    Friend WithEvents txtAncho As TextBox
    Friend WithEvents lslSuperficie As Label
    Friend WithEvents lblAncho As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents cbTipoPlancha As ComboBox
    Friend WithEvents lblTipoPL As Label
    Friend WithEvents gbTipo As GroupBox
    Friend WithEvents rbTemplados As RadioButton
    Friend WithEvents rbPlanchas As RadioButton
    Friend WithEvents rbPerfiles As RadioButton
    Friend WithEvents rbHerrajes As RadioButton
    Friend WithEvents txtEspesor As TextBox
    Friend WithEvents lblEspesor As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label3 As Label
End Class
