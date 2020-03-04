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
                ds.roturas = SafeGetInt(reader, 13)
                ds.repo = SafeGetString(reader, 14)
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

    Public Function checkRotura(ByVal id As Integer) As Boolean
        Dim r = False
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vexpediciontodojunto where Produccion = @codigo"

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()
            While reader.Read
                Dim r1 = SafeGetDate(reader, 9)
                If r1 = Nothing Then
                    r = False
                Else
                    r = True
                End If
            End While
            reader.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
        Return r
    End Function

    Public Sub guardarReposicion(ByVal ot As String, ByVal motivo As String, ByVal prod As Integer)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = "INSERT INTO `producir`.`reposiciones` (`ventCod`, `motCod`, `repoUI`, `repoFI`, `repoUU`, `repoFU`) VALUES (@venta, @motivo, @user, @fecha, @user, @fecha); SELECT LAST_INSERT_ID();"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@venta", ot)
            'If(motivo = "", DBNull.Value, motivo)
            cmd.Parameters.AddWithValue("@motivo", 9)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            Dim repo = CInt(cmd.ExecuteScalar())
            Dim queryDetalle = ""
            con.Close()
            con.Open()
            Dim con2 = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con2.Open()

            If checkRoturaTemplado(prod) Then
                queryDetalle = "INSERT INTO `producir`.`reposiciondetalle` (`idProd`, `idMotivo`, `idReposicion`,`repoTemp`) VALUES (@prod, @motivo, @repo, 'S');"
            Else
                queryDetalle = "INSERT INTO `producir`.`reposiciondetalle` (`idProd`, `idMotivo`, `idReposicion`) VALUES (@prod, @motivo, @repo);"
            End If

            Dim cmdDetalle As New MySqlCommand(queryDetalle, con2)
            cmdDetalle.Parameters.AddWithValue("@prod", prod)
            cmdDetalle.Parameters.AddWithValue("@motivo", 9)
            cmdDetalle.Parameters.AddWithValue("@repo", repo)
            cmdDetalle.ExecuteNonQuery()
            con2.Close()

            Dim proda As New ProduccionDAO
            proda.actualizarProduccion(prod)
            'Dim queryPro = "UPDATE "
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

    Public Function checkRoturaTemplado(ByVal id As Integer) As Boolean
        Dim r = False
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vexpediciontodojunto where Produccion = @codigo"

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()
            While reader.Read
                Dim r1 = SafeGetDate(reader, 12)
                If r1 = Nothing Then
                    r = False
                Else
                    r = True
                End If
            End While
            reader.Close()
        Catch ex As Exception

        End Try
        Return r
    End Function
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

    Public Function getErrores() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT e.`errorCod` AS ID , e.`errorDesc` AS Error FROM `errores` e"
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

    Public Sub guardarReposicionErrores(ByVal ot As String, ByVal producs As DataGridViewRowCollection)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "INSERT INTO `producir`.`reposiciones` (`ventCod`, `motCod`, `repoUI`, `repoFI`, `repoUU`, `repoFU`) VALUES (@venta, @motivo, @user, @fecha, @user, @fecha); SELECT LAST_INSERT_ID();"

            For Each row As Windows.Forms.DataGridViewRow In producs
                Dim nroProd = row.Cells(1).Value
                Dim mot = row.Cells(10).Value

                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@venta", ot)
                'If(motivo = "", DBNull.Value, motivo)
                cmd.Parameters.AddWithValue("@motivo", mot)
                cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
                cmd.Parameters.AddWithValue("@fecha", Date.Now)
                Dim repo = CInt(cmd.ExecuteScalar())


                Dim queryDetalle = ""

                queryDetalle = "INSERT INTO `producir`.`reposiciondetalle` (`idProd`, `idMotivo`, `idReposicion`,`repoTemp`) VALUES (@prod, @motivo, @repo, 'S');"


                Dim cmdDetalle As New MySqlCommand(queryDetalle, con)
                cmdDetalle.Parameters.AddWithValue("@prod", nroProd)
                cmdDetalle.Parameters.AddWithValue("@motivo", mot)
                cmdDetalle.Parameters.AddWithValue("@repo", repo)
                cmdDetalle.ExecuteNonQuery()
                Dim produd As New ProduccionDAO
                produd.actualizarProduccion(nroProd)
                cmd.Parameters.Clear()
                cmdDetalle.Parameters.Clear()
            Next





        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class
