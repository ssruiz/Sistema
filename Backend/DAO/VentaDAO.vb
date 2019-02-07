Imports Backend
Imports MySql.Data.MySqlClient

Public Class VentaDAO
    Dim con As New MySqlConnection()
    Public Function guardarVenta(venta As Venta, productos As DataGridViewRowCollection) As Integer
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            venta.usuI = Sesion.Usuario
            Dim queryVenta = ""
            queryVenta = "INSERT INTO `ventas` (`opeCod`, `ventCred`, `ventFecha`, `ventFact`, `ventObs`, `clieCod`, `vendCod`, `ventPlazo`, `ventFechaProm`, `ventRecargo`, `ventDescuento`, `ventTotal`, `ventSaldo`, `ventEstado`, `ventMotivo`, `ventEnvio`, `ventDireccEnv`, `ventUI`, `ventFI`, `ventUU`, `ventFU`, `ventM2`) VALUES (@op, @cre, @fecha, @fact, @obs, @cliente, @vend, @plazo, @fechap, @recar, @desc, @total, @saldo, @estado, @motivo, @envio, @direnv, @user, @fecha, @user, @fecha, @m2); SELECT LAST_INSERT_ID();"
            Dim cmdVenta As New MySqlCommand(queryVenta, con)


            cmdVenta.Parameters.AddWithValue("@fact", venta.factura)
            cmdVenta.Parameters.AddWithValue("@fecha", venta.fecha)
            cmdVenta.Parameters.AddWithValue("@op", 1)
            cmdVenta.Parameters.AddWithValue("@cre", venta.credito)
            cmdVenta.Parameters.AddWithValue("@obs", venta.obs)
            cmdVenta.Parameters.AddWithValue("@cliente", venta.cliente)
            cmdVenta.Parameters.AddWithValue("@vend", venta.vendedor)
            cmdVenta.Parameters.AddWithValue("@plazo", venta.plazo)
            cmdVenta.Parameters.AddWithValue("@fechap", venta.fechaP)
            cmdVenta.Parameters.AddWithValue("@recar", venta.recargo)
            cmdVenta.Parameters.AddWithValue("@desc", venta.descuento)
            cmdVenta.Parameters.AddWithValue("@total", venta.total)
            cmdVenta.Parameters.AddWithValue("@saldo", venta.saldo)
            cmdVenta.Parameters.AddWithValue("@estado", venta.estado)
            cmdVenta.Parameters.AddWithValue("@motivo", venta.motivo)
            cmdVenta.Parameters.AddWithValue("@envio", venta.envio)
            cmdVenta.Parameters.AddWithValue("@direnv", venta.direEnv)
            cmdVenta.Parameters.AddWithValue("@user", Sesion.Codigo)
            cmdVenta.Parameters.AddWithValue("@m2", venta.m2)

            Dim ventaCod = CInt(cmdVenta.ExecuteScalar())


            con.Close()
            con.Open()

            Dim queryDetalle = "INSERT INTO `ventasdet` (`ventCod`, `prodCod`, `ventDetCantidad`, `ventDetAncho`, `ventDetAlto`, `ventDetSup`,  `ventDetPrecioUnit`, `ventDetPrecioReal`,`ventDetObra`) VALUES ( @venta, @producto, @cantidad, @ancho, @alto, @sup, @pu, @pr, @obra);"
            Dim cmdDetalle As New MySqlCommand(queryDetalle, con)
            For Each row As Windows.Forms.DataGridViewRow In productos
                Dim producto = row.Cells(2).Value
                Dim m2 = CDbl(row.Cells(8).Value)
                Dim cantidad = CInt(row.Cells(5).Value)
                Dim precio = CDbl(row.Cells(9).Value)
                Dim precioR = CDbl(row.Cells(10).Value)
                Dim ancho = CDbl(row.Cells(6).Value)
                Dim alto = CDbl(row.Cells(7).Value)
                Dim sup = CDbl(row.Cells(8).Value)
                Dim obra = row.Cells(11).Value

                cmdDetalle.Parameters.AddWithValue("@venta", ventaCod)
                cmdDetalle.Parameters.AddWithValue("@producto", producto)
                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
                cmdDetalle.Parameters.AddWithValue("@ancho", ancho)
                cmdDetalle.Parameters.AddWithValue("@alto", alto)
                cmdDetalle.Parameters.AddWithValue("@sup", sup)
                cmdDetalle.Parameters.AddWithValue("@pu", precio)

                cmdDetalle.Parameters.AddWithValue("@obra", obra)
                cmdDetalle.Parameters.AddWithValue("@pr", precioR)


                cmdDetalle.ExecuteNonQuery()
                cmdDetalle.Parameters.Clear()
            Next



            'If venta.tipo = "Contado" Then
            '    actualizarCaja(venta.total)
            'End If



            Return ventaCod
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function getVenta(ByVal id As String) As Venta
        Try
            Dim modelo As New Venta

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from ventas where ventCod = @venta"
            Dim cmdVenta As New MySqlCommand(query, con)
            cmdVenta.Parameters.AddWithValue("@venta", id)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.operacion = SafeGetInt(reader, 1)
                modelo.credito = safeGetChar(reader, 2)
                modelo.fecha = SafeGetDate(reader, 3)
                modelo.factura = SafeGetString(reader, 4)
                modelo.obs = SafeGetString(reader, 5)
                modelo.cliente = SafeGetInt(reader, 6)
                modelo.vendedor = SafeGetInt(reader, 7)
                modelo.plazo = SafeGetInt(reader, 8)
                modelo.fechaP = SafeGetDate(reader, 9)
                modelo.recargo = SafeGetDecimal(reader, 10)
                modelo.descuento = SafeGetDecimal(reader, 11)
                modelo.total = SafeGetDouble(reader, 12)
                modelo.saldo = SafeGetDouble(reader, 13)
                modelo.estado = safeGetChar(reader, 14)
                modelo.motivo = SafeGetString(reader, 15)
                modelo.envio = safeGetChar(reader, 16)
                modelo.direEnv = SafeGetString(reader, 17)
                modelo.usuI = SafeGetInt(reader, 18)
                modelo.fechaI = SafeGetDate(reader, 19)
                modelo.usuU = SafeGetInt(reader, 20)
                modelo.fechaU = SafeGetDate(reader, 21)
                modelo.m2 = SafeGetDecimal(reader, 22)
            End While
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function listadoVentas(ByVal id As String) As List(Of Integer)
        Dim listado As New List(Of Integer)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select ventCod from ventas where clieCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                listado.Add(SafeGetInt(reader, 0))
            End While
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return listado
    End Function

    Public Function getDetalle(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vdetalleventa where Venta = " & id & ";"
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

    Public Function ventasCliente(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadoventascliente where ClienteCod = " & id & ";"
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

    Public Sub actualizarVenta(ByVal venta As Venta, productos As DataGridViewRowCollection)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "UPDATE `ventas` SET `ventFecha` = @fechaV, `ventFact` = @factura, `ventObs` = @obs,  `ventPlazo` = @plazo, `ventFechaProm` = @fechaP, `ventSaldo` = @saldo, `ventEstado` = @estado, `ventEnvio` = @envio, `ventDireccEnv` = @dirEnv, `ventUU` = @user, `ventFU` = @fecha WHERE `ventCod` = @venta;"

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fechaV", venta.fecha)
            cmd.Parameters.AddWithValue("@factura", venta.factura)
            cmd.Parameters.AddWithValue("@obs", venta.obs)
            cmd.Parameters.AddWithValue("@plazo", venta.plazo)
            cmd.Parameters.AddWithValue("@fechaP", venta.fechaP)
            cmd.Parameters.AddWithValue("@saldo", venta.saldo)
            cmd.Parameters.AddWithValue("@estado", venta.estado)
            cmd.Parameters.AddWithValue("@envio", venta.envio)
            cmd.Parameters.AddWithValue("@dirEnv", venta.direEnv)
            cmd.Parameters.AddWithValue("@user", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@venta", venta.id)
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class
