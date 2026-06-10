Imports System

Module Program
    Sub Main(args As String())
        Console.Write("商品金額を入力してください:")
        Dim price As String = Console.ReadLine()
        Dim TaxPrice As Integer = Integer.Parse(price)
        Dim intax As Double = price * 1.1

        Console.WriteLine("税抜き金額: " & price)
        Console.WriteLine("税込み金額(10%):" & intax)

        If intax >= 8000 Then
            Console.WriteLine("送料区分: 無料")
        ElseIf intax >= 5000 Then
            Console.WriteLine("送料区分: 半額")
        Else
            Console.WriteLine("送料区分: 通常")
        End If
    End Sub
End Module
