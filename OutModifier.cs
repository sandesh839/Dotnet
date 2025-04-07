using System;

class Program
{
    static void OutMod(out int x, out int y)
    {
        x = 10;  // Must assign values before returning
        y = 20;
    }

    static void Main()
    {
        int a, b;
        OutMod(out a, out b); // No need to initialize a and b
        Console.WriteLine("a:"+a+"b:"+b);
    }
}
