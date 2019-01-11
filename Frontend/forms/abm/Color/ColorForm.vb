Imports Backend

Public Class ColorForm
    Private Sub ColorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.SuspendLayout()
            cargarColores()


            Me.ResumeLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cargarColores()
        Dim daoC As New ColorDAO
        Dim ds = daoC.getColores()
        dgvColores.DataSource = ""
        dgvColores.DataSource = ds.Tables("tabla")
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvColores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvColores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvColores.ClearSelection()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim daoc As New ColorDAO
            If (controlarCampos()) Then
                Dim color As New ColorM
                color.nombre = txtNombre.Text.ToLower
                daoc.agregar(color)
                MsgBox("Color agregado correctamente", MsgBoxStyle.Information, "Éxito")
                cargarColores()
            Else
                MsgBox("Ingrese el nombre para el color", MsgBoxStyle.Critical, "Campos")
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvColores.SelectedRows.Count > 0 Then
                Dim row = dgvColores.CurrentRow.Index
                Dim codigo = dgvColores.Item(0, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar el color seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoC As New ColorDAO
                    daoC.eliminar(codigo)
                    MsgBox("Color eliminado correctamente", MsgBoxStyle.Information, "Éxito")
                    cargarColores()

                End If
            Else
                MsgBox("Seleccione un color a eliminar", MsgBoxStyle.Critical, "Seleccione color")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub
End Class