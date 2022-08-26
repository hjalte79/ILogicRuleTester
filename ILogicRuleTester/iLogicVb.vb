Imports Inventor

Public Module iLogicVb

    Private _iLogicAuto As Object
    Public Sub LoadiLogicAddin()

        Dim addIn As ApplicationAddIn = ThisApplication.ApplicationAddIns.ItemById("{3bdd8d79-2179-4b11-8a5a-257b1c0263ac}")

        If (addIn Is Nothing) Then
            Throw New OutOfMemoryException("Could not load iLogic addin")
        End If

        _iLogicAuto = addIn.Automation

    End Sub

    Public Sub RunExternalRule(ruleName As String)

        _iLogicAuto.RunExternalRule(ThisDoc.Document, ruleName)
    End Sub



End Module
