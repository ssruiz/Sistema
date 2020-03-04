<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblEnvio = New System.Windows.Forms.Label()
        Me.pnlEnvioNuevo = New System.Windows.Forms.Panel()
        Me.pnlEnvio = New System.Windows.Forms.Panel()
        Me.rbtnNo = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbtnSi = New System.Windows.Forms.RadioButton()
        Me.pnlEntrega1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFechaEnvio = New System.Windows.Forms.Label()
        Me.lblDirEnvio = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlazo1 = New System.Windows.Forms.TextBox()
        Me.lblFechaEntrega = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.pnlEnvioNuevo.SuspendLayout()
        Me.pnlEnvio.SuspendLayout()
        Me.pnlEntrega1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.lblEnvio)
        Me.Panel2.Controls.Add(Me.pnlEnvioNuevo)
        Me.Panel2.Controls.Add(Me.lblFechaEntrega)
        Me.Panel2.Location = New System.Drawing.Point(29, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 203)
        Me.Panel2.TabIndex = 16
        Me.Panel2.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label31.Location = New System.Drawing.Point(21, 40)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(95, 19)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Fecha Entrega"
        Me.Label31.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label30.Location = New System.Drawing.Point(21, -20)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(42, 19)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Envio"
        Me.Label30.Visible = False
        '
        'lblEnvio
        '
        Me.lblEnvio.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblEnvio.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnvio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEnvio.Location = New System.Drawing.Point(144, -21)
        Me.lblEnvio.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEnvio.Name = "lblEnvio"
        Me.lblEnvio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnvio.Size = New System.Drawing.Size(214, 30)
        Me.lblEnvio.TabIndex = 12
        Me.lblEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEnvio.Visible = False
        '
        'pnlEnvioNuevo
        '
        Me.pnlEnvioNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEnvioNuevo.Controls.Add(Me.pnlEnvio)
        Me.pnlEnvioNuevo.Controls.Add(Me.pnlEntrega1)
        Me.pnlEnvioNuevo.Location = New System.Drawing.Point(22, 90)
        Me.pnlEnvioNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlEnvioNuevo.Name = "pnlEnvioNuevo"
        Me.pnlEnvioNuevo.Size = New System.Drawing.Size(406, 180)
        Me.pnlEnvioNuevo.TabIndex = 9
        Me.pnlEnvioNuevo.Visible = False
        '
        'pnlEnvio
        '
        Me.pnlEnvio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEnvio.Controls.Add(Me.rbtnNo)
        Me.pnlEnvio.Controls.Add(Me.Label8)
        Me.pnlEnvio.Controls.Add(Me.rbtnSi)
        Me.pnlEnvio.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEnvio.Enabled = False
        Me.pnlEnvio.Location = New System.Drawing.Point(0, 0)
        Me.pnlEnvio.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlEnvio.Name = "pnlEnvio"
        Me.pnlEnvio.Size = New System.Drawing.Size(404, 52)
        Me.pnlEnvio.TabIndex = 3
        '
        'rbtnNo
        '
        Me.rbtnNo.AutoSize = True
        Me.rbtnNo.Checked = True
        Me.rbtnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbtnNo.Location = New System.Drawing.Point(138, 10)
        Me.rbtnNo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnNo.Name = "rbtnNo"
        Me.rbtnNo.Size = New System.Drawing.Size(47, 21)
        Me.rbtnNo.TabIndex = 7
        Me.rbtnNo.TabStop = True
        Me.rbtnNo.Text = "No"
        Me.rbtnNo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(18, 10)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Envío"
        '
        'rbtnSi
        '
        Me.rbtnSi.AutoSize = True
        Me.rbtnSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnSi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbtnSi.Location = New System.Drawing.Point(83, 11)
        Me.rbtnSi.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnSi.Name = "rbtnSi"
        Me.rbtnSi.Size = New System.Drawing.Size(41, 21)
        Me.rbtnSi.TabIndex = 6
        Me.rbtnSi.Text = "Sí"
        Me.rbtnSi.UseVisualStyleBackColor = True
        '
        'pnlEntrega1
        '
        Me.pnlEntrega1.Controls.Add(Me.Label10)
        Me.pnlEntrega1.Controls.Add(Me.lblFechaEnvio)
        Me.pnlEntrega1.Controls.Add(Me.lblDirEnvio)
        Me.pnlEntrega1.Controls.Add(Me.Label12)
        Me.pnlEntrega1.Controls.Add(Me.Label9)
        Me.pnlEntrega1.Controls.Add(Me.txtPlazo1)
        Me.pnlEntrega1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlEntrega1.Location = New System.Drawing.Point(0, 53)
        Me.pnlEntrega1.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlEntrega1.Name = "pnlEntrega1"
        Me.pnlEntrega1.Size = New System.Drawing.Size(404, 125)
        Me.pnlEntrega1.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(19, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Plazo (días)"
        '
        'lblFechaEnvio
        '
        Me.lblFechaEnvio.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblFechaEnvio.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEnvio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFechaEnvio.Location = New System.Drawing.Point(242, 20)
        Me.lblFechaEnvio.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaEnvio.Name = "lblFechaEnvio"
        Me.lblFechaEnvio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaEnvio.Size = New System.Drawing.Size(144, 30)
        Me.lblFechaEnvio.TabIndex = 12
        Me.lblFechaEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDirEnvio
        '
        Me.lblDirEnvio.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblDirEnvio.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirEnvio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDirEnvio.Location = New System.Drawing.Point(88, 67)
        Me.lblDirEnvio.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDirEnvio.Name = "lblDirEnvio"
        Me.lblDirEnvio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDirEnvio.Size = New System.Drawing.Size(283, 30)
        Me.lblDirEnvio.TabIndex = 12
        Me.lblDirEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(194, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(19, 74)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Dirección"
        '
        'txtPlazo1
        '
        Me.txtPlazo1.Enabled = False
        Me.txtPlazo1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlazo1.Location = New System.Drawing.Point(100, 24)
        Me.txtPlazo1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlazo1.Name = "txtPlazo1"
        Me.txtPlazo1.Size = New System.Drawing.Size(72, 25)
        Me.txtPlazo1.TabIndex = 9
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblFechaEntrega.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrega.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFechaEntrega.Location = New System.Drawing.Point(144, 28)
        Me.lblFechaEntrega.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaEntrega.Size = New System.Drawing.Size(214, 30)
        Me.lblFechaEntrega.TabIndex = 12
        Me.lblFechaEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFechaEntrega.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 705)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlEnvioNuevo.ResumeLayout(False)
        Me.pnlEnvio.ResumeLayout(False)
        Me.pnlEnvio.PerformLayout()
        Me.pnlEntrega1.ResumeLayout(False)
        Me.pnlEntrega1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lblEnvio As Label
    Friend WithEvents pnlEnvioNuevo As Panel
    Friend WithEvents pnlEnvio As Panel
    Friend WithEvents rbtnNo As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents rbtnSi As RadioButton
    Friend WithEvents pnlEntrega1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFechaEnvio As Label
    Friend WithEvents lblDirEnvio As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPlazo1 As TextBox
    Friend WithEvents lblFechaEntrega As Label
End Class
