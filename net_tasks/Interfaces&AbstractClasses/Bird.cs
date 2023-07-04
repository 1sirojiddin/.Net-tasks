using System;

namespace InterfacesAbstraction
{
public class Bird : IFlyable              
{
    private const double maxSpeed = 20;  // maximum speed of bird 
    Coordinate CurrentPosition = new Coordinate(4, 5); // Current position
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
