using System;

class Program
{
    static void Main()
    {
        // Declare a 2D rectangular array (3 rows, 4 columns)
        int[,] numbers = new int[3, 4] 
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Display the array elements
        Console.WriteLine("Rectangular Array Elements:");
        for (int i = 0; i < numbers.GetLength(0); i++) // Loop through rows
        {
            for (int j = 0; j < numbers.GetLength(1); j++) // Loop through columns
            {
                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine(); // New line after each row
        }
    }
}
