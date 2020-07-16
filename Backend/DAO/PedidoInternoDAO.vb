Imports MySql.Data.MySqlClient

Public Class PedidoInternoDAO
    Dim con As New MySqlConnection
    Public Function getPedidos() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadopedidosi"
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

    Public Function getPedidosEstado(ByVal estado As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadopedidosi where Estado = '" & estado & "' ;"
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

    Public Function getDetallePedido(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadopedidosd where ID = " & id & " ;"
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

    Public Sub guardarPedido(ByVal ped As PedidoInterno, ByVal detalle As DataGridViewRowCollection)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "INSERT INTO `producir`.`pedidointernocab` (`piFecha`, `piSolicitado`, `piAutorizado`, `depoCod`, `piCantidad`, `prodCod`, `piCodOpti`, `piUsrIns`, `piFchIns`,`piEstado`,`piProv`) VALUES (@fecha, @sol, @auto, @depo, @cant, @prod, @opti, @user, @fecha, 'GENERADO' , @prov); SELECT LAST_INSERT_ID();"
            ped.prov = sucursalCod
            Dim daoSuc As New SucursalDAO
            Dim sucAux = daoSuc.getSucursal(sucursalCod)
            ped.depo = sucAux.deposito

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", ped.fecha)
            cmd.Parameters.AddWithValue("@sol", ped.soli)
            cmd.Parameters.AddWithValue("@auto", ped.auto)
            cmd.Parameters.AddWithValue("@depo", ped.depo)
            cmd.Parameters.AddWithValue("@cant", ped.cantidad)
            cmd.Parameters.AddWithValue("@prod", ped.prodCod)
            cmd.Parameters.AddWithValue("@opti", ped.opti)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@prov", ped.prov)

            Dim pedidonro = cmd.ExecuteScalar()

            Dim queryDetalle = "INSERT INTO `producir`.`pedidointernodet` (`clieCod`, `piCod`, `piLinea`, `ventCod`) VALUES ( @cliente, @pedido, @linea, @venta);"
            Dim cmdDetalle As New MySqlCommand(queryDetalle, con)


            For Each row As Windows.Forms.DataGridViewRow In detalle
                Dim linea = row.Cells(0).Value
                Dim venta = row.Cells(3).Value
                Dim cli = row.Cells(4).Value
                cmdDetalle.Parameters.AddWithValue("@cliente", cli)
                cmdDetalle.Parameters.AddWithValue("@pedido", pedidonro)
                cmdDetalle.Parameters.AddWithValue("@linea", linea)
                cmdDetalle.Parameters.AddWithValue("@venta", venta)
                cmdDetalle.ExecuteNonQuery()
                cmdDetalle.Parameters.Clear()
            Next
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub autorizar(ByVal cod As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = "UPDATE `producir`.`pedidointernocab` SET  `piEstado` = 'AUTORIZADO', `piUsrUpd` = @user, `piFchUpd` = @fecha WHERE `piCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Today)
            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub anular(ByVal cod As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = "UPDATE `producir`.`pedidointernocab` SET  `piEstado` = 'ANULADO', `piUsrUpd` = @user, `piFchUpd` = @fecha WHERE `piCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Today)
            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub darSalida(ByVal cod As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = "UPDATE `producir`.`pedidointernocab` SET  `piEstado` = 'ENTREGADO', `piUsrUpd` = @user, `piFchUpd` = @fecha WHERE `piCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Today)
            cmd.Parameters.AddWithValue("@cod", cod)
            cmd.ExecuteNonQuery()
            Dim ped = getPedido(cod)
            Dim con2 = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con2.Open()
            Dim queryStock = "INSERT INTO `producir`.`stock` (`prodCodigo`, `stCantidad`, `opCod`, `stUsrIns`, `stFchIns`, `sucCod`, `depoCod`,`piCod`) VALUES (@prod, @cant, @op, @usuario, @fecha, @suc, @depo, @pi);"
            Dim cmdStock As New MySqlCommand(queryStock, con2)
            cmdStock.Parameters.AddWithValue("@prod", ped.prodCod)
            cmdStock.Parameters.AddWithValue("@cant", -ped.cantidad)
            cmdStock.Parameters.AddWithValue("@op", 5)
            cmdStock.Parameters.AddWithValue("@usuario", Sesion.Usuario)
            cmdStock.Parameters.AddWithValue("@fecha", Date.Now)
            cmdStock.Parameters.AddWithValue("@suc", ped.prov)
            cmdStock.Parameters.AddWithValue("@depo", ped.depo)
            cmdStock.Parameters.AddWithValue("@pi", ped.id)
            cmdStock.ExecuteNonQuery()
            con2.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getPedido(ByVal id As String) As PedidoInterno
        Dim modelo As New PedidoInterno
        Try

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from pedidointernocab where piCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.fecha = SafeGetDate(reader, 1)
                modelo.soli = SafeGetString(reader, 2)
                modelo.auto = SafeGetString(reader, 3)
                modelo.depo = SafeGetInt(reader, 4)
                modelo.cantidad = SafeGetInt(reader, 5)
                modelo.prodCod = SafeGetInt(reader, 6)
                modelo.opti = SafeGetInt(reader, 7)
                modelo.estado = SafeGetString(reader, 8)
                modelo.usrIns = SafeGetString(reader, 9)
                modelo.fechaIns = SafeGetDate(reader, 10)
                modelo.usrUpd = SafeGetString(reader, 11)
                modelo.fechaUpd = SafeGetDate(reader, 12)
                modelo.prov = SafeGetInt(reader, 13)

            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function
End Class
