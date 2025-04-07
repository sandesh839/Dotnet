using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Min-Heap using PriorityQueue (C# .NET 6+)
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        // Inserting elements into the min-heap
        minHeap.Enqueue(30, 30);
        minHeap.Enqueue(10, 10);
        minHeap.Enqueue(20, 20);
        minHeap.Enqueue(5, 5);

        Console.WriteLine("Min-Heap elements in order of removal:");
        while (minHeap.Count > 0)
        {
            Console.WriteLine(minHeap.Dequeue()); // Removes the smallest element first
        }
    }
}
