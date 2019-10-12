Module Module1

    Sub Main()
        Dim str1, str2, middleword As String
        Dim sp1, sp2 As Integer

        middleword = ""
        str1 = ""
        str2 = ""
        sp1 = 0
        sp2 = 0

        Console.Write("Enter string consisting of three words = ")
        str1 = Console.ReadLine

        sp1 = InStr(str1, " ")
        sp2 = InStr(sp1 + 1, str1, " ")
        middleword = Mid(str1, sp1 + 1, sp2 - sp1 - 1)
        Console.Write(middleword)
        Console.ReadKey()


    End Sub

End Module
