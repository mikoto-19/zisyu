Imports System

Module Program
    Sub Main(args As String())
        Dim departmentName As String = "開発部"
        Dim years As Integer = 4

        If departmentName = "開発部" Then
            If years >= 3 Then
                Console.WriteLine("開発部の中堅メンバーです")
            Else
                Console.WriteLine("開発部の若手メンバーです")
            End If
        Else
            Console.WriteLine("開発部ではありません")
        End If
    End Sub
End Module
