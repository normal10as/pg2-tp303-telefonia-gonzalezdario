Imports Entidades

Module LineaTest

    Sub Main()
        Dim l1 As New Linea(3764, 123456)
        Console.WriteLine("Area: " & l1.CodigoArea)
        Console.WriteLine("Numero: " & l1.Numero)
        Console.WriteLine("Linea: " & l1.ToString())

        l1.Suspender()
        Console.WriteLine("Linea: " & l1.ToString())

        l1.Reactivar()
        Console.WriteLine("Linea: " & l1.ToString())
    End Sub

End Module
