<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExpedicionForm
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvExpediciones = New System.Windows.Forms.DataGridView()
        Me.ExpNroExp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpedProducc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpedPanho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpdAncho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpAlto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpSuperficie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpFechaIns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpedUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtProduccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNroOT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CorteGB = New System.Windows.Forms.GroupBox()
        Me.dgvProduccionOT = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVerExpediciones = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblOt = New System.Windows.Forms.Label()
        Me.lblPanhExpedidos = New System.Windows.Forms.Label()
        Me.lblPanhos = New System.Windows.Forms.Label()
        Me.lblSup = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSupProd = New System.Windows.Forms.Label()
        Me.lblAlto = New System.Windows.Forms.Label()
        Me.lblAncho = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalPanhos = New System.Windows.Forms.Label()
        Me.lblRotos = New System.Windows.Forms.Label()
        Me.lblTerminados = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFaltantes = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorteFehcaCorteCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntradaHornoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaHornoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoturaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpedidoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempRotu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvExpediciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.CorteGB.SuspendLayout()
        CType(Me.dgvProduccionOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1234, 41)
        Me.Panel1.TabIndex = 34
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(393, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(415, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Expediciones - Estado de OT"
        '
        'dgvExpediciones
        '
        Me.dgvExpediciones.AllowUserToAddRows = False
        Me.dgvExpediciones.AllowUserToDeleteRows = False
        Me.dgvExpediciones.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvExpediciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExpediciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExpediciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExpediciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvExpediciones.ColumnHeadersHeight = 30
        Me.dgvExpediciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvExpediciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExpNroExp, Me.ExpedProducc, Me.ExpProducto, Me.ExpedPanho, Me.ExpdAncho, Me.ExpAlto, Me.ExpSuperficie, Me.ExpFechaIns, Me.ExpedUsuario, Me.ExpError})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExpediciones.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvExpediciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExpediciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvExpediciones.EnableHeadersVisualStyles = False
        Me.dgvExpediciones.Location = New System.Drawing.Point(3, 18)
        Me.dgvExpediciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvExpediciones.MultiSelect = False
        Me.dgvExpediciones.Name = "dgvExpediciones"
        Me.dgvExpediciones.RowHeadersVisible = False
        Me.dgvExpediciones.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvExpediciones.RowTemplate.Height = 24
        Me.dgvExpediciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpediciones.Size = New System.Drawing.Size(1163, 228)
        Me.dgvExpediciones.TabIndex = 37
        '
        'ExpNroExp
        '
        Me.ExpNroExp.DataPropertyName = "NroExp"
        Me.ExpNroExp.HeaderText = "Nro"
        Me.ExpNroExp.Name = "ExpNroExp"
        '
        'ExpedProducc
        '
        Me.ExpedProducc.DataPropertyName = "NroProd"
        Me.ExpedProducc.HeaderText = "Producción"
        Me.ExpedProducc.Name = "ExpedProducc"
        '
        'ExpProducto
        '
        Me.ExpProducto.DataPropertyName = "ProdCod"
        Me.ExpProducto.HeaderText = "Producto"
        Me.ExpProducto.Name = "ExpProducto"
        '
        'ExpedPanho
        '
        Me.ExpedPanho.DataPropertyName = "Panho"
        Me.ExpedPanho.HeaderText = "Paño"
        Me.ExpedPanho.Name = "ExpedPanho"
        '
        'ExpdAncho
        '
        Me.ExpdAncho.DataPropertyName = "Ancho"
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ExpdAncho.DefaultCellStyle = DataGridViewCellStyle3
        Me.ExpdAncho.HeaderText = "Ancho"
        Me.ExpdAncho.Name = "ExpdAncho"
        '
        'ExpAlto
        '
        Me.ExpAlto.DataPropertyName = "Alto"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ExpAlto.DefaultCellStyle = DataGridViewCellStyle4
        Me.ExpAlto.HeaderText = "Alto"
        Me.ExpAlto.Name = "ExpAlto"
        '
        'ExpSuperficie
        '
        Me.ExpSuperficie.DataPropertyName = "Superficie"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ExpSuperficie.DefaultCellStyle = DataGridViewCellStyle5
        Me.ExpSuperficie.HeaderText = "Superficie"
        Me.ExpSuperficie.Name = "ExpSuperficie"
        '
        'ExpFechaIns
        '
        Me.ExpFechaIns.DataPropertyName = "FechaInsercion"
        Me.ExpFechaIns.HeaderText = "Fecha Inserción"
        Me.ExpFechaIns.Name = "ExpFechaIns"
        '
        'ExpedUsuario
        '
        Me.ExpedUsuario.DataPropertyName = "UsuarioIns"
        Me.ExpedUsuario.HeaderText = "Usuario Ins."
        Me.ExpedUsuario.Name = "ExpedUsuario"
        '
        'ExpError
        '
        Me.ExpError.DataPropertyName = "Error"
        Me.ExpError.HeaderText = "Error"
        Me.ExpError.Name = "ExpError"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtProduccion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNroOT)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(233, 99)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'txtProduccion
        '
        Me.txtProduccion.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduccion.Location = New System.Drawing.Point(114, 58)
        Me.txtProduccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProduccion.Name = "txtProduccion"
        Me.txtProduccion.Size = New System.Drawing.Size(101, 25)
        Me.txtProduccion.TabIndex = 3
        Me.txtProduccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(8, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nro Produccion"
        '
        'txtNroOT
        '
        Me.txtNroOT.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOT.Location = New System.Drawing.Point(114, 21)
        Me.txtNroOT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroOT.Name = "txtNroOT"
        Me.txtNroOT.Size = New System.Drawing.Size(101, 25)
        Me.txtNroOT.TabIndex = 0
        Me.txtNroOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(20, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro OT"
        '
        'CorteGB
        '
        Me.CorteGB.Controls.Add(Me.dgvProduccionOT)
        Me.CorteGB.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CorteGB.Location = New System.Drawing.Point(19, 227)
        Me.CorteGB.Name = "CorteGB"
        Me.CorteGB.Size = New System.Drawing.Size(1172, 258)
        Me.CorteGB.TabIndex = 40
        Me.CorteGB.TabStop = False
        Me.CorteGB.Text = "Produccion de la OT"
        '
        'dgvProduccionOT
        '
        Me.dgvProduccionOT.AllowUserToAddRows = False
        Me.dgvProduccionOT.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProduccionOT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProduccionOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProduccionOT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduccionOT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProduccionOT.ColumnHeadersHeight = 30
        Me.dgvProduccionOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProduccionOT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn31, Me.CorteFehcaCorteCol, Me.DataGridViewTextBoxColumn32, Me.EntradaHornoCol, Me.SalidaHornoCol, Me.RoturaCol, Me.ExpedidoCol, Me.RepoCol, Me.tempRotu})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduccionOT.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProduccionOT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProduccionOT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProduccionOT.EnableHeadersVisualStyles = False
        Me.dgvProduccionOT.Location = New System.Drawing.Point(3, 18)
        Me.dgvProduccionOT.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProduccionOT.MultiSelect = False
        Me.dgvProduccionOT.Name = "dgvProduccionOT"
        Me.dgvProduccionOT.RowHeadersVisible = False
        Me.dgvProduccionOT.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProduccionOT.RowTemplate.Height = 24
        Me.dgvProduccionOT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduccionOT.Size = New System.Drawing.Size(1166, 237)
        Me.dgvProduccionOT.TabIndex = 38
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.btnVerExpediciones)
        Me.GroupBox5.Controls.Add(Me.btnGuardar)
        Me.GroupBox5.Controls.Add(Me.lblCliente)
        Me.GroupBox5.Controls.Add(Me.lblOt)
        Me.GroupBox5.Controls.Add(Me.lblPanhExpedidos)
        Me.GroupBox5.Controls.Add(Me.lblPanhos)
        Me.GroupBox5.Controls.Add(Me.lblSup)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Location = New System.Drawing.Point(270, 16)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(930, 99)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = Global.Frontend.My.Resources.Resources.icons8_error_30
        Me.Button1.Location = New System.Drawing.Point(800, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 49)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Errores"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnVerExpediciones
        '
        Me.btnVerExpediciones.AutoSize = True
        Me.btnVerExpediciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnVerExpediciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerExpediciones.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerExpediciones.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVerExpediciones.Image = Global.Frontend.My.Resources.Resources.expedi
        Me.btnVerExpediciones.Location = New System.Drawing.Point(666, 34)
        Me.btnVerExpediciones.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVerExpediciones.Name = "btnVerExpediciones"
        Me.btnVerExpediciones.Size = New System.Drawing.Size(122, 49)
        Me.btnVerExpediciones.TabIndex = 45
        Me.btnVerExpediciones.Text = "Realizadas"
        Me.btnVerExpediciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerExpediciones.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Image = Global.Frontend.My.Resources.Resources.guardar
        Me.btnGuardar.Location = New System.Drawing.Point(551, 34)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 49)
        Me.btnGuardar.TabIndex = 44
        Me.btnGuardar.Text = "Grabar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblCliente
        '
        Me.lblCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCliente.Location = New System.Drawing.Point(66, 56)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCliente.Size = New System.Drawing.Size(307, 28)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOt
        '
        Me.lblOt.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblOt.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOt.Location = New System.Drawing.Point(66, 19)
        Me.lblOt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Padding = New System.Windows.Forms.Padding(4)
        Me.lblOt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOt.Size = New System.Drawing.Size(107, 28)
        Me.lblOt.TabIndex = 27
        Me.lblOt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPanhExpedidos
        '
        Me.lblPanhExpedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblPanhExpedidos.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanhExpedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPanhExpedidos.Location = New System.Drawing.Point(461, 55)
        Me.lblPanhExpedidos.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPanhExpedidos.Name = "lblPanhExpedidos"
        Me.lblPanhExpedidos.Padding = New System.Windows.Forms.Padding(4)
        Me.lblPanhExpedidos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPanhExpedidos.Size = New System.Drawing.Size(74, 28)
        Me.lblPanhExpedidos.TabIndex = 27
        Me.lblPanhExpedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPanhos
        '
        Me.lblPanhos.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblPanhos.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanhos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPanhos.Location = New System.Drawing.Point(386, 55)
        Me.lblPanhos.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPanhos.Name = "lblPanhos"
        Me.lblPanhos.Padding = New System.Windows.Forms.Padding(4)
        Me.lblPanhos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPanhos.Size = New System.Drawing.Size(58, 28)
        Me.lblPanhos.TabIndex = 27
        Me.lblPanhos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSup
        '
        Me.lblSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblSup.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSup.Location = New System.Drawing.Point(284, 17)
        Me.lblSup.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSup.Name = "lblSup"
        Me.lblSup.Padding = New System.Windows.Forms.Padding(4)
        Me.lblSup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSup.Size = New System.Drawing.Size(89, 28)
        Me.lblSup.TabIndex = 27
        Me.lblSup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(8, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(177, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Superficie:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "OT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(461, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Paños Exp."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(377, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro. Paños"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgvExpediciones)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox6.Location = New System.Drawing.Point(19, 558)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1169, 249)
        Me.GroupBox6.TabIndex = 43
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Expediciones a Realizar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1234, 915)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.CorteGB)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1228, 868)
        Me.Panel2.TabIndex = 45
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = Global.Frontend.My.Resources.Resources.icons8_insertar_página_30
        Me.Button2.Location = New System.Drawing.Point(1006, 488)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 49)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Agregar Todos"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblSupProd)
        Me.GroupBox3.Controls.Add(Me.lblAlto)
        Me.GroupBox3.Controls.Add(Me.lblAncho)
        Me.GroupBox3.Location = New System.Drawing.Point(759, 138)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(441, 55)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(8, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nro Produccion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(281, 22)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Sup"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(153, 21)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Alto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(8, 21)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Ancho"
        '
        'lblSupProd
        '
        Me.lblSupProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblSupProd.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSupProd.Location = New System.Drawing.Point(317, 15)
        Me.lblSupProd.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSupProd.Name = "lblSupProd"
        Me.lblSupProd.Padding = New System.Windows.Forms.Padding(4)
        Me.lblSupProd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSupProd.Size = New System.Drawing.Size(73, 28)
        Me.lblSupProd.TabIndex = 27
        Me.lblSupProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlto
        '
        Me.lblAlto.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblAlto.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAlto.Location = New System.Drawing.Point(191, 15)
        Me.lblAlto.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAlto.Name = "lblAlto"
        Me.lblAlto.Padding = New System.Windows.Forms.Padding(4)
        Me.lblAlto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAlto.Size = New System.Drawing.Size(73, 28)
        Me.lblAlto.TabIndex = 27
        Me.lblAlto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAncho
        '
        Me.lblAncho.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblAncho.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAncho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAncho.Location = New System.Drawing.Point(58, 15)
        Me.lblAncho.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAncho.Name = "lblAncho"
        Me.lblAncho.Padding = New System.Windows.Forms.Padding(4)
        Me.lblAncho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAncho.Size = New System.Drawing.Size(73, 28)
        Me.lblAncho.TabIndex = 27
        Me.lblAncho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalPanhos)
        Me.GroupBox1.Controls.Add(Me.lblRotos)
        Me.GroupBox1.Controls.Add(Me.lblTerminados)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblFaltantes)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 138)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(732, 55)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'lblTotalPanhos
        '
        Me.lblTotalPanhos.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblTotalPanhos.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPanhos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalPanhos.Location = New System.Drawing.Point(613, 15)
        Me.lblTotalPanhos.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalPanhos.Name = "lblTotalPanhos"
        Me.lblTotalPanhos.Padding = New System.Windows.Forms.Padding(4)
        Me.lblTotalPanhos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalPanhos.Size = New System.Drawing.Size(73, 28)
        Me.lblTotalPanhos.TabIndex = 27
        Me.lblTotalPanhos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRotos
        '
        Me.lblRotos.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblRotos.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRotos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRotos.Location = New System.Drawing.Point(472, 15)
        Me.lblRotos.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRotos.Name = "lblRotos"
        Me.lblRotos.Padding = New System.Windows.Forms.Padding(4)
        Me.lblRotos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRotos.Size = New System.Drawing.Size(73, 28)
        Me.lblRotos.TabIndex = 27
        Me.lblRotos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTerminados
        '
        Me.lblTerminados.BackColor = System.Drawing.Color.Green
        Me.lblTerminados.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerminados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTerminados.Location = New System.Drawing.Point(91, 16)
        Me.lblTerminados.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTerminados.Name = "lblTerminados"
        Me.lblTerminados.Padding = New System.Windows.Forms.Padding(4)
        Me.lblTerminados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTerminados.Size = New System.Drawing.Size(73, 28)
        Me.lblTerminados.TabIndex = 27
        Me.lblTerminados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(571, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total"
        '
        'lblFaltantes
        '
        Me.lblFaltantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblFaltantes.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaltantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFaltantes.Location = New System.Drawing.Point(247, 16)
        Me.lblFaltantes.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFaltantes.Name = "lblFaltantes"
        Me.lblFaltantes.Padding = New System.Windows.Forms.Padding(4)
        Me.lblFaltantes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFaltantes.Size = New System.Drawing.Size(73, 28)
        Me.lblFaltantes.TabIndex = 27
        Me.lblFaltantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(338, 22)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 19)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Roturas Registradas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(179, 21)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 19)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Faltantes"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(8, 21)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 19)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Terminados"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Produccion"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn1.HeaderText = "Producción"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProdCod"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Panho"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Paño"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Corte"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'CorteFehcaCorteCol
        '
        Me.CorteFehcaCorteCol.DataPropertyName = "Pulida"
        Me.CorteFehcaCorteCol.HeaderText = "Pulida"
        Me.CorteFehcaCorteCol.Name = "CorteFehcaCorteCol"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Marcado"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Marcado"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'EntradaHornoCol
        '
        Me.EntradaHornoCol.DataPropertyName = "Entrada"
        Me.EntradaHornoCol.HeaderText = "Entrada"
        Me.EntradaHornoCol.Name = "EntradaHornoCol"
        '
        'SalidaHornoCol
        '
        Me.SalidaHornoCol.DataPropertyName = "Salida"
        Me.SalidaHornoCol.HeaderText = "Salida"
        Me.SalidaHornoCol.Name = "SalidaHornoCol"
        '
        'RoturaCol
        '
        Me.RoturaCol.DataPropertyName = "Rotura"
        Me.RoturaCol.HeaderText = "Rotura"
        Me.RoturaCol.Name = "RoturaCol"
        '
        'ExpedidoCol
        '
        Me.ExpedidoCol.DataPropertyName = "Expedido"
        Me.ExpedidoCol.HeaderText = "Expedido"
        Me.ExpedidoCol.Name = "ExpedidoCol"
        '
        'RepoCol
        '
        Me.RepoCol.DataPropertyName = "Repo"
        Me.RepoCol.HeaderText = "Reposición"
        Me.RepoCol.Name = "RepoCol"
        '
        'tempRotu
        '
        Me.tempRotu.DataPropertyName = "RoturaTemplado"
        Me.tempRotu.HeaderText = "RoturaTemplado"
        Me.tempRotu.Name = "tempRotu"
        Me.tempRotu.Visible = False
        '
        'ExpedicionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 915)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ExpedicionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExpedicionForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvExpediciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.CorteGB.ResumeLayout(False)
        CType(Me.dgvProduccionOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvExpediciones As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNroOT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CorteGB As GroupBox
    Friend WithEvents dgvProduccionOT As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblOt As Label
    Friend WithEvents lblPanhos As Label
    Friend WithEvents lblSup As Label
    Friend WithEvents txtProduccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ExpNroExp As DataGridViewTextBoxColumn
    Friend WithEvents ExpedProducc As DataGridViewTextBoxColumn
    Friend WithEvents ExpProducto As DataGridViewTextBoxColumn
    Friend WithEvents ExpedPanho As DataGridViewTextBoxColumn
    Friend WithEvents ExpdAncho As DataGridViewTextBoxColumn
    Friend WithEvents ExpAlto As DataGridViewTextBoxColumn
    Friend WithEvents ExpSuperficie As DataGridViewTextBoxColumn
    Friend WithEvents ExpFechaIns As DataGridViewTextBoxColumn
    Friend WithEvents ExpedUsuario As DataGridViewTextBoxColumn
    Friend WithEvents ExpError As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnVerExpediciones As Button
    Friend WithEvents lblPanhExpedidos As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotalPanhos As Label
    Friend WithEvents lblRotos As Label
    Friend WithEvents lblTerminados As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFaltantes As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSupProd As Label
    Friend WithEvents lblAlto As Label
    Friend WithEvents lblAncho As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents CorteFehcaCorteCol As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents EntradaHornoCol As DataGridViewTextBoxColumn
    Friend WithEvents SalidaHornoCol As DataGridViewTextBoxColumn
    Friend WithEvents RoturaCol As DataGridViewTextBoxColumn
    Friend WithEvents ExpedidoCol As DataGridViewTextBoxColumn
    Friend WithEvents RepoCol As DataGridViewTextBoxColumn
    Friend WithEvents tempRotu As DataGridViewTextBoxColumn
End Class
