Imports System.Threading

Public Class Form1
    Private Sub cargarPrgBar()
        ' With: serie de instrucciónes que haen referencia a un único objeto o estructura.-
        With progBar
            .Maximum = 100
            .Minimum = 0
            .Value = 0 ' comenzará con el valor Cero
        End With
        lblProgreso.Text = "0%"
        For i As Integer = progBar.Minimum To progBar.Maximum Step 1
            progBar.Value = i
            lblProgreso.Text = progBar.Value & " %"
            Thread.Sleep(2000) ' espera de 2 segundos.
        Next
        MsgBox("Se terminó el proceso", vbInformation, "Mensaje")
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'cargarPrgBar()
        cargarProgressBar()
    End Sub

    Private Sub cargarProgressBar()
        progBar.Minimum = 0
        progBar.Maximum = 100
        progBar.Value = 0

        For i As Integer = progBar.Minimum To progBar.Maximum Step 1

            progBar.Value = i
            lblProgreso.Text = CLng((progBar.Value * 100) / progBar.Maximum) & " %"
            'Thread.Sleep(1000)
        Next


    End Sub

End Class
