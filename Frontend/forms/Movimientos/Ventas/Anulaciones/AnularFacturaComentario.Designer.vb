<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnularFacturaComentario
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.txtAnular = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(682, 40)
        Me.Panel1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(176, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(327, 28)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ingrese el motivo de la anulación"
        '
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnular.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAnular.Location = New System.Drawing.Point(235, 130)
        Me.btnAnular.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(194, 32)
        Me.btnAnular.TabIndex = 12
        Me.btnAnular.Text = "Cancelar"
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'txtAnular
        '
        Me.txtAnular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnular.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnular.Location = New System.Drawing.Point(90, 73)
        Me.txtAnular.MaxLength = 50
        Me.txtAnular.Name = "txtAnular"
        Me.txtAnular.Size = New System.Drawing.Size(514, 31)
        Me.txtAnular.TabIndex = 11
        '
        'AnularFacturaComentario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(682, 188)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.txtAnular)
        Me.Name = "AnularFacturaComentario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnularFacturaComentario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAnular As Button
    Friend WithEvents txtAnular As TextBox
End Class
