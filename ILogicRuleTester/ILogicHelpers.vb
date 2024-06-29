Imports Inventor
Imports Autodesk.iLogic.Interfaces
Imports Autodesk.iLogic.Runtime
Imports Autodesk.iLogic.Core

Public Module ILogicHelpers

    Public ThisApplication As Inventor.Application
    Public ThisDoc As ICadDoc
    Public ThisDrawing As ICadDrawing
    Public ActiveSheet As ICadDrawingSheet
    Public iProperties As IiProperties
    Private uof As UnitsOfMeasure
    Public Measure As ICadMeasure

    Public Property Parameter(name As String) As Object
        Get
            Dim param As Parameter = getParameter(name)
            Dim value = param.Value
            Try
                value = uof.ConvertUnits(
                    param.Value,
                    uof.GetTypeFromString(
                        uof.GetDatabaseUnitsFromExpression(param.Expression, param.Units)),
                    param.Units)
            Catch ex As Exception

            End Try

            Return value
        End Get
        Set(value As Object)
            getParameter(name).Expression = value
        End Set
    End Property

    Public Sub setUnitsOfMeasure()

        Dim doc As Document = ThisDoc.Document
        If (doc.DocumentType = DocumentTypeEnum.kPartDocumentObject) Then
            uof = doc.UnitsOfMeasure
        ElseIf (doc.DocumentType = DocumentTypeEnum.kAssemblyDocumentObject) Then
            uof = doc.UnitsOfMeasure
        End If

    End Sub

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
