Public Class UsuarioUserControl

  Private Sub UsuarioUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    For Each control As Control In Controls
      AddHandler control.MouseEnter, AddressOf ResaltarFondo
      AddHandler control.MouseLeave, AddressOf ReiniciarFondo
    Next
  End Sub

  Private Sub ResaltarFondo(sender As Object, e As EventArgs) Handles Me.MouseEnter
    Me.BackColor = SystemColors.ControlLight
  End Sub

  Private Sub ReiniciarFondo(sender As Object, e As EventArgs) Handles Me.MouseLeave
    Me.BackColor = SystemColors.Control
  End Sub

End Class
