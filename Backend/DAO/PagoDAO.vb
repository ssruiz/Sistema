Imports MySql.Data.MySqlClient

Public Class PagoDAO
    Dim con As New MySqlConnection
    Public Function getPagos(ByVal venta As Integer) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadospagosventa where Venta = " & venta & " order by ID;"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub guardarPago(ByVal pago As Pago)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "INSERT INTO `producir`.`pagos` (`ventCod`, `pagoFecha`, `tpagoCod`, `banCod`, `pagoMonto`, `pagoDescuento`, `pagoRecargo`, `pagoChqNro`, `pagoChqVenc`, `pagoDias`, `pagoSaldo`, `pagoNroRecibo`, `pagoUI`, `pagoFI`, `moneda`) VALUES (@venta, @fecha, @tipo, @banco, @monto, @descuento, @recargo, @cheque, @chequev, @dias, @saldo, @recibo, @user, @fi, @moneda);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@venta", pago.venta)
            cmd.Parameters.AddWithValue("@fecha", pago.fecha)
            cmd.Parameters.AddWithValue("@tipo", pago.tpago)
            If pago.banco = 0 Then
                cmd.Parameters.AddWithValue("@banco", DBNull.Value)
                cmd.Parameters.AddWithValue("@cheque", DBNull.Value)
                cmd.Parameters.AddWithValue("@chequev", DBNull.Value)

            Else
                cmd.Parameters.AddWithValue("@banco", pago.banco)
                cmd.Parameters.AddWithValue("@cheque", pago.chequenro)
                cmd.Parameters.AddWithValue("@chequev", pago.chequevenc)
            End If
            cmd.Parameters.AddWithValue("@monto", pago.monto)
            cmd.Parameters.AddWithValue("@descuento", pago.descuento)
            cmd.Parameters.AddWithValue("@recargo", pago.recargo)

            cmd.Parameters.AddWithValue("@dias", pago.dias)
            cmd.Parameters.AddWithValue("@saldo", pago.saldo)
            cmd.Parameters.AddWithValue("@recibo", pago.recibo)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fi", Date.Now)
            cmd.Parameters.AddWithValue("@moneda", pago.moneda)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getPago(ByVal id As String) As Pago
        Try
            Dim modelo As New Pago
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `pagos` where `pagoCod`  = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.venta = SafeGetInt(reader, 1)
                modelo.fecha = SafeGetDate(reader, 2)
                modelo.tpago = SafeGetInt(reader, 3)
                modelo.banco = SafeGetInt(reader, 4)
                modelo.monto = SafeGetDouble(reader, 5)
                modelo.descuento = SafeGetDouble(reader, 6)
                modelo.recargo = SafeGetDouble(reader, 7)
                modelo.motivo = SafeGetInt(reader, 8)
                modelo.chequenro = SafeGetString(reader, 9)
                modelo.chequevenc = SafeGetDate(reader, 10)
                modelo.dias = SafeGetDate(reader, 11)
                modelo.saldo = SafeGetDouble(reader, 12)
                modelo.recibo = SafeGetString(reader, 13)
                modelo.userIn = SafeGetString(reader, 14)
                modelo.fechaI = SafeGetDate(reader, 15)
                modelo.userUp = SafeGetString(reader, 16)
                modelo.fechaU = SafeGetDate(reader, 17)
                modelo.moneda = safeGetChar(reader, 18)
                modelo.estado = safeGetChar(reader, 19)
                modelo.comentario = SafeGetString(reader, 20)
            End While

            reader.Close()

            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try

    End Function

    Public Sub anularPago(ByVal cod As String, ByVal coment As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `producir`.`pagos` SET `pago_estado` = 'A', `pago_comentario` = @com WHERE `pagoCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.Parameters.AddWithValue("@com", ("Anulado el: " + Date.Today + " . " + coment))

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class
