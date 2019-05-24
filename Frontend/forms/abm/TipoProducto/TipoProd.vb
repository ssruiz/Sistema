Imports Backend

Public Class TipoProd
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim daoc As New TipoProdDAO
            If (controlarCampos()) Then
                Dim color As New TipoProducto
                color.nombre = txtNombre.Text.ToLower
                daoc.agregar(color)
                MsgBox("Tipo agregado correctamente", MsgBoxStyle.Information, "Éxito")
                cargarTipos()
            Else
                MsgBox("Ingrese el nombre para el tipo", MsgBoxStyle.Critical, "Campos")
                txtNombre.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function controlarCampos() As Boolean
        If txtNombre.Text.Length > 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub TipoProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        cargarTipos()
        PersonalizarDAtagridView(dgvTipos)
        Me.ResumeLayout()

    End Sub
    Public Sub PersonalizarDAtagridView(ByVal dgv As DataGridView)
        With dgv
            .ForeColor = Color.FromArgb(245, 245, 245)
            .DefaultCellStyle.BackColor = Color.FromArgb(64, 69, 76)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.FromArgb(245, 245, 245)

            ' Inabilito EnableHeadersVisualStyles para que la personalizacion se haga efectiva

            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .ColumnHeadersHeight = 35
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 64, 23)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 101, 205)
            .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 101, 205)
            .AlternatingRowsDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            'Tipo de letra and color
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'Coloreo el background del DGV
            .BackgroundColor = Color.FromArgb(48, 65, 91)
        End With
    End Sub
    Private Sub cargarTipos()
        Dim daoC As New TipoProdDAO
        Dim ds = daoC.getTipos()
        dgvTipos.DataSource = ""
        dgvTipos.DataSource = ds.Tables("tabla")
        'dgvTipos.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTipos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvTipos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvTipos.ClearSelection()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvTipos.SelectedRows.Count > 0 Then
                Dim row = dgvTipos.CurrentRow.Index
                Dim codigo = dgvTipos.Item(0, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar el tipo seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoC As New TipoProdDAO
                    daoC.eliminar(codigo)
                    MsgBox("Tipo eliminado correctamente", MsgBoxStyle.Information, "Éxito")
                    cargarTipos()

                End If
            Else
                MsgBox("Seleccione un tipo a eliminar", MsgBoxStyle.Critical, "Seleccione color")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub
End Class