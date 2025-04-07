using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];

        Console.WriteLine("Enter the words:");
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        // Bubble Sort for Strings
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(words[j], words[j + 1]) > 0)
                {
                    // Swap
                    string temp = words[j];
                    words[j] = words[j + 1];
                    words[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Words in Alphabetical Order:");
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}
