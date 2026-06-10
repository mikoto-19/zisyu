Imports System

Module Program
    Sub Main(args As String())
        Dim departmentName As String = "開発部"

        If departmentName = "営業部" Then
            Console.WriteLine("営業部の処理です")
        ElseIf departmentName = "開発部" Then
            Console.WriteLine("開発部の処理です")
        Else
            Console.WriteLine("対象外です")
        End If
    End Sub
End Module
