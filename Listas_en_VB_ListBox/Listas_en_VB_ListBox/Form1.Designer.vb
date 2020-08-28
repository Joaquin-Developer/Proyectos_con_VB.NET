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
        Me.lblElemento = New System.Windows.Forms.Label()
        Me.txtElemento = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lBoxLista = New System.Windows.Forms.ListBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblElemento
        '
        Me.lblElemento.AutoSize = True
        Me.lblElemento.Location = New System.Drawing.Point(12, 28)
        Me.lblElemento.Name = "lblElemento"
        Me.lblElemento.Size = New System.Drawing.Size(54, 13)
        Me.lblElemento.TabIndex = 0
        Me.lblElemento.Text = "Elemento:"
        '
        'txtElemento
        '
        Me.txtElemento.Location = New System.Drawing.Point(72, 25)
        Me.txtElemento.Name = "txtElemento"
        Me.txtElemento.Size = New System.Drawing.Size(161, 20)
        Me.txtElemento.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(239, 23)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lBoxLista
        '
        Me.lBoxLista.FormattingEnabled = True
        Me.lBoxLista.Location = New System.Drawing.Point(15, 60)
        Me.lBoxLista.Name = "lBoxLista"
        Me.lBoxLista.Size = New System.Drawing.Size(218, 173)
        Me.lBoxLista.TabIndex = 3
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(239, 60)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 4
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnVaciar
        '
        Me.btnVaciar.Location = New System.Drawing.Point(239, 89)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciar.TabIndex = 5
        Me.btnVaciar.Text = "Vaciar"
        Me.btnVaciar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(15, 239)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 20)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 265)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.lBoxLista)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtElemento)
        Me.Controls.Add(Me.lblElemento)
        Me.Name = "Form1"
        Me.Text = "Listas de Elementos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblElemento As Label
    Friend WithEvents txtElemento As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lBoxLista As ListBox
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents btnCerrar As Button
End Class
