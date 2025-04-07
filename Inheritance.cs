using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal is eating.");
    }
} 

// Derived class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Dog class
        Dog myDog = new Dog();

        // Calling methods from both base and derived classes
        myDog.Eat();  // Inherited from Animal class
        myDog.Bark(); // Defined in Dog class

        Console.ReadLine();
    }
}
