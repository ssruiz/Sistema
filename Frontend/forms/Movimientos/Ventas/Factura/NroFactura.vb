Imports Backend

Public Class NroFactura
    Public venta As New Venta
    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If validarFactura() Then
                venta.factura = txtFiltro.Text
                Dim daoV As New VentaDAO
                daoV.actualizarVenta(venta, Nothing)
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Function validarFactura() As Boolean
        If txtFiltro.Text = "" Then
            MsgBox("Ingrese un número de factura", MsgBoxStyle.Critical, "Notificación")
            txtFiltro.Focus()
            Return False

        End If
        Return True
    End Function

    Private Sub NroFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class