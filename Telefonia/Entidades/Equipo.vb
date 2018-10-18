Public Class Equipo

    Private _modelo As Modelo
    Private _serie As String
    Private _fechaVenta As Date

    Sub New(modelo As Modelo, serie As String)
        Me.Modelo = modelo
        Me.Serie = serie
    End Sub

    Public Property Modelo As Modelo
        Get
            Return _modelo
        End Get
        Set(value As Modelo)
            _modelo = value
        End Set
    End Property

    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 15 Then
                _serie = value
            End If
        End Set
    End Property

    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    Public Sub Vender(fecha As Date)
        _fechaVenta = fecha
    End Sub

    Public Overrides Function ToString() As String
        Return Serie
    End Function

End Class
