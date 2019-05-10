Public Class Producto

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _codigo As String
    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _color As Integer
    Public Property color() As Integer
        Get
            Return _color
        End Get
        Set(ByVal value As Integer)
            _color = value
        End Set
    End Property

    Private _espesor As Integer
    Public Property espesor() As Integer
        Get
            Return _espesor
        End Get
        Set(ByVal value As Integer)
            _espesor = value
        End Set
    End Property

    Private _tipoPL As Integer
    Public Property tipoPL() As Integer
        Get
            Return _tipoPL
        End Get
        Set(ByVal value As Integer)
            _tipoPL = value
        End Set
    End Property

    Private _alto As Decimal
    Public Property alto() As Decimal
        Get
            Return _alto
        End Get
        Set(ByVal value As Decimal)
            _alto = value
        End Set
    End Property

    Private _ancho As Decimal
    Public Property ancho() As Decimal
        Get
            Return _ancho
        End Get
        Set(ByVal value As Decimal)
            _ancho = value
        End Set
    End Property

    Private _superficie As Decimal
    Public Property superficie() As Decimal
        Get
            Return _superficie
        End Get
        Set(ByVal value As Decimal)
            _superficie = value
        End Set
    End Property

    Private _PrecioA As Double
    Public Property PrecioA() As Double
        Get
            Return _PrecioA
        End Get
        Set(ByVal value As Double)
            _PrecioA = value
        End Set
    End Property

    Private _PrecioB As Double
    Public Property PrecioB() As Double
        Get
            Return _PrecioB
        End Get
        Set(ByVal value As Double)
            _PrecioB = value
        End Set
    End Property

    Private _PrecioC As Double
    Public Property PrecioC() As Double
        Get
            Return _PrecioC
        End Get
        Set(ByVal value As Double)
            _PrecioC = value
        End Set
    End Property

    Private _PrecioD As Double
    Public Property PrecioD() As Double
        Get
            Return _PrecioD
        End Get
        Set(ByVal value As Double)
            _PrecioD = value
        End Set
    End Property

    Private _usuarioI As String
    Public Property usuarioI() As String
        Get
            Return _usuarioI
        End Get
        Set(ByVal value As String)
            _usuarioI = value
        End Set
    End Property

    Private _usuarioM As String
    Public Property usuarioM() As String
        Get
            Return _usuarioM
        End Get
        Set(ByVal value As String)
            _usuarioM = value
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

    Private _fechaM As Date
    Public Property fechaM() As Date
        Get
            Return _fechaM
        End Get
        Set(ByVal value As Date)
            _fechaM = value
        End Set
    End Property

    Private _stockMin As Integer
    Public Property stockMin() As Integer
        Get
            Return _stockMin
        End Get
        Set(ByVal value As Integer)
            _stockMin = value
        End Set
    End Property

    Private _costo As Double
    Public Property costo() As Double
        Get
            Return _costo
        End Get
        Set(ByVal value As Double)
            _costo = value
        End Set
    End Property

    Private _iva As Integer
    Public Property iva() As Integer
        Get
            Return _iva
        End Get
        Set(ByVal value As Integer)
            _iva = value
        End Set
    End Property
End Class
