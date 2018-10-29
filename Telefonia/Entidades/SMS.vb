Public Class SMS
    Inherits Servicio

    Sub New(credito As UInteger, precio As Decimal)
        MyBase.Credito = credito
        MyBase.Precio = precio
    End Sub

    Public Overrides Function ToString() As String
        Return Credito & " mensajes "
    End Function

End Class
