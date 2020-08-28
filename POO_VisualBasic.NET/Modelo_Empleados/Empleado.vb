Public Class Empleado : Inherits Persona

    Property _tipo As String
    Property _sueldo As Double
    Public Sub New()

    End Sub

    Public Sub New(cedula As Integer,
                    primer_nombre As String,
                    segundo_nombre As String,
                    primer_apellido As String,
                    segundo_apellido As String,
                    tipo As String,
                    sueldo As Double)

        Me.Cedula = cedula
        _primer_nombre = primer_nombre
        _segundo_nombre = segundo_nombre
        _primer_apellido = primer_apellido
        _segundo_apellido = segundo_apellido
        _tipo = tipo
        _sueldo = sueldo

    End Sub

    Public Sub CalcularSueldo()

    End Sub

End Class
