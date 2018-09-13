Public Class Equipo

    Private _serie As String
    Private _fechaVenta As Date

    Sub New()
        Me.Serie = ""
    End Sub

    Sub New(Marca As String, Modelo As String, Serie As String)
        Me.Marca = Marca
        Me.Modelo = Modelo
        Me.Serie = Serie
    End Sub

    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            _serie = value
        End Set
    End Property

    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    Public Sub Vender()
        _fechaVenta = Now.Date()
    End Sub

End Class
