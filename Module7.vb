Module Module7
    Sub main()
        Dim basico, bonificacion, remuneracion As Integer
        Dim categoria, nombre As String

        Console.WriteLine(" BONIFICACION EMPLEADO ")
        Console.WriteLine("-------------------------------- ")

        Console.Write(" NOMBRE: ")
        nombre = Console.ReadLine()

        Console.Write("CATEGORIA: ")
        categoria = Console.ReadLine()


        Select Case categoria
            Case Is = "EMPLEADO"
                basico = 600
                bonificacion = 150
                remuneracion = basico + bonificacion
            Case Is = "OBRERO"
                basico = 550
                bonificacion = 190
                remuneracion = basico + bonificacion
            Case Is = "EJECUTIVO"
                basico = 1500
                bonificacion = 500
                remuneracion = basico + bonificacion
            Case Is = "AUXILIAR"
                basico = 200
                bonificacion = 50
                remuneracion = basico + bonificacion
        End Select
        Console.WriteLine("----------------------------------")
        Console.WriteLine("    NOMBRE: " & nombre & "        |")
        Console.WriteLine("    REMUNERACION: " & remuneracion & "|")
        Console.WriteLine("    BONIFICACION:  " & bonificacion & "         |")
        Console.WriteLine("----------------------------------")
        Console.Read()
    End Sub
End Module
