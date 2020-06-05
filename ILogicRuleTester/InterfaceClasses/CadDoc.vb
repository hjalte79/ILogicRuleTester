Imports Autodesk.iLogic.Interfaces
Imports Inventor

Public Class CadDoc : Implements ICadDoc
    Private _document As Document
    Public Sub New(doc As Document)
        Me._document = doc
    End Sub

    Public ReadOnly Property Path As String Implements ICadDoc.Path
        Get
            Return IO.Path.GetDirectoryName(_document.FullFileName)
        End Get
    End Property

    Public ReadOnly Property FileName(Optional withExtension As Boolean = False) As String Implements ICadDoc.FileName
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property PathAndFileName(Optional withExtension As Boolean = False) As String Implements ICadDoc.PathAndFileName
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Property WorkspacePath As String Implements ICadDoc.WorkspacePath
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property Document As Document Implements ICadDoc.Document
        Get
            Return Me._document
        End Get
    End Property

    Public ReadOnly Property ModelDocument As Document Implements ICadDoc.ModelDocument
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Geometry As IGeometry Implements ICadDoc.Geometry
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property NamedEntities As NamedEntities Implements ICadDoc.NamedEntities
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub Save() Implements ICadDoc.Save
        Throw New NotImplementedException()
    End Sub

    Public Function ChangeExtension(extension As String) As String Implements ICadDoc.ChangeExtension
        Throw New NotImplementedException()
    End Function

    Public Function Launch(fileName As String) As Process Implements ICadDoc.Launch
        Throw New NotImplementedException()
    End Function
End Class
