Imports System

Module Program
    Sub Main(args As String())
        Console.Write("国語の点数を入力してください:")
         Dim KokugoText As String = Console.ReadLine()

        Console.Write("数学の点数を入力してください:")
         Dim SansuText As String = Console.ReadLine()
        
         Dim KokugoScore As Integer
         Dim SansuScore As Integer

         Dim kokugoSuccess As Boolean = Integer.TryParse(KokugoText,KokugoScore)
         Dim SansuSuccess  As Boolean = Integer.TryParse(SansuText,SansuScore)

        IF kokugoSuccess And SansuSuccess Then
            Dim totalscore As Integer = KokugoScore  + SansuScore
            Dim average As Double = totalscore / 2.0

            Console.WriteLine("合計点：" & totalscore )
            Console.WriteLine("平均点:" & average )
            IF totalscore >= 160 Then
                IF (KokugoScore >= 70) And (SansuScore >= 70) Then
                    Console.WriteLine("合格です")
                Else
                    Console.WriteLine("基準点不足です")
                End If
            Else  
                Console.WriteLine("不合格です")
            End If
        Else
            Console.WriteLine("整数で入力してください")
        End If        
    End Sub
End Module
