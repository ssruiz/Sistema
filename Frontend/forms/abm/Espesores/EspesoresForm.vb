Imports Backend

Public Class EspesoresForm
    Dim nuevo = False
    Dim list
    Private Sub ColorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.SuspendLayout()
            cargarEspesores()


            Me.ResumeLayout()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtEspesor.KeyPress, txtBusqueda.KeyPress
        soloNumeros(e)
    End Sub
    Private Sub cargarEspesores()
        Dim daoE As New EspesorDAO
        list = New DataSet
        list = daoE.getEspesores()

        dgvEspesores.DataSource = ""
        dgvEspesores.DataSource = list.Tables("tabla")
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvEspesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEspesores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvEspesores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvEspesores.ClearSelection()
    End Sub

    Private Function controlarCampos() As Boolean
        If txtEspesor.Text.Length > 0 Then
            Return True
        End If
        Return False
    End Function



    Private Sub guardarEspesor(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim daoE As New EspesorDAO

            If (controlarCampos()) Then
                If nuevo = True Then
                    Dim espe As New Espesor
                    espe.espesor = txtEspesor.Text
                    daoE.agregar(espe)
                    MsgBox("Espesor agregado correctamente", MsgBoxStyle.Information, "Éxito")
                    cargarEspesores()
                Else

                    Dim row = dgvEspesores.CurrentRow.Index
                    Dim codigo = dgvEspesores.Item(0, row).Value
                    Dim modelo = llenarModelo(codigo)
                    daoE.update(modelo)

                    MsgBox("Espesor actualizado correctamente", MsgBoxStyle.Information, "Éxito")
                    limpiarCampos()
                    desactivarCampos()
                    cargarEspesores()
                    limpiarCampos()
                    desactivarCampos()
                End If
            Else
                MsgBox("Ingrese el nombre para el color", MsgBoxStyle.Critical, "Campos")
                txtEspesor.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function llenarModelo(ByVal id As Integer) As Espesor
        Dim modelo As New Espesor
        modelo.id = id
        modelo.espesor = txtEspesor.Text
        Return modelo
    End Function

    Private Sub eliminarEspesor(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvEspesores.SelectedRows.Count > 0 Then
                Dim row = dgvEspesores.CurrentRow.Index
                Dim codigo = dgvEspesores.Item(0, row).Value
                Dim result As Integer = MessageBox.Show("¿Eliminar el espesor seleccionado?", "Eliminar", MessageBoxButtons.YesNo)


                If result = DialogResult.Yes Then
                    Dim daoE As New EspesorDAO
                    daoE.eliminar(codigo)
                    MsgBox("Espesor eliminado correctamente", MsgBoxStyle.Information, "Éxito")
                    cargarEspesores()

                End If
            Else
                MsgBox("Seleccione un espesor a eliminar", MsgBoxStyle.Critical, "Seleccione espesor")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
        txtEspesor.Focus()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        nuevo = True
        btnGuardar.Text = "Guardar"
    End Sub

    Private Sub limpiarCampos()
        txtEspesor.Text = ""
    End Sub

    Private Sub activarCampos()
        txtEspesor.Enabled = True
    End Sub

    Private Sub desactivarCampos()
        txtEspesor.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnGuardar.Enabled = True
        btnGuardar.Text = "Guardar Cambios"
        btnGuardar.Width = 207
        activarCampos()
        txtEspesor.Focus()
        nuevo = False
    End Sub

    Private Sub dgvColores_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEspesores.SelectionChanged
        If dgvEspesores.Focused Then
            Try
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                Dim row = dgvEspesores.CurrentRow.Index
                Dim codigo = dgvEspesores.Item(0, row).Value
                Dim daoC As New EspesorDAO
                Dim espesor = daoC.getEspesor(codigo)
                cargarEspesor(espesor)
                desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cargarEspesor(ByVal modelo As Espesor)
        txtEspesor.Text = modelo.espesor
    End Sub

    Private Sub busquedaEspesor(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dv As New DataView(list.Tables("tabla"))
            If IsNumeric(txtBusqueda.Text) Then
                Dim aux = txtBusqueda.Text
                dv.RowFilter = String.Format("Convert(Espesor,'System.String') like '%{0}%' ", txtBusqueda.Text)
            End If

            dgvEspesores.DataSource = dv
            limpiarCampos()
            desactivarCampos()
            dgvEspesores.ClearSelection()
        End If
    End Sub
End Class