Imports System

Module Program
    Sub Main(args As String())
        Dim temperature As Integer = "37.2"

        If temperature >= 38.0 Then
            Console.WriteLine("高熱です")
        ElseIf temperature >= 37.0 Then
            Console.WriteLine("発熱しています")
        Else
            Console.WriteLine("平熱です")
        End If
    End Sub
End Module