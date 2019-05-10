<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockForm
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbTemplados = New System.Windows.Forms.RadioButton()
        Me.rbPlanchas = New System.Windows.Forms.RadioButton()
        Me.rbPerfiles = New System.Windows.Forms.RadioButton()
        Me.rbHerrajes = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1106, 70)
        Me.Panel1.TabIndex = 5
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(372, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(348, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "STOCK DE PRODUCTOS"
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.txtBusqueda)
        Me.gbTipo.Controls.Add(Me.Label1)
        Me.gbTipo.Controls.Add(Me.rbTemplados)
        Me.gbTipo.Controls.Add(Me.rbPlanchas)
        Me.gbTipo.Controls.Add(Me.rbPerfiles)
        Me.gbTipo.Controls.Add(Me.rbTodos)
        Me.gbTipo.Controls.Add(Me.rbHerrajes)
        Me.gbTipo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbTipo.Location = New System.Drawing.Point(12, 85)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(1082, 125)
        Me.gbTipo.TabIndex = 7
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
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbTodos.Location = New System.Drawing.Point(184, 26)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(70, 24)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgvProductos)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(9, 11, 9, 11)
        Me.GroupBox1.Size = New System.Drawing.Size(1082, 393)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvProductos.Location = New System.Drawing.Point(9, 31)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1064, 351)
        Me.dgvProductos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filtro"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(231, 80)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(259, 27)
        Me.txtBusqueda.TabIndex = 6
        '
        'StockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1106, 834)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StockForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbTipo As GroupBox
    Friend WithEvents rbTemplados As RadioButton
    Friend WithEvents rbPlanchas As RadioButton
    Friend WithEvents rbPerfiles As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbHerrajes As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label1 As Label
End Class
