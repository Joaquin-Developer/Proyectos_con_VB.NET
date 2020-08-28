Public Class Persona

    'https://docs.microsoft.com/es-es/dotnet/visual-basic/
    'https://docs.microsoft.com/es-es/dotnet/visual-basic/programming-guide/language-features/procedures/auto-implemented-properties

    'Private Property _cedula As Integer
    Private _cedula As Integer = 0
    Property Cedula As Integer
        Get
            Return _cedula
        End Get
        Set(ByVal value As Integer)
            _cedula = value
        End Set
    End Property

    Property _primer_nombre As String
    Property _segundo_nombre As String
    Property _primer_apellido As String
    Property _segundo_apellido As String

    Public Sub New()

    End Sub

    Public Sub New(cedula As Integer,
                    primer_nombre As String,
                    segundo_nombre As String,
                    primer_apellido As String,
                    segundo_apellido As String)

        _cedula = cedula
        _primer_nombre = primer_nombre
        _segundo_nombre = segundo_nombre
        _primer_apellido = primer_apellido
        _segundo_apellido = segundo_apellido


    End Sub

End Class
