Public Class clsThemes
    Public Class DarkBlueThemes
        Public Sub New()
            _BackColor1 = Color.LightBlue
            _BackColor2 = Color.SteelBlue
            ' _ForeColor = Color.DarkGray
        End Sub

        Private _BackColor1 As Color
        Public ReadOnly Property BackColor1() As Color
            Get
                Return _BackColor1
            End Get
        End Property

        Private _BackColor2 As Color
        Public ReadOnly Property BackColor2() As Color
            Get
                Return _BackColor2
            End Get
        End Property

        Private _ForeColor As Color
        Public ReadOnly Property ForeColor() As Color
            Get
                Return _ForeColor
            End Get
        End Property

    End Class

    Public Class LightBlueThemes
        Public Sub New()
            _BackColor1 = Color.LightBlue
            _BackColor2 = Color.SteelBlue
            '_ForeColor = Color.White
        End Sub

        Private _BackColor1 As Color
        Public ReadOnly Property BackColor1() As Color
            Get
                Return _BackColor1
            End Get
        End Property

        Private _BackColor2 As Color
        Public ReadOnly Property BackColor2() As Color
            Get
                Return _BackColor2
            End Get
        End Property

        Private _ForeColor As Color
        Public ReadOnly Property ForeColor() As Color
            Get
                Return _ForeColor
            End Get
        End Property
    End Class
End Class
