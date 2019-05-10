Public Class Venta
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

    Private _cliente As Integer
    Public Property cliente() As Integer
        Get
            Return _cliente
        End Get
        Set(ByVal value As Integer)
            _cliente = value
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

    Private _plazo As Integer
    Public Property plazo() As Integer
        Get
            Return _plazo
        End Get
        Set(ByVal value As Integer)
            _plazo = value
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

    Private _descuento As Decimal
    Public Property descuento() As Decimal
        Get
            Return _descuento
        End Get
        Set(ByVal value As Decimal)
            _descuento = value
        End Set
    End Property

    Private _recargo As Decimal
    Public Property recargo() As Decimal
        Get
            Return _recargo
        End Get
        Set(ByVal value As Decimal)
            _recargo = value
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

    Private _envio As Char
    Public Property envio() As Char
        Get
            Return _envio
        End Get
        Set(ByVal value As Char)
            _envio = value
        End Set
    End Property

    Private _direEnv As String
    Public Property direEnv() As String
        Get
            Return _direEnv
        End Get
        Set(ByVal value As String)
            _direEnv = value
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

    Private _m2 As Decimal
    Public Property m2() As Decimal
        Get
            Return _m2
        End Get
        Set(ByVal value As Decimal)
            _m2 = value
        End Set
    End Property

    Private _estadoFactura As Char
    Public Property estadoFactura() As Char
        Get
            Return _estadoFactura
        End Get
        Set(ByVal value As Char)
            _estadoFactura = value
        End Set
    End Property

    Private _plano As String
    Public Property plano() As String
        Get
            Return _plano
        End Get
        Set(ByVal value As String)
            _plano = value
        End Set
    End Property
End Class
