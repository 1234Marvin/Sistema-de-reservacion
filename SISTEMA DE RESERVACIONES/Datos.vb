Public Class Datos
    Dim usuario As String
    Dim contraseña As String
    Dim tipo As String


    Public Property gusuario()
        Get
            Return usuario
        End Get
        Set(ByVal value)
            usuario = value
        End Set
    End Property

    Public Property gcontraseña
        Get
            Return contraseña
        End Get
        Set(ByVal value)
            contraseña = value
        End Set
    End Property
    Public Property gtipo()
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property



    Public Sub New(ByVal usuario As String, ByVal contraseña As String, ByVal tipo As String)

        Me.gusuario = contraseña
        Me.gcontraseña = tipo
        Me.gtipo = usuario
    End Sub






End Class
