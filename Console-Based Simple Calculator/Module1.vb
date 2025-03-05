Module Module1
    Sub Main()
        Dim num1 As Double
        Dim num2 As Double
        Dim operation As Char

        Console.WriteLine("Simple Calculator")
        Console.Write("Enter first number: ")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.Write("Enter an operator (+, -, *, /): ")
        operation = Convert.ToChar(Console.ReadLine())

        Console.Write("Enter second number: ")
        num2 = Convert.ToDouble(Console.ReadLine())

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
                    Console.WriteLine("Error: Division by zero is not allowed.")
                End If
            Case Else
                Console.WriteLine("Invalid Operator!")
        End Select

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
