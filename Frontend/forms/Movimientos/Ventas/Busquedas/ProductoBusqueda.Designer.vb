<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoBusqueda
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ULTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 59)
        Me.Panel1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(264, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 41)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Buscar Producto"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NombreC, Me.CIC, Me.RUCC, Me.TipoC, Me.Insert, Me.ULTA, Me.FechaACT})
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle22
        Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.Location = New System.Drawing.Point(44, 184)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(684, 295)
        Me.dgvProductos.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ID.DefaultCellStyle = DataGridViewCellStyle14
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'NombreC
        '
        Me.NombreC.DataPropertyName = "Código"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.NombreC.DefaultCellStyle = DataGridViewCellStyle15
        Me.NombreC.HeaderText = "Código"
        Me.NombreC.Name = "NombreC"
        '
        'CIC
        '
        Me.CIC.DataPropertyName = "Descripción"
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.CIC.DefaultCellStyle = DataGridViewCellStyle16
        Me.CIC.HeaderText = "Descripción"
        Me.CIC.Name = "CIC"
        '
        'RUCC
        '
        Me.RUCC.DataPropertyName = "Tipo"
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.RUCC.DefaultCellStyle = DataGridViewCellStyle17
        Me.RUCC.HeaderText = "Tipo"
        Me.RUCC.Name = "RUCC"
        '
        'TipoC
        '
        Me.TipoC.DataPropertyName = "Alta"
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.TipoC.DefaultCellStyle = DataGridViewCellStyle18
        Me.TipoC.HeaderText = "Alta"
        Me.TipoC.Name = "TipoC"
        Me.TipoC.Visible = False
        '
        'Insert
        '
        Me.Insert.DataPropertyName = "Fecha alta"
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.Insert.DefaultCellStyle = DataGridViewCellStyle19
        Me.Insert.HeaderText = "Fecha alta"
        Me.Insert.Name = "Insert"
        Me.Insert.Visible = False
        '
        'ULTA
        '
        Me.ULTA.DataPropertyName = "Última mod"
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ULTA.DefaultCellStyle = DataGridViewCellStyle20
        Me.ULTA.HeaderText = "Última actualizacion"
        Me.ULTA.Name = "ULTA"
        Me.ULTA.Visible = False
        '
        'FechaACT
        '
        Me.FechaACT.DataPropertyName = "Fecha Última mod."
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.FechaACT.DefaultCellStyle = DataGridViewCellStyle21
        Me.FechaACT.HeaderText = "Fecha Última mod."
        Me.FechaACT.Name = "FechaACT"
        Me.FechaACT.Visible = False
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(240, 93)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(271, 25)
        Me.txtFiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(185, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Filtro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(149, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(437, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Seleccione un producto y presione enter para confirmar"
        '
        'ProductoBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductoBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda Producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NombreC As DataGridViewTextBoxColumn
    Friend WithEvents CIC As DataGridViewTextBoxColumn
    Friend WithEvents RUCC As DataGridViewTextBoxColumn
    Friend WithEvents TipoC As DataGridViewTextBoxColumn
    Friend WithEvents Insert As DataGridViewTextBoxColumn
    Friend WithEvents ULTA As DataGridViewTextBoxColumn
    Friend WithEvents FechaACT As DataGridViewTextBoxColumn
End Class
