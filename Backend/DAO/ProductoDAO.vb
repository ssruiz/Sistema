Imports MySql.Data.MySqlClient

Public Class ProductoDAO
    Public Function getProductos() As DataSet
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT * from vlistadoproductos"

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
    Public Sub guardar(ByVal modelo As Producto)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            ', `prodEsp`
            Dim query As String = "INSERT INTO `productos` (`prodCodigo`, `prodTipo`, `prodDesc`, `prodColor`, `prodAlto`, `prodAncho`, `prodSup`, `prodPA`, `prodPB`, `prodPC`, `prodPD`, `prodUI`, `prodFi`, `prodUU`, `prodFU`, `prodSM`, `prodTipoPl`) VALUES (@codigo, @tipo, @desc, @color, @alto, @ancho, @superf, @pa, @pb, @pc, @pd, @userI, @fecha, @userI, @fecha, @stockm,@tpl);"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@codigo", modelo.codigo)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            cmd.Parameters.AddWithValue("@color", modelo.color)
            cmd.Parameters.AddWithValue("@alto", modelo.alto)
            cmd.Parameters.AddWithValue("@ancho", modelo.ancho)
            cmd.Parameters.AddWithValue("@superf", modelo.superficie)
            cmd.Parameters.AddWithValue("@pa", modelo.PrecioA)
            cmd.Parameters.AddWithValue("@pb", modelo.PrecioB)
            cmd.Parameters.AddWithValue("@pc", modelo.PrecioC)
            cmd.Parameters.AddWithValue("@pd", modelo.PrecioD)
            cmd.Parameters.AddWithValue("@userI", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            'cmd.Parameters.AddWithValue("@fe", modelo.alto)
            'cmd.Parameters.AddWithValue("@alto", modelo.alto)
            cmd.Parameters.AddWithValue("@stockm", modelo.stockMin)
            If modelo.tipoPL <> 0 Then
                cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
            Else
                cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
            End If



            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub eliminar(ByVal id As String)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query As String = "DELETE FROM `color` WHERE `colorCod` = @id;"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@id", id)


            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub update(ByVal modelo As Producto)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            '`prodEsp` = @esp,
            Dim query = "UPDATE `productos` SET `prodCodigo` = @cod, `prodTipo` = @tipo, `prodDesc` = @desc, `prodColor` = @color,  `prodAlto` = @alto, `prodAncho` = @ancho, `prodSup` = @sup, `prodPA` = @pa, `prodPB` = @pb, `prodPC` = @pc, `prodPD` = @pd, `prodUU` = @user, `prodFU` = @fecha, `prodSM` = @stm, `prodTipoPl` = @tpl WHERE `prodCod` = @id;"


            Dim cmd As New MySqlCommand(query, con)


            cmd.Parameters.AddWithValue("@id", modelo.id)
            cmd.Parameters.AddWithValue("@cod", modelo.codigo)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            cmd.Parameters.AddWithValue("@color", modelo.color)
            ' cmd.Parameters.AddWithValue("@esp", modelo.espesor)
            ' cmd.Parameters.AddWithValue("@pl", modelo.tipoPL)
            cmd.Parameters.AddWithValue("@alto", modelo.alto)
            cmd.Parameters.AddWithValue("@ancho", modelo.ancho)
            cmd.Parameters.AddWithValue("@sup", modelo.superficie)
            cmd.Parameters.AddWithValue("@pa", modelo.PrecioA)
            cmd.Parameters.AddWithValue("@pb", modelo.PrecioB)
            cmd.Parameters.AddWithValue("@pc", modelo.PrecioC)
            cmd.Parameters.AddWithValue("@pd", modelo.PrecioD)
            cmd.Parameters.AddWithValue("@user", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@stm", modelo.stockMin)
            If modelo.tipoPL <> 0 Then
                cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
            Else
                cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
            End If

            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function getProducto(ByVal id As String) As Producto
        Try
            Dim modelo As New Producto
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from productos where prodCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.codigo = SafeGetString(reader, 1)
                modelo.tipo = SafeGetInt(reader, 2)
                modelo.descripcion = SafeGetString(reader, 3)
                modelo.color = SafeGetInt(reader, 4)
                modelo.espesor = SafeGetInt(reader, 5)
                modelo.tipoPL = SafeGetInt(reader, 6)
                modelo.alto = SafeGetDecimal(reader, 7)
                modelo.ancho = SafeGetDecimal(reader, 8)
                modelo.superficie = SafeGetDecimal(reader, 9)
                modelo.PrecioA = SafeGetDouble(reader, 10)
                modelo.PrecioB = SafeGetDouble(reader, 11)
                modelo.PrecioC = SafeGetDouble(reader, 12)
                modelo.PrecioD = SafeGetDouble(reader, 13)
                modelo.usuarioI = SafeGetString(reader, 14)
                modelo.fechaI = SafeGetDate(reader, 15)
                modelo.usuarioM = SafeGetString(reader, 16)
                modelo.fechaM = SafeGetDate(reader, 17)
                modelo.stockMin = SafeGetInt(reader, 18)
            End While

            reader.Close()
            con.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Function
End Class

