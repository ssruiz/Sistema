Imports Backend

Public Class DepositoForm
    Dim list As New DataSet
    Dim nuevo = False
    Private Sub SucursalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDepositos()
        cargarDepositos()
        desactivarCampos()
        PersonalizarDAtagridView(dgvDepositos)
    End Sub

    ' Carga de las depositos
    Private Sub cargarDepositos()
        Me.SuspendLayout()
        Dim daoO As New DepositoDAO
        list = daoO.getDepositos()
        dgvDepositos.DataSource = ""
        dgvDepositos.DataSource = list.Tables("tabla")

        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvDepositos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDepositos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvDepositos.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDepositos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvDepositos.ClearSelection()
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
    ' Activa los campos
    Private Sub activarCampos()

        txtNombre.Enabled = True

    End Sub

    ' Descactiva los campos
    Private Sub desactivarCampos()
        txtNombre.Enabled = False


    End Sub

    ' Limpia los campos
    Private Sub limpiarCampos()
        txtNombre.Text = ""

    End Sub

    Private Sub busquedaDeposito(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Nombre like '%{0}%' ", txtBusqueda.Text)
            dgvDepositos.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvDepositos.ClearSelection()
        End If
    End Sub

    Private Sub dgvUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDepositos.SelectionChanged
        If dgvDepositos.Focused Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvDepositos.CurrentRow.Index
                Dim codigo = dgvDepositos.Item(0, row).Value
                Dim daoO As New DepositoDAO
                Dim deposito = daoO.getDeposito(codigo)
                cargarDeposito(deposito)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub cargarDeposito(ByVal modelo As Deposito)
        txtNombre.Text = modelo.nombre

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then
                If (nuevo) Then
                    Dim daoO As New DepositoDAO
                    Dim modelo = llenarModelo()
                    daoO.guardar(modelo)
                    MsgBox("Depósito agregado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarDepositos()
                Else
                    Dim daoU As New DepositoDAO
                    Dim row = dgvDepositos.CurrentRow.Index
                    Dim codigo = dgvDepositos.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)
                    daoU.update(modelo)

                    MsgBox("Deposito actualizado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarDepositos()
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
        End If
        Return True

    End Function

    Private Function llenarModelo() As Deposito
        Dim modelo As New Deposito
        modelo.nombre = txtNombre.Text
        Return modelo
    End Function

    Private Function llenarModelo(ByVal cod As String) As Deposito
        Dim modelo As New Deposito
        modelo.id = cod
        modelo.nombre = txtNombre.Text
        Return modelo
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtNombre.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        dgvDepositos.ClearSelection()
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
            If dgvDepositos.SelectedRows.Count > 0 Then
                Dim row = dgvDepositos.CurrentRow.Index
                Dim codigo = dgvDepositos.Item(0, row).Value
                Dim dep = dgvDepositos.Item(1, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar el deposito " & dep & " seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoO As New DepositoDAO
                    Dim res = daoO.eliminar(codigo)
                    MsgBox(res, MsgBoxStyle.Information, "Notificación")
                    cargarDepositos()
                    desactivarCampos()
                    limpiarCampos()
                End If
            Else
                MsgBox("Seleccione un deposito a eliminar de la lista", MsgBoxStyle.Critical, "Seleccione color")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub
End Class