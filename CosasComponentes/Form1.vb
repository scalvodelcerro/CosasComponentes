Public Class Form1
  Private repo As UsuarioRepository = New UsuarioRepository()

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    For Each usuario As Usuario In repo.ObtenerUsuarios
      Dim userControl = New UsuarioUserControl()
      userControl.LblNombre.Text = usuario.Nombre
      userControl.LblPuesto.Text = usuario.Cargo
      userControl.LblNivel.Text = usuario.Nivel

      PnlUsuarios.Controls.Add(userControl)
    Next

  End Sub
End Class
