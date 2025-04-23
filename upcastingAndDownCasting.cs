using System;
class Animal{
    public void Speak(){
        Console.WriteLine("Animal Speaks");
    }
}
class Dog:Animal{
    public void Bark(){
        Console.WriteLine("Dog Speaks");

    }
}
class Program{
    static void Main(){
        Dog dog = new Dog();
        
        // Upcasting
        Animal animal = dog;
        animal.Speak();
        
        // Downcasting
        Dog downcastedDog = (Dog)animal;
        downcastedDog.Bark();
    }
}