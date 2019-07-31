Imports Backend

Public Class ReporteDeCobrosForm
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim objreporte As New CobrosReporte
            objreporte.SetParameterValue("inicio", dpInicio.Value)
            objreporte.SetParameterValue("fin", dpFin.Value)
            objreporte.SetParameterValue("inicioC", dpInicio.Value)
            objreporte.SetParameterValue("finC", dpFin.Value)
            objreporte.SetParameterValue("inicioA", dpInicio.Value)
            objreporte.SetParameterValue("finA", dpFin.Value)
            Dim daou As New SesionDAO
            objreporte.SetParameterValue("estado", "")
            objreporte.SetParameterValue("unidad", 0)
            objreporte.SetParameterValue("tipov", "")
            objreporte.SetParameterValue("Usuario", daou.getUsuario())

            ReporteVentasView.ReportSource = objreporte

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReporteDeCobrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
    End Sub
End Class