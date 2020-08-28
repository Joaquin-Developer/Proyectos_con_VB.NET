Imports System

Module Main
    Sub Main(args As String())
        Console.Clear() ' limpia la consola

        ' pedimos datos por consola y creamos un objeto:
        Dim nombre As String
        Dim edad As Integer
        Dim altura, peso As Double

        Dim p As New Persona()  ' hago referencia al constructor por defecto

        Dim p2 As New Persona("Pepe", 80, 90.0, 1.7) ' hago referencia al constructor completo.

        Console.WriteLine("Ingrese nombre de la Persona:")
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese edad de " & nombre & " :")
        edad = Console.ReadLine()
        Console.WriteLine("Ingrese Peso de " & nombre & " :")
        peso = Console.ReadLine()
        Console.WriteLine("Ingrese altura de " & nombre & " :")
        altura = Console.ReadLine()
        Dim unaPersona As New Persona(nombre, edad, peso, altura)
        Console.Clear()
        ' mostramos todos los datos del objeto unaPersona:
        Console.WriteLine(unaPersona.mostrarDatos)
        Console.WriteLine() ' imprimimos una línea en blanco.
        If unaPersona.esMayor Then
            Console.WriteLine(unaPersona.PropNombre & " es mayor de edad. Está habilitado a votar.")
            Console.WriteLine("IMC: " & unaPersona.calcImc)
            If unaPersona.calcImc >= 25 Then
                Console.WriteLine("Tiene sobrepeso u obesidad.")
            Else
                Console.WriteLine("Está en condiciones aceptables.")
            End If
        Else
            Console.WriteLine(unaPersona.PropNombre & " es menor de edad. No está habilitado a votar.")
        End If
        Console.ReadLine()  ' para que no finalize de una

    End Sub
End Module
