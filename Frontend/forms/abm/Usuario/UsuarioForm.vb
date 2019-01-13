Imports Backend

Public Class UsuarioForm
    Dim nuevo = False
    Dim list
    Private Sub UsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbEstado.SelectedIndex = 0
        cargarUsuarios()
        desactivarCampos()
    End Sub

    Private Sub cargarUsuarios()
        Me.SuspendLayout()
        Dim daoU As New UsuarioDAO
        list = daoU.getUsuarios()
        dgvUsuarios.DataSource = ""
        dgvUsuarios.DataSource = list.Tables("tabla")

        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvUsuarios.Columns("Código").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvUsuarios.ClearSelection()
        Me.SuspendLayout()
    End Sub
    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtNivel.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtCodigo.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        dgvUsuarios.ClearSelection()
        btnGuardar.Text = "Guardar"
    End Sub

    ' Limpia los campos
    Private Sub limpiarCampos()
        txtBusqueda.Text = ""
        txtCodigo.Text = ""
        txtNivel.Text = ""
        txtNombre.Text = ""
        cbEstado.SelectedIndex = 0
    End Sub

    ' Activa los campos
    Private Sub activarCampos()
        txtCodigo.Enabled = True
        txtNivel.Enabled = True
        txtNombre.Enabled = True
        cbEstado.Enabled = True
    End Sub

    ' Descactiva los campos
    Private Sub desactivarCampos()
        txtCodigo.Enabled = False
        txtNivel.Enabled = False
        txtNombre.Enabled = False
        cbEstado.Enabled = False

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnGuardar.Enabled = True
        btnGuardar.Text = "Guardar Cambios"
        btnGuardar.Width = 207
        activarCampos()
        txtCodigo.Focus()
        nuevo = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvUsuarios.SelectedRows.Count > 0 Then
                Dim row = dgvUsuarios.CurrentRow.Index
                Dim codigo = dgvUsuarios.Item(0, row).Value
                Dim usuario = dgvUsuarios.Item(1, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar el usuario seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoU As New UsuarioDAO
                    Dim res = daoU.eliminar(codigo, usuario)
                    MsgBox(res, MsgBoxStyle.Information, "Notificación")
                    cargarUsuarios()
                    desactivarCampos()
                    limpiarCampos()
                End If
            Else
                MsgBox("Seleccione un usuario a eliminar de la lista", MsgBoxStyle.Critical, "Seleccione color")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then
                If (nuevo) Then
                    Dim daoU As New UsuarioDAO
                    Dim modelo = llenarModelo()
                    daoU.guardar(modelo)
                    MsgBox("Usuario agregado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarUsuarios()
                Else
                    Dim daoU As New UsuarioDAO
                    Dim row = dgvUsuarios.CurrentRow.Index
                    Dim codigo = dgvUsuarios.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)
                    daoU.update(modelo)

                    MsgBox("Usuario actualizado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarUsuarios()
                    btnModificar.Enabled = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function llenarModelo(ByVal cod As String) As Usuario
        Dim modelo As New Usuario
        modelo.id = cod
        modelo.idNuevo = txtCodigo.Text
        If cbEstado.SelectedIndex = 1 Then
            modelo.estado = "A"
        ElseIf cbEstado.SelectedIndex = 2 Then
            modelo.estado = "I"
        End If
        modelo.nombre = txtNombre.Text
        modelo.nivel = txtNivel.Text
        Return modelo
    End Function
    Private Function validarDatos() As Boolean
        If txtCodigo.Text = "" Or txtNombre.Text = "" Or txtNivel.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
            Return False
        ElseIf cbEstado.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un estado", MsgBoxStyle.Critical, "Notificación")
            cbEstado.Focus()
            Return False
        End If
        Return True

    End Function

    Private Function llenarModelo() As Usuario
        Dim usuario As New Usuario
        usuario.id = txtCodigo.Text
        usuario.nombre = txtNombre.Text
        usuario.fechaAlta = Date.Now
        If cbEstado.SelectedIndex = 1 Then
            usuario.estado = "A"
        Else
            usuario.estado = "I"
        End If
        usuario.nivel = txtNivel.Text
        Return usuario
    End Function

    Private Sub busquedaColor(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Nombre like '%{0}%' ", txtBusqueda.Text)
            dgvUsuarios.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvUsuarios.ClearSelection()
        End If
    End Sub

    Private Sub dgvUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsuarios.SelectionChanged
        If dgvUsuarios.Focused Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvUsuarios.CurrentRow.Index
                Dim codigo = dgvUsuarios.Item(0, row).Value
                Dim daoU As New UsuarioDAO
                Dim usuario = daoU.getUsuario(codigo)
                cargarUsuario(usuario)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cargarUsuario(ByVal modelo As Usuario)
        txtCodigo.Text = modelo.id
        txtNivel.Text = modelo.nivel
        txtNombre.Text = modelo.nombre
        If modelo.estado = "A" Then
            cbEstado.SelectedIndex = 1
        ElseIf modelo.estado = "I" Then
            cbEstado.SelectedIndex = 2
        End If
    End Sub
End Class