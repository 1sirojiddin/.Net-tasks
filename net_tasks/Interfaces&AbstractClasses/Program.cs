using System;

namespace Coordinate
{

public class Program
{
public static void Main()
{
    Bird myBird = new Bird(20);                       //create a bird object
    myBird.FlyTo();
    myBird.GetFlyTime();
    AirPlane myAirplane = new AirPlane();           //create a airplane object
    myAirplane.FlyTo();
    myAirplane.GetFlyTime();
    Drone myDrone = new Drone();                    //create a drone object
    myDrone.FlyTo();
    myDrone.GetFlyTime();
    Console.ReadLine();
}
}
}
