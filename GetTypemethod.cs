using System;
public class Point
{
    public int x;
    public int y;

}
class Test
{
    static void Main()
    {
        Point p = new Point();
        Console.WriteLine(p.GetType().Name);
        Console.WriteLine(typeof(Point).Name);
        Console.WriteLine(p.GetType()==typeof(Point));
        Console.WriteLine(p.x.GetType().Name);
        Console.WriteLine(p.y.GetType().FullName);
    }
}