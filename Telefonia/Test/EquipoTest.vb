Imports Entidades

Module EquipoTest

    Sub Main()
        Dim marca As New Marca("Samsung")
        Dim modelo As New Modelo("S5", marca)
        Dim equipo1 As New Equipo(modelo, "12345")
        equipo1.Vender(Now.AddDays(-16))
        Console.WriteLine("Serie: " & equipo1.Serie)
        Console.WriteLine(equipo1.ToString())
    End Sub

End Module
