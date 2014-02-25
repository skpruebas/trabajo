Module Module4
    Sub main()
        Dim numero_hijos, haber_basico As Integer
        Dim estado_civil As String
        Dim bonificacion As Double

        haber_basico = 750

        Console.WriteLine("INGRESE ESTADO CIVIL: ")
        estado_civil = Console.ReadLine()

        Console.WriteLine("INGRESE NUMERO DE HIJOS: ")
        numero_hijos = Console.ReadLine()

        Select Case numero_hijos
            Case Is = 0
                If (estado_civil = "s") Then
                    bonificacion = haber_basico + ((haber_basico * 2.5) / 100)

                ElseIf (estado_civil = "c") Then
                    bonificacion = haber_basico + ((haber_basico * 2.8) / 100)

                ElseIf (estado_civil = "v") Then
                    bonificacion = haber_basico + ((haber_basico * 2.5) / 100)

                ElseIf (estado_civil = "d") Then
                    bonificacion = haber_basico + ((haber_basico * 2.5) / 100)
                End If
            Case Is > 0
                If (estado_civil = "s") Then
                    bonificacion = haber_basico + ((haber_basico * 2.75) / 100)

                ElseIf (estado_civil = "c") Then
                    bonificacion = haber_basico + ((haber_basico * 3) / 100)

                ElseIf (estado_civil = "v") Then
                    bonificacion = haber_basico + ((haber_basico * 2.75) / 100)

                ElseIf (estado_civil = "d") Then
                    bonificacion = haber_basico + ((haber_basico * 3) / 100)
                End If
        End Select
        Console.WriteLine("ESTADO CIVIL: " & estado_civil & " CON " & " HIJOS " & numero_hijos & " BONIFICACION: " & bonificacion)
        Console.Read()
    End Sub
End Module
