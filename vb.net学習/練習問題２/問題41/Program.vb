Imports System

Module Program
    Sub Main(args As String())
        Console.Write("商品金額を入力してください:")
        Dim ProductAmount As String = Console.ReadLine()

        Console.Write("会員ですか(yes/no):")
        Dim member As String = Console.ReadLine()
        
        Dim price As Integer
        Dim priceSuccess As Boolean = Integer.TryParse(ProductAmount,price)

        'Console.WriteLine("会員:" & members )

    If priceSuccess Then
        Dim intax As Decimal = CDec(price) * 1.1D
        Console.WriteLine("税抜き金額:" & price )
        Console.WriteLine("税込み金額(10%): " & intax.ToString("0"))
        If member = "yes" Then
            if intax >= 5000 Then
                Console.WriteLine("会員向け送料無料です")
            Else
                Console.WriteLine("会員価格ですが送料がかかります")
            End if
        Else
            Console.WriteLine("通常購入です")
        End if
    Else
        Console.WriteLine("商品金額は整数で入力してください")
    End if
    End Sub
End Module
