using System;

namespace Coordinate
{
public class Program
{
public static void Main()
{
    Bird myBird = new Bird();                       //create a bird object
    myBird.FlyTo();
    myBird.GetFlyTime();
    AirPlane myAirplane = new AirPlane();           //create a airplane object
    myAirplane.FlyTo();
    myAirplane.GetFlyTime();
    Drone myDrone = new Drone();                    //create a drone object
    myDrone.FlyTo();
    myDrone.GetFlyTime();
    Console.WriteLine($"The bird fly distance is {myBird.Distance} km and from this comes that, speed is {myBird.Speed} km/h and fly time is {myBird.FlyTime} h");
    Console.WriteLine($"The bird fly distance is {myAirplane.Distance} km and from this comes that, speed is {myAirplane.Speed} km/h and fly time is {myAirplane.FlyTime} h");
    Console.WriteLine($"The bird fly distance is {myDrone.Distance} km and from this comes that, speed is {myDrone.Speed} km/h and fly time is {myDrone.FlyTime} h");
    Console.ReadLine();

}
}
}
