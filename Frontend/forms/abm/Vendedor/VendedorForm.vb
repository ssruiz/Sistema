Imports Backend

Public Class VendedorForm
    Dim nuevo = False
    Dim list
    Dim i = 0
    Private Sub UsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarVendedores()
        desactivarCampos()
    End Sub

    Private Sub cargarVendedores()
        Me.SuspendLayout()
        Dim daoO As New VendedorDAO
        list = daoO.getVendedores()
        dgvVendedores.DataSource = ""
        dgvVendedores.DataSource = list.Tables("tabla")

        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvVendedores.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvVendedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvVendedores.ClearSelection()
        Me.SuspendLayout()
    End Sub
    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress, txtPorcentaje.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtNombre.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        dgvVendedores.ClearSelection()
        btnGuardar.Text = "Guardar"
    End Sub

    ' Limpia los campos
    Private Sub limpiarCampos()
        txtBusqueda.Text = ""
        txtCelular.Text = ""
        txtPorcentaje.Text = ""
        txtNombre.Text = ""
    End Sub

    ' Activa los campos
    Private Sub activarCampos()
        txtPorcentaje.Enabled = True
        txtCelular.Enabled = True
        txtNombre.Enabled = True
    End Sub

    ' Descactiva los campos
    Private Sub desactivarCampos()
        txtCelular.Enabled = False
        txtPorcentaje.Enabled = False
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvVendedores.SelectedRows.Count > 0 Then
                Dim row = dgvVendedores.CurrentRow.Index
                Dim codigo = dgvVendedores.Item(0, row).Value
                Dim vend = dgvVendedores.Item(1, row).Value

                Dim result As Integer = MessageBox.Show("¿Eliminar al vendedor/a " & vend & " seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoU As New VendedorDAO
                    Dim res = daoU.eliminar(codigo)
                    MsgBox(res, MsgBoxStyle.Information, "Notificación")
                    cargarVendedores()
                    desactivarCampos()
                    limpiarCampos()
                End If
            Else
                MsgBox("Seleccione un/a vendedor/a a eliminar de la lista", MsgBoxStyle.Critical, "Seleccione color")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then
                If (nuevo) Then
                    Dim daoU As New VendedorDAO
                    Dim modelo = llenarModelo()

                    daoU.guardar(modelo)
                    MsgBox("Vendedor/a agregado/a correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarVendedores()
                Else
                    Dim daoU As New VendedorDAO
                    Dim row = dgvVendedores.CurrentRow.Index
                    Dim codigo = dgvVendedores.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)
                    daoU.update(modelo)

                    MsgBox("Vendedor/a actualizado/a correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarVendedores()
                    btnModificar.Enabled = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function llenarModelo(ByVal cod As String) As Vendedor
        Dim modelo As New Vendedor
        modelo.id = cod
        modelo.nombre = txtNombre.Text
        modelo.celular = txtCelular.Text
        Dim str As String = txtPorcentaje.Text
        str = str.Replace("%", "")
        modelo.porcentaje = CDbl(str) / 100
        Return modelo
    End Function
    Private Function validarDatos() As Boolean
        If txtCelular.Text = "" Or txtNombre.Text = "" Or txtPorcentaje.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
            Return False
        End If
        Return True
    End Function

    Private Function llenarModelo() As Vendedor
        Dim vend As New Vendedor
        Dim str As String = txtPorcentaje.Text
        str = str.Replace("%", "")
        vend.nombre = txtNombre.Text
        vend.celular = txtCelular.Text
        vend.porcentaje = CDbl(str) / 100
        Return vend
    End Function

    Private Sub busquedaVendedor(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Nombre like '%{0}%' ", txtBusqueda.Text)
            dgvVendedores.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvVendedores.ClearSelection()
        End If
    End Sub

    Private Sub dgvUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVendedores.SelectionChanged
        If dgvVendedores.Focused Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvVendedores.CurrentRow.Index
                Dim codigo = dgvVendedores.Item(0, row).Value
                Dim daoU As New VendedorDAO
                Dim vendedor = daoU.getVendedor(codigo)
                cargarVendedor(vendedor)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cargarVendedor(ByVal modelo As Vendedor)
        txtNombre.Text = modelo.nombre
        txtCelular.Text = modelo.celular
        txtPorcentaje.Text = FormatPercent(modelo.porcentaje)
    End Sub

    Private Sub precioFormat(sender As Object, e As EventArgs) Handles txtPorcentaje.TextChanged
        Dim str2 As String = txtPorcentaje.Text
        If sender.Text <> "" Then
            Dim str As String = txtPorcentaje.Text
            str = str.Replace("%", "")
            Dim val = CDbl(str) / 100
            sender.Text = FormatPercent(val)
            sender.Select(sender.TextLength - 4, 0)


        Else
            sender.Text = ""
        End If
    End Sub

    Private Sub precioClick(sender As Object, e As EventArgs) Handles txtPorcentaje.Click
        If sender.Text <> "" Then
            sender.Select(sender.TextLength - 4, 0)
        End If
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCelular.Focus()
        End If
    End Sub
    Private Sub txtcel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCelular.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtPorcentaje.Focus()
        End If
    End Sub

    Private Sub txtPorcentaje_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPorcentaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnGuardar_Click(sender, e)
        End If
    End Sub
End Class