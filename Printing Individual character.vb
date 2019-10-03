Module Module1

    Sub Main()
        Dim Str1 As String = ""
        Dim Nextchar As Char = ""
        Dim Counter As Integer = 0

        Console.Write("Enter string = ")
        Str1 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            Nextchar = Mid(Str1, Counter, 1)
            Console.WriteLine(Nextchar)
        Next
        Console.ReadKey()
    End Sub

End Module
