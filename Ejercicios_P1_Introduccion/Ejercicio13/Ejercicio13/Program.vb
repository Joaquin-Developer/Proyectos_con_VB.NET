Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("=== TRI�NGULOS ===")
        Dim l1, l2, l3 As Integer
        Dim tipo As String
        Console.WriteLine("Ingrese primer lado del tri�ngulo: ")
        l1 = Console.ReadLine()
        Console.WriteLine("Ingrese segundo lado del tri�ngulo: ")
        l2 = Console.ReadLine()
        Console.WriteLine("Ingrese terc�r lado del tri�ngulo: ")
        l3 = Console.ReadLine()
        If l1 = l2 And l1 = l3 Then
            tipo = "equil�tero"
        ElseIf l1 <> l2 And l1 <> l3 Then
            tipo = "escaleno"
        Else
            tipo = "is�sceles"
        End If
        Console.WriteLine("El tri�ngulo es " & tipo)
        Console.ReadLine()
    End Sub
End Module
