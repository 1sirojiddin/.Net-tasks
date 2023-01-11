using System;
using Coordinate;

namespace Coordinate
{
    class Program
    {
        public static void Main()
        {
            Bird myBird = new Bird();                       //create a bird object
            myBird.flyTo();
            myBird.getFlyTime();
            AirPlane myAirplane = new AirPlane();           //create a airplane object
            myAirplane.flyTo();
            myAirplane.getFlyTime();
            Drone myDrone = new Drone();                    //create a drone object
            myDrone.flyTo();
            myDrone.getFlyTime();
            Console.ReadLine();
        }
    }
}
