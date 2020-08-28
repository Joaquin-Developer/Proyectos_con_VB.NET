<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblSigno = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblEsIgual = New System.Windows.Forms.Label()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblRonda = New System.Windows.Forms.Label()
        Me.lblTotalBien = New System.Windows.Forms.Label()
        Me.lblTotalMal = New System.Windows.Forms.Label()
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.lblNombreJug = New System.Windows.Forms.Label()
        Me.lblDesarrollador = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Cuánto es?"
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(126, 81)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(64, 45)
        Me.lblNum1.TabIndex = 1
        Me.lblNum1.Text = "12"
        Me.lblNum1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSigno
        '
        Me.lblSigno.AutoSize = True
        Me.lblSigno.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigno.Location = New System.Drawing.Point(187, 81)
        Me.lblSigno.Name = "lblSigno"
        Me.lblSigno.Size = New System.Drawing.Size(43, 45)
        Me.lblSigno.TabIndex = 2
        Me.lblSigno.Text = "+"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(220, 81)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(64, 45)
        Me.lblNum2.TabIndex = 3
        Me.lblNum2.Text = "12"
        '
        'lblEsIgual
        '
        Me.lblEsIgual.AutoSize = True
        Me.lblEsIgual.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsIgual.Location = New System.Drawing.Point(290, 81)
        Me.lblEsIgual.Name = "lblEsIgual"
        Me.lblEsIgual.Size = New System.Drawing.Size(43, 45)
        Me.lblEsIgual.TabIndex = 4
        Me.lblEsIgual.Text = "="
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta.Location = New System.Drawing.Point(339, 78)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(100, 53)
        Me.txtRespuesta.TabIndex = 5
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnOk.Location = New System.Drawing.Point(469, 74)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 52)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblRonda
        '
        Me.lblRonda.AutoSize = True
        Me.lblRonda.Location = New System.Drawing.Point(12, 9)
        Me.lblRonda.Name = "lblRonda"
        Me.lblRonda.Size = New System.Drawing.Size(78, 13)
        Me.lblRonda.TabIndex = 7
        Me.lblRonda.Text = "Ronda 0 de 10"
        '
        'lblTotalBien
        '
        Me.lblTotalBien.AutoSize = True
        Me.lblTotalBien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBien.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTotalBien.Location = New System.Drawing.Point(12, 31)
        Me.lblTotalBien.Name = "lblTotalBien"
        Me.lblTotalBien.Size = New System.Drawing.Size(51, 13)
        Me.lblTotalBien.TabIndex = 8
        Me.lblTotalBien.Text = "BIEN: 0"
        '
        'lblTotalMal
        '
        Me.lblTotalMal.AutoSize = True
        Me.lblTotalMal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMal.ForeColor = System.Drawing.Color.Red
        Me.lblTotalMal.Location = New System.Drawing.Point(12, 54)
        Me.lblTotalMal.Name = "lblTotalMal"
        Me.lblTotalMal.Size = New System.Drawing.Size(47, 13)
        Me.lblTotalMal.TabIndex = 9
        Me.lblTotalMal.Text = "MAL: 0"
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador.Location = New System.Drawing.Point(131, 9)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(56, 13)
        Me.lblJugador.TabIndex = 10
        Me.lblJugador.Text = "Jugador:"
        '
        'lblNombreJug
        '
        Me.lblNombreJug.AutoSize = True
        Me.lblNombreJug.Location = New System.Drawing.Point(198, 9)
        Me.lblNombreJug.Name = "lblNombreJug"
        Me.lblNombreJug.Size = New System.Drawing.Size(86, 13)
        Me.lblNombreJug.TabIndex = 11
        Me.lblNombreJug.Text = "nombre_Jugador"
        '
        'lblDesarrollador
        '
        Me.lblDesarrollador.AutoSize = True
        Me.lblDesarrollador.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesarrollador.Location = New System.Drawing.Point(1, 214)
        Me.lblDesarrollador.Name = "lblDesarrollador"
        Me.lblDesarrollador.Size = New System.Drawing.Size(498, 12)
        Me.lblDesarrollador.TabIndex = 12
        Me.lblDesarrollador.Text = "Desarrollado por Inf. Joaquín Parrilla - © 2020 Todos los derechos reservados. Pr" &
    "ohibida su distribución con fines de lucro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 226)
        Me.Controls.Add(Me.lblDesarrollador)
        Me.Controls.Add(Me.lblNombreJug)
        Me.Controls.Add(Me.lblJugador)
        Me.Controls.Add(Me.lblTotalMal)
        Me.Controls.Add(Me.lblTotalBien)
        Me.Controls.Add(Me.lblRonda)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.lblEsIgual)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblSigno)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Cuentitas - The Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblSigno As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblEsIgual As Label
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents lblRonda As Label
    Friend WithEvents lblTotalBien As Label
    Friend WithEvents lblTotalMal As Label
    Friend WithEvents lblJugador As Label
    Friend WithEvents lblNombreJug As Label
    Friend WithEvents lblDesarrollador As Label
End Class
