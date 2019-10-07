Module Module1

    Sub Main()
        Dim str1 As String = ""
        Dim count As Integer = 0
        Dim Nextchar As Char = ""
        Dim Total As Integer = 0
        Dim Flag As Boolean = True


        Console.Write("Enter string = ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            Nextchar = Mid(str1, count, 1)
            If UCase(Nextchar) >= "A" And UCase(Nextchar) <= "Z" Then
                Flag = True
                Total = Total + Asc(Nextchar)
            Else
                Flag = False

            End If

        Next
        If Total >= 2015 And Flag = True Then
            Console.WriteLine("This is a pangram!")
        Else
            Console.WriteLine("This is not a pangram!")
        End If
        Console.ReadKey()
    End Sub
End Module
