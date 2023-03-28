using System;

namespace CarPark
{
public class Scooter : Vehicle
{
    Transmission transmission = new Transmission(2, "Chinese Technology");
    Chassis chassis = new Chassis(2, 1);
    Engine engine = new Engine(20, 23, "Changan", "D34r35t4");
    public override void DefineTo()
    {
        Console.Write($" Scooter  | {engine.Power}    |  {engine.Volume}    | {engine.Type} | {engine.SerialNumber}      |    {chassis.Wheels}   |        {chassis.NumberOfSeats}        |        {transmission.NumberOfGears}        | {transmission.Manufacturer} |");
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
