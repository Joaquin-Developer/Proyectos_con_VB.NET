Public Class Persona
    Private nombre As String
    Private edad As Integer
    Private altura, peso As Double  ' declaro dos atributos en una linea sola (ya que son del mismo tipo: Double)
    ' constructores:
    '1) Constructor Completo:
    Public Sub New(nombre As String, edad As Integer, altura As Double, peso As Double)
        Me.nombre = nombre
        Me.edad = edad
        Me.altura = altura
        Me.peso = peso
    End Sub
    '2) Constructor por defecto:
    Public Sub New()
        nombre = ""
        edad = 0
        altura = 0.0
        peso = 0.0
    End Sub
    ' Getters y setters de todos los atributos:
    Public Property PropNombre() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property PropEdad() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property
    Public Property PropAltura() As Double
        Get
            Return altura
        End Get
        Set(value As Double)
            altura = value
        End Set
    End Property
    Public Property PropPeso() As Double
        Get
            Return peso
        End Get
        Set(value As Double)
            peso = value
        End Set
    End Property

    ' Operación con método que muestra todos los datos de la Persona: (similar a toString):
    Public Function mostrarDatos() As String
        Return "Nombre: " & nombre & " | " & "Edad: " & edad & " | " & "Peso: " & peso & " | " & "Altura: " & altura
    End Function

    Public Function esMayor() As Boolean
        If edad >= 18 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function calcImc() As Double
        Dim imc As Double = (peso) / (Math.Pow(altura, 2))
        Return imc
    End Function


End Class
