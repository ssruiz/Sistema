﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmarMIForm
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dpFin = New System.Windows.Forms.DateTimePicker()
        Me.dpInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblDesdeF = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHastaF = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbS1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDO = New System.Windows.Forms.TextBox()
        Me.txtAutorizado = New System.Windows.Forms.TextBox()
        Me.txtSolicidato = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtDD = New System.Windows.Forms.TextBox()
        Me.txtSD = New System.Windows.Forms.TextBox()
        Me.txtSO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.solCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAutorizar = New System.Windows.Forms.Button()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1392, 53)
        Me.Panel1.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(473, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(442, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Autorizar Movimiento Interno"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.dpFin)
        Me.GroupBox1.Controls.Add(Me.dpInicio)
        Me.GroupBox1.Controls.Add(Me.lblDesdeF)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblHastaF)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(17, 147)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(899, 161)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'dpFin
        '
        Me.dpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFin.Location = New System.Drawing.Point(336, 108)
        Me.dpFin.Margin = New System.Windows.Forms.Padding(4)
        Me.dpFin.Name = "dpFin"
        Me.dpFin.Size = New System.Drawing.Size(221, 30)
        Me.dpFin.TabIndex = 15
        '
        'dpInicio
        '
        Me.dpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpInicio.Location = New System.Drawing.Point(336, 31)
        Me.dpInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dpInicio.Name = "dpInicio"
        Me.dpInicio.Size = New System.Drawing.Size(221, 30)
        Me.dpInicio.TabIndex = 15
        '
        'lblDesdeF
        '
        Me.lblDesdeF.AutoSize = True
        Me.lblDesdeF.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesdeF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDesdeF.Location = New System.Drawing.Point(135, 37)
        Me.lblDesdeF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesdeF.Name = "lblDesdeF"
        Me.lblDesdeF.Size = New System.Drawing.Size(57, 23)
        Me.lblDesdeF.TabIndex = 14
        Me.lblDesdeF.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Desde"
        '
        'lblHastaF
        '
        Me.lblHastaF.AutoSize = True
        Me.lblHastaF.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHastaF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHastaF.Location = New System.Drawing.Point(135, 115)
        Me.lblHastaF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHastaF.Name = "lblHastaF"
        Me.lblHastaF.Size = New System.Drawing.Size(54, 23)
        Me.lblHastaF.TabIndex = 14
        Me.lblHastaF.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(17, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Hasta"
        '
        'cbS1
        '
        Me.cbS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbS1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbS1.FormattingEnabled = True
        Me.cbS1.Location = New System.Drawing.Point(94, 91)
        Me.cbS1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbS1.Name = "cbS1"
        Me.cbS1.Size = New System.Drawing.Size(325, 31)
        Me.cbS1.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(13, 94)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Sucursal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDO)
        Me.GroupBox2.Controls.Add(Me.txtAutorizado)
        Me.GroupBox2.Controls.Add(Me.txtSolicidato)
        Me.GroupBox2.Controls.Add(Me.txtFecha)
        Me.GroupBox2.Controls.Add(Me.txtDD)
        Me.GroupBox2.Controls.Add(Me.txtSD)
        Me.GroupBox2.Controls.Add(Me.txtSO)
        Me.GroupBox2.Controls.Add(Me.btnDetalle)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(17, 320)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1309, 199)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Movimiento"
        '
        'txtDO
        '
        Me.txtDO.Enabled = False
        Me.txtDO.Location = New System.Drawing.Point(168, 134)
        Me.txtDO.Name = "txtDO"
        Me.txtDO.Size = New System.Drawing.Size(176, 30)
        Me.txtDO.TabIndex = 17
        '
        'txtAutorizado
        '
        Me.txtAutorizado.Enabled = False
        Me.txtAutorizado.Location = New System.Drawing.Point(844, 148)
        Me.txtAutorizado.Name = "txtAutorizado"
        Me.txtAutorizado.Size = New System.Drawing.Size(164, 30)
        Me.txtAutorizado.TabIndex = 17
        '
        'txtSolicidato
        '
        Me.txtSolicidato.Enabled = False
        Me.txtSolicidato.Location = New System.Drawing.Point(844, 99)
        Me.txtSolicidato.Name = "txtSolicidato"
        Me.txtSolicidato.Size = New System.Drawing.Size(164, 30)
        Me.txtSolicidato.TabIndex = 17
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(844, 48)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(164, 30)
        Me.txtFecha.TabIndex = 17
        '
        'txtDD
        '
        Me.txtDD.Enabled = False
        Me.txtDD.Location = New System.Drawing.Point(522, 134)
        Me.txtDD.Name = "txtDD"
        Me.txtDD.Size = New System.Drawing.Size(164, 30)
        Me.txtDD.TabIndex = 17
        '
        'txtSD
        '
        Me.txtSD.Enabled = False
        Me.txtSD.Location = New System.Drawing.Point(522, 66)
        Me.txtSD.Name = "txtSD"
        Me.txtSD.Size = New System.Drawing.Size(164, 30)
        Me.txtSD.TabIndex = 17
        '
        'txtSO
        '
        Me.txtSO.Enabled = False
        Me.txtSO.Location = New System.Drawing.Point(168, 63)
        Me.txtSO.Name = "txtSO"
        Me.txtSO.Size = New System.Drawing.Size(176, 30)
        Me.txtSO.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(708, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Autorizado por:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(708, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Solicitado por:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(708, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(375, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Sucursal Destino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(375, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Depósito Destino"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(27, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Depósito Origen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(21, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sucursal Origen"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvMovimientos)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(17, 530)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1309, 443)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Movimientos de la sucursal"
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToDeleteRows = False
        Me.dgvMovimientos.AllowUserToResizeColumns = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMovimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.MovCol, Me.solCol, Me.autoCol, Me.FechaCol, Me.EstadoCol, Me.SDCol})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMovimientos.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvMovimientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMovimientos.EnableHeadersVisualStyles = False
        Me.dgvMovimientos.Location = New System.Drawing.Point(49, 33)
        Me.dgvMovimientos.MultiSelect = False
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.RowHeadersVisible = False
        Me.dgvMovimientos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMovimientos.RowTemplate.Height = 24
        Me.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimientos.Size = New System.Drawing.Size(1191, 380)
        Me.dgvMovimientos.TabIndex = 17
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
        Me.MovCol.DataPropertyName = "SO"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.MovCol.DefaultCellStyle = DataGridViewCellStyle11
        Me.MovCol.HeaderText = "SO"
        Me.MovCol.Name = "MovCol"
        Me.MovCol.Visible = False
        '
        'solCol
        '
        Me.solCol.DataPropertyName = "Solicitante"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.solCol.DefaultCellStyle = DataGridViewCellStyle12
        Me.solCol.HeaderText = "Solicitante"
        Me.solCol.Name = "solCol"
        '
        'autoCol
        '
        Me.autoCol.DataPropertyName = "Autorizador"
        Me.autoCol.HeaderText = "Autorizado por"
        Me.autoCol.Name = "autoCol"
        '
        'FechaCol
        '
        Me.FechaCol.DataPropertyName = "Fecha"
        Me.FechaCol.HeaderText = "Fecha"
        Me.FechaCol.Name = "FechaCol"
        '
        'EstadoCol
        '
        Me.EstadoCol.DataPropertyName = "Estado"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.EstadoCol.DefaultCellStyle = DataGridViewCellStyle13
        Me.EstadoCol.HeaderText = "Estado"
        Me.EstadoCol.Name = "EstadoCol"
        '
        'SDCol
        '
        Me.SDCol.DataPropertyName = "SD"
        Me.SDCol.HeaderText = "SD"
        Me.SDCol.Name = "SDCol"
        Me.SDCol.Visible = False
        '
        'btnAutorizar
        '
        Me.btnAutorizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAutorizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutorizar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutorizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAutorizar.Image = Global.Frontend.My.Resources.Resources.approve2
        Me.btnAutorizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAutorizar.Location = New System.Drawing.Point(1024, 194)
        Me.btnAutorizar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(179, 73)
        Me.btnAutorizar.TabIndex = 17
        Me.btnAutorizar.Text = "AUTORIZAR"
        Me.btnAutorizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAutorizar.UseVisualStyleBackColor = False
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDetalle.Image = Global.Frontend.My.Resources.Resources.detalle
        Me.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetalle.Location = New System.Drawing.Point(1062, 81)
        Me.btnDetalle.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(206, 48)
        Me.btnDetalle.TabIndex = 16
        Me.btnDetalle.Text = "Ver Detalle"
        Me.btnDetalle.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = Global.Frontend.My.Resources.Resources.buscar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(652, 32)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 38)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Aplicar Filtro"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Image = Global.Frontend.My.Resources.Resources.reinciar2
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(652, 109)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(219, 37)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Limpiar Filtro"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'ConfirmarMIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1392, 989)
        Me.Controls.Add(Me.btnAutorizar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbS1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ConfirmarMIForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfirmarMIForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dpFin As DateTimePicker
    Friend WithEvents dpInicio As DateTimePicker
    Friend WithEvents lblDesdeF As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHastaF As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbS1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDO As TextBox
    Friend WithEvents txtAutorizado As TextBox
    Friend WithEvents txtSolicidato As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtDD As TextBox
    Friend WithEvents txtSD As TextBox
    Friend WithEvents txtSO As TextBox
    Friend WithEvents btnDetalle As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvMovimientos As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents MovCol As DataGridViewTextBoxColumn
    Friend WithEvents solCol As DataGridViewTextBoxColumn
    Friend WithEvents autoCol As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCol As DataGridViewTextBoxColumn
    Friend WithEvents SDCol As DataGridViewTextBoxColumn
    Friend WithEvents btnAutorizar As Button
End Class
