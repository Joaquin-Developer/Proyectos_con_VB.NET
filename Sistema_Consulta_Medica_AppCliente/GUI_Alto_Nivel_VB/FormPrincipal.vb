Imports System.Runtime.InteropServices ' para arrastrar formulario
' librerías importadas #########################################

Public Class FormPrincipal

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub pnlBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlBarraTitulo.MouseMove
        ' movimiento de panel Barra título con mouse
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub picBoxCerrar_Click(sender As Object, e As EventArgs) Handles picBoxCerrar.Click
        ' al hacer click en el pictureBox
        Application.Exit()
    End Sub

    Private Sub picBoxCerrar_MouseEnter(sender As Object, e As EventArgs) Handles picBoxCerrar.MouseEnter
        ' mouse encima del pictureBox
        picBoxCerrar.Image = My.Resources.iconoCerrarMouseEncima
    End Sub
    Private Sub picBoxCerrar_MouseLeave(sender As Object, e As EventArgs) Handles picBoxCerrar.MouseLeave
        ' mouse sale del pictureBox
        picBoxCerrar.Image = My.Resources.iconoCerrar
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        ' minimizar formulario
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AbrirForm_pnlVerForms(Of MiForm As {Form, New})()
        Dim unForm As Form ' objeto referencia del tipo Form.-
        unForm = pnlVerForms.Controls.OfType(Of MiForm)().FirstOrDefault()

        If unForm Is Nothing Then
            ' en caso que no exista instancia de unForm
            unForm = New MiForm() ' se crea una instancia
            unForm.TopLevel = False
            unForm.FormBorderStyle = FormBorderStyle.None ' quitar borde al formulario
            unForm.Dock = DockStyle.Fill ' acomodar al tamañodel panel
            pnlVerForms.Controls.Add(unForm)
            pnlVerForms.Tag = unForm
            unForm.Show()
            unForm.BringToFront()
        Else
            ' caso de que exista una instancia de formulario unForm
            unForm.BringToFront() ' la traemos al frente: "Bring to front" xd
        End If
    End Sub

    Private Sub btnVerForm1_Click(sender As Object, e As EventArgs) Handles btnVerForm1.Click
        'cerrarFormularios("Formulario1")
        btnVerForm1.BackColor = Color.FromArgb(12, 61, 92)
        btnVerForm2.BackColor = Color.FromArgb(0, 0, 94)
        btnVerForm3.BackColor = Color.FromArgb(0, 0, 94)
        AbrirForm_pnlVerForms(Of Formulario1)()
    End Sub

    Private Sub btnVerForm2_Click(sender As Object, e As EventArgs) Handles btnVerForm2.Click
        'cerrarFormularios("Formulario2")
        btnVerForm1.BackColor = Color.FromArgb(0, 0, 94)
        btnVerForm2.BackColor = Color.FromArgb(12, 61, 92)
        btnVerForm3.BackColor = Color.FromArgb(0, 0, 94)
        AbrirForm_pnlVerForms(Of Formulario2)()
    End Sub

    Private Sub btnVerForm3_Click(sender As Object, e As EventArgs) Handles btnVerForm3.Click
        'cerrarFormularios()
        btnVerForm1.BackColor = Color.FromArgb(0, 0, 94)
        btnVerForm2.BackColor = Color.FromArgb(0, 0, 94)
        btnVerForm3.BackColor = Color.FromArgb(12, 61, 92)
        'AbrirForm_pnlVerForms(Of Formulario3)() hay que crear un fomr 3-
    End Sub

    Private Sub cerrarFormularios(ByVal nombreForm As String)
        ' método para cerrar todos los forms, antes de abrir uno nuevo.
        Try
            If Application.OpenForms IsNot Nothing Then
                ' solo se ejecuta en caso de que no este vacia la coleccion de forms abiertos.
                For Each unForm As Form In Application.OpenForms
                    If unForm.Name <> nombreForm And unForm.Name <> "FormPrincipal" Then
                        unForm.Close()
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub



End Class
