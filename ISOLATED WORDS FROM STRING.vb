Module Module1

    Sub Main()
        Dim Str1 As String = ""
        Dim Str2 As String = ""
        Dim Newchar As Char = ""
        Dim count As Integer = 0

        Console.Write("Enter string = ")
        Str1 = Console.ReadLine

        For count = 1 To Len(Str1)
            Newchar = UCase(Mid(Str1, count, 1))
            If Newchar >= "A" And Newchar <= "Z" Then
            Str2 = Str2 & Newchar
            Else
                If Newchar = " " Then
                    Console.WriteLine(Str2)
                    Str2 = ""
                End If

            End If
        Next
        Console.WriteLine(Str2)
        Console.ReadKey()


    End Sub

End Module
