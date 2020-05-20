Imports Backend

Public Class MesaCorteInformeForm
    Public mesa = 0
    Private Sub MesaCorteInformeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text += " MESA " + mesa.ToString

        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        btnBuscar.Focus()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim inicio = dpInicio.Value.ToShortDateString
            Dim fin = dpFin.Value.ToShortDateString

            Dim daop As New ProduccionDAO

            Dim dsTerminados = daop.getCortesTerminados(inicio, fin, mesa)
            Dim dsRoturas = daop.getCortesRoturas(inicio, fin, mesa)

            Dim rpt As New MesaDeCorteReporte
            rpt.Subreports("cortesTerminados").SetDataSource(dsTerminados.Tables("tabla"))
            rpt.Subreports("cortesRoturas").SetDataSource(dsRoturas.Tables("tabla"))
            rpt.SetParameterValue("inicio", inicio)
            rpt.SetParameterValue("fin", fin)
            rpt.SetParameterValue("mesa", mesa)

            rptView.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class