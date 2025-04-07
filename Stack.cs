using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declare and initialize a Stack of integers
        Stack<int> stack = new Stack<int>();

        // Push elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        Console.WriteLine("Stack after pushing elements:");
        PrintStack(stack);

        // Pop an element from the stack (removes the top element)
        int poppedItem = stack.Pop();
        Console.WriteLine("\nPopped item: {poppedItem}");

        Console.WriteLine("\nStack after popping:");
        PrintStack(stack);

        // Peek at the top element without removing it
        int topItem = stack.Peek();
        Console.WriteLine("\nTop element after peek: {topItem}");
    }

    // Helper method to print stack contents
    static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
