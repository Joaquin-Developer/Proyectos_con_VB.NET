Imports System

Module Program
    Sub Main(args As String())

        Dim velocidad, tiempo, distRecorrida As Double

        Console.WriteLine("**********************************************************")
        Console.WriteLine("****************** CALCULO DE VELOCIDAD ******************")
        Console.WriteLine("**********************************************************")
        Console.WriteLine("Presione una tecla para continuar . . . ")
        Console.ReadLine()
        Console.Clear()

        Try
            Console.WriteLine("Ingresar la velocidad de movil en Km/h :")
            velocidad = Console.ReadLine()
            Console.WriteLine("Ingresar el tiempo en horas:")
            tiempo = Console.ReadLine()
            If velocidad = Nothing Or tiempo = Nothing Then
                Console.Error.WriteLine("Debe imgresar todos los datos solicitados.")
            ElseIf velocidad <= 0 Or tiempo <= 0 Then
                Console.Error.WriteLine("Datos con errores: los datos ingresados no pueden ser negativos o cero")
            Else
                distRecorrida = (velocidad * tiempo)
                Console.WriteLine("")
                Console.WriteLine("**********************************************************")
                Console.WriteLine("DISTANCIA RECORRIDA = " & distRecorrida.ToString)
                Console.WriteLine("**********************************************************")
            End If

        Catch ex As Exception
            Console.Error.WriteLine("Se produjo un error: " & ex.Message)
        Finally
            Console.ReadLine() ' finalización
        End Try

    End Sub
End Module
