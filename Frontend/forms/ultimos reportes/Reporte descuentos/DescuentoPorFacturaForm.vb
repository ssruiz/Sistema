Imports Backend

Public Class DescuentoPorFacturaForm
    Private Sub DescuentoPorFacturaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim daoc As New VentaDAO
            Dim daou As New SesionDAO
            Dim inicio = dpInicio.Value.ToShortDateString
            Dim fin = dpFin.Value.ToShortDateString

            Dim data = daoc.getFacturasDescuentos(inicio, fin)

            Dim objreporte As New RptDescuentoPorFactura



            ' objreporte.SetParameterValue("inicioanu", dpInicio.Value)
            'objreporte.SetParameterValue("finanu", dpFin.Value)
            objreporte.SetDataSource(data.Tables("tabla"))
            objreporte.SetParameterValue("inicio", inicio)
            objreporte.SetParameterValue("fin", fin)

            objreporte.SetParameterValue("Usuario", daou.getUsuario())
            'objreporte.SetDatabaseLogon("samuel", "system", "localhost", "producir")


            'objreporte.Subreports("HeaderRpt.rpt").SetDataSource(HeaderDT)
            rptvCobros.ReportSource = objreporte

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class