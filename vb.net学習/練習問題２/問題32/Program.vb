Imports System

Module Program
    Sub Main(args As String())
        Dim score As Integer = 75

        If score >= 90 Then
            Console.WriteLine("S以上です")
        ElseIf score >= 80 Then
            Console.WriteLine("A以上です")
        ElseIf score >= 70 Then
            Console.WriteLine("B以上です")
        Else
         Console.WriteLine("C評価です")
        End If
    End Sub
End Module