<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarcadoForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRoturas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMarcados = New System.Windows.Forms.Label()
        Me.txtNroProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvPulida = New System.Windows.Forms.DataGridView()
        Me.NroProdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanhoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnchoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AltoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorteCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rotura1Col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbPlano = New System.Windows.Forms.PictureBox()
        Me.btnImgPrev = New System.Windows.Forms.Button()
        Me.btnImgNext = New System.Windows.Forms.Button()
        Me.btnMesa1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPulida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbPlano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblRoturas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblMarcados)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 163)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(476, 79)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(15, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Marcados"
        '
        'lblRoturas
        '
        Me.lblRoturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblRoturas.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoturas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRoturas.Location = New System.Drawing.Point(337, 27)
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
        Me.Label4.Location = New System.Drawing.Point(241, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Roturas"
        '
        'lblMarcados
        '
        Me.lblMarcados.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblMarcados.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMarcados.Location = New System.Drawing.Point(103, 27)
        Me.lblMarcados.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMarcados.Name = "lblMarcados"
        Me.lblMarcados.Padding = New System.Windows.Forms.Padding(4)
        Me.lblMarcados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMarcados.Size = New System.Drawing.Size(113, 34)
        Me.lblMarcados.TabIndex = 26
        Me.lblMarcados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNroProd
        '
        Me.txtNroProd.Location = New System.Drawing.Point(153, 28)
        Me.txtNroProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroProd.Name = "txtNroProd"
        Me.txtNroProd.Size = New System.Drawing.Size(299, 30)
        Me.txtNroProd.TabIndex = 8
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
        Me.GroupBox2.Location = New System.Drawing.Point(22, 62)
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
        Me.lblTitulo.Location = New System.Drawing.Point(520, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(173, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "MARCADO"
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
        Me.dgvPulida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroProdCol, Me.productoCol, Me.FechaCol, Me.PanhoCol, Me.AnchoCol, Me.AltoCol, Me.CorteCol, Me.Rotura1Col})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPulida.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPulida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPulida.EnableHeadersVisualStyles = False
        Me.dgvPulida.Location = New System.Drawing.Point(24, 479)
        Me.dgvPulida.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPulida.MultiSelect = False
        Me.dgvPulida.Name = "dgvPulida"
        Me.dgvPulida.RowHeadersVisible = False
        Me.dgvPulida.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPulida.RowTemplate.Height = 24
        Me.dgvPulida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPulida.Size = New System.Drawing.Size(1179, 264)
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
        'productoCol
        '
        Me.productoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productoCol.DataPropertyName = "Producto"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.productoCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.productoCol.HeaderText = "Producto"
        Me.productoCol.Name = "productoCol"
        Me.productoCol.Visible = False
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
        Me.CorteCol.DataPropertyName = "Marcado"
        Me.CorteCol.HeaderText = "Marcado"
        Me.CorteCol.Name = "CorteCol"
        '
        'Rotura1Col
        '
        Me.Rotura1Col.DataPropertyName = "Rotura1"
        Me.Rotura1Col.HeaderText = "Rotura"
        Me.Rotura1Col.Name = "Rotura1Col"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1257, 49)
        Me.Panel1.TabIndex = 33
        '
        'pbPlano
        '
        Me.pbPlano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPlano.Location = New System.Drawing.Point(3, 3)
        Me.pbPlano.Name = "pbPlano"
        Me.pbPlano.Size = New System.Drawing.Size(379, 212)
        Me.pbPlano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPlano.TabIndex = 39
        Me.pbPlano.TabStop = False
        '
        'btnImgPrev
        '
        Me.btnImgPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnImgPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImgPrev.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImgPrev.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImgPrev.Image = Global.Frontend.My.Resources.Resources.icons8_atrás_30
        Me.btnImgPrev.Location = New System.Drawing.Point(567, 163)
        Me.btnImgPrev.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImgPrev.Name = "btnImgPrev"
        Me.btnImgPrev.Size = New System.Drawing.Size(45, 69)
        Me.btnImgPrev.TabIndex = 38
        Me.btnImgPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImgPrev.UseVisualStyleBackColor = False
        '
        'btnImgNext
        '
        Me.btnImgNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnImgNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImgNext.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImgNext.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImgNext.Image = Global.Frontend.My.Resources.Resources.icons8_adelante_30
        Me.btnImgNext.Location = New System.Drawing.Point(1142, 163)
        Me.btnImgNext.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImgNext.Name = "btnImgNext"
        Me.btnImgNext.Size = New System.Drawing.Size(51, 69)
        Me.btnImgNext.TabIndex = 38
        Me.btnImgNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImgNext.UseVisualStyleBackColor = False
        '
        'btnMesa1
        '
        Me.btnMesa1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnMesa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMesa1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMesa1.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMesa1.Image = Global.Frontend.My.Resources.Resources.rotura1
        Me.btnMesa1.Location = New System.Drawing.Point(24, 265)
        Me.btnMesa1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMesa1.Name = "btnMesa1"
        Me.btnMesa1.Size = New System.Drawing.Size(163, 69)
        Me.btnMesa1.TabIndex = 38
        Me.btnMesa1.Text = "Rotura"
        Me.btnMesa1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMesa1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(876, 387)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 44)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "-"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(746, 387)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 44)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pbPlano)
        Me.Panel2.Location = New System.Drawing.Point(615, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 318)
        Me.Panel2.TabIndex = 52
        '
        'MarcadoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 782)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImgPrev)
        Me.Controls.Add(Me.btnImgNext)
        Me.Controls.Add(Me.btnMesa1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvPulida)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MarcadoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarcadoForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvPulida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbPlano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRoturas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMarcados As Label
    Friend WithEvents btnMesa1 As Button
    Friend WithEvents txtNroProd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvPulida As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NroProdCol As DataGridViewTextBoxColumn
    Friend WithEvents productoCol As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents PanhoCol As DataGridViewTextBoxColumn
    Friend WithEvents AnchoCol As DataGridViewTextBoxColumn
    Friend WithEvents AltoCol As DataGridViewTextBoxColumn
    Friend WithEvents CorteCol As DataGridViewTextBoxColumn
    Friend WithEvents Rotura1Col As DataGridViewTextBoxColumn
    Friend WithEvents pbPlano As PictureBox
    Friend WithEvents btnImgNext As Button
    Friend WithEvents btnImgPrev As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
