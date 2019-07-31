Imports MySql.Data.MySqlClient

Public Class ReposicionesDAO
    Dim con As New MySqlConnection
    Public Function getProduccion(ByVal id As String) As CargaProduccion
        Dim ds As New CargaProduccion
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vreposiciones where IDProd = @codigo"

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds.idProd = SafeGetInt(reader, 0)
                ds.venta = SafeGetInt(reader, 1)
                ds.panho = SafeGetInt(reader, 2)
                ds.codProd = SafeGetInt(reader, 3)
                ds.cantidad = SafeGetInt(reader, 4)
                ds.ancho = SafeGetDouble(reader, 5)
                ds.alto = SafeGetDouble(reader, 6)
                ds.sup = SafeGetDouble(reader, 7)
                ds.cliente = SafeGetString(reader, 8)
                ds.opCod = SafeGetInt(reader, 9)
                ds.opDesc = SafeGetString(reader, 10)
                ds.cliCod = SafeGetInt(reader, 11)
                ds.fechaOt = SafeGetDate(reader, 12)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub guardarReposicion(ByVal ot As String, ByVal motivo As String, ByVal prod As Integer)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "INSERT INTO `producir`.`reposiciones` (`ventCod`, `motCod`, `repoUI`, `repoFI`, `repoUU`, `repoFU`) VALUES (@venta, @motivo, @user, @fecha, @user, @fecha); SELECT LAST_INSERT_ID();"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@venta", ot)
            cmd.Parameters.AddWithValue("@motivo", If(motivo = "", DBNull.Value, motivo))
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            Dim repo = CInt(cmd.ExecuteScalar())

            Dim queryDetalle = "INSERT INTO `producir`.`reposiciondetalle` (`idProd`, `idMotivo`, `idReposicion`) VALUES (@prod, @motivo, @repo);"
            Dim cmdDetalle As New MySqlCommand(queryDetalle, con)
            cmdDetalle.Parameters.AddWithValue("@prod", prod)
            cmdDetalle.Parameters.AddWithValue("@motivo", If(motivo = "", DBNull.Value, motivo))
            cmdDetalle.Parameters.AddWithValue("@repo", repo)
            cmdDetalle.ExecuteNonQuery()

            ''Dim queryPro = "UPDATE `producir`.`produccion` SET `repoCod` = @repo  WHERE `pCod` = @prod;"
            ''Dim cmdPro As New MySqlCommand(queryPro, con)
            ''cmdPro.Parameters.AddWithValue("@repo", repo)
            ''cmdPro.Parameters.AddWithValue("@prod", prod)
            'cmdPro.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub


    Public Function cargarListado(ByVal idp As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from `vlistadoreposiciones` where PID = " & idp & ""
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
End Class
