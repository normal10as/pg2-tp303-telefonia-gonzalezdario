Public Class Persona
    Inherits Cliente

    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger

    Sub New()
        Me.Apellido = ""
        Me.Nombre = ""
        Me.Documento = 0
    End Sub

    Sub New(Apellido As String, Nombre As String, Documento As UInteger)
        Me.Apellido = Apellido
        Me.Nombre = Nombre
        Me.Documento = Documento
    End Sub

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _apellido = value
            End If
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 50 Then
                _nombre = value
            End If
        End Set
    End Property

    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Apellido y Nombre: " & Apellido & " " & Nombre & " Cuenta: " & Cuenta
    End Function
End Class
