Public Class Cliente
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _limiteC As Double
    Public Property limiteC() As Double
        Get
            Return _limiteC
        End Get
        Set(ByVal value As Double)
            _limiteC = value
        End Set
    End Property

    Private _precioDefault As Char
    Public Property precioDefault() As Char
        Get
            Return _precioDefault
        End Get
        Set(ByVal value As Char)
            _precioDefault = value
        End Set
    End Property

    Private _tipo As Integer
    Public Property tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property

    Private _ci As String
    Public Property ci() As String
        Get
            Return _ci
        End Get
        Set(ByVal value As String)
            _ci = value
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

    Private _dir As String
    Public Property dir() As String
        Get
            Return _dir
        End Get
        Set(ByVal value As String)
            _dir = value
        End Set
    End Property

    Private _cel As String
    Public Property cel() As String
        Get
            Return _cel
        End Get
        Set(ByVal value As String)
            _cel = value
        End Set
    End Property

    Private _telf As String
    Public Property telf() As String
        Get
            Return _telf
        End Get
        Set(ByVal value As String)
            _telf = value
        End Set
    End Property


    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property


    Private _ruc As String
    Public Property ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
        End Set
    End Property

    Private _vendedor As Integer
    Public Property vendedor() As Integer
        Get
            Return _vendedor
        End Get
        Set(ByVal value As Integer)
            _vendedor = value
        End Set
    End Property

    Private _responsable As String
    Public Property responsable() As String
        Get
            Return _responsable
        End Get
        Set(ByVal value As String)
            _responsable = value
        End Set
    End Property

    Private _usuI As String
    Public Property usuI() As String
        Get
            Return _usuI
        End Get
        Set(ByVal value As String)
            _usuI = value
        End Set
    End Property

    Private _fechaI As Date
    Public Property fechaI() As Date
        Get
            Return _fechaI
        End Get
        Set(ByVal value As Date)
            _fechaI = value
        End Set
    End Property

    Private _usuU As String
    Public Property usuU() As String
        Get
            Return _usuU
        End Get
        Set(ByVal value As String)
            _usuU = value
        End Set
    End Property

    Private _fechaU As Date
    Public Property fechaU() As Date
        Get
            Return _fechaU
        End Get
        Set(ByVal value As Date)
            _fechaU = value
        End Set
    End Property

    Private _saldo As Double
    Public Property saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
        End Set
    End Property


    Private _sucursal As Integer
    Public Property sucursal() As Integer
        Get
            Return _sucursal
        End Get
        Set(ByVal value As Integer)
            _sucursal = value
        End Set
    End Property
End Class
