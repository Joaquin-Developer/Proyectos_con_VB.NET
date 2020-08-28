Public Class Gerente
    Inherits Empleado

    Property _nivel As Integer

    Public Sub New()

    End Sub

    Public Sub New(cedula As Integer,
                    primer_nombre As String,
                    segundo_nombre As String,
                    primer_apellido As String,
                    segundo_apellido As String,
                    tipo As String,
                    sueldo As Double, nivel As Integer)

        Me.Cedula = cedula
        _primer_nombre = primer_nombre
        _segundo_nombre = segundo_nombre
        _primer_apellido = primer_apellido
        _segundo_apellido = segundo_apellido
        _tipo = tipo
        _sueldo = sueldo
        _nivel = nivel

    End Sub

    Public Overloads Sub CalcularSueldo()

        _sueldo = (_sueldo * _nivel) * 1.8

    End Sub




End Class
