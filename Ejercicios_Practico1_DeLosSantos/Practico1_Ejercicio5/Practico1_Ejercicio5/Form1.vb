Public Class Form1
    Private textoTxtUsr_defecto As String = "Nombre de Usuario"

    '<Author("Joaquín Parrilla", Version:=1.1)>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContrasenia.PasswordChar = "*"   'por defecto no se visualizará la contraseña
        txtUsuario.Text = textoTxtUsr_defecto
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsuario.Text.Length = 0 Or txtContrasenia.Text.Length = 0 Then
            ' en caso de quedar campos vacíos 
            MsgBox("Faltan datos por ingresar", vbCritical, "Error")
        Else
            If txtUsuario.Text.Length >= 5 And txtUsuario.Text.Length <= 9 Then
                Dim p As Integer
                If Not (Integer.TryParse(txtContrasenia.Text, p)) Then
                    MsgBox("La contraseña debe tener únicamente números", vbCritical, "Error: Contraseña inválida.")
                Else
                    MsgBox("Bienvenido " & txtUsuario.Text, vbInformation, "Login")
                End If
            Else
                MsgBox("El nombre de Usuario debe tener entre 5 y 9 carácteres.", vbCritical, "Error: Nombre de usuario inválido")
            End If
        End If

    End Sub
    Private Sub CheckBoxMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrar.CheckedChanged
        If CheckBoxMostrar.Checked Then
            txtContrasenia.PasswordChar = ""
        Else
            txtContrasenia.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        ' evento se enfocó
        txtUsuario.ForeColor = Color.Black

        If txtUsuario.Text.Equals(textoTxtUsr_defecto) Or txtUsuario.Text.Equals("Debe ingresar nombre") Then
            'no es la primera vez que se carga el Form
            txtUsuario.Text = ""
        End If

    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        ' evento pierde foco
        If txtUsuario.Text.Length = 0 Then
            txtUsuario.Text = "Debe ingresar nombre"
            txtUsuario.ForeColor = Color.Red
        End If

    End Sub






    ' ****************************************************************************************************

    ' solución al problema del Foco al cargar formulario:
    ' ponerle TabIndex=0 a un elemento distinto (en este caso al btnLogin)
    ' de esta forma, el btnLogin tendrá prioridad de foco
    ' y al momento de cargar el Form tendrá dicho foco.

    ' ****************************************************************************************************

End Class
