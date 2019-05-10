Public Class ReporteCompra
    Private Sub InformeCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim objreporte As New ReportCompras
            objreporte.SetParameterValue("fecha1", dpInicio.Value)
            objreporte.SetParameterValue("fecha2", dpFin.Value)
            ReporteCompraView.ReportSource = objreporte

        Catch ex As Exception

        End Try
    End Sub
End Class