Imports Inventor
Imports Autodesk.iLogic.Interfaces
Imports Autodesk.iLogic.Automation
Imports Autodesk.iLogic.Runtime

Module ILogicStartModule

    Sub Main()

        ThisApplication = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application")
        ThisDoc = New CadDoc(ThisApplication.ActiveDocument)

        If (ThisDoc.Document.DocumentType = DocumentTypeEnum.kDrawingDocumentObject) Then
            ThisDrawing = New CadDrawing(ThisApplication.ActiveDocument, ThisApplication)
            ActiveSheet = New CadDrawingSheet(CType(ThisDrawing, CadDrawing), ThisDrawing.ActiveSheet.Sheet, ThisApplication)
        End If

        Dim rule As ThisRule = New ThisRule()
        rule.Main()

    End Sub

End Module
