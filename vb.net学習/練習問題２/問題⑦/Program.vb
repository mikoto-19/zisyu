Imports System

Module Program
    Sub Main(args As String())
        Console.Write("姓を入力してください:")
        Dim LastName As String =Console.ReadLine()
        Console.Write("名を入力してください: ")
        Dim Name As String =Console.ReadLine()
        Console.WriteLine( "氏名：" & LastName & Name )

    End Sub
End Module
