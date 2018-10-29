Public MustInherit Class Cliente
    Private _cuenta As UInteger
    Private _lineas As List(Of Linea)

    Sub New(cuenta As UInteger)
        Me.Cuenta = cuenta
    End Sub

    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property

    Public Sub addLinea(linea As Linea)
        _lineas.Add(linea)
    End Sub

    Public Sub removeLinea(linea As Linea)
        _lineas.Remove(linea)
    End Sub

    Private Function getAllLineas() As List(Of Linea)
        Return _lineas
    End Function

End Class
