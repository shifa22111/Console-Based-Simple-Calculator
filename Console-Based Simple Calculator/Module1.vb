Imports System

Module Module1
    Sub Main()
        Dim num1, num2 As Double
        Dim operation As Char

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("===== Simple Calculator =====")
        Console.ResetColor()

        Console.Write("Enter first number: ")
        If Not Double.TryParse(Console.ReadLine(), num1) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Error: Invalid input! Please enter a valid number.")
            Console.ResetColor()
            Exit Sub
        End If

        Console.Write("Enter an operator (+, -, *, /, √, ^): ")
        operation = Convert.ToChar(Console.ReadLine())

        If operation <> "√"c Then
            Console.Write("Enter second number: ")
            If Not Double.TryParse(Console.ReadLine(), num2) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error: Invalid input! Please enter a valid number.")
                Console.ResetColor()
                Exit Sub
            End If
        End If

        Console.ForegroundColor = ConsoleColor.Green
        Select Case operation
            Case "+"
                Console.WriteLine("Result: " & (num1 + num2))
            Case "-"
                Console.WriteLine("Result: " & (num1 - num2))
            Case "*"
                Console.WriteLine("Result: " & (num1 * num2))
            Case "/"
                If num2 <> 0 Then
                    Console.WriteLine("Result: " & (num1 / num2))
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Error: Division by zero is not allowed.")
                End If
            Case "√"
                If num1 >= 0 Then
                    Console.WriteLine("Result: " & Math.Sqrt(num1))
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Error: Square root of a negative number is not possible.")
                End If
            Case "^"
                Console.WriteLine("Result: " & Math.Pow(num1, num2))
            Case Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Invalid Operator!")
        End Select
        Console.ResetColor()

        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("Press any key to exit...")
        Console.ResetColor()
        Console.ReadKey()
    End Sub
End Module
