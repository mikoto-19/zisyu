Imports System

Module Program
    Sub Main(args As String())
        Dim name As String  

        Console.Write("名前を入力してください: ")
		name = Console.ReadLine()

        Console.WriteLine("こんにちは、" & name &  "さん")
    End Sub
End Module
