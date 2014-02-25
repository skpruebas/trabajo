Module Module1

    Sub Main()
        Dim numero, anio As Integer
        Dim mes As String
        anio = 2014
        mes = ""
        Console.WriteLine(" MES DEL AÑO ")
        Console.WriteLine(" ----------- ")
        Console.Write("Ingrese un numero ")
        numero = Console.ReadLine()
        Select Case numero
            Case 1 : mes = "enero"
            Case 2 : mes = "febrero"
            Case 3 : mes = "marzo"
            Case 4 : mes = "abril"
            Case 5 : mes = "mayo"
            Case 6 : mes = "junio"
            Case 7 : mes = "julio"
            Case 8 : mes = "agosto"
            Case 9 : mes = "septiembre"
            Case 10 : mes = "octubre"
            Case 11 : mes = "noviembre"
            Case 12 : mes = "diciembre"
            Case Else : Console.WriteLine("ERROR")
        End Select
        Console.WriteLine(" ----------- ")
        Console.WriteLine("MES: " & mes & " AÑO: " & anio)

        Console.ReadLine()
    End Sub

End Module
