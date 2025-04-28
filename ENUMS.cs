using System;

enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
class Program
{
    static void Main(string[] args)
    {
        Day today = Day.Wednesday;
        Console.WriteLine("Today is :"+today);
        Console.WriteLine("value of tuesday is:"+(int)Day.Tuesday);
        if(today == Day.Monday)
        {
            Console.WriteLine("Second day of the week");
        }
    }
}