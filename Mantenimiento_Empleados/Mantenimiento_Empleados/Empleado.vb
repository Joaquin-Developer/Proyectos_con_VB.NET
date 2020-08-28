Public Class Empleado

' Ejemplo de POO en VB.NET

    Private cedula As Integer
    Private primerNombre As String
    Private segundoNombre As String    
    Private primerApellido As String
    Private segundoApellido As String
    Private sueldoBase As Double
    Private tipoEmpleado As String
    

    ' Const. completo:
    Public Sub New(cedula As Integer, primerNombre As String, segundoNombre As String, primerApellido As String,
                   segundoApellido As String, sueldoBase As Double, tipoEmpleado As String)
        Me.cedula = cedula
        Me.primerNombre = primerNombre
        Me.segundoNombre = segundoNombre
        Me.primerApellido = primerApellido
        Me.segundoApellido = segundoApellido
        Me.sueldoBase = sueldoBase
        Me.tipoEmpleado = tipoEmpleado

    End Sub

    'Getters y Setters:
    Public Property propCedula() As Integer
        Get
            Return cedula
        End Get
        Set(ByVal value As Integer)
            cedula = value
        End Set
    End Property
    Public Property propPrimerNombre() As String
        Get
            Return primerNombre
        End Get
        Set(ByVal value As String)
            primerNombre = value
        End Set
    End Property
    Public Property propSegNombre() As String
        Get
            Return segundoNombre
        End Get
        Set(ByVal value As String)
            segundoNombre = value
        End Set
    End Property
    Public Property propPrimerApellido() As String
        Get
            Return primerApellido
        End Get
        Set(ByVal value As String)
            primerApellido = value
        End Set
    End Property
    Public Property propSegApellido() As String
        Get
            Return segundoApellido
        End Get
        Set(ByVal value As String)
            segundoApellido = value
        End Set
    End Property
    Public Property propSueldoBase() As Double
        Get
            Return sueldoBase
        End Get
        Set(ByVal value As Double)
            sueldoBase = value
        End Set
    End Property
    Public Property propTipoEmpleado() As String
        Get
            Return tipoEmpleado
        End Get
        Set(ByVal value As String)
            tipoEmpleado = value
        End Set
    End Property

    'Public Overrides Function toString() As String
    '    Return ""
    'End Function

    Public Function mostrarDatos() As String
        Return "Cedula: " & propCedula() & "" & vbCrLf _
            & "Primer Nombre: " & propPrimerNombre() & "" & vbCrLf _
            & "Segundo Nombre: " & propSegNombre() & vbCrLf _
            & "Primer Apellido: " & propPrimerApellido() & vbCrLf _
            & "Segundo Apellido: " & propSegApellido() & vbCrLf _
            & "Sueldo Base: " & propSueldoBase() & vbCrLf _
            & "Tipo de Empleado: " & propTipoEmpleado()
    End Function

End Class
