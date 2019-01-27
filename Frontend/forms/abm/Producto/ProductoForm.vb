Imports Backend

Public Class ProductoForm
    Dim nuevo = True
    Dim list As New DataSet
    Dim listTipos As New DataTable
    'Carga del formulario
    Private Sub ProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.SuspendLayout()
            cargarProductos()
            cargarColores()
            cargarTipos()
            cargarPlanchas()
            desactivarCampos()
            Me.ResumeLayout()
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
        dgvProductos.Columns("Código").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
        listTipos = tipos.Tables("tabla")

        'Dim rowV = listTipos.NewRow()
        'rowV("Tipo") = "-- Seleccione Tipo -- "
        'rowV("ID") = 0
        'listTipos.Rows.InsertAt(rowV, 0)

        'cbTipoPlancha.DataSource = listTipos.Copy
        'cbTipoPlancha.DisplayMember = "Tipo"
        'cbTipoPlancha.ValueMember = "ID"
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
        If dgvProductos.Focused And dgvProductos.SelectedRows.Count > 0 Then
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
        txtEspesor.Text = modelo.espesor
        txtSuperficie.Text = modelo.superficie
        cbColores.SelectedValue = modelo.color
        txtCosto.Text = modelo.costo
        Dim dr = listTipos.Select("ID='" & modelo.tipo & "'")
        If dr.Length > 0 Then
            If dr(0)("Tipo").ToString() = "herrajes" Then
                rbHerrajes.Checked = True
            ElseIf dr(0)("Tipo").ToString() = "perfiles" Then
                rbPerfiles.Checked = True
            ElseIf dr(0)("Tipo").ToString() = "planchas" Then
                rbPlanchas.Checked = True
            ElseIf dr(0)("Tipo").ToString() = "templado" Then
                rbTemplados.Checked = True
            End If
        End If

        'cbTipos.SelectedValue = modelo.tipo
        cbTipoPlancha.SelectedValue = modelo.tipoPL
    End Sub

    ' Nuevo producto
    Private Sub nuevoProducto(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If tipoCheckeado() Then
            limpiarCampos()
            activarCampos()
            txtCodigo.Focus()
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            nuevo = True
            dgvProductos.ClearSelection()
            btnGuardar.Text = "Guardar"
        Else
            MsgBox("Debe seleccionar un tipo para el produco", MsgBoxStyle.Critical, "Notificación")
            gbTipo.Focus()
        End If

    End Sub

    ' Comprueba si algun tipo fue seleccionado
    Private Function tipoCheckeado() As Boolean
        If rbPerfiles.Checked Or rbHerrajes.Checked Or rbTemplados.Checked Or rbPlanchas.Checked = True Then
            Return True
        End If
        Return False
    End Function

    ' Limpia los campos
    Private Sub limpiarCampos()
        txtAlto.Text = ""
        txtAncho.Text = ""
        'txtBusqueda.Text = ""
        txtCodigo.Text = ""
        txtDesc.Text = ""
        txtPA.Text = ""
        txtPB.Text = ""
        txtPC.Text = ""
        txtPD.Text = ""
        txtSM.Text = ""
        txtSuperficie.Text = ""
        txtEspesor.Text = ""
        txtCosto.Text = ""
        cbColores.SelectedIndex = 0
        'cbTipos.SelectedIndex = 0
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
        txtSuperficie.Enabled = False
        txtCosto.Enabled = True
        '     cbTipos.Enabled = True
        cbColores.Enabled = True
        cbColores.Enabled = True
        '   cbTipos.Enabled = True
        cbTipoPlancha.Enabled = True
        txtEspesor.Enabled = True
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
        txtCosto.Enabled = False
        txtSuperficie.Enabled = False
        txtEspesor.Enabled = False
        ' cbTipos.Enabled = False
        cbColores.Enabled = False
        cbColores.Enabled = False
        'cbTipos.Enabled = False
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

        modelo.codigo = txtCodigo.Text
        modelo.descripcion = txtDesc.Text
        modelo.PrecioA = txtPA.Text
        modelo.PrecioB = txtPB.Text
        modelo.PrecioC = txtPC.Text
        modelo.PrecioD = txtPD.Text


        modelo.color = cbColores.SelectedValue
        modelo.tipo = getTipo()
        modelo.espesor = txtEspesor.Text
        modelo.costo = txtCosto.Text
        If rbPlanchas.Checked Then
            modelo.alto = txtAlto.Text
            modelo.ancho = txtAncho.Text
            modelo.superficie = txtSuperficie.Text
            modelo.stockMin = txtSM.Text
            If cbTipoPlancha.SelectedIndex <> 0 Then
                modelo.tipoPL = cbTipoPlancha.SelectedValue
            End If
        End If

        Return modelo
    End Function

    Private Function getTipo() As Integer

        If rbHerrajes.Checked Then

            Return listTipos.Rows(0).Item("ID")
        ElseIf rbPerfiles.Checked Then
            Return listTipos.Rows(1).Item("ID")
        ElseIf rbPlanchas.Checked Then
            Return listTipos.Rows(2).Item("ID")
        Else
            Return listTipos.Rows(3).Item("ID")
        End If
    End Function

    '
    ' Llena el modelo para su actualizacion
    Private Function llenarModelo(ByVal id As Integer) As Producto
        Dim modelo As New Producto
        modelo.descripcion = txtDesc.Text
        modelo.PrecioA = txtPA.Text
        modelo.PrecioB = txtPB.Text
        modelo.PrecioC = txtPC.Text
        modelo.PrecioD = txtPD.Text
        modelo.codigo = txtCodigo.Text
        modelo.color = cbColores.SelectedValue
        ' modelo.tipo = cbTipos.SelectedValue
        modelo.id = id
        modelo.tipo = getTipo()
        modelo.espesor = txtEspesor.Text
        modelo.costo = txtCosto.Text
        If rbPlanchas.Checked Then
            modelo.alto = txtAlto.Text
            modelo.ancho = txtAncho.Text
            modelo.superficie = txtSuperficie.Text
            modelo.stockMin = txtSM.Text
            If cbTipoPlancha.SelectedIndex <> 0 Then
                modelo.tipoPL = cbTipoPlancha.SelectedValue
            End If
        End If
        Return modelo
    End Function

    ' Validaciones
    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtPA.KeyPress, txtPB.KeyPress, txtPC.KeyPress, txtPD.KeyPress, txtSM.KeyPress, txtCosto.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub soloNumerosDecilames(sender As Object, e As KeyPressEventArgs) Handles txtSuperficie.KeyPress, txtAlto.KeyPress, txtAncho.KeyPress, txtEspesor.KeyPress
        soloNumerosDecimales(sender, e)
    End Sub

    Private Function validarDatos() As Boolean
        If rbPlanchas.Checked Then
            If txtCodigo.Text = "" Or txtDesc.Text = "" Or txtAlto.Text = "" Or txtAncho.Text = "" Or txtDesc.Text = "" Or txtPA.Text = "" Or txtPB.Text = "" Or txtPC.Text = "" Or txtPD.Text = "" Or txtSM.Text = "" Or txtSuperficie.Text = "" Or txtEspesor.Text = "" Or txtCosto.Text = "" Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
                Return False
            ElseIf cbColores.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un color", MsgBoxStyle.Critical, "Notificación")
                cbColores.Focus()
                Return False
            ElseIf cbTipoPlancha.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un tipo para la plancha", MsgBoxStyle.Critical, "Notificación")
                cbTipoPlancha.Focus()
                Return False
            End If
        Else
            If txtCodigo.Text = "" Or txtDesc.Text = "" Or txtPA.Text = "" Or txtPB.Text = "" Or txtPC.Text = "" Or txtPD.Text = "" Or txtEspesor.Text = "" Or txtCosto.Text = "" Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
                Return False
            ElseIf cbColores.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un color", MsgBoxStyle.Critical, "Notificación")
                cbColores.Focus()
                Return False
            End If
        End If
        Return True

    End Function

    ' Formato Precios
    Private Sub precioFormat(sender As Object, e As EventArgs) Handles txtPA.TextChanged, txtPB.TextChanged, txtPC.TextChanged, txtPD.TextChanged, txtCosto.TextChanged

        If sender.Text <> "" Then
            sender.Text = FormatCurrency(sender.Text, 1)
            sender.Select(sender.TextLength - 2, 0)
        Else
            sender.Text = FormatCurrency(0, 1)
            sender.Select(sender.TextLength - 2, 0)
        End If
    End Sub

    Private Sub precioClick(sender As Object, e As EventArgs) Handles txtPA.Click, txtPB.Click, txtPC.Click, txtPD.Click, txtCosto.Click
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
                    Dim daoP As New ProductoDAO
                    daoP.eliminar(codigo)
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




    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles rbHerrajes.Click

    End Sub

    Private Sub checkChangeConList(sender As Object, e As EventArgs) Handles rbHerrajes.CheckedChanged, rbPerfiles.CheckedChanged, rbTemplados.CheckedChanged
        If dgvProductos.SelectedRows.Count > 0 Then
            If sender.Checked Then
                lblTipoPL.Visible = False
                cbTipoPlancha.Visible = False
                pnlDatosProd.Visible = False

            End If
        End If

    End Sub

    Private Sub checkChangeConListPlanchas(sender As Object, e As EventArgs) Handles rbPlanchas.CheckedChanged
        If dgvProductos.SelectedRows.Count > 0 Then
            If rbPlanchas.Checked = True Then
                lblTipoPL.Visible = True
                cbTipoPlancha.Visible = True
                pnlDatosProd.Visible = True

            End If
        End If
    End Sub

    Private Sub rbHerrajes_CheckedChanged(sender As Object, e As EventArgs) Handles rbHerrajes.Click, rbPerfiles.Click, rbTemplados.Click
        dgvProductos.ClearSelection()
        If sender.Checked Then
            lblTipoPL.Visible = False
            cbTipoPlancha.Visible = False
            pnlDatosProd.Visible = False
            limpiarCampos()
            desactivarCampos()
        End If
    End Sub

    Private Sub rbPlanchas_CheckedChanged(sender As Object, e As EventArgs) Handles rbPlanchas.Click
        dgvProductos.ClearSelection()
        If rbPlanchas.Checked = True Then
            lblTipoPL.Visible = True
            cbTipoPlancha.Visible = True
            pnlDatosProd.Visible = True
            limpiarCampos()
            desactivarCampos()
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Código like '%{0}%' or Descripción like '%{0}%' or Tipo like '%{0}%' ", txtBusqueda.Text)
            dgvProductos.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvProductos.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtAlto_TextChanged(sender As Object, e As EventArgs) Handles txtAlto.TextChanged, txtAncho.TextChanged
        Try
            If txtAlto.Text.Contains(".") Then
                txtAlto.Text = Replace(txtAlto.Text, ".", ",")
                If txtAlto.Focused Then
                    txtAlto.SelectionStart = txtAlto.Text.Length
                End If
            End If

            If txtAncho.Text.Contains(".") Then
                txtAncho.Text = Replace(txtAncho.Text, ".", ",")
                If txtAncho.Focused Then
                    txtAncho.SelectionStart = txtAncho.Text.Length
                End If
            End If
            If txtAncho.Text <> "" And txtAlto.Text <> "" Then
                Dim str As Double
                If Double.TryParse(txtAlto.Text * txtAncho.Text, str) Then

                    txtSuperficie.Text = str
                End If
            Else
                txtSuperficie.Text = ""
            End If
        Catch ex As Exception
            txtAlto.Text = ""
            txtAncho.Text = ""
            txtSuperficie.Text = ""
        End Try

    End Sub
End Class