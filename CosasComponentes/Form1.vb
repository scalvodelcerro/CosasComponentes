Public Class Form1
  Public Sub New()
    InitializeComponent()

    For index = 1 To 10
      Dim userControl = New UsuarioUserControl()
      userControl.LblNombre.Text = "Usuario " & index
      userControl.LblPuesto.Text = "Puesto " & index
      userControl.LblNivel.Text = "Nivel " & index

      PnlUsuarios.Controls.Add(userControl)
    Next
  End Sub
End Class
