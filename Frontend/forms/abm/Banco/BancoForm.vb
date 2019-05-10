Imports Backend

Public Class BancoForm
    Dim nuevo = True
    Dim list As New DataSet
    Dim listTipos As New DataTable

    Private Sub BancoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarBancos()
            limpiarCampos()
            desactivarCampos()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cargarBancos()
        Me.SuspendLayout()
        Dim daoP As New BancoDAO
        list = daoP.getBancos()
        dgvProveedores.DataSource = ""
        dgvProveedores.DataSource = list.Tables("tabla")
        ''dgvProveedores.Columns("ID").Visible = False
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvProveedores.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvProveedores.ClearSelection()
        Me.SuspendLayout()
    End Sub

    Private Sub desactivarCampos()
        txtNombre.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtNombre.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        dgvProveedores.ClearSelection()
        btnGuardar.Text = "Guardar"
    End Sub

    ' Limpia los campos
    Private Sub limpiarCampos()
        dgvProveedores.ClearSelection()
        txtNombre.Text = ""
    End Sub

    ' Activa los campos
    Private Sub activarCampos()
        txtNombre.Enabled = True
        dgvProveedores.ClearSelection()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then

                If (nuevo) Then
                    Dim daoP As New BancoDAO


                    Dim modelo = llenarModelo()

                    daoP.guardar(modelo)

                    MsgBox("Banco agregado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarBancos()

                Else
                    Dim daoP As New BancoDAO

                    Dim row = dgvProveedores.CurrentRow.Index
                    Dim codigo = dgvProveedores.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)

                    daoP.update(modelo)

                    MsgBox("Banco actualizado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarBancos()
                    btnModificar.Enabled = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function llenarModelo() As Banco
        Dim modelo As New Banco
        modelo.nombre = txtNombre.Text
        Return modelo
    End Function

    ' Llena el modelo para su actualizacion
    Private Function llenarModelo(ByVal id As Integer) As Banco
        Dim modelo As New Banco
        modelo.id = id
        modelo.nombre = txtNombre.Text
        Return modelo
    End Function
    Private Function validarDatos() As Boolean

        If txtNombre.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
            txtNombre.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProveedores.SelectionChanged
        If dgvProveedores.Focused And dgvProveedores.SelectedRows.Count > 0 Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvProveedores.CurrentRow.Index
                Dim codigo = dgvProveedores.Item(0, row).Value
                Dim daoP As New BancoDAO

                Dim prov = daoP.getBanco(codigo)
                cargarBanco(prov)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    ' Carga el producto seleccionado
    Private Sub cargarBanco(ByVal modelo As Banco)
        txtNombre.Text = modelo.nombre
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnGuardar.Enabled = True
        btnGuardar.Text = "Guardar Cambios"
        btnGuardar.Width = 207
        activarCampos()
        txtNombre.Focus()
        nuevo = False
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Nombre like '%{0}%' or ID like '%{0}%' ", txtBusqueda.Text)
        dgvProveedores.DataSource = dv
        limpiarCampos()
        desactivarCampos()
        dgvProveedores.ClearSelection()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnGuardar_Click(sender, e)
        End If
    End Sub

End Class