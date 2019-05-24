Imports Backend

Public Class ClienteForm
    Dim nuevo = True
    Dim list As New DataSet
    Dim listTipos As New DataTable
    'Carga del formulario
    Private Sub loadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarClientes()
            cargarSucursal()
            cargarTipos()
            cargarVendedores()
            desactivarCampos()
            PersonalizarDAtagridView(dgvClientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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
    'Carga de productos de la db
    Private Sub cargarClientes()
        Me.SuspendLayout()
        Dim daoP As New ClienteDAO
        list = daoP.getClientes()
        dgvClientes.DataSource = ""
        dgvClientes.DataSource = list.Tables("tabla")
        dgvClientes.Columns("ID").Visible = False
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvClientes.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvClientes.ClearSelection()
        Me.SuspendLayout()
    End Sub

    'Carga de colores desde la BD
    Private Sub cargarSucursal()
        Dim daoC As New SucursalDAO
        Dim sucursales = daoC.getSucursales()
        Dim listColores = sucursales.Tables("tabla")
        Dim rowV = listColores.NewRow()
        rowV("Nombre") = "-- Seleccione Sucursal -- "
        rowV("ID") = 0
        listColores.Rows.InsertAt(rowV, 0)

        cbSucursal.DataSource = listColores.Copy
        cbSucursal.DisplayMember = "Nombre"
        cbSucursal.ValueMember = "ID"
    End Sub

    Private Sub cargarVendedores()
        Dim daoC As New VendedorDAO
        Dim sucursales = daoC.getVendedores()
        Dim listColores = sucursales.Tables("tabla")
        Dim rowV = listColores.NewRow()
        rowV("Nombre") = "-- Seleccione Vendedor -- "
        rowV("ID") = 0
        listColores.Rows.InsertAt(rowV, 0)

        cbVendedor.DataSource = listColores.Copy
        cbVendedor.DisplayMember = "Nombre"
        cbVendedor.ValueMember = "ID"
    End Sub

    ' Carga de tipos desde la BD
    Private Sub cargarTipos()
        Dim daoT As New TipoClienteDAO
        Dim tipos = daoT.getTipos()
        listTipos = tipos.Tables("tabla")

        Dim rowV = listTipos.NewRow()
        rowV("Nombre") = "-- Seleccione Tipo -- "
        rowV("ID") = 0
        listTipos.Rows.InsertAt(rowV, 0)

        cbTipoC.DataSource = listTipos.Copy
        cbTipoC.DisplayMember = "Nombre"
        cbTipoC.ValueMember = "ID"
    End Sub
    ' Carga de tipo de planchas desde la BD
    'Private Sub cargarPlanchas()
    '    Dim daoT As New TipoProdDAO
    '    Dim tipos = daoT.getTiposPlancha()
    '    Dim listTipos = tipos.Tables("tabla")
    '    Dim rowV = listTipos.NewRow()
    '    rowV("Tipo") = "-- Seleccione Tipo -- "
    '    rowV("ID") = 0
    '    listTipos.Rows.InsertAt(rowV, 0)

    '    cbTipoPlancha.DataSource = listTipos.Copy
    '    cbTipoPlancha.DisplayMember = "Tipo"
    '    cbTipoPlancha.ValueMember = "ID"
    'End Sub

    'Carga de producto seleccionado
    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.Focused And dgvClientes.SelectedRows.Count > 0 Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvClientes.CurrentRow.Index
                Dim codigo = dgvClientes.Item(0, row).Value
                Dim daoP As New ClienteDAO
                Dim cliente = daoP.getCliente(codigo)
                cargarCliente(cliente)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    ' Carga el producto seleccionado
    Private Sub cargarCliente(ByVal modelo As Cliente)
        txtCel.Text = modelo.cel
        txtCI.Text = modelo.ci
        txtDir.Text = modelo.dir
        txtMail.Text = modelo.email
        txtNombre.Text = modelo.nombre
        txtResponsable.Text = modelo.responsable
        txtRUC.Text = modelo.ruc
        txtTel.Text = modelo.telf
        txtLimiteC.Text = modelo.limiteC
        cbSucursal.SelectedValue = modelo.sucursal
        cbTipoC.SelectedValue = modelo.tipo
        cbVendedor.SelectedValue = modelo.vendedor
        Select Case modelo.precioDefault
            Case "A"
                cbPrecio.SelectedIndex = 1
            Case "B"
                cbPrecio.SelectedIndex = 2
            Case "C"
                cbPrecio.SelectedIndex = 3
            Case "D"
                cbPrecio.SelectedIndex = 4
            Case Else
                cbPrecio.SelectedIndex = 0
        End Select
    End Sub

    ' Nuevo producto
    Private Sub nuevoCliente(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtNombre.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        dgvClientes.ClearSelection()
        btnGuardar.Text = "Guardar"
    End Sub

    ' Comprueba si algun tipo fue seleccionado
    Private Function tipoCheckeado() As Boolean
        If cbTipoC.SelectedIndex <> 0 = True Then
            Return True
        End If
        Return False
    End Function

    ' Limpia los campos
    Private Sub limpiarCampos()
        txtCel.Text = ""
        txtCI.Text = ""
        txtDir.Text = ""
        txtMail.Text = ""
        txtNombre.Text = ""
        txtResponsable.Text = ""
        txtRUC.Text = ""
        txtTel.Text = ""
        txtLimiteC.Text = ""
        cbSucursal.SelectedValue = 0
        cbTipoC.SelectedValue = 0
        cbVendedor.SelectedValue = 0
        cbPrecio.SelectedIndex = 0
    End Sub

    ' Activa los campos
    Private Sub activarCampos()
        txtCel.Enabled = True
        txtCI.Enabled = True
        txtDir.Enabled = True
        txtMail.Enabled = True
        txtNombre.Enabled = True
        txtResponsable.Enabled = True
        txtRUC.Enabled = True
        txtTel.Enabled = True
        txtLimiteC.Enabled = True
        cbSucursal.Enabled = True
        cbTipoC.Enabled = True
        cbVendedor.Enabled = True
        cbPrecio.Enabled = True
        dgvClientes.ClearSelection()
    End Sub

    ' Descactiva los campos
    Private Sub desactivarCampos()
        txtCel.Enabled = False
        txtCI.Enabled = False
        txtDir.Enabled = False
        txtMail.Enabled = False
        txtNombre.Enabled = False
        txtResponsable.Enabled = False
        txtRUC.Enabled = False
        txtTel.Enabled = False
        txtLimiteC.Enabled = False
        cbSucursal.Enabled = False
        cbTipoC.Enabled = False
        cbVendedor.Enabled = False
        cbPrecio.Enabled = False
    End Sub


    ' Guardar nuevo producto
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then

                If (nuevo) Then
                    Dim daoP As New ClienteDAO
                    Dim modelo = llenarModelo()

                    daoP.guardar(modelo)

                    MsgBox("Cliente agregado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarClientes()
                Else
                    Dim daoP As New ClienteDAO
                    Dim row = dgvClientes.CurrentRow.Index
                    Dim codigo = dgvClientes.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)

                    daoP.update(modelo)

                    MsgBox("Cliente actualizado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarClientes()
                    btnModificar.Enabled = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' LLenado de modelo
    Private Function llenarModelo() As Cliente
        Dim modelo As New Cliente
        modelo.cel = txtCel.Text
        modelo.ci = txtCI.Text
        modelo.dir = txtDir.Text
        modelo.email = txtMail.Text
        modelo.nombre = txtNombre.Text
        modelo.responsable = txtResponsable.Text
        modelo.ruc = txtRUC.Text
        modelo.telf = txtTel.Text
        If txtLimiteC.Text = "" Then modelo.limiteC = 0 Else modelo.limiteC = txtLimiteC.Text
        modelo.sucursal = cbSucursal.SelectedValue
        modelo.tipo = cbTipoC.SelectedValue
        modelo.vendedor = cbVendedor.SelectedValue
        modelo.precioDefault = cbPrecio.SelectedValue
        Select Case cbPrecio.SelectedIndex
            Case 1
                modelo.precioDefault = "A"
            Case 2
                modelo.precioDefault = "B"
            Case 3
                modelo.precioDefault = "C"
            Case 4
                modelo.precioDefault = "D"

        End Select
        Return modelo
    End Function

    ' Llena el modelo para su actualizacion
    Private Function llenarModelo(ByVal id As Integer) As Cliente
        Dim modelo As New Cliente
        modelo.id = id
        modelo.cel = txtCel.Text
        modelo.ci = txtCI.Text
        modelo.dir = txtDir.Text
        modelo.email = txtMail.Text
        modelo.nombre = txtNombre.Text
        modelo.responsable = txtResponsable.Text
        modelo.ruc = txtRUC.Text
        modelo.telf = txtTel.Text
        modelo.limiteC = txtLimiteC.Text
        modelo.sucursal = cbSucursal.SelectedValue
        modelo.tipo = cbTipoC.SelectedValue
        modelo.vendedor = cbVendedor.SelectedValue
        Select Case cbPrecio.SelectedIndex
            Case 1
                modelo.precioDefault = "A"
            Case 2
                modelo.precioDefault = "B"
            Case 3
                modelo.precioDefault = "C"
            Case 4
                modelo.precioDefault = "D"
        End Select
        Return modelo
    End Function

    ' Validaciones
    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtCel.KeyPress, txtCI.KeyPress, txtLimiteC.KeyPress, txtTel.KeyPress
        soloNumeros(e)
    End Sub

    Private Function validarDatos() As Boolean

        If txtCI.Text = "" Or txtNombre.Text = "" Or txtCel.Text = "" Or txtRUC.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
            txtNombre.Focus()
            Return False
        ElseIf cbVendedor.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un vendedor", MsgBoxStyle.Critical, "Notificación")
            cbVendedor.Focus()
            Return False
        ElseIf cbTipoC.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un tipo para el cliente", MsgBoxStyle.Critical, "Notificación")
            cbTipoC.Focus()
            Return False
        ElseIf cbPrecio.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un precio por defecto", MsgBoxStyle.Critical, "Notificación")
            cbPrecio.Focus()
            Return False
        End If

        Return True

    End Function

    '' Formato Precios
    'Private Sub precioFormat(sender As Object, e As EventArgs) Handles txtPA.TextChanged, txtPB.TextChanged, txtPC.TextChanged, txtPD.TextChanged

    '    If sender.Text <> "" Then
    '        sender.Text = FormatCurrency(sender.Text, 1)
    '        sender.Select(sender.TextLength - 2, 0)
    '    Else
    '        sender.Text = FormatCurrency(0, 1)
    '        sender.Select(sender.TextLength - 2, 0)
    '    End If
    'End Sub

    'Private Sub precioClick(sender As Object, e As EventArgs) Handles txtPA.Click, txtPB.Click, txtPC.Click, txtPD.Click
    '    If sender.Text <> "" Then
    '        sender.Select(sender.TextLength - 2, 0)
    '    End If
    'End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnGuardar.Enabled = True
        btnGuardar.Text = "Guardar Cambios"
        btnGuardar.Width = 207
        activarCampos()
        txtNombre.Focus()
        nuevo = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvClientes.SelectedRows.Count > 0 Then
                Dim row = dgvClientes.CurrentRow.Index
                Dim codigo = dgvClientes.Item(0, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar el cliente seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoP As New ClienteDAO
                    daoP.eliminar(codigo)
                    MsgBox("Cliente eliminado correctamente", MsgBoxStyle.Information, "Éxito")
                    cargarClientes()
                    desactivarCampos()
                    limpiarCampos()
                End If
            Else
                MsgBox("Seleccione un cliente a eliminar de la lista", MsgBoxStyle.Critical, "Seleccione color")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    'Metodo para la busqueda de productos
    Private Sub busquedaProducto(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Nombre like '%{0}%' or Tipo like '%{0}%' ", txtBusqueda.Text)
            dgvClientes.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvClientes.ClearSelection()
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Nombre like '%{0}%' or Tipo like '%{0}%' or CI like '%{0}%' or RUC like '%{0}%' ", txtBusqueda.Text)
        dgvClientes.DataSource = dv
        limpiarCampos()
        desactivarCampos()
        dgvClientes.ClearSelection()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtRUC.Focus()
        End If
    End Sub

    Private Sub txtRUC_TextChanged(sender As Object, e As KeyEventArgs) Handles txtRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCI.Focus()
        End If
    End Sub

    Private Sub txtCI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCI.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtDir.Focus()
        End If
    End Sub

    Private Sub txtDir_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDir.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtResponsable.Focus()
        End If
    End Sub

    Private Sub txtResponsable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtResponsable.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtTel.Focus()
        End If
    End Sub

    Private Sub txtTel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTel.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCel.Focus()
        End If
    End Sub

    Private Sub txtCel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCel.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtMail.Focus()
        End If
    End Sub

    Private Sub txtMail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMail.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cbTipoC.Focus()
        End If
    End Sub
End Class