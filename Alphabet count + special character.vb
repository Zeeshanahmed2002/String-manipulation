Module Module1

    Sub Main()
        Dim Str1, Nextchar As String
        Dim AlphabetCounter, NumberCounter, Scharacter, Counter As Integer


        Str1 = ""
        Nextchar = ""
        AlphabetCounter = 0
        NumberCounter = 0
        Counter = 0
        Scharacter = 0

        Console.Write(" Enter string = ")
        Str1 = Console.ReadLine

        For Count = 1 To Len(Str1)
            Nextchar = UCase(Mid(Str1, Count, 1))

            If Nextchar >= "A" And Nextchar <= "Z" Then
                AlphabetCounter = AlphabetCounter + 1
            Else

                If Nextchar >= "0" And Nextchar <= "9" Then
                    NumberCounter = NumberCounter + 1
                Else
                    Scharacter = Scharacter + 1

                End If


            End If

        Next


        Console.WriteLine("The number of Alphabets in the string are = " & AlphabetCounter)
        Console.WriteLine("The number of character other than Alphabet are = " & NumberCounter)
        Console.WriteLine("The number of Special characters are = " & Scharacter)
        Console.ReadKey()

    End Sub

End Module
