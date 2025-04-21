using System;

public class Rose
{
    public void Bloom()
    {
        Console.WriteLine("The rose is blooming.");
    }
}

public class Lily
{
    public void Fragrance()
    {
        Console.WriteLine("The lily has a sweet fragrance.");
    }
}

public interface IRose
{
    void Bloom();
}

public interface ILily
{
    void Fragrance();
}

public class Flower : IRose, ILily
{
    private readonly Rose _rose = new Rose();
    private readonly Lily _lily = new Lily();

    public void Bloom()
    {
        _rose.Bloom();
    }

    public void Fragrance()
    {
        _lily.Fragrance();
    }
}

class Program
{
    static void Main()
    {
        Flower flower = new Flower();
        flower.Bloom();
        flower.Fragrance();
    }
}