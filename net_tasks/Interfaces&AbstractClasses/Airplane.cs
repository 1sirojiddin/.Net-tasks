using System;

namespace InterfacesAbstraction
{

public class AirPlane : IFlyable           //Class Airplane
{
    private int speed = 200;                    //initial speed in km/h
    private const int acceleration = 10;        // every 10 km increases by 10 km/h
    private const int distance = 100;
    Coordinate CurrentPosition = new Coordinate(4, 6);  //Position
    public void FlyTo()
    {
        Console.WriteLine($"The plane's current position is {CurrentPosition}");
    }
    public void GetFlyTime()
    {
        for (int i = 0; i < distance; i += 10). // cycle for 10km speed increase by 10km/h
        {
            speed += acceleration;
            Console.WriteLine($"At {i + 10}km, the speed is {speed} km/h");
        }
    }
}
}
