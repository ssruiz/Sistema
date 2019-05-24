Imports MySql.Data.MySqlClient

Public Class CambioDAO
    Dim con As New MySqlConnection
    Public Function getCambio() As Cambio
        Dim ds As New DataSet
        Dim modelo As New Cambio
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * FROM cambio ORDER BY id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim reader = cmd.ExecuteReader()
            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.cambio = SafeGetDouble(reader, 1)
            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Sub guardarCambio(ByVal cambio As Double)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "INSERT INTO `producir`.`cambio` (`cambio`) VALUES (@cambio);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cambio", cambio)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class
