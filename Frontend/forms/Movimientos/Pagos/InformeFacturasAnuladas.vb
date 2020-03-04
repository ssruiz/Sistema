Imports Backend

Public Class InformeFacturasAnuladas
    Private Sub InformeCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim objreporte As New CRFacturasAn



            Dim dao As New VentaDAO
            Dim ds = dao.getFacturasAnuladas(dpInicio.Value, dpFin.Value)
            objreporte.SetDataSource(ds.Tables("tabla"))
            rptFacturas.ReportSource = objreporte

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class