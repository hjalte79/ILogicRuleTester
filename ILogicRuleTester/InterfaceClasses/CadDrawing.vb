Imports Inventor
Imports Autodesk.iLogic.Interfaces

Public Class CadDrawing
    Implements ICadDrawing

    Private doc As DrawingDocument
    Public Sub New(document As Document)
        If (document.DocumentType = DocumentTypeEnum.kDrawingDocumentObject) Then
            Me.doc = document
        End If
    End Sub
    Public ReadOnly Property Sheet(sheetName As String) As ICadDrawingSheet Implements ICadDrawing.Sheet
        Get
            For Each item As Sheet In Me.doc.Sheets
                If (item.Name.Equals(sheetName)) Then
                    Return New CadDrawingSheet(item)
                End If
            Next
            Throw New Exception(String.Format("ThisDrawing.Sheet: No sheet named '{0}' was found.", sheetName))
        End Get
    End Property

    Public ReadOnly Property ActiveSheet As ICadDrawingSheet Implements ICadDrawing.ActiveSheet
        Get
            Return New CadDrawingSheet(doc.ActiveSheet)
        End Get
    End Property

    Public Property ResourceFileName As String Implements ICadDrawing.ResourceFileName
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property KeepExtraResources As Boolean Implements ICadDrawing.KeepExtraResources
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Boolean)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property Document As DrawingDocument Implements ICadDrawing.Document
        Get
            Return Me.doc
        End Get
    End Property

    Public ReadOnly Property ModelDocument As Document Implements ICadDrawing.ModelDocument
        Get
            Throw New NotImplementedException()
        End Get
    End Property
End Class
