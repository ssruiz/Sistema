<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaBusqueda
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chPendiente = New System.Windows.Forms.CheckBox()
        Me.chDevuelto = New System.Windows.Forms.CheckBox()
        Me.chCobrado = New System.Windows.Forms.CheckBox()
        Me.chAnulado = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 49)
        Me.Panel1.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(471, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 41)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Buscar Venta"
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AllowUserToResizeColumns = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FechaC, Me.Factura, Me.ClienteCod, Me.Cliente, Me.Estado})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentas.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVentas.EnableHeadersVisualStyles = False
        Me.dgvVentas.Location = New System.Drawing.Point(39, 211)
        Me.dgvVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(1103, 351)
        Me.dgvVentas.TabIndex = 16
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
        'FechaC
        '
        Me.FechaC.DataPropertyName = "Fecha"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.FechaC.DefaultCellStyle = DataGridViewCellStyle11
        Me.FechaC.HeaderText = "Fecha"
        Me.FechaC.Name = "FechaC"
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "Factura"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.Factura.DefaultCellStyle = DataGridViewCellStyle12
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        '
        'ClienteCod
        '
        Me.ClienteCod.DataPropertyName = "ClienteCod"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ClienteCod.DefaultCellStyle = DataGridViewCellStyle13
        Me.ClienteCod.HeaderText = "ClienteCod"
        Me.ClienteCod.Name = "ClienteCod"
        Me.ClienteCod.Visible = False
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(390, 39)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(320, 30)
        Me.txtFiltro.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(324, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Filtro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(363, 184)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Seleccione una venta y presione enter para confirmar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chPendiente)
        Me.GroupBox1.Controls.Add(Me.chDevuelto)
        Me.GroupBox1.Controls.Add(Me.chCobrado)
        Me.GroupBox1.Controls.Add(Me.chAnulado)
        Me.GroupBox1.Controls.Add(Me.txtFiltro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(39, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1080, 96)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'chPendiente
        '
        Me.chPendiente.AutoSize = True
        Me.chPendiente.Location = New System.Drawing.Point(721, 139)
        Me.chPendiente.Margin = New System.Windows.Forms.Padding(4)
        Me.chPendiente.Name = "chPendiente"
        Me.chPendiente.Size = New System.Drawing.Size(175, 27)
        Me.chPendiente.TabIndex = 0
        Me.chPendiente.Text = "Pendiente de Pago"
        Me.chPendiente.UseVisualStyleBackColor = True
        Me.chPendiente.Visible = False
        '
        'chDevuelto
        '
        Me.chDevuelto.AutoSize = True
        Me.chDevuelto.Location = New System.Drawing.Point(519, 139)
        Me.chDevuelto.Margin = New System.Windows.Forms.Padding(4)
        Me.chDevuelto.Name = "chDevuelto"
        Me.chDevuelto.Size = New System.Drawing.Size(100, 27)
        Me.chDevuelto.TabIndex = 0
        Me.chDevuelto.Text = "Devuelto"
        Me.chDevuelto.UseVisualStyleBackColor = True
        Me.chDevuelto.Visible = False
        '
        'chCobrado
        '
        Me.chCobrado.AutoSize = True
        Me.chCobrado.Location = New System.Drawing.Point(318, 139)
        Me.chCobrado.Margin = New System.Windows.Forms.Padding(4)
        Me.chCobrado.Name = "chCobrado"
        Me.chCobrado.Size = New System.Drawing.Size(98, 27)
        Me.chCobrado.TabIndex = 0
        Me.chCobrado.Text = "Cobrado"
        Me.chCobrado.UseVisualStyleBackColor = True
        Me.chCobrado.Visible = False
        '
        'chAnulado
        '
        Me.chAnulado.AutoSize = True
        Me.chAnulado.Location = New System.Drawing.Point(109, 139)
        Me.chAnulado.Margin = New System.Windows.Forms.Padding(4)
        Me.chAnulado.Name = "chAnulado"
        Me.chAnulado.Size = New System.Drawing.Size(96, 27)
        Me.chAnulado.TabIndex = 0
        Me.chAnulado.Text = "Anulado"
        Me.chAnulado.UseVisualStyleBackColor = True
        Me.chAnulado.Visible = False
        '
        'VentaBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1186, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "VentaBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentaBusqueda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FechaC As DataGridViewTextBoxColumn
    Friend WithEvents Factura As DataGridViewTextBoxColumn
    Friend WithEvents ClienteCod As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chPendiente As CheckBox
    Friend WithEvents chDevuelto As CheckBox
    Friend WithEvents chCobrado As CheckBox
    Friend WithEvents chAnulado As CheckBox
End Class
