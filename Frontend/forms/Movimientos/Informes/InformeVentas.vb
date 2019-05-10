Public Class InformeVentas
    Private Sub InformeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim objreporte As New ReporteVentas
            objreporte.SetParameterValue("fecha1", dpInicio.Value)
            objreporte.SetParameterValue("fecha2", dpFin.Value)
            ReporteVentasView.ReportSource = objreporte

        Catch ex As Exception

        End Try
    End Sub
End Class