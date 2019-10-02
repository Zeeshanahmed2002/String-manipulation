Module Module1

    Sub Main()
        Dim S1, S2, Firstword, Secword As String
        Dim SP As Integer

        S1 = ""
        S2 = ""
        Firstword = ""
        Secword = ""
        SP = 0

        Console.Write(" Enter your First string = ")
        S1 = Console.ReadLine
        Console.Write("Enter the Second string = ")
        S2 = Console.ReadLine


        SP = InStr(S1, " ")
        Firstword = Left(S1, SP - 1)
        SP = InStr(S2, " ")
        Secword = Right(S2, Len(S2) - SP)


        Console.WriteLine("Final String = " _
                          & Firstword & " " & Secword)
        Console.ReadKey()


    End Sub

End Module
