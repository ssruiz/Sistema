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
            btnGuardar.Enabled = False
            PersonalizarDAtagridView(dgvBancos)
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
    Private Sub cargarBancos()
        Me.SuspendLayout()
        Dim daoP As New BancoDAO
        list = daoP.getBancos()
        dgvBancos.DataSource = ""
        dgvBancos.DataSource = list.Tables("tabla")
        ''dgvProveedores.Columns("ID").Visible = False
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvBancos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBancos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvBancos.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvBancos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvBancos.ClearSelection()
        Me.SuspendLayout()
    End Sub

    Private Sub desactivarCampos()
        txtNombre.Enabled = False
        btnGuardar.Enabled = False
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
        txtNombre.Text = ""
    End Sub

    ' Activa los campos
    Private Sub activarCampos()
        txtNombre.Enabled = True
        dgvBancos.ClearSelection()
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

                    Dim row = dgvBancos.CurrentRow.Index
                    Dim codigo = dgvBancos.Item(0, row).Value
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

    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBancos.SelectionChanged
        If dgvBancos.Focused And dgvBancos.SelectedRows.Count > 0 Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvBancos.CurrentRow.Index
                Dim codigo = dgvBancos.Item(0, row).Value
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
        dgvBancos.DataSource = dv
        limpiarCampos()
        desactivarCampos()
        dgvBancos.ClearSelection()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnGuardar_Click(sender, e)
        End If
    End Sub

End Class