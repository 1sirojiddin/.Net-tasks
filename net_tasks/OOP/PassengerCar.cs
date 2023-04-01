using System;

namespace CarPark
{

public class PassengerCar : Vehicle
{
    Transmission transmission = new Transmission(6, "Deutsche Production");
    Chassis chassis = new Chassis(4, 4);
    Engine engine = new Engine(200, 222, "Camaro", "F213g232");

    public override void DefineTo()
    {
        Console.Write($" Car      | {engine.Power}   |  {engine.Volume}   | {engine.Type}  | {engine.SerialNumber}      |    {chassis.Wheels}   |        {chassis.NumberOfSeats}        |        {transmission.NumberOfGears}        | {transmission.Manufacturer}|");
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
