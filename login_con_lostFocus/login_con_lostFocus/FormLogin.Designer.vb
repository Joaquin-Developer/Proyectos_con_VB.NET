<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtNombreUsr = New System.Windows.Forms.TextBox()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.lblNotificacionUsr = New System.Windows.Forms.Label()
        Me.lblNotificacionPsw = New System.Windows.Forms.Label()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(12, 32)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 70)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtNombreUsr
        '
        Me.txtNombreUsr.Location = New System.Drawing.Point(80, 29)
        Me.txtNombreUsr.Name = "txtNombreUsr"
        Me.txtNombreUsr.Size = New System.Drawing.Size(190, 20)
        Me.txtNombreUsr.TabIndex = 2
        '
        'txtPasswd
        '
        Me.txtPasswd.Location = New System.Drawing.Point(80, 67)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.Size = New System.Drawing.Size(190, 20)
        Me.txtPasswd.TabIndex = 3
        '
        'lblNotificacionUsr
        '
        Me.lblNotificacionUsr.AutoSize = True
        Me.lblNotificacionUsr.ForeColor = System.Drawing.Color.Red
        Me.lblNotificacionUsr.Location = New System.Drawing.Point(121, 51)
        Me.lblNotificacionUsr.Name = "lblNotificacionUsr"
        Me.lblNotificacionUsr.Size = New System.Drawing.Size(149, 13)
        Me.lblNotificacionUsr.TabIndex = 4
        Me.lblNotificacionUsr.Text = "Nombre de Usuario Incorrecto"
        '
        'lblNotificacionPsw
        '
        Me.lblNotificacionPsw.AutoSize = True
        Me.lblNotificacionPsw.ForeColor = System.Drawing.Color.Red
        Me.lblNotificacionPsw.Location = New System.Drawing.Point(158, 90)
        Me.lblNotificacionPsw.Name = "lblNotificacionPsw"
        Me.lblNotificacionPsw.Size = New System.Drawing.Size(112, 13)
        Me.lblNotificacionPsw.TabIndex = 5
        Me.lblNotificacionPsw.Text = "Contraseña Incorrecta"
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.Location = New System.Drawing.Point(15, 106)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(255, 23)
        Me.btnInicioSesion.TabIndex = 6
        Me.btnInicioSesion.Text = "Login"
        Me.btnInicioSesion.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 166)
        Me.Controls.Add(Me.btnInicioSesion)
        Me.Controls.Add(Me.lblNotificacionPsw)
        Me.Controls.Add(Me.lblNotificacionUsr)
        Me.Controls.Add(Me.txtPasswd)
        Me.Controls.Add(Me.txtNombreUsr)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Name = "FormLogin"
        Me.Text = "Inicio de Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtNombreUsr As TextBox
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents lblNotificacionUsr As Label
    Friend WithEvents lblNotificacionPsw As Label
    Friend WithEvents btnInicioSesion As Button
End Class
