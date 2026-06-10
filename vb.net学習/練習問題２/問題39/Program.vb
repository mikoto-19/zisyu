Imports System

Module Program
    Sub Main(args As String())
        Dim score As Integer = 78
        Dim attendance As Integer = 85

        If score >= 70 Then
            If attendance  >= 80 Then
                Console.WriteLine("合格です")
            Else
                Console.WriteLine("出席率不足です")
            End If
        Else
            Console.WriteLine("不合格です")
        End If
    End Sub
End Module
