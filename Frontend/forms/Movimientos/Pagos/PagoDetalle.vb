Imports Backend

Public Class PagoDetalle
    Public id_pago = ""
    Dim pago As New Pago
    Dim banco As New Banco
    Dim tipo As New TipoPagoM
    Private Sub PagoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPago()
        cargarDetalles()
    End Sub

    Private Sub cargarPago()
        Try
            Dim daop As New PagoDAO
            Dim daob As New BancoDAO
            Dim daot As New TipoPagoDAO
            pago = daop.getPago(id_pago)
            banco = daob.getBanco(pago.banco)
            tipo = daot.getTipo(pago.tpago)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargarDetalles()
        lblNroOrden.Text = pago.venta
        lblFechaPago.Text = pago.fecha
        lblMonto.Text = pago.monto
        lblTipoPago.Text = tipo.desc
        lblRecibo.Text = pago.recibo
        lblBanco.Text = banco.nombre
        lblCheque.Text = pago.chequenro
        lblComent.Text = pago.comentario
        If banco.nombre <> "" Then
            lblchequev.Text = pago.chequevenc
        End If

    End Sub
End Class