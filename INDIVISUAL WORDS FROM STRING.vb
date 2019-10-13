Module Module1

    Sub Main()
        Dim Str1 As String = ""
        Dim Str2 As String = ""
        Dim Nextchar As String = ""
        Dim count As Integer = 0

        Console.Write("Enter string = ")
        Str1 = Console.ReadLine

        For count = 1 To Len(Str1)
            Nextchar = Mid(Str1, count, 1)
            If Nextchar = " " Then
                Console.WriteLine(Str2)
                Str2 = ""
            Else
                Str2 = Str2 & Nextchar
            End If
        Next
        Console.WriteLine(Str2)
        Console.ReadKey()


    End Sub

End Module
