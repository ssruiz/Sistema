Imports Backend

Public Class CambioForm
    Private Sub txtFactuNro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCambio.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As Integer = MessageBox.Show("¿Guardar venta?", "Guardar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            guardarCambio()
        End If
    End Sub

    Private Sub guardarCambio()
        Try
            If txtCambio.Text <> "" Then
                Dim daom As New CambioDAO
                Dim m = CDbl(txtCambio.Text)
                If m > 0 Then
                    daom.guardarCambio(CDbl(txtCambio.Text))
                    MsgBox("Cambio guardado", MsgBoxStyle.Information, "Notificación")
                    txtCambio.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFactuNro_TextChanged(sender As Object, e As EventArgs) Handles txtCambio.TextChanged
        If sender.Text <> "" Then
            sender.Text = FormatCurrency(sender.Text, 1)
            sender.Select(sender.TextLength - 2, 0)
        Else
            sender.Text = FormatCurrency(0, 1)
            sender.Select(sender.TextLength - 2, 0)
        End If
    End Sub

    Private Sub CambioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCambio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCambio.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            guardarCambio()
        End If
    End Sub
End Class