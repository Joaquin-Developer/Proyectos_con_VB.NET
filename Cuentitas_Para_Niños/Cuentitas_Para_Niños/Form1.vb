
Public Class Form1
    Public gamer, signo, ultimoSigno As String
    Public num1, num2, totalMal, totalBien, acumErrores, puntuacFinal, nroRonda As Integer
    ' <>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do
            gamer = InputBox("Ingrese nombre del Jugador:", "Aprender Cuentitas - El Juego")
            If (gamer.Length = 0) Then
                MsgBox("Debe ingresarse nombre del jugador.", vbCritical, "Error")
            End If
        Loop While (gamer.Length = 0) ' se repite siempre que tamaño del string sea cero.
        MsgBox("Que comienze el juego, " & gamer & "!!", vbInformation, "Mensaje")
        ' carga del Form1(Main) ...
        lblNombreJug.Text = gamer
        lblRonda.Text = "Ronda 1 de 10"
        nroRonda = 1 ' inicializamos
        signo = "+"
        generarAleatorios()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            Dim respuesta As Integer
            If txtRespuesta.Text.Length = 0 Then
                MsgBox("Debe indicar una respuesta.", vbCritical, "Mensaje.")
            ElseIf Integer.TryParse(txtRespuesta.Text, respuesta) Then ' si se logró convertir
                eventoRespuesta(respuesta)
                If nroRonda > 10 Then
                    puntuacFinal = (100 * totalBien) / 10
                    If puntuacFinal >= 60 Then
                        reproducirSonido(6)
                    Else
                        reproducirSonido(7)
                    End If
                    Dim mensaje As String = gamer & ", TU PUNTUACIÓN FINAL ES: " & puntuacFinal & "/100"
                    MsgBox(mensaje, vbInformation, "¡FIN DEL JUEGO!")
                    Dim i As Integer
                    i = MsgBox("¿Desea jugar otra ronda?", vbQuestion + vbYesNo, "Mensaje")
                    Select Case i
                        Case 6
                            totalBien = 0
                            totalMal = 0
                            acumErrores = 0
                            signo = "+"
                            puntuacFinal = 0
                            nroRonda = 1
                            lblRonda.Text = "Ronda " & nroRonda & " de 10"
                            lblTotalBien.Text = "BIEN: " & totalBien
                            lblTotalMal.Text = "MAL: " & totalMal
                            generarAleatorios()
                        Case 7
                            MsgBox("Bye", vbEmpty, "Mensaje")
                            Me.Close()
                    End Select
                Else
                    lblRonda.Text = "Ronda " & nroRonda & " de 10"
                    generarAleatorios()
                End If
            Else
                MsgBox("Se debe ingresar un numero como respuesta.", vbCritical, "Mensaje")
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error:" & ex.Message, vbCritical, "Mensaje")
        End Try
    End Sub
    Private Sub generarAleatorios()
        Dim random As New Random()
        Do
            num1 = random.Next(1, 12)
            num2 = random.Next(1, 12)
            signo = generarSigno()
        Loop While validarTodo() = False
        ultimoSigno = signo
        lblNum1.Text = num1
        lblNum2.Text = num2
        lblSigno.Text = signo

    End Sub
    Private Function generarSigno() As String
        Dim sig As String
        If ultimoSigno = Nothing Then
            sig = "+"
        ElseIf ultimoSigno.Equals("+") Then
            sig = "-"
        Else
            sig = "+"
        End If
        Return sig
    End Function

    Private Function validarTodo() As Boolean
        ' devuelve true si todo esta bien, o falso si hay problemas. 
        Dim estado As Boolean = True
        Dim suma As Integer = (num1 + num2)
        Dim resta As Integer = (num1 - num2)
        If signo.Equals("+") And (suma > 15) Then
            estado = False
        ElseIf signo.Equals("-") And (resta < 0) Then
            estado = False
        End If
        Return estado
    End Function
    Private Sub eventoRespuesta(ByVal respuesta As Integer)
        Dim correcta As Integer
        If signo.Equals("+") Then
            correcta = num1 + num2
        Else
            correcta = num1 - num2
        End If
        If correcta.Equals(respuesta) Then
            ' si responde bien
            If acumErrores >= 2 Then
                ' bien despues de muchos errores
                totalBien += 1
                acumErrores = 0 ' se deja de acumular errores
                lblTotalBien.Text = "BIEN: " & totalBien
                reproducirSonido(5)
            Else
                totalBien += 1
                acumErrores = 0 ' se deja de acumular errores
                lblTotalBien.Text = "BIEN: " & totalBien
                Dim s As Integer = CInt(Math.Floor((2) * Rnd())) + 1 ' aleatorio entre 1 y 2
                reproducirSonido(s)
            End If
        Else
            ' si responde mal
            totalMal += 1
            acumErrores += 1
            lblTotalMal.Text = "MAL: " & totalMal
            Dim s As Integer = CInt(Math.Floor((2) * Rnd())) + 3 'aleatorio entre 3 y 4
            reproducirSonido(s)
        End If
        nroRonda += 1
        txtRespuesta.Text = ""
    End Sub

    Private Sub reproducirSonido(ByVal tipo As Integer)
        Try
            'Dim sound As System.Media.SoundPlayer
            Select Case tipo
                Case 1
                    'sonido acierto1
                    My.Computer.Audio.Play(My.Resources.bien1, AudioPlayMode.WaitToComplete)
                Case 2
                    'sonido acierto2
                    My.Computer.Audio.Play(My.Resources.bien2, AudioPlayMode.WaitToComplete)
                Case 3
                    'sonido mal1
                    My.Computer.Audio.Play(My.Resources.mal1, AudioPlayMode.WaitToComplete)
                Case 4
                    'sonido mal2
                    My.Computer.Audio.Play(My.Resources.mal2, AudioPlayMode.WaitToComplete)
                Case 5
                    ' sonido bien despues de muchas
                    My.Computer.Audio.Play(My.Resources.bienDespuesDeMuchas, AudioPlayMode.WaitToComplete)
                Case 6
                    ' sonido victoria
                    My.Computer.Audio.Play(My.Resources.victory, AudioPlayMode.WaitToComplete)
                Case 7
                    ' sonido derrota
                    My.Computer.Audio.Play(My.Resources.gameOver, AudioPlayMode.WaitToComplete)
            End Select
        Catch ex As Exception
            MsgBox("Se produjo un error.", vbCritical, "Error.")
        End Try
    End Sub

End Class
