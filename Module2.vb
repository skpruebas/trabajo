Module Module2
    Sub Main()

        Dim ARA, U, D, C, M As Integer
        Dim MU, MD, MC, MM As String

        MU = ""
        MD = ""
        MC = ""
        MM = ""

        Console.WriteLine("-- NUMEROS ROMANOS --")
        Console.Write("Ingrese numero para convertir : ")
        ARA = Console.ReadLine()

        U = ARA Mod 10
        D = (ARA \ 10) Mod 10
        C = ((ARA \ 10) \ 10) Mod 10
        M = ((ARA \ 10) \ 10) \ 10

        Select Case (M)
            Case 0 : MM = " "
            Case 1 : MM = "M"
            Case 2 : MM = "MM"
            Case 3 : MM = "MMM"
        End Select

        Select Case (C)
            Case 0 : MC = " "
            Case 1 : MC = "C"
            Case 2 : MC = "CC"
            Case 3 : MC = "CCC"
            Case 4 : MC = "CD"
            Case 5 : MC = "D"
            Case 6 : MC = "DC"
            Case 7 : MC = "DCC"
            Case 8 : MC = "DCCC"
            Case 9 : MC = "CM"
        End Select

        Select Case (D)
            Case 0 : MD = ""
            Case 1 : MD = "X"
            Case 2 : MD = "XX"
            Case 3 : MD = "XXX"
            Case 4 : MD = "XL"
            Case 5 : MD = "L"
            Case 6 : MD = "LX"
            Case 7 : MD = "LXX"
            Case 8 : MD = "LXXX"
            Case 9 : MD = "XC"
        End Select

        Select Case (U)
            Case 0 : MU = " "
            Case 1 : MU = "I"
            Case 2 : MU = "II"
            Case 3 : MU = "III"
            Case 4 : MU = "IV"
            Case 5 : MU = "V"
            Case 6 : MU = "VI"
            Case 7 : MU = "VII"
            Case 8 : MU = "VIII"
            Case 9 : MU = "IX"
        End Select

        Console.WriteLine("ROMANOS : " & MM & MC & MD & MU)


        Console.Read()
    End Sub
End Module
