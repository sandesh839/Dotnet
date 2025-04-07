using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Bubble Sort
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Numbers in Ascending Order:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
