Imports System.Xml
Imports System.Xml.Serialization

Public Class XmlUtils
  Public Shared Function Serializar(Of T)(obj As T) As XElement
    Dim xs As XmlSerializer = New XmlSerializer(GetType(T))
    Dim doc As XDocument = New XDocument()
    Using xw As XmlWriter = doc.CreateWriter()
      xs.Serialize(xw, obj)
      xw.Close()
    End Using
    Return doc.Root
  End Function
End Class
