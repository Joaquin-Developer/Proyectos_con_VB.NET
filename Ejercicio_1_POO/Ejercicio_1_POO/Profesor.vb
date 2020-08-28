Public Class Profesor
    Inherits Persona

    Private asignatura As String

    Public Sub New(nombre As String, edad As Integer, altura As Double, peso As Double, asignatura As String)
        MyBase.New(nombre, edad, altura, peso)
        Me.asignatura = asignatura
    End Sub

    Public Property PropAsignatura As String
        Get
            Return asignatura
        End Get
        Set(value As String)
            asignatura = value
        End Set
    End Property


End Class
