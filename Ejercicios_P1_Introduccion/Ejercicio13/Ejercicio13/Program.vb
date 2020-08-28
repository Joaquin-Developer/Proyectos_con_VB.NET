Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("=== TRIÁNGULOS ===")
        Dim l1, l2, l3 As Integer
        Dim tipo As String
        Console.WriteLine("Ingrese primer lado del triángulo: ")
        l1 = Console.ReadLine()
        Console.WriteLine("Ingrese segundo lado del triángulo: ")
        l2 = Console.ReadLine()
        Console.WriteLine("Ingrese tercér lado del triángulo: ")
        l3 = Console.ReadLine()
        If l1 = l2 And l1 = l3 Then
            tipo = "equilátero"
        ElseIf l1 <> l2 And l1 <> l3 Then
            tipo = "escaleno"
        Else
            tipo = "isósceles"
        End If
        Console.WriteLine("El triángulo es " & tipo)
        Console.ReadLine()
    End Sub
End Module
