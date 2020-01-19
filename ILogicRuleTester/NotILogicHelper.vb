Imports Inventor

Module NotILogicHelper

    Public Sub showtInventorObjectType(obj As Object)
        MsgBox(CType(obj.type, ObjectTypeEnum).ToString())
        'Console.WriteLine( ((ObjectTypeEnum)test.type).ToString() ); // in c#
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

End Module
