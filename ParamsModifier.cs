using System;
class Program
{
    static void PrintNumbers(params int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        PrintNumbers(1, 2, 3, 4, 5); // Output: 1 2 3 4 5
        PrintNumbers(10, 20);        // Output: 10 20
    }
}
