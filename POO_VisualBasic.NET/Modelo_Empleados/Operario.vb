Public Class Operario : Inherits Empleado

    Property _horas_extras As Double
    Property _valor_hora As Double


    Public Sub New()

    End Sub


    ' SOBRECARGA
    Public Sub New(cedula As Integer,
                    primer_nombre As String,
                    segundo_nombre As String,
                    primer_apellido As String,
                    segundo_apellido As String,
                    tipo As String,
                    sueldo As Double, horas_ext As Double,
                    valor_hora As Double)

        Me.Cedula = cedula
        _primer_nombre = primer_nombre
        _segundo_nombre = segundo_nombre
        _primer_apellido = primer_apellido
        _segundo_apellido = segundo_apellido
        _tipo = tipo
        _sueldo = sueldo
        _horas_extras = horas_ext
        _valor_hora = valor_hora

    End Sub

    Public Overloads Sub CalcularSueldo()

        _sueldo = (_sueldo + (_horas_extras * _valor_hora)) * 1.2

    End Sub

End Class
