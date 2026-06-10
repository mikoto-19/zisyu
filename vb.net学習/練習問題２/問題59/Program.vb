Imports System

Module Program
    Sub Main(args As String())
        CONST taxRate As Double = 0.1
        Dim price As Double = 1000
        Dim total As Double = price * (1 + taxRate)
        Console.WriteLine(total)
    End Sub
End Module
