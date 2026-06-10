Imports System

Module Program
    Sub Main(args As String())
        Dim price As Integer = 3000
        Dim quantity As Integer = 2

        If price + quantity >= 5000 Then
            Console.WriteLine("小計:送料無料です")
        Else
            Console.WriteLine("送料がかかります")
        End If
    End Sub
End Module