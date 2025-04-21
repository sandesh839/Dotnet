using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PersonDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }

    public void EmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
    }
}

public class Manager : Employee
{
    public string Department { get; set; }

    public void DepartmentDetails()
    {
        Console.WriteLine($"Department: {Department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager
        {
            Name = "Alice",
            Age = 35,
            EmployeeId = 12345,
            Department = "IT"
        };

        manager.PersonDetails();
        manager.EmployeeDetails();
        manager.DepartmentDetails();
    }
}