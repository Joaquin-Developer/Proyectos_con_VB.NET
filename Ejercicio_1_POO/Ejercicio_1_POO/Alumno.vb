Public Class Alumno
    Inherits Persona

    Private calif As Integer
    Public Sub New(nombre As String, edad As Integer, altura As Double, peso As Double, calif As Integer)
        MyBase.New(nombre, edad, altura, peso)
        Me.calif = calif    ' similar a: this.calif = calif; en JAVA--
    End Sub
    ' Getters y setters: 
    Public Property PropCalif As Integer
        Get
            Return calif
        End Get
        Set(value As Integer)
            calif = value
        End Set
    End Property

End Class
