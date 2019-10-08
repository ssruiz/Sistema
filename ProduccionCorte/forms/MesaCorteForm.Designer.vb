<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesaCorteForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnMesa2 = New System.Windows.Forms.Button()
        Me.btnMesa1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1045, 50)
        Me.Panel1.TabIndex = 26
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(375, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(284, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "MESAS DE CORTES"
        '
        'btnMesa2
        '
        Me.btnMesa2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnMesa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMesa2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMesa2.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMesa2.Location = New System.Drawing.Point(141, 306)
        Me.btnMesa2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMesa2.Name = "btnMesa2"
        Me.btnMesa2.Size = New System.Drawing.Size(778, 134)
        Me.btnMesa2.TabIndex = 28
        Me.btnMesa2.Text = "MESA DE CORTE 2"
        Me.btnMesa2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMesa2.UseVisualStyleBackColor = False
        '
        'btnMesa1
        '
        Me.btnMesa1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnMesa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMesa1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMesa1.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMesa1.Location = New System.Drawing.Point(141, 124)
        Me.btnMesa1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMesa1.Name = "btnMesa1"
        Me.btnMesa1.Size = New System.Drawing.Size(778, 134)
        Me.btnMesa1.TabIndex = 27
        Me.btnMesa1.Text = "MESA DE CORTE 1"
        Me.btnMesa1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMesa1.UseVisualStyleBackColor = False
        '
        'MesaCorteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1045, 545)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMesa2)
        Me.Controls.Add(Me.btnMesa1)
        Me.Name = "MesaCorteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MesaCorteForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnMesa2 As Button
    Friend WithEvents btnMesa1 As Button
End Class
