Imports System

Module Program
    Sub Main(args As String())
        Dim lastName As String = "山田"
        Dim firstName As String = "太郎"
        Dim score1 As Integer = 100
        Dim score2 As Integer = 60

        Dim totalscore AS Integer = score1 + score2
        Console.WriteLine("氏名：" & lastName & " " & firstName )
        Console.WriteLine("合計点：" & totalscore)

        If (totalscore >= 150) and (score1 >= 70) and (score2 >= 70) 
            Console.WriteLine("合格です")

        Else 
            Console.WriteLine("不合格です")

        End if

    End Sub
End Module