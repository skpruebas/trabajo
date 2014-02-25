Module Module3

    Sub Main()
        Dim monto_minimo As Integer
        Dim interes_generado, nuevo_saldo As Double
        Dim plan As String
        plan = ""
        Console.WriteLine("--- BANCO ----")
        Console.WriteLine("INGRESE MONTO:  ")
        monto_minimo = Console.ReadLine()
        Select Case monto_minimo
            Case 1000
                plan = "A"
                interes_generado = monto_minimo * 0.07
                nuevo_saldo = interes_generado + monto_minimo
            Case 1500
                plan = "B"
                interes_generado = monto_minimo * 0.08
                nuevo_saldo = interes_generado + monto_minimo
            Case 2000
                plan = "C"
                interes_generado = monto_minimo * 0.09
                nuevo_saldo = interes_generado + monto_minimo
            Case 2500
                plan = "X"
                interes_generado = monto_minimo * 0.1
                nuevo_saldo = interes_generado + monto_minimo
        End Select
        Console.WriteLine("PLAN: " & plan & " INTERES: " & interes_generado & " NUEVO SALDO: " & nuevo_saldo)
        Console.Read()
    End Sub

End Module
