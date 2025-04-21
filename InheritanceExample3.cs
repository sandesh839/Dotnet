using System;

namespace InheritanceExample
{
    // Base class
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping...");
        }
    }

    // Derived class: Car
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void OpenTrunk()
        {
            Console.WriteLine("Car trunk is open.");
        }
    }

    // Derived class: Truck
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; } // in kilograms

        public void LoadCargo()
        {
            Console.WriteLine("Truck is loading cargo.");
        }
    }

    // Derived class: Motorcycle
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public void PerformWheelie()
        {
            Console.WriteLine("Motorcycle is performing a wheelie!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Make = "Toyota", Model = "Camry", Year = 2022, NumberOfDoors = 4 };
            car.Start();
            car.OpenTrunk();
            car.Stop();

            Truck truck = new Truck { Make = "Ford", Model = "F-150", Year = 2021, LoadCapacity = 5000 };
            truck.Start();
            truck.LoadCargo();
            truck.Stop();

            Motorcycle motorcycle = new Motorcycle { Make = "Harley-Davidson", Model = "Sportster", Year = 2023, HasSidecar = false };
            motorcycle.Start();
            motorcycle.PerformWheelie();
            motorcycle.Stop();
        }
    }
}