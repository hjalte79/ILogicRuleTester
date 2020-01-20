Imports Autodesk.iLogic.Interfaces
Imports Inventor

Public Class CadDrawingSheet
    Implements ICadDrawingSheet

    Public Sub New(sheet As Sheet)
        Me._sheet = sheet
    End Sub

    Public ReadOnly Property Name As String Implements ICadDrawingSheet.Name
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Size As String Implements ICadDrawingSheet.Size
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Height As Double Implements ICadDrawingSheet.Height
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Width As Double Implements ICadDrawingSheet.Width
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private _sheet As Sheet
    Public ReadOnly Property Sheet As Sheet Implements ICadDrawingSheet.Sheet
        Get
            Return _sheet
        End Get
    End Property

    Public Property TitleBlock As String Implements ICadDrawingSheet.TitleBlock
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property Border As String Implements ICadDrawingSheet.Border
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property View(viewName As String) As ICadDrawingView Implements ICadDrawingSheet.View
        Get
            For Each item As DrawingView In Sheet.DrawingViews
                If (item.Name.Equals(viewName)) Then
                    Return New CadDrawingView(item)
                End If
            Next
            Throw New Exception(String.Format("Sheet.View: No drawing view named '{0}' was found.", viewName))
        End Get
    End Property

    Public Sub ChangeSize(size As String, Optional MoveBorderItems As Boolean = True) Implements ICadDrawingSheet.ChangeSize
        Throw New NotImplementedException()
    End Sub

    Public Sub ChangeSize(customHeight As Double, customWidth As Double, Optional MoveBorderItems As Boolean = True) Implements ICadDrawingSheet.ChangeSize
        Throw New NotImplementedException()
    End Sub

    Public Sub SetTitleBlock(titleBlockName As String, ParamArray promptedEntries() As String) Implements ICadDrawingSheet.SetTitleBlock
        Throw New NotImplementedException()
    End Sub

    Public Sub SetBorder(borderName As String, ParamArray promptedEntries() As String) Implements ICadDrawingSheet.SetBorder
        Throw New NotImplementedException()
    End Sub
End Class
