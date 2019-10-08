Imports MySql.Data.MySqlClient

Public Class UsuarioDAO
    Dim con As New MySqlConnection
    Dim con2 As New MySqlConnection
    Public Function getUsuarios() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadousuarios"
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

    ' Guarda un nuevo usuario en la DB
    Public Sub guardar(ByVal modelo As Usuario)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Config.root, Config.Password))
            con.Open()
            ', `prodEsp`

            Dim query = "CREATE USER '" & modelo.nombre & "'@'%'; ALTER USER '" & modelo.nombre & "'@'%' IDENTIFIED BY '" & modelo.nombre & "' ;  " & "GRANT Insert ON *.* TO '" & modelo.nombre & "'@'%';" & "GRANT Select ON *.* TO '" & modelo.nombre & "'@'%';" & "GRANT Update ON *.* TO '" & modelo.nombre & "'@'%';" & "GRANT Usage ON *.* TO '" & modelo.nombre & "'@'%';" & "FLUSH PRIVILEGES;"

            Dim cmd As New MySqlCommand(query, con)

            cmd.ExecuteNonQuery()
            con.Close()

            con2 = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con2.Open()
            Dim query2 = "INSERT INTO `usuario` (`usuCod`, `usuNombre`, `usuNivel`, `usuAlta`, `usuEstado`) VALUES (@cod, @nombre, @nivel, @fecha, @estado);"
            Dim cmd2 As New MySqlCommand(query2, con2)
            cmd2.Parameters.AddWithValue("@cod", modelo.id)
            cmd2.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd2.Parameters.AddWithValue("@nivel", modelo.nivel)
            cmd2.Parameters.AddWithValue("@fecha", modelo.fechaAlta)
            cmd2.Parameters.AddWithValue("@estado", modelo.estado)
            cmd2.ExecuteNonQuery()

            con2.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
            con2.Close()
        End Try
    End Sub

    Public Function eliminar(ByVal id As String, ByVal usuario As String) As String
        Try

            If Sesion.Usuario = usuario Then
                Return "La sesión actual corresponde al usuario que desea eliminar. Operación abortada"
            End If

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Config.root, Config.Password))
            con.Open()

            Dim query As String = " DROP USER '" & usuario & "'@'%';"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@id", id)


            cmd.ExecuteNonQuery()
            con.Close()

            con2 = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con2.Open()
            Dim query2 = "DELETE FROM `usuario` WHERE `usuCod` = @cod;"
            Dim cmd2 As New MySqlCommand(query2, con2)

            cmd2.Parameters.AddWithValue("@cod", id)
            cmd2.ExecuteNonQuery()


            Return "Usuario eliminado correctamente"
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
            con2.Close()
        End Try
    End Function

    Public Sub update(ByVal modelo As Usuario)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            '`prodEsp` = @esp,
            Dim query = " UPDATE `usuario` SET `usuCod` = @cod, `usuNombre` = @nombre, `usuNivel` = @nivel,  `usuEstado` = @estado WHERE `usuCod` = @cod2;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", modelo.idNuevo)
            cmd.Parameters.AddWithValue("@cod2", modelo.id)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@estado", modelo.estado)
            cmd.Parameters.AddWithValue("@nivel", modelo.nivel)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getUsuario(ByVal id As String) As Usuario
        Try
            Dim modelo As New Usuario
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from usuario where usuCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetString(reader, 0)
                modelo.nombre = SafeGetString(reader, 1)
                modelo.nivel = SafeGetInt(reader, 2)
                modelo.fechaAlta = SafeGetDate(reader, 3)
                modelo.estado = safeGetChar(reader, 4)

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
