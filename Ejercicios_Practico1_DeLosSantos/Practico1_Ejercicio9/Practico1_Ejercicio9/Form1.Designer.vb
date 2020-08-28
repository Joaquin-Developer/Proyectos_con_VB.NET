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
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.NumericOpDuwnNumero = New System.Windows.Forms.NumericUpDown()
        Me.btnMostrarTabla = New System.Windows.Forms.Button()
        Me.listBoxTabla = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.NumericOpDuwnNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(12, 40)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(59, 16)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Número:"
        '
        'NumericOpDuwnNumero
        '
        Me.NumericOpDuwnNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericOpDuwnNumero.Location = New System.Drawing.Point(77, 38)
        Me.NumericOpDuwnNumero.Name = "NumericOpDuwnNumero"
        Me.NumericOpDuwnNumero.Size = New System.Drawing.Size(40, 22)
        Me.NumericOpDuwnNumero.TabIndex = 1
        '
        'btnMostrarTabla
        '
        Me.btnMostrarTabla.Location = New System.Drawing.Point(142, 37)
        Me.btnMostrarTabla.Name = "btnMostrarTabla"
        Me.btnMostrarTabla.Size = New System.Drawing.Size(286, 23)
        Me.btnMostrarTabla.TabIndex = 2
        Me.btnMostrarTabla.Text = "Mostrar Tabla"
        Me.btnMostrarTabla.UseVisualStyleBackColor = True
        '
        'listBoxTabla
        '
        Me.listBoxTabla.FormattingEnabled = True
        Me.listBoxTabla.Location = New System.Drawing.Point(77, 78)
        Me.listBoxTabla.Name = "listBoxTabla"
        Me.listBoxTabla.Size = New System.Drawing.Size(269, 290)
        Me.listBoxTabla.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(353, 416)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(353, 78)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 451)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.listBoxTabla)
        Me.Controls.Add(Me.btnMostrarTabla)
        Me.Controls.Add(Me.NumericOpDuwnNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "Form1"
        Me.Text = "Tablas de Multiplicar"
        CType(Me.NumericOpDuwnNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents NumericOpDuwnNumero As NumericUpDown
    Friend WithEvents btnMostrarTabla As Button
    Friend WithEvents listBoxTabla As ListBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
End Class
