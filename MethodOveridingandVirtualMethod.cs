using System;
public class Account{
    public virtual int balance()
    {
        return 100;
    }
}
public class Amount:Account
{
    public override int balance(){
        return 500;
    }
}
class Test{
    static void Main(){
        Amount obj = new Amount();
        int b = obj.balance();
        Console.WriteLine("Balance:"+b);
    }
}