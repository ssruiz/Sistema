Imports Backend
Imports MySql.Data.MySqlClient

Public Class CompraDAO
    Dim con As New MySqlConnection()
    Public Function guardarCompra(ByVal compra As Compra, ByVal productos As DataGridViewRowCollection, ByVal sucursal As Sucursal, ByVal deposito As Deposito, ByVal produccionDia As Double) As Integer
        Dim compraCod = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            compra.usuI = Sesion.Usuario
            Dim queryVenta = ""
            queryVenta = "INSERT INTO `compras` (`opeCod`, `comprasCred`, `comprasObs`, `provCod`, `comprasTotal`, `comprasEstado`, `comprasNroFact`, `comprasFchPago`, `comprasSaldo`, `comprasFchFact`, `comprasUsrIns`, `comprasFchIns`, `comprasUsrUpd`, `comprasFchUpd`, `comprasExenta`, `compras5`, `compras10`, `sucCod`, `depoCod`) VALUES (@op, @cre, @obs, @prov, @total, @estado, @fact, @fpago, @saldo, @fecha, @user, @fecha, @user, @fecha, @exenta, @iva5, @iva10, @suc, @depo); SELECT LAST_INSERT_ID();"
            Dim cmdVenta As New MySqlCommand(queryVenta, con)

            cmdVenta.Parameters.AddWithValue("@op", 2)
            cmdVenta.Parameters.AddWithValue("@cre", compra.credito)
            cmdVenta.Parameters.AddWithValue("@obs", compra.obs)
            cmdVenta.Parameters.AddWithValue("@prov", compra.proveedor)
            cmdVenta.Parameters.AddWithValue("@total", compra.total)
            cmdVenta.Parameters.AddWithValue("@estado", compra.estado)
            cmdVenta.Parameters.AddWithValue("@fact", compra.factura)
            cmdVenta.Parameters.AddWithValue("@fpago", compra.fechaP)
            cmdVenta.Parameters.AddWithValue("@saldo", compra.saldo)
            cmdVenta.Parameters.AddWithValue("@fecha", Date.Now)
            cmdVenta.Parameters.AddWithValue("@user", Sesion.Codigo)
            cmdVenta.Parameters.AddWithValue("@exenta", compra.excenta)
            cmdVenta.Parameters.AddWithValue("@iva5", compra.iva5)
            cmdVenta.Parameters.AddWithValue("@iva10", compra.iva10)
            cmdVenta.Parameters.AddWithValue("@suc", sucursal.id)
            cmdVenta.Parameters.AddWithValue("@depo", deposito.id)
            compraCod = CInt(cmdVenta.ExecuteScalar())
            con.Close()
            con.Open()

            Dim queryDetalle = "INSERT INTO `comprasdet` ( `comprasCod`, `prodCod`, `comprasDetCosto`, `comprasDetExenta`, `comprasDet5`, `comprasDet10`, `comprasDetCantidad`) VALUES (@compra, @prod, @costo,@exenta, @iva5, @iva10, @cantidad);"
            Dim cmdDetalle As New MySqlCommand(queryDetalle, con)

            For Each row As Windows.Forms.DataGridViewRow In productos
                Dim idProducto = row.Cells(0).Value
                Dim producto = row.Cells(2).Value
                Dim costo = row.Cells(9).Value
                Dim exenta = row.Cells(8).Value
                Dim iva5 = row.Cells(6).Value
                Dim iva10 = row.Cells(7).Value
                Dim cantidad = CInt(row.Cells(5).Value)
                cmdDetalle.Parameters.AddWithValue("@compra", compraCod)
                cmdDetalle.Parameters.AddWithValue("@prod", producto)
                cmdDetalle.Parameters.AddWithValue("@costo", costo)
                cmdDetalle.Parameters.AddWithValue("@exenta", exenta)
                cmdDetalle.Parameters.AddWithValue("@iva5", iva5)
                cmdDetalle.Parameters.AddWithValue("@iva10", iva10)
                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
                cmdDetalle.ExecuteNonQuery()
                cmdDetalle.Parameters.Clear()

                'Actualizacion stock
                Dim queryStock = "INSERT INTO `stock` (`prodCodigo`, `stCantidad`, `opCod`, `stUsrIns`, `stFchIns`, `sucCod`, `depoCod`, `compraCod` ) VALUES (@producto, @cantidad, @op, @user, @fecha, @sucursal, @deposito, @compra);"
                Dim cmdStock As New MySqlCommand(queryStock, con)
                cmdStock.Parameters.AddWithValue("@producto", producto)
                cmdStock.Parameters.AddWithValue("@cantidad", cantidad)
                cmdStock.Parameters.AddWithValue("@op", 2)
                cmdStock.Parameters.AddWithValue("@user", Sesion.Usuario)
                cmdStock.Parameters.AddWithValue("@fecha", Date.Today)
                cmdStock.Parameters.AddWithValue("@sucursal", sucursal.id)
                cmdStock.Parameters.AddWithValue("@deposito", deposito.id)
                cmdStock.Parameters.AddWithValue("@compra", compraCod)
                cmdStock.ExecuteNonQuery()
                cmdStock.Parameters.Clear()
            Next

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return compraCod
    End Function

    Public Function getCompra(ByVal id As String) As Compra
        Try
            Dim modelo As New Compra

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from compras where comprasCod = @compra"
            Dim cmdVenta As New MySqlCommand(query, con)
            cmdVenta.Parameters.AddWithValue("@compra", id)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.operacion = SafeGetInt(reader, 1)
                modelo.credito = safeGetChar(reader, 2)
                modelo.obs = SafeGetString(reader, 3)
                modelo.proveedor = SafeGetInt(reader, 4)
                modelo.total = SafeGetDouble(reader, 5)
                modelo.estado = safeGetChar(reader, 6)
                modelo.factura = SafeGetString(reader, 7)
                modelo.fechaA = SafeGetDate(reader, 8)
                modelo.fechaP = SafeGetDate(reader, 9)
                modelo.saldo = SafeGetDouble(reader, 10)
                modelo.fecha = SafeGetDate(reader, 11)
                modelo.usuI = SafeGetInt(reader, 12)
                modelo.fechaI = SafeGetDate(reader, 13)
                modelo.usuU = SafeGetInt(reader, 14)
                modelo.fechaU = SafeGetDate(reader, 15)
                modelo.excenta = SafeGetDouble(reader, 16)
                modelo.iva5 = SafeGetDouble(reader, 17)
                modelo.iva10 = SafeGetDouble(reader, 18)
                modelo.sucursal = SafeGetInt(reader, 19)
                modelo.deposito = SafeGetInt(reader, 20)
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
            Dim mysql = "SELECT * from vdetallecompra where Compra = " & id & ";"
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

    Public Sub anularCompra(ByVal compra As Compra, ByVal motivo As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `compras` SET `comprasEstado` = 'A',`comprasObs` = @motivo WHERE `comprasCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@cod", compra.id)
            cmd.Parameters.AddWithValue("@motivo", motivo)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getCompras() As List(Of Integer)
        Dim listado As New List(Of Integer)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select comprasCod from compras"
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
End Class
