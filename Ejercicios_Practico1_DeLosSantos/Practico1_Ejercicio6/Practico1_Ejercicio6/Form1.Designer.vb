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
        Me.cBoxPais = New System.Windows.Forms.ComboBox()
        Me.cBoxLocalidad = New System.Windows.Forms.ComboBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cBoxPais
        '
        Me.cBoxPais.FormattingEnabled = True
        Me.cBoxPais.Items.AddRange(New Object() {"Uruguay", "Argentina", "Paraguay", "Chile"})
        Me.cBoxPais.Location = New System.Drawing.Point(110, 24)
        Me.cBoxPais.Name = "cBoxPais"
        Me.cBoxPais.Size = New System.Drawing.Size(121, 21)
        Me.cBoxPais.TabIndex = 0
        '
        'cBoxLocalidad
        '
        Me.cBoxLocalidad.FormattingEnabled = True
        Me.cBoxLocalidad.Location = New System.Drawing.Point(110, 61)
        Me.cBoxLocalidad.Name = "cBoxLocalidad"
        Me.cBoxLocalidad.Size = New System.Drawing.Size(121, 21)
        Me.cBoxLocalidad.TabIndex = 1
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(41, 64)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(56, 13)
        Me.lblLocalidad.TabIndex = 2
        Me.lblLocalidad.Text = "Localidad:"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(41, 27)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(32, 13)
        Me.lblPais.TabIndex = 3
        Me.lblPais.Text = "País:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(236, 118)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(129, 88)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "Aceptar"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 144)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.cBoxLocalidad)
        Me.Controls.Add(Me.cBoxPais)
        Me.Name = "Form1"
        Me.Text = "Países y sus localidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cBoxPais As ComboBox
    Friend WithEvents cBoxLocalidad As ComboBox
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnOk As Button
End Class
