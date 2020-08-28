Imports System

Module Program
    Sub Main(args As String())
        Dim num1, num2, division, resto As Double
        Console.WriteLine("====== División de dos números ======")
        Do
            Console.WriteLine("Ingrese primer numero:")
            num1 = Console.ReadLine()
            Console.WriteLine("Ingrese segundo numero:")
            num2 = Console.ReadLine()
            If num2.Equals(0.0) Then
                Console.WriteLine("Error: No se puede dividir entre cero.")
            Else
                division = num1 / num2
                resto = num1 Mod num2
                Console.WriteLine("Operación realizada : " & num1 & " / " & num2)
                Console.WriteLine("Resultado = " & division)
                Console.WriteLine("Resto = " & resto)
            End If
        Loop While (num2 = 0.0)
        Console.ReadLine()
    End Sub
End Module
