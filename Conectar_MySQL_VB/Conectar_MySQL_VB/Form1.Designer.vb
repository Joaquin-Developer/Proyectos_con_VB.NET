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
        Me.btnConexion = New System.Windows.Forms.Button()
        Me.btnConsultaDatos = New System.Windows.Forms.Button()
        Me.dgvPersonas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConexion
        '
        Me.btnConexion.Location = New System.Drawing.Point(12, 38)
        Me.btnConexion.Name = "btnConexion"
        Me.btnConexion.Size = New System.Drawing.Size(299, 38)
        Me.btnConexion.TabIndex = 0
        Me.btnConexion.Text = "Conectar a MySQL"
        Me.btnConexion.UseVisualStyleBackColor = True
        '
        'btnConsultaDatos
        '
        Me.btnConsultaDatos.Location = New System.Drawing.Point(317, 38)
        Me.btnConsultaDatos.Name = "btnConsultaDatos"
        Me.btnConsultaDatos.Size = New System.Drawing.Size(440, 38)
        Me.btnConsultaDatos.TabIndex = 1
        Me.btnConsultaDatos.Text = "traer datos y cargar DataGridView"
        Me.btnConsultaDatos.UseVisualStyleBackColor = True
        '
        'dgvPersonas
        '
        Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonas.Location = New System.Drawing.Point(12, 96)
        Me.dgvPersonas.Name = "dgvPersonas"
        Me.dgvPersonas.Size = New System.Drawing.Size(745, 317)
        Me.dgvPersonas.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvPersonas)
        Me.Controls.Add(Me.btnConsultaDatos)
        Me.Controls.Add(Me.btnConexion)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConexion As Button
    Friend WithEvents btnConsultaDatos As Button
    Friend WithEvents dgvPersonas As DataGridView
End Class
