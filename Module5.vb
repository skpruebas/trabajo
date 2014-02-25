Module Module5
    Sub main()
        Dim costo As Integer
        Dim nivel, participante, nombre As String

        Console.WriteLine(" RECIBO DE CURSO DE PROGRAMACION ")
        Console.WriteLine("-------------------------------- ")

        Console.WriteLine(" NOMBRE:")
        nombre = Console.ReadLine()

        Console.WriteLine("PARTICIPANTE (PROFESOR/ALUMNO/EXTERNO) ")
        participante = Console.ReadLine()

        Console.WriteLine("NIVEL: ")
        nivel = Console.ReadLine()

        Select Case participante
            Case Is = "PROFESOR"
                If (nivel = "BASICO") Then
                    costo = 50
                End If
                If (nivel = "INTERMEDIO") Then
                    costo = 70
                End If
                If (nivel = "AVANZADO") Then
                    costo = 100
                End If
            Case Is = "ALUMNO"
                If (nivel = "BASICO") Then
                    costo = 40
                End If
                If (nivel = "INTERMEDIO") Then
                    costo = 50
                End If
                If (nivel = "AVANZADO") Then
                    costo = 80
                End If
            Case Is = "EXTERNO"
                If (nivel = "BASICO") Then
                    costo = 70
                End If
                If (nivel = "INTERMEDIO") Then
                    costo = 100
                End If
                If (nivel = "AVANZADO") Then
                    costo = 120
                End If

        End Select
        Console.WriteLine("----------------------------------")
        Console.WriteLine("    NOMBRE: " & nombre & "        |")
        Console.WriteLine("    COSTO DEL CURSO: " & costo & "|")
        Console.WriteLine("    NIVEL:  " & nivel & "         |")
        Console.WriteLine("----------------------------------")
        Console.Read()
    End Sub
End Module
