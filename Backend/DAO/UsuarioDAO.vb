Imports MySql.Data.MySqlClient

Public Class UsuarioDAO
    Public Function getUsuarios() As DataSet
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT * from vlistadousuarios"

            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    ' Guarda un nuevo producto en la DB
    Public Sub guardar(ByVal modelo As Usuario)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("root", "system"))
            con.Open()
            ', `prodEsp`

            Dim query = "CREATE USER '" & modelo.nombre & "'@'" & Sesion.Host & "' IDENTIFIED BY '" & modelo.nombre & "'; GRANT ALL PRIVILEGES ON * . * TO '" & modelo.nombre & "'@'" & Sesion.Host & "'; FLUSH PRIVILEGES;"
            Dim cmd As New MySqlCommand(query, con)



            'cmd.Parameters.AddWithValue("@fe", modelo.alto)
            'cmd.Parameters.AddWithValue("@alto", modelo.alto)
            'cmd.Parameters.AddWithValue("@stockm", modelo.stockMin)
            'If modelo.tipoPL <> 0 Then
            '    cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
            'Else
            '    cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
            'End If



            cmd.ExecuteNonQuery()
            con.Close()

            Dim con2 As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con2.Open()
            Dim query2 = "INSERT INTO `usuario` (`usuCod`, `usuNombre`, `usuNivel`, `usuAlta`, `usuEstado`) VALUES (@cod, @nombre, @nivel, @fecha, @estado);"

            Dim cmd2 As New MySqlCommand(query2, con2)

            cmd2.Parameters.AddWithValue("@cod", modelo.id)
            cmd2.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd2.Parameters.AddWithValue("@nivel", modelo.nivel)
            cmd2.Parameters.AddWithValue("@fecha", modelo.fechaAlta)
            cmd2.Parameters.AddWithValue("@estado", modelo.estado)
            cmd2.ExecuteNonQuery()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub eliminar(ByVal id As String)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query As String = "DELETE FROM `usuario` WHERE `usuCod` = @id;"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@id", id)


            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub update(ByVal modelo As Usuario)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
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
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function getUsuario(ByVal id As String) As Usuario
        Try
            Dim modelo As New Usuario
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
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
            con.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Function
End Class
