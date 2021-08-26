Imports Inventor
Imports Autodesk.iLogic.Interfaces
Imports Autodesk.iLogic.Runtime
Imports Autodesk.iLogic.Core

Public Module ILogicHelpers

    Public ThisApplication As Inventor.Application
    Public ThisDoc As ICadDoc
    Public ThisDrawing As ICadDrawing
    Public ActiveSheet As ICadDrawingSheet

    Public Property Parameter(name As String) As Object
        Get
            Return getParameter(name).Value
        End Get
        Set(value As Object)
            getParameter(name).Expression = value
        End Set
    End Property

    Private Function getParameter(name As String) As Parameter
        Dim doc As Document = ThisDoc.Document
        If (doc.DocumentType = DocumentTypeEnum.kPartDocumentObject) Then
            Dim pDoc As PartDocument = doc
            Dim def As PartComponentDefinition = pDoc.ComponentDefinition
            Return def.Parameters.Item(name)
        ElseIf (doc.DocumentType = DocumentTypeEnum.kAssemblyDocumentObject) Then
            Dim pDoc As AssemblyDocument = doc
            Dim def As AssemblyComponentDefinition = pDoc.ComponentDefinition
            Return def.Parameters.Item(name)
        Else
            Throw New Exception("Cant get parameter. ThisDoc is not an part or assembly")
        End If
    End Function

End Module
