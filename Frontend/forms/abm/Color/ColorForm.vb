Imports Backend

Public Class ColorForm
    Dim nuevo = False
    Dim list
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
        list = New DataSet
        list = daoC.getColores()

        dgvColores.DataSource = ""
        dgvColores.DataSource = list.Tables("tabla")
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvColores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvColores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvColores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvColores.ClearSelection()
    End Sub

    Private Function controlarCampos() As Boolean
        If txtNombre.Text.Length > 0 Then
            Return True
        End If
        Return False
    End Function



    Private Sub guardarColor(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim daoc As New ColorDAO

            If (controlarCampos()) Then
                If nuevo = True Then
                    Dim color As New ColorM
                    color.nombre = txtNombre.Text.ToLower
                    daoc.agregar(color)
                    MsgBox("Color agregado correctamente", MsgBoxStyle.Information, "Éxito")
                    cargarColores()
                Else

                    Dim row = dgvColores.CurrentRow.Index
                    Dim codigo = dgvColores.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)
                    daoc.update(modelo)

                    MsgBox("Color actualizado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarColores()
                    limpiarCampos()
                    desactivarCampos()
                End If
            Else
                MsgBox("Ingrese el nombre para el color", MsgBoxStyle.Critical, "Campos")
                txtNombre.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function llenarModelo(ByVal id As Integer) As ColorM
        Dim modelo As New ColorM
        modelo.id = id
        modelo.nombre = txtNombre.Text
        Return modelo
    End Function
    Private Sub eliminarColor(sender As Object, e As EventArgs) Handles btnEliminar.Click
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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtNombre.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        btnGuardar.Text = "Guardar"
    End Sub

    Private Sub limpiarCampos()
        txtNombre.Text = ""
    End Sub

    Private Sub activarCampos()
        txtNombre.Enabled = True
    End Sub

    Private Sub desactivarCampos()
        txtNombre.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnGuardar.Enabled = True
        btnGuardar.Text = "Guardar Cambios"
        btnGuardar.Width = 207
        activarCampos()
        txtNombre.Focus()
        nuevo = False
    End Sub

    Private Sub dgvColores_SelectionChanged(sender As Object, e As EventArgs) Handles dgvColores.SelectionChanged
        If dgvColores.Focused Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvColores.CurrentRow.Index
                Dim codigo = dgvColores.Item(0, row).Value
                Dim daoC As New ColorDAO
                Dim color = daoC.getColor(codigo)
                cargarColor(color)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cargarColor(ByVal modelo As ColorM)
        txtNombre.Text = modelo.nombre
    End Sub

    Private Sub busquedaColor(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Color like '%{0}%' ", txtBusqueda.Text)
            dgvColores.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvColores.ClearSelection()
        End If
    End Sub
End Class