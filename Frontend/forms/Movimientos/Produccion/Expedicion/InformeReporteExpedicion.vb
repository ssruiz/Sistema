Imports Backend

Public Class InformeReporteExpedicion
    Public filtro = 0
    Public inicio As Date
    Public fin As Date
    Public nroprod = 0
    Public cliente = ""
    Public totalP = 0
    Private Sub InformeReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rep As New reporteExpedicion
            Dim dao As New SesionDAO
            rep.SetParameterValue("nroExpedicion", nroprod)
            rep.SetParameterValue("usuario", dao.getUsuario)
            rep.SetParameterValue("Cliente", cliente)
            rep.SetParameterValue("Cliente", cliente)
            rep.SetParameterValue("totalP", totalP)

            crvProduc.ReportSource = rep
        Catch ex As Exception

        End Try

    End Sub
End Class