Imports Backend
Imports MySql.Data.MySqlClient

Public Class VentaDAO
    Dim con As New MySqlConnection()
    Public Function guardarVenta(ByVal venta As Venta, ByVal productos As DataGridViewRowCollection, ByVal sucursal As Sucursal, ByVal deposito As Deposito, ByVal produccionDia As Double) As Integer
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            venta.usuI = Sesion.Usuario
            Dim queryVenta = ""
            queryVenta = "INSERT INTO `ventas` (`opeCod`, `ventCred`, `ventFecha`, `ventFact`, `ventObs`, `clieCod`, `vendCod`, `ventPlazo`, `ventFechaProm`, `ventRecargo`, `ventDescuento`, `ventTotal`, `ventSaldo`, `ventEstado`, `ventMotivo`, `ventEnvio`, `ventDireccEnv`, `ventUI`, `ventFI`, `ventUU`, `ventFU`, `ventM2`,`estadoFactura`,`plano`,`moneda`) VALUES (@op, @cre, @fecha, @fact, @obs, @cliente, @vend, @plazo, @fechap, @recar, @desc, @total, @saldo, @estado, @motivo, @envio, @direnv, @user, @fecha, @user, @fecha, @m2,@estadoFact,@plano, @moneda); SELECT LAST_INSERT_ID();"
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
            cmdVenta.Parameters.AddWithValue("@estadoFact", "N")
            cmdVenta.Parameters.AddWithValue("@plano", "")
            cmdVenta.Parameters.AddWithValue("@moneda", venta.moneda)

            Dim ventaCod = CInt(cmdVenta.ExecuteScalar())

            If venta.credito = "N" Then
                Dim pago As New Pago
                pago.fecha = Date.Today
                pago.fechaI = Date.Today
                pago.moneda = venta.moneda
                pago.monto = venta.total
                pago.userIn = Sesion.Usuario
                pago.recibo = "Factura Contado - " & venta.factura
                pago.tpago = 1
                pago.saldo = 0
                pago.venta = ventaCod
                Dim daop As New PagoDAO
                daop.guardarPago(pago)
            End If

            con.Close()
            con.Open()

            Dim queryDetalle = "INSERT INTO `ventasdet` (`ventCod`, `prodCod`, `ventDetCantidad`, `ventDetAncho`, `ventDetAlto`, `ventDetSup`,  `ventDetPrecioUnit`, `ventDetPrecioReal`,`ventDetObra`,`ventDetRecargo`, `ventDetDescuento`) VALUES ( @venta, @producto, @cantidad, @ancho, @alto, @sup, @pu, @pr, @obra,@recargo,@descuento); SELECT LAST_INSERT_ID();"
            Dim cmdDetalle As New MySqlCommand(queryDetalle, con)
            Dim panho = 1
            For Each row As Windows.Forms.DataGridViewRow In productos
                Dim idProducto = row.Cells(0).Value
                Dim producto = row.Cells(2).Value
                Dim m2 = CDbl(row.Cells(10).Value)
                Dim cantidad = CInt(row.Cells(5).Value)
                Dim precio = CDbl(row.Cells(11).Value)
                Dim total = CDbl(row.Cells(12).Value)
                Dim ancho = CDbl(row.Cells(6).Value)
                Dim alto = CDbl(row.Cells(7).Value)
                Dim sup = CDbl(row.Cells(10).Value)
                Dim obra = row.Cells(13).Value

                cmdDetalle.Parameters.AddWithValue("@venta", ventaCod)
                cmdDetalle.Parameters.AddWithValue("@producto", producto)
                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
                cmdDetalle.Parameters.AddWithValue("@ancho", ancho)
                cmdDetalle.Parameters.AddWithValue("@alto", alto)
                cmdDetalle.Parameters.AddWithValue("@sup", sup)
                cmdDetalle.Parameters.AddWithValue("@pu", precio)
                cmdDetalle.Parameters.AddWithValue("@obra", obra)
                cmdDetalle.Parameters.AddWithValue("@pr", total)

                Dim str As String = row.Cells(8).Value
                str = str.Replace("%", "")
                Dim val = CDbl(str) / 100
                cmdDetalle.Parameters.AddWithValue("@descuento", val)
                str = row.Cells(9).Value
                str = str.Replace("%", "")
                val = CDbl(str) / 100
                cmdDetalle.Parameters.AddWithValue("@recargo", val)
                Dim detalleCod = CInt(cmdDetalle.ExecuteScalar())

                cmdDetalle.Parameters.Clear()

                '' Si la venta no es por superficie
                If venta.m2 = 0 Then
                    Dim queryStock = "INSERT INTO `stock` (`prodCodigo`, `stCantidad`, `opCod`, `stUsrIns`, `stFchIns`, `sucCod`, `depoCod`, `ventaCod` ) VALUES (@producto, @cantidad, @op, @user, @fecha, @sucursal, @deposito, @venta);"
                    Dim cmdStock As New MySqlCommand(queryStock, con)
                    cmdStock.Parameters.AddWithValue("@producto", producto)
                    cmdStock.Parameters.AddWithValue("@cantidad", -cantidad)
                    cmdStock.Parameters.AddWithValue("@op", 1)
                    cmdStock.Parameters.AddWithValue("@user", Sesion.Usuario)
                    cmdStock.Parameters.AddWithValue("@fecha", Date.Today)
                    cmdStock.Parameters.AddWithValue("@sucursal", sucursal.id)
                    cmdStock.Parameters.AddWithValue("@deposito", deposito.id)
                    cmdStock.Parameters.AddWithValue("@venta", ventaCod)
                    cmdStock.ExecuteNonQuery()
                    cmdStock.Parameters.Clear()
                Else
                    Dim queryProducion = "INSERT INTO `producir`.`produccion` (`ventCod`, `ventDetCod`, `pPanho`) VALUES (@vent, @fet, @pan); SELECT LAST_INSERT_ID();"
                    Dim queryCorte = "INSERT INTO `producir`.`corte` (`pCod`, `corteUsuIns`, `corteFchIns`) VALUES (@prod,@usuario,@fecha);"
                    Dim queryPulida = "INSERT INTO `producir`.`pulida` (`pCod`, `puliUsrIns`, `puliFchIns`) VALUES (@prod, @usuario, @fecha);"
                    Dim queryTemplado = "INSERT INTO `producir`.`templado` (`pCod`, `templaUsrIns`, `templaFchIns`) VALUES (@prod, @usuario, @fecha);"

                    Dim cmdProd As New MySqlCommand(queryProducion, con)
                    Dim cmdCorte As New MySqlCommand(queryCorte, con)
                    Dim cmdPulida As New MySqlCommand(queryPulida, con)
                    Dim cmdTemplado As New MySqlCommand(queryTemplado, con)

                    For index As Integer = 1 To cantidad
                        ' Se agrega a produccion
                        cmdProd.Parameters.AddWithValue("@vent", ventaCod)
                        cmdProd.Parameters.AddWithValue("@fet", detalleCod)
                        cmdProd.Parameters.AddWithValue("@pan", panho)
                        panho += 1
                        Dim prodCod = CInt(cmdProd.ExecuteScalar())
                        cmdProd.Parameters.Clear()

                        '' A corte
                        cmdCorte.Parameters.AddWithValue("@prod", prodCod)
                        cmdCorte.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                        cmdCorte.Parameters.AddWithValue("@fecha", Date.Now)
                        cmdCorte.ExecuteNonQuery()
                        cmdCorte.Parameters.Clear()

                        ' A pulida
                        cmdPulida.Parameters.AddWithValue("@prod", prodCod)
                        cmdPulida.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                        cmdPulida.Parameters.AddWithValue("@fecha", Date.Now)
                        cmdPulida.ExecuteNonQuery()
                        cmdPulida.Parameters.Clear()

                        ' A templado
                        cmdTemplado.Parameters.AddWithValue("@prod", prodCod)
                        cmdTemplado.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                        cmdTemplado.Parameters.AddWithValue("@fecha", Date.Now)
                        cmdTemplado.ExecuteNonQuery()
                        cmdTemplado.Parameters.Clear()
                    Next
                End If
            Next


            'If produccionDia > 0 Then
            '    Dim queryProd = "UPDATE `producciondia` SET `prodDiaSup` = `prodDiaSup` + @sup WHERE `prodDiaFecha` = @fecha;"
            '    Dim cmdProd As New MySqlCommand(queryProd, con)
            '    cmdProd.Parameters.AddWithValue("@sup", produccionDia)
            '    cmdProd.Parameters.AddWithValue("@fecha", Date.Today)
            '    cmdProd.ExecuteNonQuery()
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
                modelo.estadoFactura = safeGetChar(reader, 23)
                modelo.plano = SafeGetString(reader, 24)
                modelo.moneda = safeGetChar(reader, 25)
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

    Public Function getVentas() As List(Of Integer)
        Dim listado As New List(Of Integer)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select ventCod from ventas"
            Dim cmd As New MySqlCommand(query, con)
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
            Dim mysql = "UPDATE `ventas` SET `ventFecha` = @fechaV, `ventFact` = @factura, `ventObs` = @obs,  `ventPlazo` = @plazo, `ventFechaProm` = @fechaP, `ventSaldo` = @saldo, `ventEstado` = @estado, `ventEnvio` = @envio, `ventDireccEnv` = @dirEnv, `ventUU` = @user, `ventFU` = @fecha,`clieCod` = @cliente WHERE `ventCod` = @venta;"

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
            cmd.Parameters.AddWithValue("@cliente", venta.cliente)
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub guardarImagen(ByVal ruta As String, ByVal id As String, ByRef img As Image)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "UPDATE `ventas` SET `plano` = @ruta WHERE `ventCod` = @venta;"
            Dim ruta2 = Config.RutaImagenes + ruta

            img.Save(ruta2, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim cmd As New MySqlCommand(mysql, con)

            cmd.Parameters.AddWithValue("@venta", id)
            cmd.Parameters.AddWithValue("@ruta", ruta2)
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub anularVenta(ByVal venta As Venta, ByVal motivo As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `producir`.`ventas` SET `ventEstado` = 'A',`ventObs` = @motivo WHERE `ventCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@cod", venta.id)
            cmd.Parameters.AddWithValue("@motivo", motivo)
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        Finally
            con.Close()
        End Try
    End Sub
End Class
