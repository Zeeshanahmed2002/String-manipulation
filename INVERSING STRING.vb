Module Module1

    Sub Main()
        Dim Str1 As String = ""
        Dim Str2 As String = ""
        Console.Write("Enter string to reverse = ")
        Str1 = Console.ReadLine



        If Str1 = "" Then
            Console.Write("Try a valid name please.")
        Else
            Dim Name As String = Str1
            Dim s As String = ""
            For i As Integer = Name.Length To 1 Step -1
                s = s & Mid(Name, i, 1)
            Next
            Str2 = s
        End If

        Console.Write(Str2)
        Console.ReadKey()

    End Sub

End Module
