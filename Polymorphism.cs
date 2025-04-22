using System;

class Calculator
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method to add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method to add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Add two integers: " + calc.Add(5, 10));
        Console.WriteLine("Add three integers: " + calc.Add(5, 10, 15));
        Console.WriteLine("Add two doubles: " + calc.Add(5.5, 10.5));
    }
}