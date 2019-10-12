Module Module1

    Sub Main()

        Dim firstword As String = ""
        Dim secondword As String = ""
        Dim count As Integer = 0
        Dim Newchar As Char = ""
        Dim flag As Boolean = True

        Console.Write("Enter Firstword = ")
        firstword = Console.ReadLine
        firstword = UCase(firstword)


        Console.Write("Enter secondword = ")
        secondword = Console.ReadLine
        secondword = UCase(secondword)

        For count = 1 To Len(firstword)
            Newchar = Mid(firstword, count, 1)
            If InStr(secondword, Newchar) = 0 Then
                flag = False
                Exit For
            End If
        Next

        If flag = True Then
            Console.Write("These words are Anagram!")
        Else
            Console.Write("These words are NOT Anagram!")
        End If
        Console.ReadKey()


    End Sub

End Module
