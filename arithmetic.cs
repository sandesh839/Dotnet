using System;

class ArithmeticOperations
{
    static void Main()
    {
        // Declare variables for two numbers and the operator
        double num1, num2;
        string operation;

        // Input two numbers from the user
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Input the arithmetic operation
        Console.Write("Enter the operation (+, -, *, /): ");
        operation = Console.ReadLine();

        // Perform the operation based on the user's input
        switch (operation)
        {
            case "+":
                Console.WriteLine("The result of {num1} + {num2} is: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine("The result of {num1} - {num2} is: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine("The result of {num1} * {num2} is: {num1 * num2}");
                break;
            case "/":
                // Check if the second number is zero to avoid division by zero
                if (num2 != 0)
                {
                    Console.WriteLine("The result of {num1} / {num2} is: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /.");
                break;
        }

        // Pause to view output
        Console.ReadLine();
    }
}
