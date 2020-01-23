Imports Inventor
Imports Autodesk.iLogic.Interfaces

Module ILogicHelpers

    Public ThisApplication As Inventor.Application = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application")
    Public ThisDoc As ICadDoc = New CadDoc(ThisApplication.ActiveDocument)
    Public ThisDrawing As ICadDrawing = New CadDrawing(ThisApplication.ActiveDocument)
    Public ActiveSheet As ICadDrawingSheet = New CadDrawingSheet()



End Module
