using System;
abstract class A
{
    public virtual void msgA()
    {
        Console.WriteLine("Abstract class Method");
    }
}
class B:A{
    public void msgB()
    {
          Console.WriteLine("Inherit class Method");
    }
}
class Program{
    static void Main()
    {
        B obj = new B();
        obj.msgB();
        obj.msgA();
    }
}
