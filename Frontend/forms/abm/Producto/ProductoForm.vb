Imports Backend

Public Class ProductoForm
    Dim nuevo = True
    Dim list As New DataSet
    'Carga del formulario
    Private Sub ProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarProductos()
            cargarColores()
            cargarTipos()
            cargarPlanchas()
            desactivarCampos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Carga de productos de la db
    Private Sub cargarProductos()
        Me.SuspendLayout()
        Dim daoP As New ProductoDAO
        list = daoP.getProductos()
        dgvProductos.DataSource = ""
        dgvProductos.DataSource = list.Tables("tabla")
        dgvProductos.Columns("ID").Visible = False
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvProductos.Columns("Codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvProductos.ClearSelection()
        Me.SuspendLayout()
    End Sub

    'Carga de colores desde la BD
    Private Sub cargarColores()
        Dim daoC As New ColorDAO
        Dim colores = daoC.getColores()
        Dim listColores = colores.Tables("tabla")
        Dim rowV = listColores.NewRow()
        rowV("Color") = "-- Seleccione Color -- "
        rowV("ID") = 0
        listColores.Rows.InsertAt(rowV, 0)

        cbColores.DataSource = listColores.Copy
        cbColores.DisplayMember = "Color"
        cbColores.ValueMember = "ID"
    End Sub

    ' Carga de tipos desde la BD
    Private Sub cargarTipos()
        Dim daoT As New TipoProdDAO
        Dim tipos = daoT.getTipos()
        Dim listTipos = tipos.Tables("tabla")
        Dim rowV = listTipos.NewRow()
        rowV("Tipo") = "-- Seleccione Tipo -- "
        rowV("ID") = 0
        listTipos.Rows.InsertAt(rowV, 0)

        cbTipos.DataSource = listTipos.Copy
        cbTipos.DisplayMember = "Tipo"
        cbTipos.ValueMember = "ID"
    End Sub

    ' Carga de tipo de planchas desde la BD
    Private Sub cargarPlanchas()
        Dim daoT As New TipoProdDAO
        Dim tipos = daoT.getTiposPlancha()
        Dim listTipos = tipos.Tables("tabla")
        Dim rowV = listTipos.NewRow()
        rowV("Tipo") = "-- Seleccione Tipo -- "
        rowV("ID") = 0
        listTipos.Rows.InsertAt(rowV, 0)

        cbTipoPlancha.DataSource = listTipos.Copy
        cbTipoPlancha.DisplayMember = "Tipo"
        cbTipoPlancha.ValueMember = "ID"
    End Sub

    'Carga de producto seleccionado
    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
        If dgvProductos.Focused Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvProductos.CurrentRow.Index
                Dim codigo = dgvProductos.Item(0, row).Value
                Dim daoP As New ProductoDAO
                Dim producto = daoP.getProducto(codigo)
                cargarProducto(producto)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    ' Carga el producto seleccionado
    Private Sub cargarProducto(ByVal modelo As Producto)
        txtAlto.Text = modelo.alto
        txtAncho.Text = modelo.ancho
        txtCodigo.Text = modelo.codigo
        txtDesc.Text = modelo.descripcion
        txtPA.Text = modelo.PrecioA
        txtPB.Text = modelo.PrecioB
        txtPC.Text = modelo.PrecioC
        txtPD.Text = modelo.PrecioD
        txtSM.Text = modelo.stockMin
        txtSuperficie.Text = modelo.superficie
        cbColores.SelectedValue = modelo.color
        cbTipos.SelectedValue = modelo.tipo
        cbTipoPlancha.SelectedValue = modelo.tipoPL
    End Sub

    ' Nuevo producto
    Private Sub nuevoProducto(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtCodigo.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        btnGuardar.Text = "Guardar"
    End Sub

    ' Limpia los campos
    Private Sub limpiarCampos()
        txtAlto.Text = ""
        txtAncho.Text = ""
        txtBusqueda.Text = ""
        txtCodigo.Text = ""
        txtDesc.Text = ""
        txtPA.Text = ""
        txtPB.Text = ""
        txtPC.Text = ""
        txtPD.Text = ""
        txtSM.Text = ""
        txtSuperficie.Text = ""
        cbColores.SelectedIndex = 0
        cbTipos.SelectedIndex = 0
        cbTipoPlancha.SelectedIndex = 0
    End Sub

    ' Activa los campos
    Private Sub activarCampos()
        txtAlto.Enabled = True
        txtAncho.Enabled = True
        txtCodigo.Enabled = True
        txtDesc.Enabled = True
        txtPA.Enabled = True
        txtPB.Enabled = True
        txtPC.Enabled = True
        txtPD.Enabled = True
        txtSM.Enabled = True
        txtSuperficie.Enabled = True
        cbTipos.Enabled = True
        cbColores.Enabled = True
        cbColores.Enabled = True
        cbTipos.Enabled = True
        cbTipoPlancha.Enabled = True
        dgvProductos.ClearSelection()
    End Sub

    ' Descactiva los campos
    Private Sub desactivarCampos()
        txtAlto.Enabled = False
        txtAncho.Enabled = False
        txtCodigo.Enabled = False
        txtDesc.Enabled = False
        txtPA.Enabled = False
        txtPB.Enabled = False
        txtPC.Enabled = False
        txtPD.Enabled = False
        txtSM.Enabled = False
        txtSuperficie.Enabled = False
        cbTipos.Enabled = False
        cbColores.Enabled = False
        cbColores.Enabled = False
        cbTipos.Enabled = False
        cbTipoPlancha.Enabled = False

    End Sub


    ' Guardar nuevo producto
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then

                If (nuevo) Then
                    Dim daoP As New ProductoDAO
                    Dim modelo = llenarModelo()
                    daoP.guardar(modelo)
                    MsgBox("Producto agregado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarProductos()
                Else
                    Dim daoP As New ProductoDAO
                    Dim row = dgvProductos.CurrentRow.Index
                    Dim codigo = dgvProductos.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)
                    daoP.update(modelo)

                    MsgBox("Producto actualizado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarProductos()
                    btnModificar.Enabled = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' LLenado de modelo
    Private Function llenarModelo() As Producto
        Dim modelo As New Producto
        modelo.alto = txtAlto.Text
        modelo.ancho = txtAncho.Text
        modelo.codigo = txtCodigo.Text
        modelo.descripcion = txtDesc.Text
        modelo.PrecioA = txtPA.Text
        modelo.PrecioB = txtPB.Text
        modelo.PrecioC = txtPC.Text
        modelo.PrecioD = txtPD.Text
        modelo.stockMin = txtSM.Text
        modelo.superficie = txtSuperficie.Text
        modelo.color = cbColores.SelectedValue
        modelo.tipo = cbTipos.SelectedValue
        If cbTipoPlancha.SelectedIndex <> 0 Then
            modelo.tipoPL = cbTipoPlancha.SelectedValue
        End If
        Return modelo
    End Function

    ' Llena el modelo para su actualizacion
    Private Function llenarModelo(ByVal id As Integer) As Producto
        Dim modelo As New Producto
        modelo.alto = txtAlto.Text
        modelo.ancho = txtAncho.Text
        modelo.codigo = txtCodigo.Text
        modelo.descripcion = txtDesc.Text
        modelo.PrecioA = txtPA.Text
        modelo.PrecioB = txtPB.Text
        modelo.PrecioC = txtPC.Text
        modelo.PrecioD = txtPD.Text
        modelo.stockMin = txtSM.Text
        modelo.superficie = txtSuperficie.Text
        modelo.color = cbColores.SelectedValue
        modelo.tipo = cbTipos.SelectedValue
        modelo.id = id
        If cbTipoPlancha.SelectedIndex <> 0 Then
            modelo.tipoPL = cbTipoPlancha.SelectedValue
        End If
        Return modelo
    End Function

    ' Validaciones
    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtAlto.KeyPress, txtAncho.KeyPress, txtPA.KeyPress, txtPB.KeyPress, txtPC.KeyPress, txtPD.KeyPress, txtSuperficie.KeyPress, txtSM.KeyPress
        soloNumeros(e)
    End Sub

    Private Function validarDatos() As Boolean
        If txtCodigo.Text = "" Or txtDesc.Text = "" Or txtAlto.Text = "" Or txtAncho.Text = "" Or txtDesc.Text = "" Or txtPA.Text = "" Or txtPB.Text = "" Or txtPC.Text = "" Or txtPD.Text = "" Or txtSM.Text = "" Or txtSuperficie.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
            Return False
        ElseIf cbColores.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un color", MsgBoxStyle.Critical, "Notificación")
            cbColores.Focus()
            Return False
        ElseIf cbTipos.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un tipo", MsgBoxStyle.Critical, "Notificación")
            cbTipos.Focus()
            Return False
        End If
        Return True

    End Function

    ' Formato Precios
    Private Sub precioFormat(sender As Object, e As EventArgs) Handles txtPA.TextChanged, txtPB.TextChanged, txtPC.TextChanged, txtPD.TextChanged

        If sender.Text <> "" Then
            sender.Text = FormatCurrency(sender.Text, 1)
            sender.Select(sender.TextLength - 2, 0)
        Else
            sender.Text = FormatCurrency(0, 1)
            sender.Select(sender.TextLength - 2, 0)
        End If
    End Sub

    Private Sub precioClick(sender As Object, e As EventArgs) Handles txtPA.Click, txtPB.Click, txtPC.Click, txtPD.Click
        If sender.Text <> "" Then
            sender.Select(sender.TextLength - 2, 0)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnGuardar.Enabled = True
        btnGuardar.Text = "Guardar Cambios"
        btnGuardar.Width = 207
        activarCampos()
        txtCodigo.Focus()
        nuevo = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvProductos.SelectedRows.Count > 0 Then
                Dim row = dgvProductos.CurrentRow.Index
                Dim codigo = dgvProductos.Item(0, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar el producto seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoC As New ColorDAO
                    daoC.eliminar(codigo)
                    MsgBox("Producto eliminado correctamente", MsgBoxStyle.Information, "Éxito")
                    cargarProductos()
                    desactivarCampos()
                    limpiarCampos()
                End If
            Else
                MsgBox("Seleccione un producto a eliminar de la lista", MsgBoxStyle.Critical, "Seleccione color")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    'Metodo para la busqueda de productos
    Private Sub busquedaProducto(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Codigo like '%{0}%' or Descripción like '%{0}%' or Tipo like '%{0}%' ", txtBusqueda.Text)
            dgvProductos.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvProductos.ClearSelection()
        End If
    End Sub
End Class