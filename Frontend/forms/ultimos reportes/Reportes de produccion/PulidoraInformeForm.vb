Imports Backend

Public Class PulidoraInformeForm
    Public pulidora = 0
    Private Sub PulidoraInformeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text += pulidora.ToString

        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        btnBuscar.Focus()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim inicio = dpInicio.Value.ToShortDateString
            Dim fin = dpFin.Value.ToShortDateString

            Dim daop As New ProduccionDAO

            Dim dsTerminados = daop.getPulidasTerminadas(inicio, fin, pulidora)
            Dim dsRoturas = daop.getPulidasRoturas(inicio, fin, pulidora)

            Dim rpt As New PulidasReporte
            rpt.Subreports("pulidasTerminadas").SetDataSource(dsTerminados.Tables("tabla"))
            rpt.Subreports("pulidasRoturas").SetDataSource(dsRoturas.Tables("tabla"))
            rpt.SetParameterValue("inicio", inicio)
            rpt.SetParameterValue("fin", fin)
            rpt.SetParameterValue("pulidora", pulidora)

            rptView.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class