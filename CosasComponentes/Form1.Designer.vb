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
    Me.PnlUsuarios = New System.Windows.Forms.FlowLayoutPanel()
    Me.SuspendLayout()
    '
    'PnlUsuarios
    '
    Me.PnlUsuarios.AutoScroll = True
    Me.PnlUsuarios.Location = New System.Drawing.Point(12, 12)
    Me.PnlUsuarios.Name = "PnlUsuarios"
    Me.PnlUsuarios.Size = New System.Drawing.Size(546, 324)
    Me.PnlUsuarios.TabIndex = 0
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.PnlUsuarios)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents PnlUsuarios As FlowLayoutPanel
End Class
