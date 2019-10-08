<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovInternoForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCodCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblDatosProdutcosDetalle = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblDescPr = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbDepo2 = New System.Windows.Forms.ComboBox()
        Me.cbDepo1 = New System.Windows.Forms.ComboBox()
        Me.cbS2 = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbS1 = New System.Windows.Forms.ComboBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAuto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblDatosProdutcosDetalle.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tblDatosProdutcosDetalle, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.308057!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.87156!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.97248!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.99541!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1392, 872)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEliminarProd)
        Me.Panel3.Controls.Add(Me.dgvProductos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 374)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1392, 498)
        Me.Panel3.TabIndex = 5
        '
        'btnEliminarProd
        '
        Me.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProd.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarProd.Image = Global.Frontend.My.Resources.Resources.eliminar2
        Me.btnEliminarProd.Location = New System.Drawing.Point(1268, 65)
        Me.btnEliminarProd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminarProd.Name = "btnEliminarProd"
        Me.btnEliminarProd.Size = New System.Drawing.Size(63, 53)
        Me.btnEliminarProd.TabIndex = 18
        Me.btnEliminarProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarProd.UseVisualStyleBackColor = False
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.MovCol, Me.IDProdCol, Me.ProdCodCol, Me.ProductoCol, Me.CantidadCol})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.Location = New System.Drawing.Point(47, 65)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1193, 417)
        Me.dgvProductos.TabIndex = 16
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ID.DefaultCellStyle = DataGridViewCellStyle10
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'MovCol
        '
        Me.MovCol.DataPropertyName = "Mov"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.MovCol.DefaultCellStyle = DataGridViewCellStyle11
        Me.MovCol.HeaderText = "Mov"
        Me.MovCol.Name = "MovCol"
        Me.MovCol.Visible = False
        '
        'IDProdCol
        '
        Me.IDProdCol.DataPropertyName = "ProdID"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.IDProdCol.DefaultCellStyle = DataGridViewCellStyle12
        Me.IDProdCol.HeaderText = "ProdID"
        Me.IDProdCol.Name = "IDProdCol"
        Me.IDProdCol.Visible = False
        '
        'ProdCodCol
        '
        Me.ProdCodCol.DataPropertyName = "Código"
        Me.ProdCodCol.HeaderText = "Código"
        Me.ProdCodCol.Name = "ProdCodCol"
        '
        'ProductoCol
        '
        Me.ProductoCol.DataPropertyName = "Producto"
        Me.ProductoCol.HeaderText = "Producto"
        Me.ProductoCol.Name = "ProductoCol"
        '
        'CantidadCol
        '
        Me.CantidadCol.DataPropertyName = "Cantidad"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.CantidadCol.DefaultCellStyle = DataGridViewCellStyle13
        Me.CantidadCol.HeaderText = "Cantidad"
        Me.CantidadCol.Name = "CantidadCol"
        '
        'tblDatosProdutcosDetalle
        '
        Me.tblDatosProdutcosDetalle.ColumnCount = 1
        Me.tblDatosProdutcosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31185!))
        Me.tblDatosProdutcosDetalle.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.tblDatosProdutcosDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDatosProdutcosDetalle.Location = New System.Drawing.Point(0, 227)
        Me.tblDatosProdutcosDetalle.Margin = New System.Windows.Forms.Padding(0)
        Me.tblDatosProdutcosDetalle.Name = "tblDatosProdutcosDetalle"
        Me.tblDatosProdutcosDetalle.RowCount = 1
        Me.tblDatosProdutcosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosProdutcosDetalle.Size = New System.Drawing.Size(1392, 147)
        Me.tblDatosProdutcosDetalle.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1392, 147)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1390, 146)
        Me.Panel5.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox2)
        Me.Panel6.Controls.Add(Me.btnBuscar)
        Me.Panel6.Controls.Add(Me.btnGuardar)
        Me.Panel6.Controls.Add(Me.btnNuevo)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1390, 146)
        Me.Panel6.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.lblDescPr)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblDesc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCodProd)
        Me.GroupBox2.Controls.Add(Me.lblCodigo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblStock)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(165, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1225, 146)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(32, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 19)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Código Producto"
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(693, 53)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(254, 25)
        Me.txtCantidad.TabIndex = 0
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDescPr
        '
        Me.lblDescPr.AutoSize = True
        Me.lblDescPr.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDescPr.Location = New System.Drawing.Point(185, 83)
        Me.lblDescPr.Name = "lblDescPr"
        Me.lblDescPr.Size = New System.Drawing.Size(0, 19)
        Me.lblDescPr.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(546, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 19)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Cantidad"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDesc.Location = New System.Drawing.Point(32, 83)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(79, 19)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(382, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código"
        '
        'txtCodProd
        '
        Me.txtCodProd.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(178, 35)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(157, 25)
        Me.txtCodProd.TabIndex = 0
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCodigo.Location = New System.Drawing.Point(536, 38)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(0, 19)
        Me.lblCodigo.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(382, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Stock disponible"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStock.Location = New System.Drawing.Point(536, 83)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(0, 19)
        Me.lblStock.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Image = Global.Frontend.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(165, 40)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(63, 53)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Image = Global.Frontend.My.Resources.Resources.guardar
        Me.btnGuardar.Location = New System.Drawing.Point(18, 40)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(63, 53)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar Movimiento")
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Image = Global.Frontend.My.Resources.Resources.nuevo
        Me.btnNuevo.Location = New System.Drawing.Point(93, 40)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(63, 53)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo Movimiento")
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbDepo2)
        Me.GroupBox1.Controls.Add(Me.cbDepo1)
        Me.GroupBox1.Controls.Add(Me.cbS2)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.cbS1)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSolicitante)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblAuto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1386, 175)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cbDepo2
        '
        Me.cbDepo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepo2.FormattingEnabled = True
        Me.cbDepo2.Location = New System.Drawing.Point(1105, 114)
        Me.cbDepo2.Name = "cbDepo2"
        Me.cbDepo2.Size = New System.Drawing.Size(254, 24)
        Me.cbDepo2.TabIndex = 12
        '
        'cbDepo1
        '
        Me.cbDepo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepo1.FormattingEnabled = True
        Me.cbDepo1.Location = New System.Drawing.Point(1105, 64)
        Me.cbDepo1.Name = "cbDepo1"
        Me.cbDepo1.Size = New System.Drawing.Size(254, 24)
        Me.cbDepo1.TabIndex = 12
        '
        'cbS2
        '
        Me.cbS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbS2.FormattingEnabled = True
        Me.cbS2.Location = New System.Drawing.Point(676, 117)
        Me.cbS2.Name = "cbS2"
        Me.cbS2.Size = New System.Drawing.Size(254, 24)
        Me.cbS2.TabIndex = 12
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label32.Location = New System.Drawing.Point(24, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(105, 17)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Autorizado por:"
        '
        'cbS1
        '
        Me.cbS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbS1.FormattingEnabled = True
        Me.cbS1.Location = New System.Drawing.Point(676, 70)
        Me.cbS1.Name = "cbS1"
        Me.cbS1.Size = New System.Drawing.Size(254, 24)
        Me.cbS1.TabIndex = 12
        '
        'txtObservacion
        '
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(118, 119)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(396, 22)
        Me.txtObservacion.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(24, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Observación"
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicitante.Location = New System.Drawing.Point(351, 75)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(163, 22)
        Me.txtSolicitante.TabIndex = 0
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(118, 75)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(136, 22)
        Me.txtFecha.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(271, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Solicitante"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(24, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(536, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Sucursal Destino:"
        '
        'lblAuto
        '
        Me.lblAuto.AutoSize = True
        Me.lblAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAuto.Location = New System.Drawing.Point(170, 40)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(36, 17)
        Me.lblAuto.TabIndex = 9
        Me.lblAuto.Text = "auto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(952, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Depósito Destino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(536, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sucursal Origen:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(952, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 17)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Depósito Origen"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1392, 46)
        Me.Panel1.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(535, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(302, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Movimiento Interno"
        '
        'MovInternoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1392, 872)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MovInternoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovInterno"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblDatosProdutcosDetalle.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tblDatosProdutcosDetalle As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEliminarProd As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblDescPr As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents MovCol As DataGridViewTextBoxColumn
    Friend WithEvents IDProdCol As DataGridViewTextBoxColumn
    Friend WithEvents ProdCodCol As DataGridViewTextBoxColumn
    Friend WithEvents ProductoCol As DataGridViewTextBoxColumn
    Friend WithEvents CantidadCol As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbDepo2 As ComboBox
    Friend WithEvents cbDepo1 As ComboBox
    Friend WithEvents cbS2 As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents cbS1 As ComboBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAuto As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtSolicitante As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
