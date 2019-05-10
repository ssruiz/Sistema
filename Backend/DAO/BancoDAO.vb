Imports MySql.Data.MySqlClient

Public Class BancoDAO
    Dim con As New MySqlConnection
    Public Function getBancos() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadobancos"
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

    Public Sub guardar(ByVal modelo As Banco)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query As String = "INSERT INTO `producir`.`bancos` (`banNombre`) VALUES (@nombre);"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub update(ByVal modelo As Banco)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            ', `prodEsp`
            Dim query As String = "UPDATE `producir`.`bancos` SET `banNombre` = @nombre WHERE `banCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", modelo.id)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getBanco(ByVal id As String) As Banco
        Try
            Dim modelo As New Banco
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `producir`.`bancos` where `banCod` = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.nombre = SafeGetString(reader, 1)
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
