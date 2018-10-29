Public Class Dato
    Inherits Servicio

    Sub New(credito As UInteger, precio As Decimal)
        MyBase.Credito = credito
        MyBase.Precio = precio
    End Sub

    Public Overrides Function ToString() As String
        Return Credito & " mbytes "
    End Function

End Class
