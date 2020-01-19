Imports Inventor
Imports System.Threading

Module Module1
    Private inventor As Inventor.Application
    Private appEvents As ApplicationEvents
    Private docEvents As DocumentEvents

    Sub Main()

        inventor = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application")

        subscribeToApplicationEvents()
        subscribeToDocumentEvents()

        'this will keep the code running long enough to catch the events.
        Console.ReadKey()
    End Sub

#Region "ApplicationEvents"

    Private Sub subscribeToApplicationEvents()
        appEvents = inventor.ApplicationEvents
        AddHandler appEvents.OnActivateDocument, AddressOf AppEvents_OnActivateDocument
        AddHandler appEvents.OnDocumentChange, AddressOf AppEvents_OnDocumentChange
        AddHandler appEvents.OnNewDocument, AddressOf AppEvents_OnNewDocument
        AddHandler appEvents.OnOpenDocument, AddressOf AppEvents_OnOpenDocument
    End Sub

    Private Sub AppEvents_OnOpenDocument(DocumentObject As _Document, FullDocumentName As String, BeforeOrAfter As EventTimingEnum, Context As NameValueMap, ByRef HandlingCode As HandlingCodeEnum)
        HandlingCode = HandlingCodeEnum.kEventNotHandled
        Console.WriteLine(String.Format("AppEvents_OnOpenDocument -> Timing:{0} DocumentName:{1} TopLevelFilename:{2}",
                                        BeforeOrAfter.ToString(),
                                        IO.Path.GetFileName(FullDocumentName),
                                        IO.Path.GetFileName(Context(0))
                                        ))
    End Sub

    Private Sub AppEvents_OnNewDocument(DocumentObject As _Document, BeforeOrAfter As EventTimingEnum, Context As NameValueMap, ByRef HandlingCode As HandlingCodeEnum)
        HandlingCode = HandlingCodeEnum.kEventNotHandled
        Console.WriteLine(String.Format("AppEvents_OnNewDocument -> Timing:{0} TemplateFilename:{1}",
                                        BeforeOrAfter.ToString(),
                                        IO.Path.GetFileName(Context(0))
                                        ))
    End Sub

    Private Sub AppEvents_OnActivateDocument(DocumentObject As _Document, BeforeOrAfter As EventTimingEnum, Context As NameValueMap, ByRef HandlingCode As HandlingCodeEnum)
        HandlingCode = HandlingCodeEnum.kEventNotHandled
        Console.WriteLine(String.Format("AppEvents_OnActivateDocument -> Timing:{0} DocName:{1}",
                                        BeforeOrAfter.ToString(),
                                        DocumentObject.DisplayName
                                        ))
    End Sub

    Private Sub AppEvents_OnDocumentChange(DocumentObject As _Document, BeforeOrAfter As EventTimingEnum, ReasonsForChange As CommandTypesEnum, Context As NameValueMap, ByRef HandlingCode As HandlingCodeEnum)
        HandlingCode = HandlingCodeEnum.kEventNotHandled
        Console.WriteLine(String.Format("AppEvents_OnDocumentChange -> Timing:{0} Reason:{1} internalName:{2}",
                                        BeforeOrAfter.ToString(),
                                        ReasonsForChange.ToString(),
                                        Context(1)
                                        ))
    End Sub
#End Region
#Region "DocumentEvents"
    Private Sub subscribeToDocumentEvents()
        docEvents = inventor.ActiveDocument.DocumentEvents
        AddHandler docEvents.OnChange, AddressOf docEvents_OnChange
        AddHandler docEvents.OnChangeSelectSet, AddressOf docEvents_OnChangeSelectSet
    End Sub
    Private Sub docEvents_OnChange(ReasonsForChange As CommandTypesEnum, BeforeOrAfter As EventTimingEnum, Context As NameValueMap, ByRef HandlingCode As HandlingCodeEnum)
        HandlingCode = HandlingCodeEnum.kEventNotHandled
        Console.WriteLine(String.Format("docEvents_OnChange -> Timing:{0} Reason:{1} internalName:{2}",
                                        BeforeOrAfter.ToString(),
                                        ReasonsForChange.ToString(),
                                        Context(1)
                                        ))
    End Sub

    Private Sub docEvents_OnChangeSelectSet(BeforeOrAfter As EventTimingEnum, Context As NameValueMap, ByRef HandlingCode As HandlingCodeEnum)
        HandlingCode = HandlingCodeEnum.kEventNotHandled
        Console.WriteLine(String.Format("docEvents_OnChangeSelectSet -> Timing:{0}",
                                        BeforeOrAfter.ToString()
                                        ))
    End Sub
#End Region
End Module
