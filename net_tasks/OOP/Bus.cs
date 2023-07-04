using System;

namespace CarPark
{

public class Bus : Vehicle
{
    Transmission transmission = new Transmission(4, "Deutsch Technology");
    Chassis chassis = new Chassis(4, 50);
    Engine engine = new Engine(600, 250, "Mercedes", "Der34354fdsf");
    public override void DefineTo()
    {
        Console.Write($" Bus      | {engine.Power}   |  {engine.Volume}   | {engine.Type}| {engine.SerialNumber}  |    {chassis.Wheels}   |        {chassis.NumberOfSeats}       |        {transmission.NumberOfGears}        | {transmission.Manufacturer} |");
    }
    public override void TestAmount()
    {
        try
        {
            if (engine.Power < 0) { Console.WriteLine($"The index must be > 0"); }
            if (engine.Volume < 0) { Console.WriteLine($"The index must be > 0"); }
            if (chassis.Wheels < 0) { Console.WriteLine($"The index must be > 0"); }
            if (chassis.NumberOfSeats < 0) { Console.WriteLine($"The index must be > 0"); }
            if (transmission.NumberOfGears < 0) { Console.WriteLine($"The index must be > 0"); }
            throw new ArgumentOutOfRangeException();
        }
        catch (ArgumentOutOfRangeException) { }
    }
}
}
