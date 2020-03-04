<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnularFacturaForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbDatosCliente = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblt = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblClienteTel = New System.Windows.Forms.Label()
        Me.lblClienteRuc = New System.Windows.Forms.Label()
        Me.lblClienteNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSupTotalOT = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFechaVenta = New System.Windows.Forms.Label()
        Me.lblOTSeleccionada = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.dgvAnulaciones = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoPagoCOl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.gbDatosCliente.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAnulaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOT)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 62)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(265, 59)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'txtOT
        '
        Me.txtOT.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOT.Location = New System.Drawing.Point(88, 19)
        Me.txtOT.Margin = New System.Windows.Forms.Padding(0)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(135, 25)
        Me.txtOT.TabIndex = 8
        Me.txtOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(16, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro OT"
        '
        'gbDatosCliente
        '
        Me.gbDatosCliente.Controls.Add(Me.Label23)
        Me.gbDatosCliente.Controls.Add(Me.lblR)
        Me.gbDatosCliente.Controls.Add(Me.Label33)
        Me.gbDatosCliente.Controls.Add(Me.lblt)
        Me.gbDatosCliente.Controls.Add(Me.lblVendedor)
        Me.gbDatosCliente.Controls.Add(Me.lblClienteTel)
        Me.gbDatosCliente.Controls.Add(Me.lblClienteRuc)
        Me.gbDatosCliente.Controls.Add(Me.lblClienteNombre)
        Me.gbDatosCliente.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbDatosCliente.Location = New System.Drawing.Point(13, 138)
        Me.gbDatosCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDatosCliente.Size = New System.Drawing.Size(448, 195)
        Me.gbDatosCliente.TabIndex = 12
        Me.gbDatosCliente.TabStop = False
        Me.gbDatosCliente.Text = "Datos Cliente"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(9, 33)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 19)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Nombre"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblR.Location = New System.Drawing.Point(9, 77)
        Me.lblR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(39, 19)
        Me.lblR.TabIndex = 1
        Me.lblR.Text = "RUC:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(3, 153)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 19)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "Vendedor"
        '
        'lblt
        '
        Me.lblt.AutoSize = True
        Me.lblt.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblt.Location = New System.Drawing.Point(7, 114)
        Me.lblt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblt.Name = "lblt"
        Me.lblt.Size = New System.Drawing.Size(51, 19)
        Me.lblt.TabIndex = 1
        Me.lblt.Text = "Celular"
        '
        'lblVendedor
        '
        Me.lblVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblVendedor.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblVendedor.Location = New System.Drawing.Point(87, 152)
        Me.lblVendedor.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVendedor.Size = New System.Drawing.Size(353, 30)
        Me.lblVendedor.TabIndex = 12
        Me.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClienteTel
        '
        Me.lblClienteTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblClienteTel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblClienteTel.Location = New System.Drawing.Point(87, 114)
        Me.lblClienteTel.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClienteTel.Name = "lblClienteTel"
        Me.lblClienteTel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClienteTel.Size = New System.Drawing.Size(353, 30)
        Me.lblClienteTel.TabIndex = 12
        Me.lblClienteTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClienteRuc
        '
        Me.lblClienteRuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblClienteRuc.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteRuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblClienteRuc.Location = New System.Drawing.Point(87, 76)
        Me.lblClienteRuc.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClienteRuc.Name = "lblClienteRuc"
        Me.lblClienteRuc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClienteRuc.Size = New System.Drawing.Size(353, 30)
        Me.lblClienteRuc.TabIndex = 12
        Me.lblClienteRuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClienteNombre
        '
        Me.lblClienteNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblClienteNombre.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblClienteNombre.Location = New System.Drawing.Point(87, 33)
        Me.lblClienteNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClienteNombre.Name = "lblClienteNombre"
        Me.lblClienteNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClienteNombre.Size = New System.Drawing.Size(353, 30)
        Me.lblClienteNombre.TabIndex = 12
        Me.lblClienteNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1220, 58)
        Me.Panel1.TabIndex = 13
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(441, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(397, 38)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "VENTAS - ANULAR FACTURA"
        '
        'lblSupTotalOT
        '
        Me.lblSupTotalOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblSupTotalOT.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupTotalOT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSupTotalOT.Location = New System.Drawing.Point(570, 25)
        Me.lblSupTotalOT.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSupTotalOT.Name = "lblSupTotalOT"
        Me.lblSupTotalOT.Padding = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.lblSupTotalOT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSupTotalOT.Size = New System.Drawing.Size(96, 32)
        Me.lblSupTotalOT.TabIndex = 26
        Me.lblSupTotalOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label32.Location = New System.Drawing.Point(16, 33)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 19)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Nro. OT"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(488, 77)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 19)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Depósito:"
        '
        'lblDeposito
        '
        Me.lblDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblDeposito.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeposito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDeposito.Location = New System.Drawing.Point(570, 68)
        Me.lblDeposito.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDeposito.Size = New System.Drawing.Size(96, 30)
        Me.lblDeposito.TabIndex = 22
        Me.lblDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSucursal
        '
        Me.lblSucursal.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblSucursal.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSucursal.Location = New System.Drawing.Point(315, 68)
        Me.lblSucursal.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSucursal.Size = New System.Drawing.Size(169, 30)
        Me.lblSucursal.TabIndex = 23
        Me.lblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(230, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Sucursal:"
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblFechaVenta.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFechaVenta.Location = New System.Drawing.Point(87, 68)
        Me.lblFechaVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaVenta.Size = New System.Drawing.Size(126, 30)
        Me.lblFechaVenta.TabIndex = 24
        Me.lblFechaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOTSeleccionada
        '
        Me.lblOTSeleccionada.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblOTSeleccionada.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTSeleccionada.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOTSeleccionada.Location = New System.Drawing.Point(87, 25)
        Me.lblOTSeleccionada.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOTSeleccionada.Name = "lblOTSeleccionada"
        Me.lblOTSeleccionada.Padding = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.lblOTSeleccionada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOTSeleccionada.Size = New System.Drawing.Size(126, 32)
        Me.lblOTSeleccionada.TabIndex = 25
        Me.lblOTSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label36.Location = New System.Drawing.Point(488, 33)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(78, 19)
        Me.Label36.TabIndex = 20
        Me.Label36.Text = "Sup. Total: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.lblFactura)
        Me.GroupBox1.Controls.Add(Me.lblSupTotalOT)
        Me.GroupBox1.Controls.Add(Me.lblOTSeleccionada)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.lblDeposito)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblSucursal)
        Me.GroupBox1.Controls.Add(Me.lblFechaVenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(495, 138)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(695, 120)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos OT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(230, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Factura Nro"
        '
        'lblFactura
        '
        Me.lblFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblFactura.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFactura.Location = New System.Drawing.Point(315, 25)
        Me.lblFactura.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Padding = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.lblFactura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFactura.Size = New System.Drawing.Size(169, 32)
        Me.lblFactura.TabIndex = 26
        Me.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvAnulaciones
        '
        Me.dgvAnulaciones.AllowUserToAddRows = False
        Me.dgvAnulaciones.AllowUserToDeleteRows = False
        Me.dgvAnulaciones.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvAnulaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAnulaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAnulaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAnulaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAnulaciones.ColumnHeadersHeight = 30
        Me.dgvAnulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAnulaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.VentaCol, Me.FechaCol, Me.MontoCol, Me.EstadoPagoCOl})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAnulaciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAnulaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAnulaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAnulaciones.EnableHeadersVisualStyles = False
        Me.dgvAnulaciones.Location = New System.Drawing.Point(4, 22)
        Me.dgvAnulaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAnulaciones.MultiSelect = False
        Me.dgvAnulaciones.Name = "dgvAnulaciones"
        Me.dgvAnulaciones.RowHeadersVisible = False
        Me.dgvAnulaciones.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAnulaciones.RowTemplate.Height = 24
        Me.dgvAnulaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnulaciones.Size = New System.Drawing.Size(1162, 285)
        Me.dgvAnulaciones.TabIndex = 20
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvAnulaciones)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(20, 341)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1170, 311)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Anulaciones Registradas"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = Global.Frontend.My.Resources.Resources.eliminar2
        Me.Button1.Location = New System.Drawing.Point(495, 278)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 49)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Anular Factura"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.ForestGreen
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblResult.Location = New System.Drawing.Point(693, 291)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Padding = New System.Windows.Forms.Padding(5)
        Me.lblResult.Size = New System.Drawing.Size(130, 30)
        Me.lblResult.TabIndex = 29
        Me.lblResult.Text = "Factura Anulada"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResult.Visible = False
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'VentaCol
        '
        Me.VentaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VentaCol.DataPropertyName = "OT"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.VentaCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.VentaCol.HeaderText = "Venta"
        Me.VentaCol.Name = "VentaCol"
        Me.VentaCol.Visible = False
        '
        'FechaCol
        '
        Me.FechaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaCol.DataPropertyName = "Fecha"
        Me.FechaCol.HeaderText = "Fecha"
        Me.FechaCol.Name = "FechaCol"
        '
        'MontoCol
        '
        Me.MontoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MontoCol.DataPropertyName = "UsuarioIns"
        Me.MontoCol.HeaderText = "Usuario. Ins"
        Me.MontoCol.Name = "MontoCol"
        '
        'EstadoPagoCOl
        '
        Me.EstadoPagoCOl.DataPropertyName = "motivo"
        Me.EstadoPagoCOl.HeaderText = "Motivo"
        Me.EstadoPagoCOl.Name = "EstadoPagoCOl"
        '
        'AnularFacturaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1220, 682)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbDatosCliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "AnularFacturaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnularFacturaForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbDatosCliente.ResumeLayout(False)
        Me.gbDatosCliente.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAnulaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbDatosCliente As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents lblR As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lblt As Label
    Friend WithEvents lblVendedor As Label
    Friend WithEvents lblClienteTel As Label
    Friend WithEvents lblClienteRuc As Label
    Friend WithEvents lblClienteNombre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSupTotalOT As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblDeposito As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFechaVenta As Label
    Friend WithEvents lblOTSeleccionada As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFactura As Label
    Friend WithEvents dgvAnulaciones As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents VentaCol As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents MontoCol As DataGridViewTextBoxColumn
    Friend WithEvents EstadoPagoCOl As DataGridViewTextBoxColumn
End Class
