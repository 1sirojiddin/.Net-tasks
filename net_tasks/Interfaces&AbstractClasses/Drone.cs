using System;

namespace InterfacesAbstraction
{

public class Drone : IFlyable                            
{
    private const int hoverTime = 1;  
    private const int maxDistance = 1000;
    Coordinate CurrentPosition = new Coordinate(2, 5);
    public void FlyTo()
    {
        Console.WriteLine($"The drone's Currrent Position is {CurrentPosition}");
    }
    public void GetFlyTime()
    {
        if (maxDistance > 1000)     // Drone's max flight distance is 1000
        {
            Console.WriteLine("The drone can't flight more than 1000");
        }
    }
}
}
