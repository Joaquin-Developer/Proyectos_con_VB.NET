<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CBoxPaises = New System.Windows.Forms.ComboBox()
        Me.lboxLocalidades = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBoxPaises
        '
        Me.CBoxPaises.FormattingEnabled = True
        Me.CBoxPaises.Items.AddRange(New Object() {"Uruguay", "Brasil", "Argentina"})
        Me.CBoxPaises.Location = New System.Drawing.Point(46, 64)
        Me.CBoxPaises.Name = "CBoxPaises"
        Me.CBoxPaises.Size = New System.Drawing.Size(121, 21)
        Me.CBoxPaises.TabIndex = 0
        '
        'lboxLocalidades
        '
        Me.lboxLocalidades.FormattingEnabled = True
        Me.lboxLocalidades.Location = New System.Drawing.Point(254, 64)
        Me.lboxLocalidades.Name = "lboxLocalidades"
        Me.lboxLocalidades.Size = New System.Drawing.Size(120, 95)
        Me.lboxLocalidades.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione un Pais:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Localidades Encontradas:"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 303)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lboxLocalidades)
        Me.Controls.Add(Me.CBoxPaises)
        Me.Name = "Principal"
        Me.Text = "Lista de Paises"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBoxPaises As System.Windows.Forms.ComboBox
    Friend WithEvents lboxLocalidades As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
