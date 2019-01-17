Public Class Sucursal
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _deposito As Integer
    Public Property deposito() As Integer
        Get
            Return _deposito
        End Get
        Set(ByVal value As Integer)
            _deposito = value
        End Set
    End Property
End Class
