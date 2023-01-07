using System;
using Coordinate;

namespace Coordinate
{
    class Program
    {
        public static void Main()
        {
            Bird mybird = new Bird();                       //create a bird object
            mybird.FlyTo();
            mybird.GetFlyTime();
            AirPlane myairplane = new AirPlane();           //create a airplane object
            myairplane.FlyTo();
            myairplane.GetFlyTime();
            Drone mydrone = new Drone();                    //create a drone ojbject
            mydrone.FlyTo();
            mydrone.GetFlyTime();
            Console.ReadLine();
        }
    }
}
