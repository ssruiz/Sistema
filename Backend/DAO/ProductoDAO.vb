Imports MySql.Data.MySqlClient

Public Class ProductoDAO
    Dim con As New MySqlConnection
    Public Function getProductos() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadoproductos"
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

    ' Guarda un nuevo producto en la DB
    Public Sub guardar(ByVal modelo As Producto)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            ', `prodEsp`
            Dim query As String = "INSERT INTO `productos` (`prodCodigo`, `prodTipo`, `prodDesc`, `prodColor`, `prodAlto`, `prodAncho`, `prodSup`, `prodPA`, `prodPB`, `prodPC`, `prodPD`, `prodUI`, `prodFi`, `prodUU`, `prodFU`, `prodSM`, `prodTipoPl`,`prodEsp`,`prodCosto`, `prodIva`) VALUES (@codigo, @tipo, @desc, @color, @alto, @ancho, @superf, @pa, @pb, @pc, @pd, @userI, @fecha, @userI, @fecha, @stockm,@tpl,@espe,@costo,@iva);"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@codigo", modelo.codigo)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            cmd.Parameters.AddWithValue("@color", modelo.color)
            cmd.Parameters.AddWithValue("@pa", modelo.PrecioA)
            cmd.Parameters.AddWithValue("@pb", modelo.PrecioB)
            cmd.Parameters.AddWithValue("@pc", modelo.PrecioC)
            cmd.Parameters.AddWithValue("@pd", modelo.PrecioD)
            cmd.Parameters.AddWithValue("@userI", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@espe", modelo.espesor)
            cmd.Parameters.AddWithValue("@costo", modelo.costo)
            cmd.Parameters.AddWithValue("@iva", modelo.iva)

            'cmd.Parameters.AddWithValue("@fe", modelo.alto)
            'cmd.Parameters.AddWithValue("@alto", modelo.alto)

            If modelo.tipoPL <> 0 Then
                cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
                cmd.Parameters.AddWithValue("@alto", modelo.alto)
                cmd.Parameters.AddWithValue("@ancho", modelo.ancho)
                cmd.Parameters.AddWithValue("@superf", modelo.superficie)
                cmd.Parameters.AddWithValue("@stockm", modelo.stockMin)
            Else
                cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
                cmd.Parameters.AddWithValue("@alto", DBNull.Value)
                cmd.Parameters.AddWithValue("@ancho", DBNull.Value)
                cmd.Parameters.AddWithValue("@superf", DBNull.Value)
                cmd.Parameters.AddWithValue("@stockm", DBNull.Value)
            End If
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
            Dim query As String = "DELETE FROM `productos` WHERE `prodCod` = @id;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub update(ByVal modelo As Producto)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            '`prodEsp` = @esp,
            Dim query = "UPDATE `productos` SET `prodCodigo` = @cod, `prodTipo` = @tipo, `prodDesc` = @desc, `prodColor` = @color,  `prodAlto` = @alto, `prodAncho` = @ancho, `prodSup` = @sup, `prodPA` = @pa, `prodPB` = @pb, `prodPC` = @pc, `prodPD` = @pd, `prodUU` = @user, `prodFU` = @fecha, `prodSM` = @stm, `prodTipoPl` = @tpl, `prodEsp` = @esp, `prodCosto` = @costo, `prodIva`= @iva WHERE `prodCod` = @id;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", modelo.id)
            cmd.Parameters.AddWithValue("@cod", modelo.codigo)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            cmd.Parameters.AddWithValue("@color", modelo.color)
            cmd.Parameters.AddWithValue("@esp", modelo.espesor)
            ' cmd.Parameters.AddWithValue("@pl", modelo.tipoPL)

            cmd.Parameters.AddWithValue("@pa", modelo.PrecioA)
            cmd.Parameters.AddWithValue("@pb", modelo.PrecioB)
            cmd.Parameters.AddWithValue("@pc", modelo.PrecioC)
            cmd.Parameters.AddWithValue("@pd", modelo.PrecioD)
            cmd.Parameters.AddWithValue("@user", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@costo", modelo.costo)
            cmd.Parameters.AddWithValue("@iva", modelo.iva)

            If modelo.tipoPL <> 0 Then
                cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
                cmd.Parameters.AddWithValue("@alto", modelo.alto)
                cmd.Parameters.AddWithValue("@ancho", modelo.ancho)
                cmd.Parameters.AddWithValue("@sup", modelo.superficie)
                cmd.Parameters.AddWithValue("@stm", modelo.stockMin)
            Else
                cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
                cmd.Parameters.AddWithValue("@alto", DBNull.Value)
                cmd.Parameters.AddWithValue("@ancho", DBNull.Value)
                cmd.Parameters.AddWithValue("@sup", DBNull.Value)
                cmd.Parameters.AddWithValue("@stm", DBNull.Value)
            End If
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getProducto(ByVal id As String) As Producto
        Try
            Dim modelo As New Producto
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
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
                modelo.costo = SafeGetDouble(reader, 19)
                modelo.iva = SafeGetInt(reader, 20)
            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function getProductoByCod(ByVal id As String) As Producto
        Try
            Dim modelo As New Producto
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from productos where prodCodigo = @codigo"
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
                modelo.costo = SafeGetDouble(reader, 19)
                modelo.iva = SafeGetInt(reader, 20)
            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function getStock(ByVal id As String) As Integer
        Dim stock = 0
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from vstockproductos where Cod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                stock = SafeGetInt(reader, 2)
            End While
            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return stock
    End Function

    Public Function getStocks() As DataSet
        Dim stock = 0
        Dim ds As New DataSet
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from vstockproductosdet"
            Dim cmd As New MySqlCommand(query, con)
            Dim adp As New MySqlDataAdapter(query, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getStockSucursal(ByVal id As String, ByVal sucursal As Integer, ByVal depo As Integer) As Integer
        Dim stock = 0
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select Stock from vstockproductossuc where IDP = @id and IDS = @suc and IDD= @depo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@suc", sucursal)
            cmd.Parameters.AddWithValue("@depo", depo)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                stock = SafeGetInt(reader, 0)
            End While
            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return stock
    End Function
End Class

