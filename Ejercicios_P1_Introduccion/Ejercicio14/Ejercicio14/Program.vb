' Ejercicio 14
' Dentro de un proyecto de tipo Consola solicitar el ingreso de las notas de un alumno.
' Estas serán:  3 obligatorios de una puntuación de 0 a 10, una prueba de puntuación de 0
' a 50 y un obligatorio de puntuación de 0 a 20. Se deberá determinar si el alumno va a
' examen(puntuación total de 0 a 69) o exonero el curso (puntuación de 70 a 100).
Imports System
Module Program
    Sub Main(args As String())
        Console.WriteLine("================ Sistema de Calificaciónes ================")
        Console.WriteLine("")
        Dim obl1, obl2, obl3, prueba, oblFinal, califFinal As Integer
        Console.WriteLine("Ingresar calificación de los 3 obligatorios de 10pts c/u :")
        Console.WriteLine("Primer obligatorio (Max 10pts) :")
        obl1 = Console.ReadLine()
        Console.WriteLine("Segundo obligatorio (Max 10pts) :")
        obl2 = Console.ReadLine()
        Console.WriteLine("Tercer obligatorio (Max 10pts) :")
        obl3 = Console.ReadLine()
        Console.WriteLine("Ingresar calificación de Prueba de 50pts :")
        prueba = Console.ReadLine()
        Console.WriteLine("Ingresar calificación del 4to obligatorios de 20pts :")
        oblFinal = Console.ReadLine() ' <>
        If (obl1 > 10) Or (obl2 > 10) Or (obl3 > 10) Or (prueba > 50) Or (oblFinal > 20) Then
            Console.WriteLine("Error: Datos invalidos.")
        Else
            califFinal = obl1 + obl2 + obl3 + prueba + oblFinal
            If califFinal >= 60 Then
                Console.WriteLine("Puntaje acumulado final Total: " & califFinal)
                Console.WriteLine("Fallo final: Exonerado.")
            ElseIf califFinal >= 25 And califFinal < 60 Then
                Console.WriteLine("Puntaje acumulado final Total: " & califFinal)
                Console.WriteLine("Fallo final: Aprobado. Habilitado a examen final.")
            Else
                Console.WriteLine("Puntaje acumulado final Total: " & califFinal)
                Console.WriteLine("Fallo final: No Aprobado. Recursar asignatura.")
            End If
        End If
    End Sub
End Module
