Module Module1

    Sub Main()
        Dim Binarynumber As String
        Dim Count As Integer
        Dim x As String = ""
        Dim y As Integer = 0
        Dim Z As Integer = 0
        Dim nextchar As String
        Dim ValidBinarystring As Boolean

        ValidBinarystring = True
        Binarynumber = ""
        Count = 0
        nextchar = ""

        Console.Write("Enter Binary Number = ")
        Binarynumber = Console.ReadLine

        If Len(Binarynumber) > 0 And Len(Binarynumber) <= 8 Then
            ValidBinarystring = True
        Else
            ValidBinarystring = False
            Console.Write("Entered Binary number is out of range!")
            Console.ReadKey()
            End
        End If

        For Count = 1 To Len(Binarynumber)
            nextchar = Mid(Binarynumber, Count, 1)
            If Asc(nextchar) = 48 Or Asc(nextchar) = 49 Then
                ValidBinarystring = True
            Else
                ValidBinarystring = False
                Console.Write("Entered Number is not Binary!")
                Console.ReadKey()
                End
            End If
        Next

        Dim Denarynumber As String = ""
        y = Len(Binarynumber)

        For Count = 0 To Len(Binarynumber) - 1
            nextchar = Mid(Binarynumber, y, 1)
            y = y - 1
            x = nextchar * (2 ^ Count)
            Z = Z + x
            Denarynumber = Z

        Next
        Console.Write(Binarynumber)
        Console.Write(" = ")
        Console.Write(Denarynumber)
        Console.ReadKey()

    End Sub

End Module

