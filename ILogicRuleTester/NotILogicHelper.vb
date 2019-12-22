Imports Inventor

Module NotILogicHelper

    Public Sub showtInventorObjectType(obj As Object)
        MsgBox(CType(obj.type, ObjectTypeEnum).ToString())
    End Sub

End Module
