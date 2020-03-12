Imports Backend

Public Class ReporteSaldoProduccionGenForm
    Public ot = 0
    Public filtroCliente = 0
    Public clienteCod = 0
    Public tipo = 0
    Public title = ""
    Private Sub ReporteSaldoProduccionGenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(tipo)
        MsgBox(filtroCliente)
        MsgBox(clienteCod)
        MsgBox(ot)
        lblTitulo.Text += " - " + title
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        Dim daop As New ProduccionDAO
        Dim dsDetalle = daop.getDetalleSaldoPGeneral()
        Dim dsRes = daop.getResumenSaldoGeneral(ot, filtroCliente, clienteCod, tipo)

        Dim rep As New SaldoClientesProduccionGeneral
        rep.Database.Tables(0).SetDataSource(dsDetalle.Tables("tabla"))
        rep.Database.Tables(1).SetDataSource(dsRes.Tables("tabla"))
        rptView.ReportSource = rep
    End Sub
End Class