Public Class Vehiculo
    ' Atributos:
    Private marca As String
    Private modelo As String
    Private anio As Integer

    ' Constructor completo:
    Public Sub New(marca As String, modelo As String, anio As Integer)
        Me.marca = marca
        Me.modelo = modelo
        Me.anio = anio

    End Sub
    ' constructor por defecto:
    Public Sub New()
        marca = "x"
        modelo = "x"
        anio = 2000
    End Sub
    ' Propiedades (Getters y Setters):
    Public Property propMarca As String
        Get
            Return marca
        End Get
        Set(entrada As String)
            marca = entrada
        End Set
    End Property
    Public Property propModelo As String
        Get
            Return modelo
        End Get
        Set(entrada As String)
            modelo = entrada
        End Set
    End Property
    Public Property propAnio As Integer
        Get
            Return anio
        End Get
        Set(entrada As Integer)
            anio = entrada
        End Set
    End Property

    Public Sub modificarMarca()

    End Sub
    Public Sub eliminarVehiculo()

    End Sub
    Public Sub mostrarDatos()

    End Sub

End Class
