Imports Autodesk.iLogic.Interfaces
Imports Inventor

Public Class CadDrawingView
    Implements ICadDrawingView

    Private _drawingView As DrawingView
    Public Sub New(drawingView As DrawingView)
        Me._drawingView = drawingView
    End Sub

    Public Property SpacingBetween(otherView As ICadDrawingView) As Double Implements ICadDrawingView.SpacingBetween
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Double)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property SpacingBetween(otherViewName As String) As Double Implements ICadDrawingView.SpacingBetween
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Double)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property Name As String Implements ICadDrawingView.Name
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Height As Double Implements ICadDrawingView.Height
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Width As Double Implements ICadDrawingView.Width
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Property Scale As Double Implements ICadDrawingView.Scale
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Double)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property ScaleString As String Implements ICadDrawingView.ScaleString
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property ModelDocument As Document Implements ICadDrawingView.ModelDocument
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Balloons As ICadViewBalloons Implements ICadDrawingView.Balloons
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property View As DrawingView Implements ICadDrawingView.View
        Get
            Return Me._drawingView
        End Get
    End Property

    Public Sub SetCenter(centerX As Double, centerY As Double) Implements ICadDrawingView.SetCenter
        Throw New NotImplementedException()
    End Sub

    Public Sub SetSpacingToCorner(distanceX As Double, distanceY As Double, Optional corner As SheetCorner = SheetCorner.Automatic) Implements ICadDrawingView.SetSpacingToCorner
        Throw New NotImplementedException()
    End Sub
End Class
