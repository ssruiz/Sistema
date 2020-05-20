Imports System.IO
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
            cmdVenta.Parameters.AddWithValue("@fecha", Date.Now)
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

            'If venta.credito = "N" Then
            '    Dim pago As New Pago
            '    pago.fecha = Date.Today
            '    pago.fechaI = Date.Today
            '    pago.moneda = venta.moneda
            '    pago.monto = venta.total
            '    pago.userIn = Sesion.Usuario
            '    pago.recibo = "Factura Contado - " & venta.factura
            '    pago.tpago = 1
            '    pago.saldo = 0
            '    pago.venta = ventaCod
            '    Dim daop As New PagoDAO
            '    daop.guardarPago(pago)
            'End If

            con.Close()
            con.Open()

            Dim queryDetalle = "INSERT INTO `ventasdet` (`ventCod`, `prodCod`, `ventDetCantidad`, `ventDetAncho`, `ventDetAlto`, `ventDetSup`,  `ventDetPrecioUnit`, `ventDetPrecioReal`,`ventDetObra`,`ventDetRecargo`, `ventDetDescuento`) VALUES ( @venta, @producto, @cantidad, @ancho, @alto, @sup, @pu, @pr, @obra,@recargo,@descuento); SELECT LAST_INSERT_ID();"
            Dim cmdDetalle As New MySqlCommand(queryDetalle, con)
            Dim panho = 1
            Dim list As New Dictionary(Of String, Integer)
            For Each row As Windows.Forms.DataGridViewRow In productos
                panho = 1
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
                'MsgBox(idProducto)
                If list.Count = 0 Then
                    list.Add(producto, 1)
                Else
                    Dim value As Integer
                    If (list.TryGetValue(producto, value)) Then
                        'list(idProducto) = value + 1
                        'MsgBox(value)
                    Else
                        list.Add(producto, 1)
                    End If
                End If
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
                Dim val = CDbl(str)
                cmdDetalle.Parameters.AddWithValue("@descuento", val)
                str = row.Cells(9).Value
                str = str.Replace("%", "")
                val = CDbl(str)
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

                    'Dim queryProducion = "INSERT INTO `producir`.`produccion` (`ventCod`, `ventDetCod`, `pPanho`, `produccion_detalle`) VALUES (@vent, @fet, @pan, @pdetalle); SELECT LAST_INSERT_ID();"
                    'Dim queryCorte = "INSERT INTO `producir`.`corte` (`pCod`, `corteUsuIns`, `corteFchIns`) VALUES (@prod,@usuario,@fecha);"
                    'Dim queryPulida = "INSERT INTO `producir`.`pulida` (`pCod`, `puliUsrIns`, `puliFchIns`) VALUES (@prod, @usuario, @fecha);"
                    'Dim queryTemplado = "INSERT INTO `producir`.`templado` (`pCod`, `templaUsrIns`, `templaFchIns`) VALUES (@prod, @usuario, @fecha);"
                    'Dim queryMarcado = "INSERT INTO `producir`.`marcado` (`pCod`, `marcadoUsrIns`, `marcadoFchIns`) VALUES (@prod,@usuario,@fecha);"


                    'Dim queryDetalleProduccion = "INSERT INTO `producir`.`producciondetalle` (`prod_id`) VALUES (@producto); SELECT LAST_INSERT_ID();"
                    'Dim cmdDetalleProduccion As New MySqlCommand(queryDetalleProduccion, con)


                    'cmdDetalleProduccion.Parameters.AddWithValue("@producto", producto)
                    'Dim detalleProduccionCod = CInt(cmdDetalleProduccion.ExecuteScalar())

                    'cmdDetalleProduccion.Parameters.Clear()



                    'Dim cmdProd As New MySqlCommand(queryProducion, con)
                    'Dim cmdCorte As New MySqlCommand(queryCorte, con)
                    'Dim cmdPulida As New MySqlCommand(queryPulida, con)
                    'Dim cmdTemplado As New MySqlCommand(queryTemplado, con)
                    'Dim cmdMarcado As New MySqlCommand(queryMarcado, con)
                    'For index As Integer = 1 To cantidad
                    '    ' Se agrega a produccion
                    '    Dim panhaux As New Integer

                    '    list.TryGetValue(producto, panhaux)
                    '    ' MsgBox(panhaux)

                    '    cmdProd.Parameters.AddWithValue("@vent", ventaCod)
                    '    cmdProd.Parameters.AddWithValue("@fet", detalleCod)
                    '    cmdProd.Parameters.AddWithValue("@pan", panhaux)
                    '    cmdProd.Parameters.AddWithValue("@pdetalle", detalleProduccionCod)
                    '    panho += 1
                    '    Dim prodCod = CInt(cmdProd.ExecuteScalar())
                    '    cmdProd.Parameters.Clear()
                    '    list(producto) = panhaux + 1
                    '    '' A corte
                    '    cmdCorte.Parameters.AddWithValue("@prod", prodCod)
                    '    cmdCorte.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                    '    cmdCorte.Parameters.AddWithValue("@fecha", Date.Now)
                    '    cmdCorte.ExecuteNonQuery()
                    '    cmdCorte.Parameters.Clear()

                    '    ' A pulida
                    '    cmdPulida.Parameters.AddWithValue("@prod", prodCod)
                    '    cmdPulida.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                    '    cmdPulida.Parameters.AddWithValue("@fecha", Date.Now)
                    '    cmdPulida.ExecuteNonQuery()
                    '    cmdPulida.Parameters.Clear()

                    '    ' A templado
                    '    cmdTemplado.Parameters.AddWithValue("@prod", prodCod)
                    '    cmdTemplado.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                    '    cmdTemplado.Parameters.AddWithValue("@fecha", Date.Now)
                    '    cmdTemplado.ExecuteNonQuery()
                    '    cmdTemplado.Parameters.Clear()

                    '    ' A marcado
                    '    cmdMarcado.Parameters.AddWithValue("@prod", prodCod)
                    '    cmdMarcado.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                    '    cmdMarcado.Parameters.AddWithValue("@fecha", Date.Now)
                    '    cmdMarcado.ExecuteNonQuery()
                    '    cmdMarcado.Parameters.Clear()
                    'Next
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

    Public Function getFacturasDescuentos(inicio As Date, fin As Date) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "CALL spfacturasdescuentos(@inicio,@fin);"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@inicio", inicio)
            cmd.Parameters.AddWithValue("@fin", fin)

            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
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
            reader.Close()
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
            reader.Close()
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
            Dim query = "Select ventCod from ventas where `ventEstado` <> 'A' "
            Dim cmd As New MySqlCommand(query, con)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                listado.Add(SafeGetInt(reader, 0))
            End While
            reader.Close()
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
            Dim mysql = "UPDATE `ventas` SET  `ventFact` = @factura, `ventUU` = @user, `ventFU` = @fecha WHERE `ventCod` = @venta;"

            Dim cmd As New MySqlCommand(mysql, con)

            cmd.Parameters.AddWithValue("@factura", venta.factura)
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

    Public Sub guardarPlanos(ByVal id As String, ByRef planos As DataTable)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "INSERT INTO `planos` (`nombre_plano`, `fecha`, `id_venta`) VALUES (@ruta, @fecha, @venta);"
            Dim cmd As New MySqlCommand(mysql, con)

            Dim ruta2 = ""

            Dim i = 1
            Dim pathImg = Path.Combine(Config.RutaImagenes, id.ToString)
            'MsgBox(pathImg)
            If (Not System.IO.Directory.Exists(pathImg)) Then
                System.IO.Directory.CreateDirectory(pathImg)
            End If

            For Each row As DataRow In planos.Rows
                ruta2 = Path.Combine(pathImg, id.ToString & "_pl_" & i & ".jpg")
                'ruta2 = pathImg & "ot_" & id & "_pl_" & i & ".jpg"
                Dim dirImg = row("Nombre")
                My.Computer.Network.UploadFile(dirImg, ruta2)

                'Dim newImage As Image = Image.FromFile(dirImg)
                'newImage.Save(ruta2, System.Drawing.Imaging.ImageFormat.Jpeg)
                i += 1

                cmd.Parameters.AddWithValue("@venta", id)
                cmd.Parameters.AddWithValue("@ruta", ruta2)
                cmd.Parameters.AddWithValue("@fecha", Date.Today)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            Next
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
            Dim query = "UPDATE `producir`.`ventas` SET `ventEstado` = 'A',`ventObs` = @motivo, `ventFU` = @fecha, ventUU = @usu WHERE `ventCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@cod", venta.id)
            cmd.Parameters.AddWithValue("@motivo", motivo)
            cmd.Parameters.AddWithValue("@fecha", Date.Today)
            cmd.Parameters.AddWithValue("@usu", Sesion.Codigo)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function cargarPlanos(ByVal venta As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `vplanosventa` WHERE `Venta` =" & venta & ";"

            Dim adp As New MySqlDataAdapter(query, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function cargarPlanos2(ByVal venta As String) As List(Of Image)
        Dim ds As New DataSet
        Dim planos As New List(Of Image)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `vplanosventa` WHERE `Venta` =" & venta & ";"
            Dim cmd As New MySqlCommand(query, con)
            Dim adp As New MySqlDataAdapter(query, con)
            Dim reader = cmd.ExecuteReader()
            While reader.Read
                planos.Add(Image.FromFile(SafeGetString(reader, 1)))

            End While


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return planos
    End Function

    Public Function cargarEtiquetas(ByVal venta As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `vetiquetas` WHERE `Venta` =" & venta & " and Impreso = 'No' order by Panho, Prod;"

            Dim adp As New MySqlDataAdapter(query, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function cargarEtiquetas2(ByVal venta As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `vetiquetas` WHERE `Venta` =" & venta & " order by Panho, Prod;"

            Dim adp As New MySqlDataAdapter(query, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub actualizarProduccion(ByVal venta As String, ByVal ini As String, ByVal fin As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `producir`.`produccion` SET `produccion_ticket` = 'S' WHERE `pCod` between @ini and @fin;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ini", ini)
            cmd.Parameters.AddWithValue("@fin", fin)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function cajaVenta(ByVal inicio As String, ByVal fin As String, ByVal estado As String, ByVal unidad As Integer, ByVal tipov As String) As CajaVenta
        Dim res As New CajaVenta
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()



            Dim query = "Call pcajaresumen('" & inicio & "','" & fin & "','" & estado.ToCharArray & "'," & unidad & ",'" & tipov.ToCharArray & "')"
            Dim cmdVenta As New MySqlCommand(query, con)

            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read

                res.M2 = SafeGetDouble(reader, 0)
                res.anuladas = SafeGetInt(reader, 1)
                res.credito = SafeGetInt(reader, 2)

                res.contado = SafeGetInt(reader, 3)
                res.recargoGS = SafeGetDouble(reader, 4)
                res.descuentoGS = SafeGetDouble(reader, 5)
                res.totalGS = SafeGetDouble(reader, 6)
                res.precioPGS = SafeGetDouble(reader, 7)
            End While
            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return res
    End Function

    Public Function getVentasCaja(ByVal ini As String, ByVal fin As String, ByVal estado As String, ByVal unidad As Integer, ByVal tipov As String) As DataSet
        Dim ds As New DataSet

        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = ""

            If unidad = 0 Then
                query = "Select * from vventascaja WHERE `Fecha` between @ini and @fin and (Estado = @estado OR @estado = '') and (Tipo = @tipo OR @tipo = '');"
            ElseIf unidad = 1 Then
                query = "Select * from vventascaja WHERE `Fecha` between @ini and @fin and (Estado = @estado OR @estado = '') and (Tipo = @tipo OR @tipo = '') and M2 = 0;"
            Else
                query = "Select * from vventascaja WHERE `Fecha` between @ini and @fin and (Estado = @estado OR @estado = '') and (Tipo = @tipo OR @tipo = '') and M2 > 0;"
            End If

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ini", ini)
            cmd.Parameters.AddWithValue("@fin", fin)
            cmd.Parameters.AddWithValue("@estado", estado)
            cmd.Parameters.AddWithValue("@tipo", tipov)

            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub actualizarVentaFactura(ByVal venta As Venta)
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `producir`.`ventas` SET `ventFact` = @fact, `estadoFactura` = 'S' WHERE `ventCod` = @cod"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fact", venta.factura)
            cmd.Parameters.AddWithValue("@cod", venta.id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub


    Public Function getVentasCaja2() As DataSet
        Dim ds As New DataSet

        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM `vventascaja`"



            Dim adp As New MySqlDataAdapter(query, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getFacturaVenta(ByVal id As String) As DataSet
        Dim ds As New DataSet

        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "CALL `facturadetalle`(" & id & ")"



            Dim adp As New MySqlDataAdapter(query, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function


    '' busqueda de ventas

    '' POR FECHA

    Public Function getVentasFecha(ini As Date, fin As Date) As DataSet
        Dim ds As New DataSet

        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * from vbusquedadeventas where Fecha between @f1 and @f2"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@f1", ini)
            cmd.Parameters.AddWithValue("@f2", fin)

            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getDetalleBusquedaVentas(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vdetalleproductosbusquedav where Venta = " & id & ";"
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

    '' BUSQUEDA POR CLIENTE

    Public Function getVentasCliente(ByVal id As Integer) As DataSet
        Dim ds As New DataSet

        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * from vbusquedadeventas where IDCli = @cli ORDER BY ID DESC"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cli", id)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function


    Public Sub anularFactura(id As Integer, factura As String, ByVal motivo As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `ventas` SET `ventFact` = @fact, `estadoFactura` = 'N' WHERE `ventCod` = @id;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@fact", "")


            cmd.ExecuteNonQuery()
            Dim query2 = "INSERT INTO `producir`.`anulaciones` (`ventaCod`, `motivo`, `fechaI`, `usuarioIns`,`facturaNro`) VALUES (@venta, @motivo, @fecha, @usu,@factu);"
            Dim cmd2 As New MySqlCommand(query2, con)
            cmd2.Parameters.AddWithValue("@venta", id)
            cmd2.Parameters.AddWithValue("@motivo", motivo)
            cmd2.Parameters.AddWithValue("@fecha", Date.Now)
            cmd2.Parameters.AddWithValue("@usu", Sesion.Usuario)
            cmd2.Parameters.AddWithValue("@factu", factura)
            cmd2.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try


    End Sub


    Public Function cargarAnulacionesFactura(ByVal id As Integer) As DataSet
        Dim ds As New DataSet

        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * from vlistadoanulacionesfact where OT = @cli"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cli", id)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getIngresador(ByVal id As String) As String
        Dim r = ""
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()



            Dim query = "SELECT `usuNombre` FROM `producir`.`usuario` where `usuCod` = @id"
            Dim cmdVenta As New MySqlCommand(query, con)
            cmdVenta.Parameters.AddWithValue("@id", id)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read

                r = SafeGetString(reader, 0)
            End While
            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return r
    End Function

    Public Function getFacturasAnuladas(ByVal inicio As Date, ByVal fin As Date) As DataSet
        Dim ds As New DataSet

        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT a.`id_an` AS ID, a.`motivo` AS Motivo, DATE_FORMAT(a.`fechaI`, '%Y-%m-%d') AS Fecha, c.`clieNombre` AS Cliente, a.`facturaNro` AS Factura FROm `anulaciones` a INNER JOIN `ventas` v ON v.`ventCod` = a.`ventaCod` INNER JOIN `clientes` c ON c.`clieCod` = v.`clieCod` WHERE DATE_FORMAT(a.`fechaI`, '%Y-%m-%d') BETWEEN DATE_FORMAT(@in, '%Y-%m-%d') AND DATE_FORMAT(@fin, '%Y-%m-%d') ORDER BY c.`clieNombre`;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@in", inicio)
            cmd.Parameters.AddWithValue("@fin", fin)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

End Class
