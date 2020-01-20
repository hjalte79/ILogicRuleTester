# ILogicRuleTester
I write a lot of iLogic rules. Mostly examples for people on the [autodesk Inventor customization forum](https://forums.autodesk.com/t5/inventor-customization/bd-p/120). The editor that you find in Inventor is not that great when you are used to work in Visual Studio. That is why i created a Visual Studio project that i can use to write i logic code. 

## Project goal
My goal is to make a project that helps me create iLogic code that i can copy directly into Inventor. 

## setup.
This project need refrences to the folowwing dll's:
 - C:\Program Files\Autodesk\Inventor 2018\Bin\Autodesk.iLogic.dll
 - C:\Program Files\Autodesk\Inventor 2018\Bin\Autodesk.iLogic.CommonUI.dll 
 - C:\Program Files\Autodesk\Inventor 2018\Bin\Autodesk.iLogic.Interfaces.dll
 - C:\Program Files\Autodesk\Inventor 2018\Bin\Public Assemblies\Autodesk.Inventor.Interop.dll

This are the default paths. In the solution other paths are used. You need to set the references to your own installation paths.
(probably the default paths as mentioned above)

## How to use.
Start writing your code in the module "ILogicStartModule" in the sub "Main()"

**At this moment only the following iLogic helper properties/functions are available:**
 - ThisApplication As Inventor.Application
 - ThisDoc As ICadDoc
   - Document As Document
 - ThisDrawing As ICadDrawing
   - Sheet(sheetName As String) As ICadDrawingSheet
   - ActiveSheet As ICadDrawingSheet
   - Document As DrawingDocument
 - ActiveSheet As ICadDrawingSheet
   - Sheet As Sheet
   - View(viewName As String) As ICadDrawingView
** At this moment i added implementations for the intrefaces:**
 - ICadDrawingView
   - View As DrawingView
 I would like to add also functions for Parameter() but i did not manage that yet. If you want to help on this projetct then send a pull request.

**Other functions that i use regularly:**

| Function  | Parameters  | returns | description |
| --------- | ----------- | ------- | ----------- |
|showtInventorObjectType| obj As Object | Nothing | Shows messagebox with the inventor object type|

## Event logger
For some projects it's helpfull to log which events are triggerd. There for i created a very simple logger.
see the project "InventorEventTester" in this solution.
** The following events are logged **
 - ApplicationEvents
   - OnActivateDocument
   - OnDocumentChange
   - OnNewDocument
   - OnOpenDocument
 - DocumentEvents (only events from the document that was active when the program was started)
   - OnChange
   - OnChangeSelectSet