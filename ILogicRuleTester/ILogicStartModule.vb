Imports Inventor
Imports Autodesk.iLogic.Runtime
Imports iLogic
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports Autodesk.iLogic

Module ILogicStartModule

    Sub Main()
        Try
            ThisApplication = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application")
        Catch ex As Exception
            ' ThisApplication = CreateObject("Inventor.Application")

            Dim type As System.Type = System.Type.GetTypeFromProgID("Inventor.Application")
            ThisApplication = System.Activator.CreateInstance(type)

        End Try
        ThisApplication.Visible = True

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
