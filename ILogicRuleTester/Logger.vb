Module logger
    Public Sub Debug(text As String)
        Console.WriteLine("Debug|" & text)
        Diagnostics.Debug.WriteLine("Debug|" & text)
    End Sub
    Public Sub Info(text As String)
        Console.WriteLine("Info|" & text)
        Diagnostics.Debug.WriteLine("Info|" & text)
    End Sub
End Module
