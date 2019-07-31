Imports Backend


Public Class CajaDiariaForm
    Dim cajaActual As New CajaVenta
    Dim ventas As New DataTable
    Dim dt As New DataSet
    Dim uni As Integer
    Dim tipoPago = ""
    Dim estado = ""
    Dim resumen = 0
    Dim anulados = ""
    Private Sub CajaDiariaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dpFehaI.Value = Date.Today
        dpFechaFin.Value = Date.Today
        labelTotalm2.Text = "Total M" & Chr(178) & ""
        labelPromediom2.Text = "Promedio M" & Chr(178) & ""
        uni = 0
        estado = ""
        tipoPago = ""
        anulados = ""
        ventas = New DataSet1.ventasCajaDiaDataTable
        Dim daov As New VentaDAO
        Dim a = dpFehaI.Value
        Dim b = dpFechaFin.Value

        a = New Date(a.Year, a.Month, a.Day, 0, 0, 0)
        b = New Date(b.Year, b.Month, b.Day, 23, 59, 59)

        cajaActual = daov.cajaVenta(a.ToString("yyyy-MM-dd HH:mm:ss"), b.ToString("yyyy-MM-dd HH:mm:ss"), estado, uni, tipoPago)
        cargarResumen()
        cargarVentas()
    End Sub

    Private Sub cargarResumen()
        lblAnuladas.Text = cajaActual.anuladas
        lblContado.Text = cajaActual.contado
        lblCredito.Text = cajaActual.credito
        lblM2.Text = cajaActual.M2
        lblRecargoGS.Text = FormatCurrency(cajaActual.recargoGS, 1)
        lblDescuentoGS.Text = FormatCurrency(cajaActual.descuentoGS, 1)
        lblPromedioGS.Text = FormatCurrency(cajaActual.precioPGS, 1)
        lblTotalGS.Text = FormatCurrency(cajaActual.totalGS, 1)
    End Sub

    Private Sub cargarVentas()
        Try
            Dim daov As New VentaDAO
            Dim tv = ""
            Dim st = ""
            If tipoPago = "S" Then
                tv = "Crédito"
            ElseIf tipoPago = "N" Then
                tv = "Contado"
            Else
                tv = ""
            End If

            If estado = "A" Then
                st = "Anulado"
            ElseIf estado = "C" Then
                st = "Cobrado"
            ElseIf estado = "P" Then
                st = "Pendiente"
            ElseIf estado = "D" Then
                st = "Devuelto"
            Else
                st = ""
            End If
            Dim a = dpFehaI.Value
            Dim b = dpFechaFin.Value
            a = New Date(a.Year, a.Month, a.Day, 0, 0, 0)
            b = New Date(b.Year, b.Month, b.Day, 23, 59, 59)
            dt = daov.getVentasCaja(a.ToString("yyyy-MM-dd HH:mm:ss"), b.ToString("yyyy-MM-dd HH:mm:ss"), st, uni, tv)
            ventas = dt.Tables("tabla")
            dgvVentas.DataSource = ventas
            dgvVentas.ClearSelection()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim daov As New VentaDAO
        Dim a = dpFehaI.Value
        Dim b = dpFechaFin.Value
        a = New Date(a.Year, a.Month, a.Day, 0, 0, 0)
        b = New Date(b.Year, b.Month, b.Day, 23, 59, 59)
        cajaActual = daov.cajaVenta(a.ToString("yyyy-MM-dd HH:mm:ss"), b.ToString("yyyy-MM-dd HH:mm:ss"), estado, uni, tipoPago)
        cargarResumen()
        cargarVentas()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        Dim dv As New DataView(dt.Tables("tabla"))
        dv.RowFilter = String.Format(getQuery())
        dgvVentas.DataSource = dv
        dgvVentas.ClearSelection()

    End Sub

    Private Sub chbAnulados_CheckedChanged(sender As Object, e As EventArgs) Handles chbAnulados.CheckedChanged

        'Dim dv As New DataView(dt.Tables("tabla"))
        'dv.RowFilter = String.Format(getQuery())
        'dgvVentas.DataSource = dv
        'dgvVentas.ClearSelection()
        Dim daov As New VentaDAO
        Dim q = getQuery()
        cajaActual = daov.cajaVenta(dpFehaI.Value.ToString("yyyyMMdd"), dpFechaFin.Value.ToString("yyyyMMdd"), estado, uni, tipoPago)
        cargarResumen()
        cargarVentas()
        dgvVentas.ClearSelection()
    End Sub

    Private Function getQuery() As String
        Dim q = ""

        If rbPorUnidad.Checked Then
            q = "M2 = 0"
            uni = 1
        ElseIf rbPorSuperficie.Checked Then
            q = "M2 > 0"
            uni = 2
        Else
            q = "M2 >= 0"
            uni = 0
        End If



        If rbContado.Checked Then
            q = String.Concat(q, " and Tipo = 'Contado'")
            tipoPago = "N"
        ElseIf rbCredito.Checked Then
            q = String.Concat(q, " and Tipo = 'Crédito'")
            tipoPago = "S"
        ElseIf rbcreditosald.Checked Then
            q = String.Concat(q, " and Tipo = 'Crédito' and Estado = 'Cobrado'")
            tipoPago = "S"
            estado = "C"
        Else
            tipoPago = ""
        End If

        If chbAnulados.Checked Then
            q = String.Concat(q, " and Estado = 'Anulado'")
            estado = "A"
        Else
            estado = ""
        End If
        Return q
    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbAll.CheckedChanged, rbContado.CheckedChanged, rbCredito.CheckedChanged, rbcreditosald.CheckedChanged, rbTodosSupUn.CheckedChanged, rbPorUnidad.CheckedChanged, rbPorSuperficie.CheckedChanged
        'Dim dv As New DataView(dt.Tables("tabla"))
        'dv.RowFilter = String.Format(getQuery())
        'dgvVentas.DataSource = dv
        Dim daov As New VentaDAO
        Dim q = getQuery()
        cajaActual = daov.cajaVenta(dpFehaI.Value.ToString("yyyyMMdd"), dpFechaFin.Value.ToString("yyyyMMdd"), estado, uni, tipoPago)
        cargarResumen()
        cargarVentas()
        dgvVentas.ClearSelection()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDetalleVenta.Click
        If dgvVentas.SelectedRows.Count > 0 Then
            Try

                Dim row = dgvVentas.CurrentRow.Index
                Dim codigo = dgvVentas.Item(0, row).Value
                Dim daoP As New VentaDetalleForm
                daoP.txtOt = codigo
                daoP.ShowDialog()
                daoP.Dispose()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim caj As New CajaDiariaReporteForm
        caj.inicio = dpFehaI.Value
        caj.fin = dpFechaFin.Value
        caj.uni = uni
        caj.estado = estado
        caj.tipov = tipoPago

        caj.ShowDialog()
        caj.Dispose()
    End Sub
End Class