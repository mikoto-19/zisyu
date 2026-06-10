Imports System

Module Program
	Sub Main(args As String())
		Console.Write("テストの点数を入力してください:")
		Dim scoreText As String = Console.ReadLine()
        Dim score As Integer = Integer.Parse(scoreText)

        Console.WriteLine("点数: " & score)   


    End Sub
End Module