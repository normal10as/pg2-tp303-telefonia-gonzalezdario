Imports Entidades

Module EquipoTest

    Sub Main()
        Dim e1 As New Equipo("", "", "12345")
        e1.Vender(Now.AddDays(-16))
        Console.WriteLine("Serie: " & e1.Serie)
        Console.WriteLine(e1.ToString())
    End Sub

End Module
