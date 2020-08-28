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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lBoxNombres = New System.Windows.Forms.ListBox()
        Me.btnVaciarLista = New System.Windows.Forms.Button()
        Me.btnEliminarElemento = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Nombres:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(335, 20)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(59, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(270, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 25)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lBoxNombres
        '
        Me.lBoxNombres.FormattingEnabled = True
        Me.lBoxNombres.Location = New System.Drawing.Point(12, 75)
        Me.lBoxNombres.Name = "lBoxNombres"
        Me.lBoxNombres.Size = New System.Drawing.Size(329, 212)
        Me.lBoxNombres.TabIndex = 1
        '
        'btnVaciarLista
        '
        Me.btnVaciarLista.Location = New System.Drawing.Point(347, 75)
        Me.btnVaciarLista.Name = "btnVaciarLista"
        Me.btnVaciarLista.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciarLista.TabIndex = 2
        Me.btnVaciarLista.Text = "Vaciar lista"
        Me.btnVaciarLista.UseVisualStyleBackColor = True
        '
        'btnEliminarElemento
        '
        Me.btnEliminarElemento.Location = New System.Drawing.Point(347, 104)
        Me.btnEliminarElemento.Name = "btnEliminarElemento"
        Me.btnEliminarElemento.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarElemento.TabIndex = 3
        Me.btnEliminarElemento.Text = "Eliminar"
        Me.btnEliminarElemento.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(347, 290)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 315)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminarElemento)
        Me.Controls.Add(Me.btnVaciarLista)
        Me.Controls.Add(Me.lBoxNombres)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Lista de Nombres"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lBoxNombres As ListBox
    Friend WithEvents btnVaciarLista As Button
    Friend WithEvents btnEliminarElemento As Button
    Friend WithEvents btnSalir As Button
End Class
