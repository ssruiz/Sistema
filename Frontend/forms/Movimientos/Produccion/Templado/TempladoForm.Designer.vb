<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempladoForm
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
        Me.btnMesa1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSalidaEntrada = New System.Windows.Forms.Label()
        Me.lblRoturas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSalidas = New System.Windows.Forms.Label()
        Me.txtPulidora = New System.Windows.Forms.Label()
        Me.dgvPulida = New System.Windows.Forms.DataGridView()
        Me.NroProdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanhoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnchoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AltoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorteCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoturaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNroProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPiezas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEntradas = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPulida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMesa1
        '
        Me.btnMesa1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnMesa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMesa1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMesa1.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMesa1.Image = Global.Frontend.My.Resources.Resources.rotura1
        Me.btnMesa1.Location = New System.Drawing.Point(1062, 162)
        Me.btnMesa1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMesa1.Name = "btnMesa1"
        Me.btnMesa1.Size = New System.Drawing.Size(163, 69)
        Me.btnMesa1.TabIndex = 38
        Me.btnMesa1.Text = "Rotura"
        Me.btnMesa1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMesa1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSalidaEntrada)
        Me.GroupBox1.Controls.Add(Me.lblRoturas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblEntradas)
        Me.GroupBox1.Controls.Add(Me.lblSalidas)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox1.Location = New System.Drawing.Point(37, 154)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(743, 79)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DÍA"
        '
        'txtSalidaEntrada
        '
        Me.txtSalidaEntrada.AutoSize = True
        Me.txtSalidaEntrada.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalidaEntrada.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtSalidaEntrada.Location = New System.Drawing.Point(223, 36)
        Me.txtSalidaEntrada.Name = "txtSalidaEntrada"
        Me.txtSalidaEntrada.Size = New System.Drawing.Size(62, 23)
        Me.txtSalidaEntrada.TabIndex = 23
        Me.txtSalidaEntrada.Text = "Salidas"
        '
        'lblRoturas
        '
        Me.lblRoturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblRoturas.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoturas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRoturas.Location = New System.Drawing.Point(520, 29)
        Me.lblRoturas.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRoturas.Name = "lblRoturas"
        Me.lblRoturas.Padding = New System.Windows.Forms.Padding(4)
        Me.lblRoturas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRoturas.Size = New System.Drawing.Size(113, 34)
        Me.lblRoturas.TabIndex = 24
        Me.lblRoturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(448, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Roturas"
        '
        'lblSalidas
        '
        Me.lblSalidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblSalidas.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSalidas.Location = New System.Drawing.Point(303, 29)
        Me.lblSalidas.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSalidas.Name = "lblSalidas"
        Me.lblSalidas.Padding = New System.Windows.Forms.Padding(4)
        Me.lblSalidas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSalidas.Size = New System.Drawing.Size(113, 34)
        Me.lblSalidas.TabIndex = 26
        Me.lblSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPulidora
        '
        Me.txtPulidora.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPulidora.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulidora.ForeColor = System.Drawing.Color.AliceBlue
        Me.txtPulidora.Location = New System.Drawing.Point(762, 67)
        Me.txtPulidora.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPulidora.Name = "txtPulidora"
        Me.txtPulidora.Padding = New System.Windows.Forms.Padding(4)
        Me.txtPulidora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPulidora.Size = New System.Drawing.Size(463, 69)
        Me.txtPulidora.TabIndex = 37
        Me.txtPulidora.Text = "MESA DE PULIDA1"
        Me.txtPulidora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPulida
        '
        Me.dgvPulida.AllowUserToAddRows = False
        Me.dgvPulida.AllowUserToDeleteRows = False
        Me.dgvPulida.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPulida.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPulida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPulida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPulida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPulida.ColumnHeadersHeight = 30
        Me.dgvPulida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPulida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroProdCol, Me.FechaCol, Me.PanhoCol, Me.AnchoCol, Me.AltoCol, Me.CorteCol, Me.SalidaCol, Me.RoturaCol})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPulida.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPulida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPulida.EnableHeadersVisualStyles = False
        Me.dgvPulida.Location = New System.Drawing.Point(37, 283)
        Me.dgvPulida.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPulida.MultiSelect = False
        Me.dgvPulida.Name = "dgvPulida"
        Me.dgvPulida.RowHeadersVisible = False
        Me.dgvPulida.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPulida.RowTemplate.Height = 24
        Me.dgvPulida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPulida.Size = New System.Drawing.Size(1188, 382)
        Me.dgvPulida.TabIndex = 36
        '
        'NroProdCol
        '
        Me.NroProdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NroProdCol.DataPropertyName = "Nro. Prod."
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.NroProdCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.NroProdCol.HeaderText = "Nro. Prod."
        Me.NroProdCol.Name = "NroProdCol"
        '
        'FechaCol
        '
        Me.FechaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaCol.DataPropertyName = "Código"
        Me.FechaCol.HeaderText = "Código"
        Me.FechaCol.Name = "FechaCol"
        '
        'PanhoCol
        '
        Me.PanhoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PanhoCol.DataPropertyName = "Panho"
        Me.PanhoCol.HeaderText = "Paño"
        Me.PanhoCol.Name = "PanhoCol"
        '
        'AnchoCol
        '
        Me.AnchoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AnchoCol.DataPropertyName = "Ancho"
        Me.AnchoCol.HeaderText = "Ancho"
        Me.AnchoCol.Name = "AnchoCol"
        '
        'AltoCol
        '
        Me.AltoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AltoCol.DataPropertyName = "Alto"
        Me.AltoCol.HeaderText = "Alto"
        Me.AltoCol.Name = "AltoCol"
        '
        'CorteCol
        '
        Me.CorteCol.DataPropertyName = "Horno"
        Me.CorteCol.HeaderText = "Horno"
        Me.CorteCol.Name = "CorteCol"
        '
        'SalidaCol
        '
        Me.SalidaCol.DataPropertyName = "Salida"
        Me.SalidaCol.HeaderText = "Salida"
        Me.SalidaCol.Name = "SalidaCol"
        '
        'RoturaCol
        '
        Me.RoturaCol.DataPropertyName = "Rotura"
        Me.RoturaCol.HeaderText = "Rotura"
        Me.RoturaCol.Name = "RoturaCol"
        '
        'txtNroProd
        '
        Me.txtNroProd.Location = New System.Drawing.Point(153, 28)
        Me.txtNroProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroProd.Name = "txtNroProd"
        Me.txtNroProd.Size = New System.Drawing.Size(299, 30)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNroProd)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 67)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(478, 79)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(540, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(181, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "TEMPLADO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1297, 49)
        Me.Panel1.TabIndex = 33
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.Image = Global.Frontend.My.Resources.Resources.guardar
        Me.btnConfirmar.Location = New System.Drawing.Point(841, 164)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(200, 69)
        Me.btnConfirmar.TabIndex = 38
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(33, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Piezas:"
        '
        'lblPiezas
        '
        Me.lblPiezas.AutoSize = True
        Me.lblPiezas.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPiezas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPiezas.Location = New System.Drawing.Point(164, 247)
        Me.lblPiezas.Name = "lblPiezas"
        Me.lblPiezas.Size = New System.Drawing.Size(0, 23)
        Me.lblPiezas.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(15, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Entrada"
        '
        'lblEntradas
        '
        Me.lblEntradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblEntradas.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEntradas.Location = New System.Drawing.Point(87, 29)
        Me.lblEntradas.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEntradas.Name = "lblEntradas"
        Me.lblEntradas.Padding = New System.Windows.Forms.Padding(4)
        Me.lblEntradas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEntradas.Size = New System.Drawing.Size(113, 34)
        Me.lblEntradas.TabIndex = 26
        Me.lblEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TempladoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1297, 686)
        Me.Controls.Add(Me.lblPiezas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnMesa1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPulidora)
        Me.Controls.Add(Me.dgvPulida)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TempladoForm"
        Me.Text = "TempladoForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPulida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMesa1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSalidaEntrada As Label
    Friend WithEvents lblRoturas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSalidas As Label
    Friend WithEvents txtPulidora As Label
    Friend WithEvents dgvPulida As DataGridView
    Friend WithEvents txtNroProd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NroProdCol As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents PanhoCol As DataGridViewTextBoxColumn
    Friend WithEvents AnchoCol As DataGridViewTextBoxColumn
    Friend WithEvents AltoCol As DataGridViewTextBoxColumn
    Friend WithEvents CorteCol As DataGridViewTextBoxColumn
    Friend WithEvents SalidaCol As DataGridViewTextBoxColumn
    Friend WithEvents RoturaCol As DataGridViewTextBoxColumn
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPiezas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEntradas As Label
End Class
