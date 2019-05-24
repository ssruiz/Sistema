Imports Backend

Public Class SucursalForm
    Dim list As New DataSet
    Dim nuevo = False
    Private Sub SucursalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSucursales()
        cargarDepositos()
        desactivarCampos()
        PersonalizarDAtagridView(dgvSucursales)
    End Sub

    ' Carga de las sucursales
    Private Sub cargarSucursales()
        Me.SuspendLayout()
        Dim daoS As New SucursalDAO
        list = daoS.getSucursales()
        dgvSucursales.DataSource = ""
        dgvSucursales.DataSource = list.Tables("tabla")

        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvSucursales.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSucursales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvSucursales.ClearSelection()
        Me.SuspendLayout()
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
    ' carga de depositos
    Private Sub cargarDepositos()
        Dim daoD As New DepositoDAO
        Dim depositos = daoD.getDepositos()
        Dim listTipos = depositos.Tables("tabla")
        Dim rowV = listTipos.NewRow()
        rowV("Nombre") = "-- Seleccione Tipo -- "
        rowV("ID") = 0
        listTipos.Rows.InsertAt(rowV, 0)

        cbDepositos.DataSource = listTipos.Copy
        cbDepositos.DisplayMember = "Nombre"
        cbDepositos.ValueMember = "ID"
    End Sub


    ' Activa los campos
    Private Sub activarCampos()

        txtNombre.Enabled = True
        cbDepositos.Enabled = True
    End Sub

    ' Descactiva los campos
    Private Sub desactivarCampos()
        txtNombre.Enabled = False
        cbDepositos.Enabled = False

    End Sub

    ' Limpia los campos
    Private Sub limpiarCampos()
        txtNombre.Text = ""
        cbDepositos.SelectedIndex = 0
    End Sub

    Private Sub busquedaSucursal(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Nombre like '%{0}%' ", txtBusqueda.Text)
            dgvSucursales.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvSucursales.ClearSelection()
        End If
    End Sub

    Private Sub dgvUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSucursales.SelectionChanged
        If dgvSucursales.Focused Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvSucursales.CurrentRow.Index
                Dim codigo = dgvSucursales.Item(0, row).Value
                Dim daoU As New SucursalDAO
                Dim sucursal = daoU.getSucursal(codigo)
                cargarSucursal(sucursal)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub cargarSucursal(ByVal modelo As Sucursal)
        txtNombre.Text = modelo.nombre
        cbDepositos.SelectedValue = modelo.deposito
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then
                If (nuevo) Then
                    Dim daoO As New SucursalDAO
                    Dim modelo = llenarModelo()
                    daoO.guardar(modelo)
                    MsgBox("Sucursal agregada correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarSucursales()
                Else
                    Dim daoU As New SucursalDAO
                    Dim row = dgvSucursales.CurrentRow.Index
                    Dim codigo = dgvSucursales.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)
                    daoU.update(modelo)

                    MsgBox("Sucursal actualizada correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarSucursales()
                    btnModificar.Enabled = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function validarDatos() As Boolean
        If txtNombre.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Notificación")
            txtNombre.Focus()
            Return False
        ElseIf cbDepositos.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un depósito", MsgBoxStyle.Critical, "Notificación")
            cbDepositos.Focus()
            Return False
        End If
        Return True

    End Function

    Private Function llenarModelo() As Sucursal
        Dim modelo As New Sucursal
        modelo.nombre = txtNombre.Text
        modelo.deposito = cbDepositos.SelectedValue
        Return modelo
    End Function

    Private Function llenarModelo(ByVal cod As String) As Sucursal
        Dim modelo As New Sucursal
        modelo.id = cod
        modelo.nombre = txtNombre.Text
        modelo.deposito = cbDepositos.SelectedValue
        Return modelo
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtNombre.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        dgvSucursales.ClearSelection()
        btnGuardar.Text = "Guardar"
    End Sub

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
            If dgvSucursales.SelectedRows.Count > 0 Then
                Dim row = dgvSucursales.CurrentRow.Index
                Dim codigo = dgvSucursales.Item(0, row).Value
                Dim suc = dgvSucursales.Item(1, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar la sucursal " & suc & " seleccionada?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoO As New SucursalDAO
                    Dim res = daoO.eliminar(codigo)
                    MsgBox(res, MsgBoxStyle.Information, "Notificación")
                    cargarSucursales()
                    desactivarCampos()
                    limpiarCampos()
                End If
            Else
                MsgBox("Seleccione una sucursal a eliminar de la lista", MsgBoxStyle.Critical, "Seleccione color")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class