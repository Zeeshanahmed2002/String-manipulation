Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Nextchar As Char
        Dim counter As Integer

        Str1 = ""
        Str2 = ""
        Nextchar = ""
        counter = 0

        Console.Write("Enter string = ")
        Str1 = Console.ReadLine

        For counter = 1 To Len(Str1)
            Nextchar = Mid(Str1, counter, 1)
            If Nextchar >= "0" And Nextchar <= "9" Then
                Nextchar = "*"
            End If
            Str2 = Str2 & Nextchar
        Next

        Str1 = Str2

        Console.WriteLine(Str1)
        Console.ReadKey()

    End Sub

End Module
