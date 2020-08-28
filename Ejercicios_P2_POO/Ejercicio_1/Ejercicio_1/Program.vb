Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("")
        Console.WriteLine("========================================================")
        Console.WriteLine("================== MEN� PRINCIPAL ======================")
        Console.WriteLine("========================================================")
        Dim entrada As Integer
        Dim vehiculo As Vehiculo
        Do
            Console.WriteLine("Elegir una opci�n:")
            Console.WriteLine("1) - Crear un objeto veh�culo por defecto")
            Console.WriteLine("2) - Solicitar los datos de un veh�culo para crear un objeto con datos")
            Console.WriteLine("3) - Modificar la marca del objeto veh�culo, desplegando la actual y solicitando la nueva")
            Console.WriteLine("4) - Eliminar el objeto veh�culo actual")
            Console.WriteLine("5) - Mostrar los datos del objeto veh�culo actual")
            Console.WriteLine("0) - Salir.")
            entrada = Console.ReadLine()
            Select Case entrada
                Case = 1
                    Dim unVehiculo As New Vehiculo()
                    Console.WriteLine("Se cre� un veh�culo por defecto.")
                Case = 2
                    Dim marca, modelo As String
                    Dim anio As Integer
                    Console.Clear() ' limpiar la consola.
                    Console.WriteLine("Ingresar marca: ")
                    marca = Console.ReadLine()
                    Console.WriteLine("Ingresar modelo:")
                    modelo = Console.ReadLine()
                    Console.WriteLine("Ingresar anio:")
                    anio = Console.ReadLine()
                    Dim unVehiculo As New Vehiculo(marca, modelo, anio)

                Case = 3
                    vehiculo.modificarMarca()
                Case = 4
                    vehiculo.eliminarVehiculo()
                Case = 5
                    vehiculo.mostrarDatos()
                Case = 0
                    Console.Clear()
                    Console.WriteLine("Bye.")
            End Select
        Loop While entrada <> 0









        'Dim unAuto As New Vehiculo("Ford", "Eskere", 1994)


    End Sub


End Module
