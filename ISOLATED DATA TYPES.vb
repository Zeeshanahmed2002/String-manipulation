Module Module1

    Sub Main()
        Dim Str1, Nextchar, Alphabet, Number, Scharacter As String
        Dim Counter As Integer = 0


        Str1 = ""
        Nextchar = ""
        Alphabet = ""
        Number = ""
        Scharacter = ""

        Console.Write(" Enter string = ")
        Str1 = Console.ReadLine

        For Count = 1 To Len(Str1)
            Nextchar = UCase(Mid(Str1, Count, 1))

            If Nextchar >= "A" And Nextchar <= "Z" Then
                Alphabet = Alphabet & Nextchar
            Else

                If Nextchar >= "0" And Nextchar <= "9" Then
                    Number = Number & Nextchar
                Else
                    Scharacter = Scharacter & Nextchar

                End If


            End If

        Next


        Console.WriteLine("The Alphabets in the string are = " & Alphabet)
        Console.WriteLine("The character other than Alphabet are = " & Number)
        Console.WriteLine("The Special characters are = " & Scharacter)
        Console.ReadKey()

    End Sub

End Module
