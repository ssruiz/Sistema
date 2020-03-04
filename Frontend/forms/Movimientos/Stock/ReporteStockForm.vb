Public Class ReporteStockForm
    Private Sub ReporteStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        Dim objreporte As New ReporteStock
        objreporte.SetParameterValue("fecha", Date.Now)


        ReporteVentasView.ReportSource = objreporte

    End Sub
End Class