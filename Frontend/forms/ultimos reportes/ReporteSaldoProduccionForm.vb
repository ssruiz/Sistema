Imports Backend

Public Class ReporteSaldoProduccionForm
    Public title = ""
    Public ot = 0
    Private Sub ReporteSaldoProduccionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitulo.Text = title
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        Dim daop As New ProduccionDAO
        Dim dsDetalle = daop.getDetalleSaldoPIndividual(ot)
        Dim dsRes = daop.getResumenSaldoPIndividual(ot)

        Dim rep As New SaldoClientesProduccionIndividual
        rep.Database.Tables(0).SetDataSource(dsDetalle.Tables("tabla"))
        rep.Database.Tables(1).SetDataSource(dsRes.Tables("tabla"))
        rptView.ReportSource = rep
    End Sub
End Class