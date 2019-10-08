<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReposicionesForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNroProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSup = New System.Windows.Forms.Label()
        Me.txtAlto = New System.Windows.Forms.Label()
        Me.txtAncho = New System.Windows.Forms.Label()
        Me.txtPanho = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMotivo = New System.Windows.Forms.Label()
        Me.txtMotCod = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.txtOT = New System.Windows.Forms.Label()
        Me.txtOpCod = New System.Windows.Forms.Label()
        Me.txtCliCod = New System.Windows.Forms.Label()
        Me.txtOpDesc = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.Label()
        Me.labelot = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEtiquetas = New System.Windows.Forms.Button()
        Me.dgvReposiciones = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdColumna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTColumna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPColumna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnchoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UACol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvReposiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 46)
        Me.Panel1.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(388, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(200, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Reposiciones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNroProd)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 67)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(381, 79)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'txtNroProd
        '
        Me.txtNroProd.Location = New System.Drawing.Point(153, 28)
        Me.txtNroProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroProd.Name = "txtNroProd"
        Me.txtNroProd.Size = New System.Drawing.Size(179, 30)
        Me.txtNroProd.TabIndex = 8
        Me.txtNroProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(15, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro Producción"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSup)
        Me.GroupBox1.Controls.Add(Me.txtAlto)
        Me.GroupBox1.Controls.Add(Me.txtAncho)
        Me.GroupBox1.Controls.Add(Me.txtPanho)
        Me.GroupBox1.Controls.Add(Me.txtProducto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 154)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(381, 256)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtSup
        '
        Me.txtSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtSup.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSup.Location = New System.Drawing.Point(118, 198)
        Me.txtSup.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSup.Name = "txtSup"
        Me.txtSup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSup.Size = New System.Drawing.Size(214, 30)
        Me.txtSup.TabIndex = 13
        Me.txtSup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAlto
        '
        Me.txtAlto.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtAlto.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAlto.Location = New System.Drawing.Point(118, 155)
        Me.txtAlto.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAlto.Size = New System.Drawing.Size(214, 30)
        Me.txtAlto.TabIndex = 13
        Me.txtAlto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAncho
        '
        Me.txtAncho.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtAncho.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAncho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAncho.Location = New System.Drawing.Point(118, 113)
        Me.txtAncho.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAncho.Size = New System.Drawing.Size(214, 30)
        Me.txtAncho.TabIndex = 13
        Me.txtAncho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPanho
        '
        Me.txtPanho.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtPanho.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPanho.Location = New System.Drawing.Point(118, 73)
        Me.txtPanho.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPanho.Name = "txtPanho"
        Me.txtPanho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPanho.Size = New System.Drawing.Size(214, 30)
        Me.txtPanho.TabIndex = 13
        Me.txtPanho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProducto
        '
        Me.txtProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtProducto.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtProducto.Location = New System.Drawing.Point(118, 31)
        Me.txtProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProducto.Size = New System.Drawing.Size(214, 30)
        Me.txtProducto.TabIndex = 13
        Me.txtProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(15, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Superficie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(15, 162)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Alto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(15, 118)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ancho "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(15, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Paño"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMotivo)
        Me.GroupBox3.Controls.Add(Me.txtMotCod)
        Me.GroupBox3.Controls.Add(Me.txtFecha)
        Me.GroupBox3.Controls.Add(Me.txtOT)
        Me.GroupBox3.Controls.Add(Me.txtOpCod)
        Me.GroupBox3.Controls.Add(Me.txtCliCod)
        Me.GroupBox3.Controls.Add(Me.txtOpDesc)
        Me.GroupBox3.Controls.Add(Me.txtCliente)
        Me.GroupBox3.Controls.Add(Me.labelot)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(424, 154)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(412, 256)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'txtMotivo
        '
        Me.txtMotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtMotivo.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMotivo.Location = New System.Drawing.Point(164, 198)
        Me.txtMotivo.Margin = New System.Windows.Forms.Padding(0)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMotivo.Size = New System.Drawing.Size(214, 30)
        Me.txtMotivo.TabIndex = 13
        Me.txtMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMotCod
        '
        Me.txtMotCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtMotCod.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotCod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMotCod.Location = New System.Drawing.Point(108, 198)
        Me.txtMotCod.Margin = New System.Windows.Forms.Padding(0)
        Me.txtMotCod.Name = "txtMotCod"
        Me.txtMotCod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMotCod.Size = New System.Drawing.Size(41, 30)
        Me.txtMotCod.TabIndex = 13
        Me.txtMotCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtFecha.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFecha.Location = New System.Drawing.Point(108, 157)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(0)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFecha.Size = New System.Drawing.Size(270, 30)
        Me.txtFecha.TabIndex = 13
        Me.txtFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOT
        '
        Me.txtOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtOT.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOT.Location = New System.Drawing.Point(108, 113)
        Me.txtOT.Margin = New System.Windows.Forms.Padding(0)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOT.Size = New System.Drawing.Size(95, 30)
        Me.txtOT.TabIndex = 13
        Me.txtOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOpCod
        '
        Me.txtOpCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtOpCod.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpCod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOpCod.Location = New System.Drawing.Point(108, 68)
        Me.txtOpCod.Margin = New System.Windows.Forms.Padding(0)
        Me.txtOpCod.Name = "txtOpCod"
        Me.txtOpCod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpCod.Size = New System.Drawing.Size(41, 30)
        Me.txtOpCod.TabIndex = 13
        Me.txtOpCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCliCod
        '
        Me.txtCliCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtCliCod.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliCod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCliCod.Location = New System.Drawing.Point(108, 29)
        Me.txtCliCod.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCliCod.Name = "txtCliCod"
        Me.txtCliCod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliCod.Size = New System.Drawing.Size(41, 30)
        Me.txtCliCod.TabIndex = 13
        Me.txtCliCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOpDesc
        '
        Me.txtOpDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtOpDesc.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOpDesc.Location = New System.Drawing.Point(164, 68)
        Me.txtOpDesc.Margin = New System.Windows.Forms.Padding(0)
        Me.txtOpDesc.Name = "txtOpDesc"
        Me.txtOpDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpDesc.Size = New System.Drawing.Size(214, 30)
        Me.txtOpDesc.TabIndex = 13
        Me.txtOpDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.txtCliente.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCliente.Location = New System.Drawing.Point(164, 27)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.Size = New System.Drawing.Size(214, 30)
        Me.txtCliente.TabIndex = 13
        Me.txtCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelot
        '
        Me.labelot.AutoSize = True
        Me.labelot.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelot.Location = New System.Drawing.Point(8, 118)
        Me.labelot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelot.Name = "labelot"
        Me.labelot.Size = New System.Drawing.Size(31, 23)
        Me.labelot.TabIndex = 1
        Me.labelot.Text = "OT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(8, 162)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Fecha"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(6, 205)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 23)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Motivo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(8, 73)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 23)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Operación"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(8, 36)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 23)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Cliente"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Image = Global.Frontend.My.Resources.Resources.guardar
        Me.btnGuardar.Location = New System.Drawing.Point(424, 86)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(179, 49)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Grabar Reposición"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEtiquetas
        '
        Me.btnEtiquetas.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnEtiquetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEtiquetas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEtiquetas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEtiquetas.Image = Global.Frontend.My.Resources.Resources.tickets1
        Me.btnEtiquetas.Location = New System.Drawing.Point(657, 86)
        Me.btnEtiquetas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEtiquetas.Name = "btnEtiquetas"
        Me.btnEtiquetas.Size = New System.Drawing.Size(179, 49)
        Me.btnEtiquetas.TabIndex = 16
        Me.btnEtiquetas.Text = "Etiquetas"
        Me.btnEtiquetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEtiquetas.UseVisualStyleBackColor = False
        '
        'dgvReposiciones
        '
        Me.dgvReposiciones.AllowUserToAddRows = False
        Me.dgvReposiciones.AllowUserToDeleteRows = False
        Me.dgvReposiciones.AllowUserToResizeColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvReposiciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReposiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReposiciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgvReposiciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReposiciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReposiciones.ColumnHeadersHeight = 35
        Me.dgvReposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReposiciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ProdColumna, Me.OTColumna, Me.GPColumna, Me.AnchoCol, Me.APCol, Me.UACol})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReposiciones.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvReposiciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReposiciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvReposiciones.EnableHeadersVisualStyles = False
        Me.dgvReposiciones.Location = New System.Drawing.Point(4, 27)
        Me.dgvReposiciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReposiciones.MultiSelect = False
        Me.dgvReposiciones.Name = "dgvReposiciones"
        Me.dgvReposiciones.RowHeadersVisible = False
        Me.dgvReposiciones.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvReposiciones.RowTemplate.Height = 24
        Me.dgvReposiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReposiciones.Size = New System.Drawing.Size(925, 282)
        Me.dgvReposiciones.TabIndex = 20
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ID.DefaultCellStyle = DataGridViewCellStyle7
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'ProdColumna
        '
        Me.ProdColumna.DataPropertyName = "PID"
        Me.ProdColumna.HeaderText = "PID"
        Me.ProdColumna.Name = "ProdColumna"
        Me.ProdColumna.Visible = False
        '
        'OTColumna
        '
        Me.OTColumna.DataPropertyName = "OT"
        Me.OTColumna.HeaderText = "OT"
        Me.OTColumna.Name = "OTColumna"
        '
        'GPColumna
        '
        Me.GPColumna.DataPropertyName = "Grabado por"
        Me.GPColumna.HeaderText = "Grabado por"
        Me.GPColumna.Name = "GPColumna"
        '
        'AnchoCol
        '
        Me.AnchoCol.DataPropertyName = "Fecha inserción"
        Me.AnchoCol.HeaderText = "Fecha inserción"
        Me.AnchoCol.Name = "AnchoCol"
        '
        'APCol
        '
        Me.APCol.DataPropertyName = "Actualizado por"
        Me.APCol.HeaderText = "Actualizado por"
        Me.APCol.Name = "APCol"
        '
        'UACol
        '
        Me.UACol.DataPropertyName = "Última act"
        Me.UACol.HeaderText = "Última act"
        Me.UACol.Name = "UACol"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvReposiciones)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Location = New System.Drawing.Point(13, 418)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(933, 313)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reposiciones de la producción"
        '
        'ReposicionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(979, 759)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnEtiquetas)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReposicionesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReposicionesForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvReposiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNroProd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSup As Label
    Friend WithEvents txtAlto As Label
    Friend WithEvents txtAncho As Label
    Friend WithEvents txtPanho As Label
    Friend WithEvents txtProducto As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMotivo As Label
    Friend WithEvents txtOpDesc As Label
    Friend WithEvents txtCliente As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtMotCod As Label
    Friend WithEvents txtFecha As Label
    Friend WithEvents txtOpCod As Label
    Friend WithEvents txtCliCod As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOT As Label
    Friend WithEvents labelot As Label
    Friend WithEvents btnEtiquetas As Button
    Friend WithEvents dgvReposiciones As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ProdColumna As DataGridViewTextBoxColumn
    Friend WithEvents OTColumna As DataGridViewTextBoxColumn
    Friend WithEvents GPColumna As DataGridViewTextBoxColumn
    Friend WithEvents AnchoCol As DataGridViewTextBoxColumn
    Friend WithEvents APCol As DataGridViewTextBoxColumn
    Friend WithEvents UACol As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
End Class
