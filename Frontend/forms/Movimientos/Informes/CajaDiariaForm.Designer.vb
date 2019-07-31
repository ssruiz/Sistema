<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CajaDiariaForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblRecargoGS = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDescuentoGS = New System.Windows.Forms.Label()
        Me.lblCredito = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblContado = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblReposiciones = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelTotalm2 = New System.Windows.Forms.Label()
        Me.labelPromediom2 = New System.Windows.Forms.Label()
        Me.dpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dpFehaI = New System.Windows.Forms.DateTimePicker()
        Me.lblAnuladas = New System.Windows.Forms.Label()
        Me.lblTotalGS = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPromedioGS = New System.Windows.Forms.Label()
        Me.lblM2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbcreditosald = New System.Windows.Forms.RadioButton()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.rbContado = New System.Windows.Forms.RadioButton()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbAnulados = New System.Windows.Forms.CheckBox()
        Me.rbPorSuperficie = New System.Windows.Forms.RadioButton()
        Me.rbPorUnidad = New System.Windows.Forms.RadioButton()
        Me.rbTodosSupUn = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDetalleVenta = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M2Col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.622517!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27152!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.10596!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1378, 755)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1378, 50)
        Me.Panel1.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(503, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(346, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "CAJA DIARIA - VENTAS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1372, 365)
        Me.Panel2.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.lblRecargoGS)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lblDescuentoGS)
        Me.GroupBox3.Controls.Add(Me.lblCredito)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lblContado)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblReposiciones)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.labelTotalm2)
        Me.GroupBox3.Controls.Add(Me.labelPromediom2)
        Me.GroupBox3.Controls.Add(Me.dpFechaFin)
        Me.GroupBox3.Controls.Add(Me.dpFehaI)
        Me.GroupBox3.Controls.Add(Me.lblAnuladas)
        Me.GroupBox3.Controls.Add(Me.lblTotalGS)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblPromedioGS)
        Me.GroupBox3.Controls.Add(Me.lblM2)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1345, 227)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(704, 37)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 23)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Recargo Gs."
        '
        'lblRecargoGS
        '
        Me.lblRecargoGS.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblRecargoGS.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecargoGS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRecargoGS.Location = New System.Drawing.Point(820, 30)
        Me.lblRecargoGS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRecargoGS.Name = "lblRecargoGS"
        Me.lblRecargoGS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRecargoGS.Size = New System.Drawing.Size(214, 30)
        Me.lblRecargoGS.TabIndex = 26
        Me.lblRecargoGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(694, 84)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 23)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Descuentos Gs"
        '
        'lblDescuentoGS
        '
        Me.lblDescuentoGS.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblDescuentoGS.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoGS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDescuentoGS.Location = New System.Drawing.Point(820, 79)
        Me.lblDescuentoGS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDescuentoGS.Name = "lblDescuentoGS"
        Me.lblDescuentoGS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescuentoGS.Size = New System.Drawing.Size(214, 30)
        Me.lblDescuentoGS.TabIndex = 24
        Me.lblDescuentoGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCredito
        '
        Me.lblCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblCredito.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCredito.Location = New System.Drawing.Point(580, 127)
        Me.lblCredito.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCredito.Size = New System.Drawing.Size(82, 30)
        Me.lblCredito.TabIndex = 22
        Me.lblCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(388, 132)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 23)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Ventas a crédito"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(388, 183)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 23)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Ventas al contado"
        '
        'lblContado
        '
        Me.lblContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblContado.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblContado.Location = New System.Drawing.Point(580, 176)
        Me.lblContado.Margin = New System.Windows.Forms.Padding(0)
        Me.lblContado.Name = "lblContado"
        Me.lblContado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblContado.Size = New System.Drawing.Size(82, 30)
        Me.lblContado.TabIndex = 20
        Me.lblContado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Image = Global.Frontend.My.Resources.Resources.reporte2
        Me.Button3.Location = New System.Drawing.Point(1074, 132)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 52)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Generar Informe"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Image = Global.Frontend.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(1074, 55)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(172, 49)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(385, 81)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 23)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Cantidad Reposiciones"
        Me.Label11.Visible = False
        '
        'lblReposiciones
        '
        Me.lblReposiciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblReposiciones.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReposiciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblReposiciones.Location = New System.Drawing.Point(580, 79)
        Me.lblReposiciones.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReposiciones.Name = "lblReposiciones"
        Me.lblReposiciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblReposiciones.Size = New System.Drawing.Size(82, 30)
        Me.lblReposiciones.TabIndex = 17
        Me.lblReposiciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReposiciones.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(132, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(214, 30)
        Me.Label4.TabIndex = 14
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(385, 35)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Ventas Anuladas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(735, 181)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Total Gs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(680, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio Promedio"
        '
        'labelTotalm2
        '
        Me.labelTotalm2.AutoSize = True
        Me.labelTotalm2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalm2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTotalm2.Location = New System.Drawing.Point(14, 132)
        Me.labelTotalm2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTotalm2.Name = "labelTotalm2"
        Me.labelTotalm2.Size = New System.Drawing.Size(76, 23)
        Me.labelTotalm2.TabIndex = 13
        Me.labelTotalm2.Text = "Total M2"
        '
        'labelPromediom2
        '
        Me.labelPromediom2.AutoSize = True
        Me.labelPromediom2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPromediom2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelPromediom2.Location = New System.Drawing.Point(14, 181)
        Me.labelPromediom2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelPromediom2.Name = "labelPromediom2"
        Me.labelPromediom2.Size = New System.Drawing.Size(114, 23)
        Me.labelPromediom2.TabIndex = 13
        Me.labelPromediom2.Text = "Promedio M2"
        '
        'dpFechaFin
        '
        Me.dpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaFin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dpFechaFin.Location = New System.Drawing.Point(127, 80)
        Me.dpFechaFin.Name = "dpFechaFin"
        Me.dpFechaFin.Size = New System.Drawing.Size(219, 30)
        Me.dpFechaFin.TabIndex = 15
        '
        'dpFehaI
        '
        Me.dpFehaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFehaI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dpFehaI.Location = New System.Drawing.Point(127, 35)
        Me.dpFehaI.Name = "dpFehaI"
        Me.dpFehaI.Size = New System.Drawing.Size(219, 30)
        Me.dpFehaI.TabIndex = 15
        '
        'lblAnuladas
        '
        Me.lblAnuladas.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblAnuladas.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnuladas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAnuladas.Location = New System.Drawing.Point(580, 33)
        Me.lblAnuladas.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAnuladas.Name = "lblAnuladas"
        Me.lblAnuladas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnuladas.Size = New System.Drawing.Size(82, 30)
        Me.lblAnuladas.TabIndex = 14
        Me.lblAnuladas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalGS
        '
        Me.lblTotalGS.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTotalGS.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalGS.Location = New System.Drawing.Point(820, 176)
        Me.lblTotalGS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalGS.Name = "lblTotalGS"
        Me.lblTotalGS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalGS.Size = New System.Drawing.Size(214, 30)
        Me.lblTotalGS.TabIndex = 14
        Me.lblTotalGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(14, 84)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 23)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Fecha Fin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(14, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha Inicio"
        '
        'lblPromedioGS
        '
        Me.lblPromedioGS.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblPromedioGS.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedioGS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPromedioGS.Location = New System.Drawing.Point(820, 127)
        Me.lblPromedioGS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPromedioGS.Name = "lblPromedioGS"
        Me.lblPromedioGS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPromedioGS.Size = New System.Drawing.Size(214, 30)
        Me.lblPromedioGS.TabIndex = 14
        Me.lblPromedioGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblM2
        '
        Me.lblM2.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblM2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblM2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblM2.Location = New System.Drawing.Point(132, 127)
        Me.lblM2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblM2.Name = "lblM2"
        Me.lblM2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblM2.Size = New System.Drawing.Size(214, 30)
        Me.lblM2.TabIndex = 14
        Me.lblM2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbcreditosald)
        Me.GroupBox2.Controls.Add(Me.rbCredito)
        Me.GroupBox2.Controls.Add(Me.rbContado)
        Me.GroupBox2.Controls.Add(Me.rbAll)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(496, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 71)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros tipo venta"
        '
        'rbcreditosald
        '
        Me.rbcreditosald.AutoSize = True
        Me.rbcreditosald.Location = New System.Drawing.Point(324, 29)
        Me.rbcreditosald.Name = "rbcreditosald"
        Me.rbcreditosald.Size = New System.Drawing.Size(153, 27)
        Me.rbcreditosald.TabIndex = 0
        Me.rbcreditosald.Text = "Crédito Saldado"
        Me.rbcreditosald.UseVisualStyleBackColor = True
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Location = New System.Drawing.Point(221, 29)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(87, 27)
        Me.rbCredito.TabIndex = 0
        Me.rbCredito.Text = "Crédito"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'rbContado
        '
        Me.rbContado.AutoSize = True
        Me.rbContado.Location = New System.Drawing.Point(108, 29)
        Me.rbContado.Name = "rbContado"
        Me.rbContado.Size = New System.Drawing.Size(97, 27)
        Me.rbContado.TabIndex = 0
        Me.rbContado.Text = "Contado"
        Me.rbContado.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Location = New System.Drawing.Point(16, 29)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(75, 27)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "Todos"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbAnulados)
        Me.GroupBox1.Controls.Add(Me.rbPorSuperficie)
        Me.GroupBox1.Controls.Add(Me.rbPorUnidad)
        Me.GroupBox1.Controls.Add(Me.rbTodosSupUn)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(9, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 71)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de ventas"
        '
        'chbAnulados
        '
        Me.chbAnulados.AutoSize = True
        Me.chbAnulados.Checked = True
        Me.chbAnulados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbAnulados.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chbAnulados.Location = New System.Drawing.Point(362, 32)
        Me.chbAnulados.Name = "chbAnulados"
        Me.chbAnulados.Size = New System.Drawing.Size(103, 27)
        Me.chbAnulados.TabIndex = 0
        Me.chbAnulados.Text = "Anulados"
        Me.chbAnulados.UseVisualStyleBackColor = True
        '
        'rbPorSuperficie
        '
        Me.rbPorSuperficie.AutoSize = True
        Me.rbPorSuperficie.Location = New System.Drawing.Point(221, 32)
        Me.rbPorSuperficie.Name = "rbPorSuperficie"
        Me.rbPorSuperficie.Size = New System.Drawing.Size(135, 27)
        Me.rbPorSuperficie.TabIndex = 0
        Me.rbPorSuperficie.Text = "Por Superficie"
        Me.rbPorSuperficie.UseVisualStyleBackColor = True
        '
        'rbPorUnidad
        '
        Me.rbPorUnidad.AutoSize = True
        Me.rbPorUnidad.Location = New System.Drawing.Point(101, 33)
        Me.rbPorUnidad.Name = "rbPorUnidad"
        Me.rbPorUnidad.Size = New System.Drawing.Size(114, 27)
        Me.rbPorUnidad.TabIndex = 0
        Me.rbPorUnidad.Text = "Por unidad"
        Me.rbPorUnidad.UseVisualStyleBackColor = True
        '
        'rbTodosSupUn
        '
        Me.rbTodosSupUn.AutoSize = True
        Me.rbTodosSupUn.Checked = True
        Me.rbTodosSupUn.Location = New System.Drawing.Point(15, 33)
        Me.rbTodosSupUn.Name = "rbTodosSupUn"
        Me.rbTodosSupUn.Size = New System.Drawing.Size(75, 27)
        Me.rbTodosSupUn.TabIndex = 0
        Me.rbTodosSupUn.TabStop = True
        Me.rbTodosSupUn.Text = "Todos"
        Me.rbTodosSupUn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDetalleVenta)
        Me.Panel3.Controls.Add(Me.dgvVentas)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 424)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1372, 328)
        Me.Panel3.TabIndex = 8
        '
        'btnDetalleVenta
        '
        Me.btnDetalleVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleVenta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleVenta.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDetalleVenta.Image = Global.Frontend.My.Resources.Resources.actualizar
        Me.btnDetalleVenta.Location = New System.Drawing.Point(1147, 14)
        Me.btnDetalleVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDetalleVenta.Name = "btnDetalleVenta"
        Me.btnDetalleVenta.Size = New System.Drawing.Size(185, 49)
        Me.btnDetalleVenta.TabIndex = 23
        Me.btnDetalleVenta.Text = "Ver Detalle"
        Me.btnDetalleVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDetalleVenta.UseVisualStyleBackColor = False
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVentas.ColumnHeadersHeight = 35
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FechaCol, Me.ClienteCol, Me.TotalCol, Me.M2Col, Me.EstadoCol})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentas.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVentas.EnableHeadersVisualStyles = False
        Me.dgvVentas.Location = New System.Drawing.Point(9, 1)
        Me.dgvVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(1097, 326)
        Me.dgvVentas.TabIndex = 18
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'FechaCol
        '
        Me.FechaCol.DataPropertyName = "Fecha"
        Me.FechaCol.HeaderText = "Fecha"
        Me.FechaCol.Name = "FechaCol"
        '
        'ClienteCol
        '
        Me.ClienteCol.DataPropertyName = "Cliente"
        Me.ClienteCol.HeaderText = "Cliente"
        Me.ClienteCol.Name = "ClienteCol"
        '
        'TotalCol
        '
        Me.TotalCol.DataPropertyName = "Total"
        Me.TotalCol.HeaderText = "Total"
        Me.TotalCol.Name = "TotalCol"
        '
        'M2Col
        '
        Me.M2Col.DataPropertyName = "M2"
        Me.M2Col.HeaderText = "M2"
        Me.M2Col.Name = "M2Col"
        '
        'EstadoCol
        '
        Me.EstadoCol.DataPropertyName = "Estado"
        Me.EstadoCol.HeaderText = "Estado"
        Me.EstadoCol.Name = "EstadoCol"
        '
        'CajaDiariaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1378, 755)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CajaDiariaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CajaDiariaForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dpFehaI As DateTimePicker
    Friend WithEvents lblM2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelTotalm2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblReposiciones As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents labelPromediom2 As Label
    Friend WithEvents lblAnuladas As Label
    Friend WithEvents lblTotalGS As Label
    Friend WithEvents lblPromedioGS As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbCredito As RadioButton
    Friend WithEvents rbContado As RadioButton
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chbAnulados As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lblRecargoGS As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblDescuentoGS As Label
    Friend WithEvents lblCredito As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblContado As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDetalleVenta As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents ClienteCol As DataGridViewTextBoxColumn
    Friend WithEvents TotalCol As DataGridViewTextBoxColumn
    Friend WithEvents M2Col As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCol As DataGridViewTextBoxColumn
    Friend WithEvents dpFechaFin As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents rbcreditosald As RadioButton
    Friend WithEvents rbTodosSupUn As RadioButton
    Friend WithEvents rbPorSuperficie As RadioButton
    Friend WithEvents rbPorUnidad As RadioButton
End Class
