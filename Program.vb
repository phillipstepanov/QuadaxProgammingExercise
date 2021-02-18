Imports System

Module Program
    Sub Main(args As String())

        ' Random number int.
        Dim randomValue1 As Integer = 0
        Dim randomValue2 As Integer = 0
        Dim randomValue3 As Integer = 0
        Dim randomValue4 As Integer = 0

        ' Answer .
        Dim answer As Integer
        Dim answerString As String = ""
        Dim answerSheet As String = "++++"
        Dim digit1 As Long
        Dim digit2 As Long
        Dim digit3 As Long
        Dim digit4 As Long

        ' User input.
        Dim userInput As Integer

        ' Generating a random number between 1 and 6.
        randomValue1 = CInt(Math.Floor((6 - 1 + 1) * Rnd())) + 1
        randomValue2 = CInt(Math.Floor((6 - 1 + 1) * Rnd())) + 1
        randomValue3 = CInt(Math.Floor((6 - 1 + 1) * Rnd())) + 1
        randomValue4 = CInt(Math.Floor((6 - 1 + 1) * Rnd())) + 1


        ' Storing random values in answer.
        answer = (randomValue1 * 10 ^ 3) + (randomValue2 * 10 ^ 2) + (randomValue2 * 10 ^ 1) + (randomValue4 * 10 ^ 0)

        ' User Instructions
        Console.WriteLine("MASTERMIND" & vbCrLf & "Please enter the 4 digits you think the answer is" & vbCrLf & "A '-' sign will be printed for every digit that is correct but in the wrong position" & vbCrLf & "A '+' will be printed for every digit that is both correct and in the correct position" & vbCrLf & "Nothing will be printed for incorrect digits...You only have 10 attempts, Good Luck!")
        Console.WriteLine(vbCrLf)

        For y As Integer = 0 To 9

            ' Reading user input.
            Dim input = Console.ReadLine()
            userInput = input
            Console.WriteLine(vbCrLf)

            ' Get most significant digit from input (1000s)
            digit1 = CLng(Left$(CStr(userInput), 1))

            ' Compare most significant digit (1000s)
            If (digit1 = randomValue1) Then
                answerString = answerString + "+"c
            ElseIf (digit1 = randomValue2) Then
                answerString = answerString + "-"c
            ElseIf (digit1 = randomValue3) Then
                answerString = answerString + "-"c
            ElseIf (digit1 = randomValue4) Then
                answerString = answerString + "-"c
            Else
                Console.WriteLine("")
            End If

            ' Getting 2nd digit from left input (100s)
            digit2 = CLng(Left$(CStr(userInput), 2))
            digit2 = CLng(Right$(CStr(digit2), 1))

            ' Compare 2nd digit from left input(100s)
            If (digit2 = randomValue2) Then
                answerString = answerString + "+"c
            ElseIf (digit2 = randomValue1) Then
                answerString = answerString + "-"c
            ElseIf (digit2 = randomValue3) Then
                answerString = answerString + "-"c
            ElseIf (digit2 = randomValue4) Then
                answerString = answerString + "-"c
            Else
                Console.WriteLine("")
            End If

            ' Getting 3rd digit from input
            digit3 = CLng(Left$(CStr(userInput), 3))
            digit3 = CLng(Right$(CStr(digit3), 1))

            'Compare 3rd digit from left input(10s)
            If (digit3 = randomValue3) Then
                answerString = answerString + "+"c
            ElseIf (digit3 = randomValue1) Then
                answerString = answerString + "-"c
            ElseIf (digit3 = randomValue2) Then
                answerString = answerString + "-"c
            ElseIf (digit3 = randomValue4) Then
                answerString = answerString + "-"c
            Else
                Console.WriteLine("")
            End If

            ' Getting least significant digit from input(1s)
            digit4 = CLng(Right$(CStr(userInput), 1))

            'Compare least significant digit from input(1s)
            If (digit4 = randomValue4) Then
                answerString = answerString + "+"c
            ElseIf (digit4 = randomValue1) Then
                answerString = answerString + "-"c
            ElseIf (digit4 = randomValue2) Then
                answerString = answerString + "-"c
            ElseIf (digit4 = randomValue3) Then
                answerString = answerString + "-"c
            Else
                Console.WriteLine("")
            End If

            'Write what you get for the round
            Console.WriteLine(answerString)

            'If they won, end the game
            If (String.Compare(answerString, answerSheet) = 0) Then
                Console.WriteLine("Congratulations you won! You're the mastermind!")
                End
            End If

            'Clear the string for next round if game is not over
            answerString = ""

        Next

        'If the player has run out trys, end the game becasue they lost
        Console.WriteLine("Sorry, you lost! ")

    End Sub
End Module
