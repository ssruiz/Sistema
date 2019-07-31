Public Class CajaDiariaReporteForm
    Public fin, inicio As String
    Public uni As Integer
    Public estado As String
    Public tipov As String
    Private Sub CajaDiariaReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objreporte As New CajaDiariarpt

            objreporte.SetParameterValue("fecha1", inicio)
            objreporte.SetParameterValue("fecha2", fin)
            objreporte.SetParameterValue("inicio", inicio)
            objreporte.SetParameterValue("fin", fin)
            objreporte.SetParameterValue("unidad", uni)
            objreporte.SetParameterValue("estado", estado)
            objreporte.SetParameterValue("tipov", tipov)
            objreporte.SetParameterValue("unidadv", uni)
            objreporte.SetParameterValue("estadov", estado)
            objreporte.SetParameterValue("tipovv", tipov)
            CrystalReportViewer1.ReportSource = objreporte

        Catch ex As Exception

        End Try
    End Sub
End Class