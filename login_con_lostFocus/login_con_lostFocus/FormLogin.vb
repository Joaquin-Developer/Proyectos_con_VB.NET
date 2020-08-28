Public Class FormLogin

    ' Usuario: Igual a "Joaquin" o "root"
    ' Password: Joaquin: jp1234 | root: root1234

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNotificacionUsr.Visible = False
        lblNotificacionPsw.Visible = False

    End Sub
    Private Sub txtNombreUsr_LostFocus(sender As Object, e As EventArgs) Handles txtNombreUsr.LostFocus
        ' evento foco perdido. txtNombreUsr
        If txtNombreUsr.Text.Equals("Joaquin") Or txtNombreUsr.Text.Equals("root") Then
            lblNotificacionUsr.Visible = False
        Else
            lblNotificacionUsr.Visible = True
        End If

    End Sub
    Private Sub txtPasswd_LostFocus(sender As Object, e As EventArgs) Handles txtPasswd.LostFocus
        Dim usr As String = txtNombreUsr.Text
        Select Case usr
            Case = "Joaquin"
                If txtPasswd.Text.Equals("jp1234") Then
                    lblNotificacionPsw.Visible = False
                Else
                    lblNotificacionPsw.Visible = True
                End If

            Case = "root"
                If txtPasswd.Text.Equals("root1234") Then
                    lblNotificacionPsw.Visible = False
                Else
                    lblNotificacionPsw.Visible = True
                End If

        End Select

    End Sub

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        If lblNotificacionUsr.Visible Or lblNotificacionPsw.Visible Then
            If lblNotificacionUsr.Visible And lblNotificacionPsw.Visible Then
                MsgBox("Usuario y contraseña son incorrectas", vbCritical, "Error")
            ElseIf lblNotificacionUsr.Visible And Not (lblNotificacionPsw.Visible) Then
                MsgBox("Usuario incorrecto", vbCritical, "Error")
            Else
                MsgBox("Contraseña incorrecta", vbCritical, "Error")
            End If
        Else
            MsgBox("Iniciando sesión...", vbInformation, "Login")
        End If
    End Sub
End Class
