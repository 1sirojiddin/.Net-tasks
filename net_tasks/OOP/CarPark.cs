using System;

namespace CarPark
{
public class Vehicle
{
    public virtual void DefineTo()
    {
        Console.WriteLine("                  The details of different types of vehicles");
        Console.Write($" Vehicles | Power | Volume |  Type   | Serial Number | Wheels | Number of seats | Number of gears |    Manufacturer    |");
        Console.Write("------------------------------------------------------------------------------------------------------------------------");
    }
    public virtual void TestAmount() { }
}
}
