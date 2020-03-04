Imports Backend

Public Class ListadoExpediciones
    Public ot = 0
    Public cliente = ""
    Public idCliente = 0
    Public totalPanh = 0
    Private Sub ListadoExpediciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim classResize As New ClsResizeForm
        classResize.ResizeForm(Me, 1255, 815)
        Me.WindowState = FormWindowState.Maximized
        Me.Show()

        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        cargarExpediciones(ot)
        lblOt.Text = ot
        lblCliente.Text = cliente
    End Sub

    Private Sub cargarExpediciones(ot)
        Try
            Dim daop As New ProduccionDAO
            Dim r = daop.getExpediciones(ot)
            dgvExpediciones.DataSource = r.Tables("tabla")
            dgvExpediciones.ClearSelection()
            dgvExpediciones.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvExpediciones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvExpediciones.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvVentasPorFecha_SelectionChanged(sender As Object, e As EventArgs) Handles dgvExpediciones.SelectionChanged
        If dgvExpediciones.Focused And dgvExpediciones.SelectedRows.Count > 0 Then
            Try

                Dim row = dgvExpediciones.CurrentRow
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
        If dgvExpediciones.SelectedRows.Count > 0 Then
            Try

                Dim row = dgvExpediciones.CurrentRow
                Dim codigo = row.Cells(1).Value

                Dim reporteEx As New InformeReporteExpedicion
                Dim daoclient As New ClienteDAO
                Dim cli = daoclient.getCliente(idCliente)
                reporteEx.cliente = cli.nombre
                reporteEx.nroprod = codigo
                reporteEx.totalP = totalPanh
                reporteEx.ShowDialog()
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class