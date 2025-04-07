using System;

class Program
{
    static void Main()
    {
        // Declare a jagged array with 3 rows (arrays of different lengths)
        int[][] jaggedArray = new int[3][];

        // Initialize each row with a different size
        jaggedArray[0] = new int[] { 1, 2, 3 };       // Row 1: 3 elements
        jaggedArray[1] = new int[] { 4, 5 };          // Row 2: 2 elements
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };    // Row 3: 4 elements

        // Display the jagged array
        Console.WriteLine("Jagged Array Elements:");
        for (int i = 0; i < jaggedArray.Length; i++) // Loop through rows
        {
            for (int j = 0; j < jaggedArray[i].Length; j++) // Loop through columns
            {
                Console.Write(jaggedArray[i][j] + "\t");
            }
            Console.WriteLine(); // New line after each row
        }
    }
}
