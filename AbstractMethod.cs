using System;
public abstract class Shape
{
    public abstract void draw();
}
public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle();
        r.draw();
    }
}