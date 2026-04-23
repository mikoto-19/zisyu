Imports System

Module Program
	Sub Main(args As String())
		Console.Write("名前を入力してください: ")
		Dim name As String =Console.ReadLine()
		Console.WriteLine("ようこそ、"& name &"さん")
	End Sub
End Module