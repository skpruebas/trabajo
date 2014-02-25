Module Module6
    Sub Main()
        Dim dia, mes, anio, dias_mes As Integer
        Dim men, bisiesto As String
        men = ""
        bisiesto = ""
        Console.WriteLine("-- AÑO BISIESTO --")

        Console.WriteLine("-- INGRESE DIA: ")
        dia = Console.ReadLine()

        Console.WriteLine("-- INGRESE MES: ")
        mes = Console.ReadLine()

        Console.WriteLine("-- INGRESE AÑO: ")
        anio = Console.ReadLine()

        Select Case mes
            Case 1 : men = "enero"
            Case 2 : men = "febrero"
            Case 3 : men = "marzo"
            Case 4 : men = "abril"
            Case 5 : men = "mayo"
            Case 6 : men = "junio"
            Case 7 : men = "julio"
            Case 8 : men = "agosto"
            Case 9 : men = "septiembre"
            Case 10 : men = "octubre"
            Case 11 : men = "noviembre"
            Case 12 : men = "diciembre"
            Case Else : Console.WriteLine("ERROR")
        End Select

        If (anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0) Then
            bisiesto = "bisiesto"
        Else
            bisiesto = "nobisiesto"
        End If

        If (men = "septiembre" Or men = "abril" Or men = "junio" Or men = "noviembre") Then
            dias_mes = 30
        Else

            If (men = "febrero" And bisiesto = "bisisesto") Then
                dias_mes = 29
            Else

                If (bisiesto = "nobisiesto") Then
                    dias_mes = 28
                Else

                    dias_mes = 31
                End If
            End If
        End If



        Console.WriteLine("Mes " & men & " Dias: " & dias_mes & " Año " & bisiesto)

        Console.Read()
    End Sub
End Module
