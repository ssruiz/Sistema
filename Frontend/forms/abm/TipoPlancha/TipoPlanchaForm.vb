Imports Backend

Public Class TipoPlanchaForm
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim daoc As New TipoProdDAO
            If (controlarCampos()) Then
                Dim tipo As New TipoPlancha
                tipo.nombre = txtNombre.Text.ToLower
                daoc.agregarPlancha(tipo)
                MsgBox("Tipo de plancha agregado correctamente", MsgBoxStyle.Information, "Éxito")
                cargarTipos()
            Else
                MsgBox("Ingrese el nombre para el tipo", MsgBoxStyle.Critical, "Campos")
                txtNombre.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TipoPlanchaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipos()
    End Sub

    Private Sub cargarTipos()
        Dim daoC As New TipoProdDAO
        Dim ds = daoC.getTiposPlancha()
        dgvTipos.DataSource = ""
        dgvTipos.DataSource = ds.Tables("tabla")
        'dgvTipos.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTipos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvTipos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvTipos.ClearSelection()
    End Sub

    Private Function controlarCampos() As Boolean
        If txtNombre.Text.Length > 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvTipos.SelectedRows.Count > 0 Then
                Dim row = dgvTipos.CurrentRow.Index
                Dim codigo = dgvTipos.Item(0, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar el tipo seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoC As New TipoProdDAO
                    daoC.eliminarPlancha(codigo)
                    MsgBox("Tipo de plancha eliminado correctamente", MsgBoxStyle.Information, "Éxito")
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