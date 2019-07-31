Imports MySql.Data.MySqlClient

Public Class MovInternoDAO
    Dim con As New MySqlConnection()
    Public Function guardarMovimiento(ByVal mov As MInterno, ByVal productos As DataGridViewRowCollection) As Integer
        Dim movCod = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            mov.autorizador = Sesion.Usuario
            Dim query = ""
            query = "INSERT INTO `movinterno` (`sucursalOrigen`, `sucursalDestino`, `depositoOrigen`, `depositoDestino`, `solicitante`, `autorizado`,  `estado`, `fecha`, `observacion`) VALUES (@sor, @sdest, @depor, @depdest, @sol, @aut, 'C' , @fecha, @obs); SELECT LAST_INSERT_ID();"
            Dim cmdMov As New MySqlCommand(query, con)

            cmdMov.Parameters.AddWithValue("@sor", mov.sorigen)
            cmdMov.Parameters.AddWithValue("@sdest", mov.sdestino)
            cmdMov.Parameters.AddWithValue("@depor", mov.dorigen)
            cmdMov.Parameters.AddWithValue("@depdest", mov.ddestino)
            cmdMov.Parameters.AddWithValue("@sol", mov.solicitante)
            cmdMov.Parameters.AddWithValue("@aut", mov.autorizador)
            cmdMov.Parameters.AddWithValue("@fecha", mov.fecha)
            cmdMov.Parameters.AddWithValue("@obs", mov.obs)
            movCod = CInt(cmdMov.ExecuteScalar())
            con.Close()
            con.Open()

            Dim queryDetalle = "INSERT INTO `movinternodetalle` (`idMov`, `prodId`, `cantidad`) VALUES (@mov, @prod, @cantidad);"
            Dim cmdDetalle As New MySqlCommand(queryDetalle, con)

            For Each row As Windows.Forms.DataGridViewRow In productos

                Dim producto = row.Cells(2).Value
                Dim cantidad = CInt(row.Cells(5).Value)

                cmdDetalle.Parameters.AddWithValue("@prod", producto)
                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
                cmdDetalle.Parameters.AddWithValue("@mov", movCod)
                cmdDetalle.ExecuteNonQuery()
                cmdDetalle.Parameters.Clear()

                ''Actualizacion stock
                'Dim queryStock = "INSERT INTO `stock` (`prodCodigo`, `stCantidad`, `opCod`, `stUsrIns`, `stFchIns`, `sucCod`, `depoCod`, `movCod` ) VALUES (@producto, @cantidad, @op, @user, @fecha, @sucursal, @deposito, @mov);"
                'Dim cmdStock As New MySqlCommand(queryStock, con)
                'cmdStock.Parameters.AddWithValue("@producto", producto)
                'cmdStock.Parameters.AddWithValue("@cantidad", -cantidad)
                'cmdStock.Parameters.AddWithValue("@op", 3)
                'cmdStock.Parameters.AddWithValue("@user", Sesion.Usuario)
                'cmdStock.Parameters.AddWithValue("@fecha", Date.Today)
                'cmdStock.Parameters.AddWithValue("@sucursal", mov.sorigen)
                'cmdStock.Parameters.AddWithValue("@deposito", mov.dorigen)
                'cmdStock.Parameters.AddWithValue("@mov", movCod)
                'cmdStock.ExecuteNonQuery()
                'cmdStock.Parameters.Clear()

                'Dim cmdStock2 As New MySqlCommand(queryStock, con)
                'cmdStock2.Parameters.AddWithValue("@producto", producto)
                'cmdStock2.Parameters.AddWithValue("@cantidad", cantidad)
                'cmdStock2.Parameters.AddWithValue("@op", 3)
                'cmdStock2.Parameters.AddWithValue("@user", Sesion.Usuario)
                'cmdStock2.Parameters.AddWithValue("@fecha", Date.Today)
                'cmdStock2.Parameters.AddWithValue("@sucursal", mov.sdestino)
                'cmdStock2.Parameters.AddWithValue("@deposito", mov.ddestino)
                'cmdStock2.Parameters.AddWithValue("@mov", movCod)
                'cmdStock2.ExecuteNonQuery()
                'cmdStock2.Parameters.Clear()
            Next

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return movCod
    End Function

    Public Function getMovimientos(ByVal so As Integer) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vmovimientosinternos where SO = " & so & " or SD = " & so & ";"
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

    Public Function getMovimientosA(ByVal so As Integer) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vmovimientosinternos where SO = @so and Estado = 'Pendiente' ; "
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@so", so)

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

    Public Function getMI(ByVal id As String) As MInterno
        Try
            Dim modelo As New MInterno
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from movinterno where id = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.sorigen = SafeGetInt(reader, 1)
                modelo.sdestino = SafeGetInt(reader, 2)
                modelo.dorigen = SafeGetInt(reader, 3)
                modelo.ddestino = SafeGetInt(reader, 4)
                modelo.solicitante = SafeGetString(reader, 5)
                modelo.autorizador = SafeGetString(reader, 6)
                modelo.estado = safeGetChar(reader, 7)
                modelo.fecha = SafeGetDate(reader, 8)
                modelo.obs = SafeGetString(reader, 9)
            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function getDetalle(ByVal id As Integer) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vdetallemi where Mov = " & id & ";"
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

    Public Function autorizar(ByVal id As Integer, ByVal sorigen As Integer, ByVal sdestino As Integer, ByVal dorigen As Integer, ByVal ddestino As Integer) As Integer
        Dim ds = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "UPDATE `producir`.`movinterno` SET `autorizado` = @user, `estado` = 'B', `fecha_auto` = @fecha  WHERE `id` = @id;"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)

            cmd.ExecuteNonQuery()

            Dim daoM As New MovInternoDAO
            Dim listado = daoM.getDetalle(id)


            For Each row As DataRow In listado.Tables("tabla").Rows

                Dim producto = row(2)
                Dim cantidad = CInt(row(5))



                ''Actualizacion stock
                Dim queryStock = "INSERT INTO `stock` (`prodCodigo`, `stCantidad`, `opCod`, `stUsrIns`, `stFchIns`, `sucCod`, `depoCod`, `movCod` ) VALUES (@producto, @cantidad, @op, @user, @fecha, @sucursal, @deposito, @mov);"
                Dim cmdStock As New MySqlCommand(queryStock, con)
                cmdStock.Parameters.AddWithValue("@producto", producto)
                cmdStock.Parameters.AddWithValue("@cantidad", -cantidad)
                cmdStock.Parameters.AddWithValue("@op", 3)
                cmdStock.Parameters.AddWithValue("@user", Sesion.Usuario)
                cmdStock.Parameters.AddWithValue("@fecha", Date.Today)
                cmdStock.Parameters.AddWithValue("@sucursal", sorigen)
                cmdStock.Parameters.AddWithValue("@deposito", dorigen)
                cmdStock.Parameters.AddWithValue("@mov", id)
                cmdStock.ExecuteNonQuery()
                cmdStock.Parameters.Clear()

                Dim cmdStock2 As New MySqlCommand(queryStock, con)
                cmdStock2.Parameters.AddWithValue("@producto", producto)
                cmdStock2.Parameters.AddWithValue("@cantidad", cantidad)
                cmdStock2.Parameters.AddWithValue("@op", 3)
                cmdStock2.Parameters.AddWithValue("@user", Sesion.Usuario)
                cmdStock2.Parameters.AddWithValue("@fecha", Date.Today)
                cmdStock2.Parameters.AddWithValue("@sucursal", sdestino)
                cmdStock2.Parameters.AddWithValue("@deposito", ddestino)
                cmdStock2.Parameters.AddWithValue("@mov", id)
                cmdStock2.ExecuteNonQuery()
                cmdStock2.Parameters.Clear()
            Next
            ds = 1
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub anular(ByVal id As Integer)
        Dim ds = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "UPDATE `producir`.`movinterno` SET `estado` = 'A'  WHERE `id` = @id;"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()





            ''Actualizacion stock
            Dim queryStock = "UPDATE `producir`.`stock` SET `stEstado` = 'A' WHERE `movCod` = @id;"
            Dim cmdStock As New MySqlCommand(queryStock, con)
            cmdStock.Parameters.AddWithValue("@id", id)

            cmdStock.ExecuteNonQuery()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub
End Class
