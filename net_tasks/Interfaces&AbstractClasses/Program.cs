using System;
using Coordinate;

namespace Coordinate
{
    class Program
    {
        public static void Main()
        {
            Bird myBird = new Bird();                       //create a bird object
            myBird.FlyTo();
            myBird.GetFlyTime();
            AirPlane myAirplane = new AirPlane();           //create a airplane object
            myAirplane.FlyTo();
            myAirplane.GetFlyTime();
            Drone myDrone = new Drone();                    //create a drone ojbject
            myDrone.FlyTo();
            myDrone.GetFlyTime();
            Console.ReadLine();
        }
    }
}
