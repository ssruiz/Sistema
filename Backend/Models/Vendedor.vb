Public Class Vendedor
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

    Private _celular As String
    Public Property celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property

    Private _porcentaje As Decimal
    Public Property porcentaje() As Decimal
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Decimal)
            _porcentaje = value
        End Set
    End Property
End Class
