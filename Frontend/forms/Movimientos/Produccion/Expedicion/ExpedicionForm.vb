Imports System.Globalization
Imports Backend

Public Class ExpedicionForm
    Dim venta As New Venta
    Private Sub ExpedicionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim classResize As New ClsResizeForm
        classResize.ResizeForm(Me, 1252, 962)
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
        txtNroOT.Focus()
        dgvExpediciones.DataSource = New DataSetProduccion.ExpedicionesTableDataTable
    End Sub

    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroOT.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim ot = txtNroOT.Text
            txtNroOT.Text = ""
            Try
                If ot <> "" Then
                    'cargarCortes(ot)
                    'cargarMarcados(ot)
                    'cargarTemplados(ot)
                    'cargarPulidas(ot)

                    cargarVenta(ot)
                    cargarProduccion()
                    'cargarExpediciones()
                    txtProduccion.Focus()
                Else
                    Dim busqvent As New VentaBusqueda
                    busqvent.inicial = 1
                    Dim r = busqvent.ShowDialog()
                    If r = DialogResult.OK Then
                        Dim daov As New VentaDAO
                        cargarVenta(busqvent.ventaSel)
                        cargarProduccion()
                        txtProduccion.Focus()
                    End If
                    busqvent.Dispose()
                End If
                lblAlto.Text = ""
                lblAncho.Text = ""
                lblSupProd.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub cargarProduccion()
        Try
            Dim daoProd As New ProduccionDAO
            Dim res = daoProd.cargarProduccionOT(venta.id)
            dgvProduccionOT.DataSource = res.Tables("tabla")
            dgvProduccionOT.ClearSelection()
            'dgvProduccionOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvProduccionOT.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduccionOT.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargarVenta(ByVal ot As String)
        Dim daop As New VentaDAO
        venta = daop.getVenta(ot)
        lblOt.Text = venta.id
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


    'Private Sub cargarTemplados(ByVal ot As String)
    '    Dim daop As New ProduccionDAO
    '    Dim tr = daop.getExpTemplado(ot)
    '    dgvTemplados.DataSource = tr.Tables("tabla")
    '    dgvTemplados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    '    dgvTemplados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    dgvTemplados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    '    dgvTemplados.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    dgvTemplados.ClearSelection()
    'End Sub

    Private Sub cargarCortes(ByVal ot As String)
        Dim daop As New ProduccionDAO
        Dim tr = daop.getExpCorte(ot)
        dgvProduccionOT.DataSource = tr.Tables("tabla")
        dgvProduccionOT.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        dgvProduccionOT.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvProduccionOT.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvProduccionOT.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvProduccionOT.AutoResizeColumnHeadersHeight()
        dgvProduccionOT.ClearSelection()
    End Sub

    'Private Sub cargarMarcados(ByVal ot As String)
    '    Dim daop As New ProduccionDAO
    '    Dim tr = daop.getExpMarcado(ot)
    '    dgvMarcado.DataSource = tr.Tables("tabla")
    '    dgvMarcado.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    '    dgvMarcado.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    '    dgvMarcado.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    dgvMarcado.AutoResizeColumnHeadersHeight()
    '    dgvMarcado.ClearSelection()
    'End Sub

    'Private Sub cargarPulidas(ByVal ot As String)
    '    Dim daop As New ProduccionDAO
    '    Dim tr = daop.getExpPulida(ot)
    '    dgvPulidas.DataSource = tr.Tables("tabla")
    '    dgvPulidas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    '    dgvPulidas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    '    dgvPulidas.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    dgvPulidas.AutoResizeColumnHeadersHeight()
    '    dgvPulidas.ClearSelection()
    'End Sub

    Private Sub txtProduccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProduccion.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            Try
                If txtProduccion.Text = "" Then
                    Exit Sub
                End If
                Dim aux = txtProduccion.Text
                txtProduccion.Text = ""
                If controlarExpe(aux) Then

                    Dim prodd As New ProduccionDAO
                    'Dim dv As New DataView(dgvTemplados.DataSource)

                    Dim nrop = 0
                    Dim estadop = ""
                    Dim salida = Nothing
                    Dim estado = ""
                    For Each row As Windows.Forms.DataGridViewRow In dgvProduccionOT.Rows

                        If Convert.ToInt32(row.Cells(1).Value) = CInt(aux) Then
                            nrop = row.Cells(1).Value
                            salida = row.Cells(8).Value
                            estado = row.Cells(10).Value
                            Exit For
                        End If
                    Next
                    'MsgBox(nrop)
                    'MsgBox(estadop)
                    Dim fechaSalida As New Date

                    If nrop <> 0 Then
                        If IsDBNull(salida) Then
                            Exit Sub
                        ElseIf IsNothing(salida) Then
                            Exit Sub
                        End If
                    End If

                    If DateTime.TryParse(salida, fechaSalida) Then
                        If estado = "S" Then
                            MsgBox("Producción ya expedida", MsgBoxStyle.Critical, "Expedición")
                            Exit Sub
                        End If
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
                            row(9) = ""

                            row2.Rows.Add(row)
                            dgvExpediciones.DataSource = row2
                            'dgvProductos.Rows.Add(row)
                            dgvExpediciones.ClearSelection()
                            'daopro.guardarExpedicion(nrop)
                            'cargarExpediciones()
                        End If
                    End If


                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


    Private Function controlarExpe(ByVal id As String) As Boolean
        Try
            For Each row As Windows.Forms.DataGridViewRow In dgvExpediciones.Rows

                If Convert.ToInt32(row.Cells(1).Value) = CInt(id) Then
                    'MsgBox("Produccion ya expedida")
                    Return False
                    Exit For
                End If
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub cargarExpediciones()
        Try
            'Dim daop As New ProduccionDAO
            'Dim r = daop.cargarExped(venta.id)
            'dgvExpediciones.DataSource = r.Tables("tabla")
            'dgvExpediciones.ClearSelection()
            dgvExpediciones.DataSource = New DataSetProduccion.ExpedicionesTableDataTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If dgvExpediciones.Rows.Count > 0 Then
                Me.SuspendLayout()
                Dim daop As New ProduccionDAO
                Dim res = daop.guardarExpedicion2(dgvExpediciones.Rows)
                If res <> 0 Then
                    Dim reporteEx As New InformeReporteExpedicion
                    Dim daoclient As New ClienteDAO
                    Dim cli = daoclient.getCliente(venta.cliente)
                    reporteEx.cliente = cli.nombre
                    reporteEx.nroprod = res
                    Me.ResumeLayout()
                    reporteEx.ShowDialog()
                    Me.Close()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVerExpediciones_Click(sender As Object, e As EventArgs) Handles btnVerExpediciones.Click
        Try
            If venta.id <> 0 Then
                Dim listadoExp As New ListadoExpediciones
                listadoExp.ot = venta.id
                listadoExp.totalPanh = CInt(lblPanhos.Text)
                listadoExp.cliente = lblCliente.Text
                listadoExp.idCliente = venta.cliente
                listadoExp.ShowDialog()
                listadoExp.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvProduccionOT_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProduccionOT.SelectionChanged
        If dgvProduccionOT.Focused And dgvProduccionOT.SelectedRows.Count > 0 Then
            Try
                'btnGuardar.Enabled = False
                'btnModificar.Enabled = True
                Dim row = dgvProduccionOT.CurrentRow.Index
                Dim codigo = dgvProduccionOT.Item(1, row).Value
                Dim daoP As New ProduccionDAO
                Dim produc = daoP.getProduccion(codigo)
                lblAlto.Text = Math.Round(produc.alto, 0)
                lblAncho.Text = Math.Round(produc.ancho, 0)
                lblSupProd.Text = Math.Round(produc.sup, 2)
                'cargarProducto(producto)
                'desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim err As New ExpedicionErroresFrom
        err.otv = venta.id
        err.ShowDialog()
        cargarVenta(venta.id)
        cargarProduccion()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try



            Dim prodd As New ProduccionDAO
                'Dim dv As New DataView(dgvTemplados.DataSource)

                Dim nrop = 0
                Dim estadop = ""
                Dim salida = Nothing
                Dim estado = ""
            For Each row As Windows.Forms.DataGridViewRow In dgvProduccionOT.Rows


                nrop = row.Cells(1).Value
                salida = row.Cells(8).Value
                estado = row.Cells(10).Value
                If controlarExpe(nrop) Then
                    If nrop <> 0 Then
                        If IsDBNull(salida) Then

                        ElseIf IsNothing(salida) Then
                        Else
                            Dim fechaSalida As New Date



                            If DateTime.TryParse(salida, fechaSalida) Then
                                If estado = "S" Then
                                    'MsgBox("Producción ya expedida", MsgBoxStyle.Critical, "Expedición")
                                    'Exit Sub
                                Else
                                    If nrop <> 0 Then

                                        Dim n = dgvExpediciones.Rows.Count
                                        Dim row2 As DataTable = dgvExpediciones.DataSource
                                        Dim rowaux As DataRow = row2.NewRow()
                                        Dim daopro As New ProduccionDAO
                                        Dim producDao As New ProductoDAO
                                        Dim auxprod = daopro.getProduccion(nrop)
                                        Dim producaux = producDao.getProducto(auxprod.codProd)
                                        Dim daousu As New SesionDAO
                                        rowaux(0) = n + 1
                                        rowaux(1) = auxprod.idProd
                                        rowaux(2) = producaux.codigo
                                        rowaux(3) = auxprod.panho
                                        rowaux(4) = auxprod.ancho
                                        rowaux(5) = auxprod.alto
                                        rowaux(6) = auxprod.sup
                                        rowaux(7) = Date.Now
                                        rowaux(8) = daousu.getUsuario
                                        rowaux(9) = ""

                                        row2.Rows.Add(rowaux)
                                        dgvExpediciones.DataSource = row2
                                        'dgvProductos.Rows.Add(row)
                                        dgvExpediciones.ClearSelection()
                                        'daopro.guardarExpedicion(nrop)
                                        'cargarExpediciones()
                                    End If
                                End If

                            End If

                        End If

                    End If
                End If

            Next
            'MsgBox(nrop)
            'MsgBox(estadop)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class