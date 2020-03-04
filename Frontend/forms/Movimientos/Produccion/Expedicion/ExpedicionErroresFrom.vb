Imports Backend

Public Class ExpedicionErroresFrom
    Public otv = 0
    Dim venta As New Venta
    Private Sub ExpedicionErroresFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarVenta(otv)
        cargarProduccion()
        cargarErrores()
        dgvExpediciones.DataSource = New DataSetProduccion.ExpedicionesErroresDataTable
    End Sub

    Private Sub cargarErrores()
        Dim daop As New ReposicionesDAO
        Dim c = daop.getErrores()
        cbErrores.DisplayMember = "Error"
        cbErrores.ValueMember = "ID"
        cbErrores.DataSource = c.Tables("tabla")
    End Sub
    Private Sub cargarProduccion()
        Try
            Dim daoProd As New ProduccionDAO
            Dim res = daoProd.cargarExpedicionesRealizadas(otv)
            dgvExpedicionesRealizadas.DataSource = res.Tables("tabla")
            dgvExpedicionesRealizadas.ClearSelection()
            'dgvProduccionOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvExpedicionesRealizadas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvExpedicionesRealizadas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvExpedicionesRealizadas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvExpedicionesRealizadas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargarVenta(ByVal ot As String)
        Dim daop As New VentaDAO
        venta = daop.getVenta(ot)
        lblOt.Text = ot
        Dim cliente As New ClienteDAO
        Dim c = cliente.getCliente(venta.cliente)
        lblCliente.Text = c.nombre
        lblSup.Text = venta.m2
        Dim daopr As New ProduccionDAO
        Dim r = daopr.getExtTotalPanhos(ot)
        Dim r2 = daopr.getExtTotalPanhosExpedidos(ot)
        Dim r3 = daopr.getExtTotalPanhosTerminados(ot)
        Dim r4 = daopr.getExtTotalPanhosRotos(ot)
        lblPanhos.Text = r
        lblPanhExpedidos.Text = r2
        lblTotalPanhos.Text = r
        lblTerminados.Text = r3
        lblFaltantes.Text = r - r3
        lblRotos.Text = r4
    End Sub

    Private Sub txtProduccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProduccion.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            Try
                If txtProduccion.Text = "" Then
                    Exit Sub
                End If
                Dim aux = txtProduccion.Text
                txtProduccion.Text = ""


                Dim prodd As New ProduccionDAO
                'Dim dv As New DataView(dgvTemplados.DataSource)

                Dim nrop = 0
                Dim estadop = ""
                Dim salida = Nothing
                Dim estado = ""
                For Each row As Windows.Forms.DataGridViewRow In dgvDetalle.Rows

                    If Convert.ToInt32(row.Cells(1).Value) = CInt(aux) Then
                        nrop = row.Cells(1).Value
                        'salida = row.Cells(8).Value
                        'estado = row.Cells(10).Value
                        Exit For
                    End If
                Next





                If nrop <> 0 Then
                    Dim n = dgvExpediciones.Rows.Count
                    Dim row2 As DataTable = dgvExpediciones.DataSource
                    Dim row As DataRow = row2.NewRow()
                    Dim daopro As New ProduccionDAO
                    Dim producDao As New ProductoDAO
                    Dim auxprod = daopro.getProduccion(nrop)
                    Dim producaux = producDao.getProducto(auxprod.codProd)
                    Dim daousu As New SesionDAO
                    row(0) = n + 1
                    row(1) = auxprod.idProd
                    row(2) = producaux.codigo
                    row(3) = auxprod.panho
                    row(4) = auxprod.ancho
                    row(5) = auxprod.alto
                    row(6) = auxprod.sup
                    row(7) = Date.Now
                    row(8) = daousu.getUsuario
                    row(9) = cbErrores.SelectedItem("Error")

                    row(10) = cbErrores.SelectedValue.ToString
                    row2.Rows.Add(row)
                    dgvExpediciones.DataSource = row2
                    'dgvProductos.Rows.Add(row)
                    dgvExpediciones.ClearSelection()
                    dgvExpediciones.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvExpediciones.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    'daopro.guardarExpedicion(nrop)
                    'cargarExpediciones()
                End If



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub dgvProduccionOT_SelectionChanged(sender As Object, e As EventArgs) Handles dgvExpedicionesRealizadas.SelectionChanged
        If dgvExpedicionesRealizadas.Focused And dgvExpedicionesRealizadas.SelectedRows.Count > 0 Then
            Try

                Dim row = dgvExpedicionesRealizadas.CurrentRow
                Dim codigo = row.Cells(1).Value

                Dim daoP As New ProduccionDAO
                Dim producto = daoP.getDetalleExpedicion(codigo)
                dgvDetalle.DataSource = producto.Tables("tabla")
                dgvDetalle.ClearSelection()

                dgvDetalle.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalle.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalle.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalle.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalle.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalle.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalle.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dgvDetalle.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dgvDetalle.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dgvDetalle.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If dgvExpediciones.Rows.Count > 0 Then
                Dim result As Integer = MessageBox.Show("¿Guardar reposición?", "Guardar", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    Try
                        Dim daor As New ReposicionesDAO
                        daor.guardarReposicionErrores(otv, dgvExpediciones.Rows)
                        MsgBox("Reposición guardada", MsgBoxStyle.Information, "Notificación")
                        cargarVenta(otv)
                        cargarProduccion()
                        dgvDetalle.DataSource = ""
                        dgvExpediciones.DataSource = ""
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class