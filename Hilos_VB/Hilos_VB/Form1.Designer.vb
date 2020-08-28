<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.progBar = New System.Windows.Forms.ProgressBar()
        Me.lblProgreso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'progBar
        '
        Me.progBar.Location = New System.Drawing.Point(12, 46)
        Me.progBar.Name = "progBar"
        Me.progBar.Size = New System.Drawing.Size(389, 18)
        Me.progBar.TabIndex = 1
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.Location = New System.Drawing.Point(422, 51)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(21, 13)
        Me.lblProgreso.TabIndex = 2
        Me.lblProgreso.Text = "0%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 102)
        Me.Controls.Add(Me.lblProgreso)
        Me.Controls.Add(Me.progBar)
        Me.Name = "Form1"
        Me.Text = "ProgressBar + Thread en VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents progBar As ProgressBar
    Friend WithEvents lblProgreso As Label
End Class
