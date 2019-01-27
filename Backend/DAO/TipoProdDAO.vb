Imports MySql.Data.MySqlClient

Public Class TipoProdDAO
    Dim con As New MySqlConnection
    Public Function getTipos() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadotipoprod"
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

    ' Agrega un tipo de producto nuevo
    Public Sub agregar(ByVal modelo As TipoProducto)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query As String = "INSERT INTO `prodtipo` (`prodTipo`) VALUES (@tipo);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@tipo", modelo.nombre)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub eliminar(ByVal id As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query As String = "DELETE FROM `prodtipo` WHERE `prodTipocod` = @id;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub


    ' --------------------------- PLANCHAS

    Public Function getTiposPlancha() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadotipoplancha"
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

    Public Sub agregarPlancha(ByVal modelo As TipoPlancha)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query As String = "INSERT INTO `tipoplancha` (`tipo`) VALUES (@tipo);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@tipo", modelo.nombre)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub eliminarPlancha(ByVal id As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query As String = "DELETE FROM `tipoplancha` WHERE `tipoCod` = @id;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub


    Public Function getTipo(ByVal codigo As String) As TipoProducto
        Dim modelo As New TipoProducto
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadotipoprod where ID = @cod"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@cod", codigo)
            Dim reader = cmd.ExecuteReader
            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.nombre = SafeGetString(reader, 1)
            End While
            reader.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return modelo
    End Function
End Class
