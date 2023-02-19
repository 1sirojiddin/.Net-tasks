using System;

namespace Coordinate
{
public class Drone : IFlyable                            //Class Drone
{
    public int Speed { get; set; } = 15;
    public int Distance { get; set; } = 100;
    public int FlyTime { get; set; } = 5;
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
