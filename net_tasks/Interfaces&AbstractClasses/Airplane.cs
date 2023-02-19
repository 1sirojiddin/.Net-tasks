using System;

namespace Coordinate
{
public class AirPlane : IFlyable           //Class Airplane
{
    public int Speed { get; set; } = 35;
    public int Distance { get; set; } = 100;
    public int FlyTime { get; set; } = 2;
    public void FlyTo()
    {
        try
        {
            Speed = Distance / FlyTime;
            if (Distance <= 0) Console.WriteLine("Error");
        }
        catch (DivideByZeroException) { Console.WriteLine("It is impossible to divide zero"); }
    }
    public void GetFlyTime()
    {
        try
        {
            FlyTime = Distance / Speed;
            if (FlyTime <= 0) Console.WriteLine("Error");
        }
        catch (DivideByZeroException) { Console.WriteLine("It is impossible to divide zero"); }
    }
}
}
