Public Class ColoresMenu
    Inherits ProfessionalColorTable
    Public Overrides ReadOnly Property MenuItemSelected() As System.Drawing.Color
        Get
            Return Color.FromArgb(255, 64, 34)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin() As System.Drawing.Color
        Get
            Return Color.FromArgb(175, 28, 2)
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd() As System.Drawing.Color
        Get
            Return Color.FromArgb(175, 28, 2)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin() As System.Drawing.Color
        Get
            Return Color.FromArgb(170, 26, 0)
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemPressedGradientEnd() As System.Drawing.Color
        Get
            Return Color.FromArgb(170, 26, 0)
        End Get
    End Property
End Class