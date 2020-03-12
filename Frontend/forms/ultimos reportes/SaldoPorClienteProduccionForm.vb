Imports Backend

Public Class SaldoPorClienteProduccionForm
    Dim cliente As New Cliente
    Dim busqueda = 0
    Dim busquedaTipoCliente = 0
    Dim otBusqueda = 0
    Dim clienteCod = 0
    Dim title = ""
    Private Sub SaldoPorClienteProduccionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim classResize As New ClsResizeForm
        'classResize.ResizeForm(Me, 1389, 765)
        'Me.WindowState = FormWindowState.Maximized
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        cbTipoCliente.SelectedIndex = 0
    End Sub

    Private Sub txtOT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                Dim buscarC As New ClienteBusqueda
                Dim res = buscarC.ShowDialog()
                If res = DialogResult.OK Then
                    cliente = buscarC.cliente
                    Dim daop As New ProduccionDAO
                    Dim ds = daop.getSaldoClienteProduccion(3, cliente.id, 0)
                    dgvOTS.DataSource = ds.Tables("tabla")
                    dgvOTS.ClearSelection()
                    busqueda = 2
                    title = "CLIENTE: " + cliente.nombre
                    clienteCod = cliente.id
                End If
            Catch ex As Exception

            End Try


        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim daop As New ProduccionDAO
            busqueda = 1
            Select Case cbTipoCliente.SelectedIndex
                Case 0
                    busquedaTipoCliente = 2
                    title = "CLIENTES INTERNOS"
                Case 1
                    busquedaTipoCliente = 1
                    title = "CLIENTES NORMALES"
                Case 3
                    busquedaTipoCliente = 1
                    title = "TODOS LOS CLIENTES"
            End Select



            Dim ds = daop.getSaldoClienteProduccion(cbTipoCliente.SelectedIndex, 0, 0)
            dgvOTS.DataSource = ds.Tables("tabla")
            dgvOTS.ClearSelection()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOT.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True


            If txtOT.Text <> "" Then

                Dim daop As New ProduccionDAO
                Dim ds = daop.getSaldoClienteProduccion(4, 0, txtOT.Text)
                dgvOTS.DataSource = ds.Tables("tabla")
                dgvOTS.ClearSelection()
                busqueda = 3
                otBusqueda = txtOT.Text
                title = "OT NRO: " + txtOT.Text
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReporteGral.Click
        Try
            If dgvOTS.Rows.Count > 0 Then


                Dim pdao As New ProduccionDAO
                Dim rep As New ReporteSaldoProduccionGenForm
                rep.tipo = busqueda

                rep.ot = otBusqueda
                rep.title = title

                rep.filtroCliente = busquedaTipoCliente
                rep.clienteCod = clienteCod
                rep.ShowDialog()
                rep.Dispose()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnReporteIndividual_Click(sender As Object, e As EventArgs) Handles btnReporteIndividual.Click
        Try
            If dgvOTS.SelectedRows.Count > 0 Then
                For Each row As DataGridViewRow In dgvOTS.SelectedRows
                    Dim ot = row.Cells(2).Value
                    Dim pdao As New ProduccionDAO
                    Dim rep As New ReporteSaldoProduccionForm
                    rep.title = "Reporte Individual"
                    rep.ot = ot
                    rep.ShowDialog()
                    rep.Dispose()

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class