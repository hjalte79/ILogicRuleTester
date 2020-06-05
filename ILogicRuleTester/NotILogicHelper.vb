Imports Inventor

Module NotILogicHelper

    Public Sub showtInventorObjectType(obj As Object)
        showEnumName(Of ObjectTypeEnum)(obj.type)
        ' MsgBox(CType(obj.type, ObjectTypeEnum).ToString()) ' in 1 line
        'Console.WriteLine( ((ObjectTypeEnum)test.type).ToString() ); // in c#
    End Sub

    Public Sub showEnumName(Of T)(obj As Object)
        ' example use:
        '    showEnumName(Of ObjectTypeEnum)(ThisDoc.Document.type)
        MsgBox(CType(obj, T).ToString())
    End Sub


    Public Function getSelectedNode(topNode As BrowserNode) As BrowserNode
        Dim foundNode As BrowserNode = Nothing
        For Each node As BrowserNode In topNode.BrowserNodes
            If (node.Selected) Then Return node
            foundNode = getSelectedNode(node)
            If (foundNode IsNot Nothing) Then
                Return foundNode
            End If
        Next
        Return foundNode
    End Function

    Public Sub showTypeOfSelectedEntity()
        Dim test = ThisApplication.CommandManager.Pick(SelectionFilterEnum.kAllEntitiesFilter, "Select something")
        showtInventorObjectType(test)
    End Sub

End Module
