Public Class DetalleVenta
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _ventaCod As Integer
    Public Property ventaCod() As Integer
        Get
            Return _ventaCod
        End Get
        Set(ByVal value As Integer)
            _ventaCod = value
        End Set
    End Property

    Private _producto As Integer
    Public Property producto() As Integer
        Get
            Return _producto
        End Get
        Set(ByVal value As Integer)
            _producto = value
        End Set
    End Property

    Private _cantidad As Integer
    Public Property cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
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

    Private _alto As Decimal
    Public Property alto() As Decimal
        Get
            Return _alto
        End Get
        Set(ByVal value As Decimal)
            _alto = value
        End Set
    End Property

    Private _sup As Decimal
    Public Property sup() As Decimal
        Get
            Return _sup
        End Get
        Set(ByVal value As Decimal)
            _sup = value
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

    Private _descuento As Decimal
    Public Property descuento() As Decimal
        Get
            Return _descuento
        End Get
        Set(ByVal value As Decimal)
            _descuento = value
        End Set
    End Property

    Private _precioU As Double
    Public Property precioU() As Double
        Get
            Return _precioU
        End Get
        Set(ByVal value As Double)
            _precioU = value
        End Set
    End Property

    Private _precioR As Double
    Public Property precioR() As Double
        Get
            Return _precioR
        End Get
        Set(ByVal value As Double)
            _precioR = value
        End Set
    End Property

    Private _precioC As Double
    Public Property precioC() As Double
        Get
            Return _precioC
        End Get
        Set(ByVal value As Double)
            _precioC = value
        End Set
    End Property

    Private _obra As String
    Public Property obra() As String
        Get
            Return _obra
        End Get
        Set(ByVal value As String)
            _obra = value
        End Set
    End Property

    Private _desc As String
    Public Property desc() As String
        Get
            Return _desc
        End Get
        Set(ByVal value As String)
            _desc = value
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

    Private _prodCod As String
    Public Property prodCod() As String
        Get
            Return _prodCod
        End Get
        Set(ByVal value As String)
            _prodCod = value
        End Set
    End Property
End Class
