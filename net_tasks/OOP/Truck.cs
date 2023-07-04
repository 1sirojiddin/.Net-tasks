using System;

namespace CarPark
{

public class Truck : Vehicle
{
    Transmission transmission = new Transmission(5, "Russian Production");
    Chassis chassis = new Chassis(4, 2);
    Engine engine = new Engine(-300, 250, "Tractor", "Fdsf343242df");
    public override void DefineTo()
    {
        Console.Write($" Truck    | {engine.Power}   |  {engine.Volume}   | {engine.Type} | {engine.SerialNumber}  |    {chassis.Wheels}   |        {chassis.NumberOfSeats}        |        {transmission.NumberOfGears}        | {transmission.Manufacturer} |");
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
