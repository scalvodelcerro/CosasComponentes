Imports System.IO
Imports System.Xml.Serialization

Public Class UsuarioRepository

  Private data As DataRoot
  Private Const XML_PATH As String = "usuarios.xml"

  Public Sub New()
    If File.Exists(XML_PATH) Then
      Dim xs As XmlSerializer = New XmlSerializer(GetType(DataRoot))
      Using fs As FileStream = New FileStream(XML_PATH, FileMode.Open)
        data = xs.Deserialize(fs)
      End Using
    Else
      data = New DataRoot With {
        .Usuarios = New List(Of Usuario)()
      }
      InsertarUsuariosIniciales()
    End If
  End Sub

  Public Function ObtenerUsuarios() As IEnumerable(Of Usuario)
    Return data.Usuarios
  End Function

  Public Sub GuardarUsuario(usuario As Usuario)
    data.Usuarios.Add(usuario)

    Dim xs As XmlSerializer = New XmlSerializer(GetType(DataRoot))

    Using fs As FileStream = New FileStream(XML_PATH, FileMode.Create)
      xs.Serialize(fs, Me.data)
    End Using
  End Sub

  Private Sub InsertarUsuariosIniciales()
    For index = 1 To 10
      Dim usuario = New Usuario() With {
        .Nombre = "Usuario " & index,
        .Cargo = "Cargo " & index,
        .Nivel = "Nivel " & index
      }

      Me.GuardarUsuario(usuario)
    Next
  End Sub
End Class

<XmlRoot("data")>
Public Class DataRoot

  <XmlArray("usuarios"), XmlArrayItem(GetType(Usuario), ElementName:="usuario")>
  Public Property Usuarios As List(Of Usuario)

End Class

<Serializable>
Public Class Usuario
  <XmlAttribute("nombre")>
  Public Property Nombre As String
  <XmlAttribute("cargo")>
  Public Property Cargo As String
  <XmlAttribute("nivel")>
  Public Property Nivel As String
End Class
