Imports Backend

Public Class ReporteCobrosPorProducto
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim objreporte As New CRCobrosTipoProducto
            objreporte.SetParameterValue("fecha1", dpInicio.Value)
            objreporte.SetParameterValue("fecha2", dpFin.Value)

            Dim daou As New SesionDAO

            objreporte.SetParameterValue("usuario", daou.getUsuario())

            ReporteVentasView.ReportSource = objreporte

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReporteVentasPorProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
    End Sub
End Class