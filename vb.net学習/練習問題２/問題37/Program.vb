Imports System

Module Program
    Sub Main(args As String())
        Dim isMember As Boolean = True
        Dim totalPrice As Integer = 6000

        If isMember Then
            If totalPrice >= 5000 Then
                Console.WriteLine("会員向け送料無料です")
            Else
                Console.WriteLine("会員ですが送料がかかります")
            End If
        Else
            Console.WriteLine("非会員です")
        End If
    End Sub
End Module