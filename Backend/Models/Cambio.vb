Public Class Cambio
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _cambio As Double
    Public Property cambio() As Double
        Get
            Return _cambio
        End Get
        Set(ByVal value As Double)
            _cambio = value
        End Set
    End Property
End Class
