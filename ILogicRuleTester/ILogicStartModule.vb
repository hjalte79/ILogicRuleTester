Imports Inventor
Imports Autodesk.iLogic.Runtime
Imports iLogic

Module ILogicStartModule

    Sub Main()

        ThisApplication = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application")
        ThisDoc = New CadDoc(ThisApplication.ActiveDocument)

        Dim h As iLogic.StylesInEnglishHandler = New iLogic.StylesInEnglishHandler()
        iProperties = New iLogic.CadPropertiesInRule(ThisApplication.ActiveDocument, h)


        If (ThisDoc.Document.DocumentType = DocumentTypeEnum.kDrawingDocumentObject) Then
            ThisDrawing = New CadDrawing(ThisApplication.ActiveDocument, ThisApplication)
            ActiveSheet = New CadDrawingSheet(CType(ThisDrawing, CadDrawing), ThisDrawing.ActiveSheet.Sheet, ThisApplication)
        End If

        Measure = New CadMeasure(ThisDoc.Document, ThisApplication)

        setUnitsOfMeasure()
        iLogicVb.LoadiLogicAddin()

        Diagnostics.Debug.WriteLine("---------------------- Start rule ---------------------")

        Dim rule As ThisRule = New ThisRule()
        rule.Main()

        Diagnostics.Debug.WriteLine("----------------------- End rule ----------------------")
    End Sub

End Module
