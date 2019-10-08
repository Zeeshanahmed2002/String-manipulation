Module Module1

    Sub Main()
        Dim Alphastr As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim str2 As String = ""
        Dim count As Integer = 0
        Dim Nextchar As Char = ""
        Dim Ispangram As Boolean = True


        Console.Write("Enter string = ")
        str2 = Console.ReadLine
        str2 = UCase(str2)


        For count = 1 To Len(Alphastr)
            Nextchar = Mid(Alphastr, count, 1)
            If InStr(str2, Nextchar) = 0 Then
                Ispangram = False
                Exit For
            End If

        Next

        If Ispangram = True Then
            Console.WriteLine("This is pangram!")
        Else
            Console.WriteLine("This is NOT pangram!")
        End If

        Console.ReadKey()



    End Sub

End Module
