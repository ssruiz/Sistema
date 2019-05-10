Public Class Compra
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _operacion As Integer
    Public Property operacion() As Integer
        Get
            Return _operacion
        End Get
        Set(ByVal value As Integer)
            _operacion = value
        End Set
    End Property

    Private _credito As Char
    Public Property credito() As Char
        Get
            Return _credito
        End Get
        Set(ByVal value As Char)
            _credito = value
        End Set
    End Property

    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _factura As String
    Public Property factura() As String
        Get
            Return _factura
        End Get
        Set(ByVal value As String)
            _factura = value
        End Set
    End Property

    Private _obs As String
    Public Property obs() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property

    Private _proveedor As Integer
    Public Property proveedor() As Integer
        Get
            Return _proveedor
        End Get
        Set(ByVal value As Integer)
            _proveedor = value
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

    Private _sucursal As Integer
    Public Property sucursal() As Integer
        Get
            Return _sucursal
        End Get
        Set(ByVal value As Integer)
            _sucursal = value
        End Set
    End Property


    Private _fechaP As Date
    Public Property fechaP() As Date
        Get
            Return _fechaP
        End Get
        Set(ByVal value As Date)
            _fechaP = value
        End Set
    End Property


    Private _fechaA As Date
    Public Property fechaA() As Date
        Get
            Return _fechaA
        End Get
        Set(ByVal value As Date)
            _fechaA = value
        End Set
    End Property

    Private _excenta As Decimal
    Public Property excenta() As Decimal
        Get
            Return _excenta
        End Get
        Set(ByVal value As Decimal)
            _excenta = value
        End Set
    End Property

    Private _iva5 As Decimal
    Public Property iva5() As Decimal
        Get
            Return _iva5
        End Get
        Set(ByVal value As Decimal)
            _iva5 = value
        End Set
    End Property

    Private _iva10 As Decimal
    Public Property iva10() As Decimal
        Get
            Return _iva10
        End Get
        Set(ByVal value As Decimal)
            _iva10 = value
        End Set
    End Property

    Private _total As Double
    Public Property total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
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


    Private _estado As Char
    Public Property estado() As Char
        Get
            Return _estado
        End Get
        Set(ByVal value As Char)
            _estado = value
        End Set
    End Property

    Private _motivo As String
    Public Property motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
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

End Class
