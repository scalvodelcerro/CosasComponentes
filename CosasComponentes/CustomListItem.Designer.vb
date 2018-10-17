<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomListItem
  Inherits System.Windows.Forms.UserControl

  'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Dim Label2 As System.Windows.Forms.Label
    Dim Label4 As System.Windows.Forms.Label
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.LblNombre = New System.Windows.Forms.Label()
    Me.LblPuesto = New System.Windows.Forms.Label()
    Me.LblNivel = New System.Windows.Forms.Label()
    Label2 = New System.Windows.Forms.Label()
    Label4 = New System.Windows.Forms.Label()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'LblNombre
    '
    Me.LblNombre.AutoSize = True
    Me.LblNombre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblNombre.Location = New System.Drawing.Point(109, 6)
    Me.LblNombre.Name = "LblNombre"
    Me.LblNombre.Size = New System.Drawing.Size(159, 23)
    Me.LblNombre.TabIndex = 1
    Me.LblNombre.Text = "Nombre del usuario"
    '
    'Label2
    '
    Label2.AutoSize = True
    Label2.Location = New System.Drawing.Point(110, 29)
    Label2.Name = "Label2"
    Label2.Size = New System.Drawing.Size(43, 13)
    Label2.TabIndex = 2
    Label2.Text = "Puesto:"
    '
    'LblPuesto
    '
    Me.LblPuesto.AutoSize = True
    Me.LblPuesto.Location = New System.Drawing.Point(155, 29)
    Me.LblPuesto.Name = "LblPuesto"
    Me.LblPuesto.Size = New System.Drawing.Size(94, 13)
    Me.LblPuesto.TabIndex = 3
    Me.LblPuesto.Text = "Puesto del usuario"
    '
    'Label4
    '
    Label4.AutoSize = True
    Label4.Location = New System.Drawing.Point(110, 42)
    Label4.Name = "Label4"
    Label4.Size = New System.Drawing.Size(34, 13)
    Label4.TabIndex = 4
    Label4.Text = "Nivel:"
    '
    'LblNivel
    '
    Me.LblNivel.AutoSize = True
    Me.LblNivel.Location = New System.Drawing.Point(155, 42)
    Me.LblNivel.Name = "LblNivel"
    Me.LblNivel.Size = New System.Drawing.Size(85, 13)
    Me.LblNivel.TabIndex = 5
    Me.LblNivel.Text = "Nivel del usuario"
    '
    'CustomListItem
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.LblNivel)
    Me.Controls.Add(Label4)
    Me.Controls.Add(Me.LblPuesto)
    Me.Controls.Add(Label2)
    Me.Controls.Add(Me.LblNombre)
    Me.Controls.Add(Me.PictureBox1)
    Me.Name = "CustomListItem"
    Me.Size = New System.Drawing.Size(386, 112)
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents PictureBox1 As PictureBox
  Friend WithEvents LblNombre As Label
  Friend WithEvents LblPuesto As Label
  Friend WithEvents LblNivel As Label
End Class
