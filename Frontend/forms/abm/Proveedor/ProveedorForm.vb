Imports Backend

Public Class ProveedorForm
    Dim nuevo = True
    Dim list As New DataSet
    Dim listTipos As New DataTable

    Private Sub ProveedorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarProveedores()
            limpiarCampos()
            desactivarCampos()

            dgvBancos.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cargarProveedores()
        Me.SuspendLayout()
        Dim daoP As New ProveedorDAO
        list = daoP.getProveedores()
        dgvBancos.DataSource = ""
        dgvBancos.DataSource = list.Tables("tabla")
        dgvBancos.Columns("ID").Visible = False
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvBancos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBancos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'dgvBancos.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvBancos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

        Me.SuspendLayout()
    End Sub

    Private Sub desactivarCampos()
        txtMail.Enabled = False
        txtNombre.Enabled = False
        txtContacto.Enabled = False
        txtRUC.Enabled = False
        txtTel.Enabled = False
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtNombre.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        dgvBancos.ClearSelection()
        btnGuardar.Text = "Guardar"
    End Sub

    ' Limpia los campos
    Private Sub limpiarCampos()
        dgvBancos.ClearSelection()

        txtMail.Text = ""
        txtNombre.Text = ""
        txtContacto.Text = ""
        txtRUC.Text = ""
        txtTel.Text = ""
    End Sub

    ' Activa los campos
    Private Sub activarCampos()

        txtMail.Enabled = True
        txtNombre.Enabled = True
        txtContacto.Enabled = True
        txtRUC.Enabled = True
        txtTel.Enabled = True
        dgvBancos.ClearSelection()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then

                If (nuevo) Then
                    Dim daoP As New ProveedorDAO

                    Dim modelo = llenarModelo()

                    daoP.guardar(modelo)

                    MsgBox("Proveedor agregado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarProveedores()

                Else
                    Dim daoP As New ProveedorDAO
                    Dim row = dgvBancos.CurrentRow.Index
                    Dim codigo = dgvBancos.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)

                    daoP.update(modelo)

                    MsgBox("Proveedor actualizado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarProveedores()
                    btnModificar.Enabled = False
                    btnGuardar.Enabled = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function llenarModelo() As Proveedor
        Dim modelo As New Proveedor
        modelo.email = txtMail.Text
        modelo.nombre = txtNombre.Text
        modelo.contacto = txtContacto.Text
        modelo.ruc = txtRUC.Text
        modelo.telf = txtTel.Text
        Return modelo
    End Function

    ' Llena el modelo para su actualizacion
    Private Function llenarModelo(ByVal id As Integer) As Proveedor
        Dim modelo As New Proveedor
        modelo.id = id
        modelo.email = txtMail.Text
        modelo.nombre = txtNombre.Text
        modelo.contacto = txtContacto.Text
        modelo.ruc = txtRUC.Text
        modelo.telf = txtTel.Text
        Return modelo
    End Function
    Private Function validarDatos() As Boolean

        If txtNombre.Text = "" Or txtRUC.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
            txtNombre.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBancos.SelectionChanged
        If dgvBancos.Focused And dgvBancos.SelectedRows.Count > 0 Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvBancos.CurrentRow.Index
                Dim codigo = dgvBancos.Item(0, row).Value
                Dim daoP As New ProveedorDAO

                Dim prov = daoP.getProveedor(codigo)
                cargarCliente(prov)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    ' Carga el producto seleccionado
    Private Sub cargarCliente(ByVal modelo As Proveedor)
        txtMail.Text = modelo.email
        txtNombre.Text = modelo.nombre
        txtContacto.Text = modelo.contacto
        txtRUC.Text = modelo.ruc
        txtTel.Text = modelo.telf

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnGuardar.Enabled = True
        btnGuardar.Text = "Guardar Cambios"
        btnGuardar.Width = 207
        activarCampos()
        txtNombre.Focus()
        nuevo = False
    End Sub

    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Nombre like '%{0}%' or RUC like '%{0}%' ", txtBusqueda.Text)
        dgvBancos.DataSource = dv
        limpiarCampos()
        desactivarCampos()
        dgvBancos.ClearSelection()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            txtRUC.Focus()
        End If
    End Sub

    Private Sub txtRUC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtTel.Focus()
        End If
    End Sub

    Private Sub txtTel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTel.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtMail.Focus()
        End If
    End Sub

    Private Sub txtMail_kd(sender As Object, e As KeyEventArgs) Handles txtMail.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtContacto.Focus()
        End If
    End Sub
End Class