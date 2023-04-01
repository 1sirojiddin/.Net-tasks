using System;

namespace InterfacesAbstraction
{
public class Bird : IFlyable              //class Bird
{
    private const double maxSpeed = 20;
    Coordinate CurrentPosition = new Coordinate(4, 5);
    public Bird(double speed)
    {     // the bird's speed  will choose randomly
        Random ran = new Random();
        speed = ran.NextDouble() * maxSpeed;
        Console.WriteLine(speed);
    }
    public void FlyTo()
    {
        Console.WriteLine($"The bird's Currrent Position is {CurrentPosition}");
    }
    public void GetFlyTime() { }
}
}
