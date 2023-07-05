using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractClasses
{
    class Drone : IFlyable
    {
        private Coordinate currentPosition;
        private double speed;

        public Drone(double x, double y, double z)
        {
            currentPosition = new Coordinate(x, y, z);
            speed = 20;
        }

        public void FlyTo(Coordinate newPoint)
        {
            if (Math.Sqrt(Math.Pow(newPoint.x - currentPosition.x, 2) + Math.Pow(newPoint.y - currentPosition.y, 2) + Math.Pow(newPoint.z - currentPosition.z, 2)) > 1000)
            {
                Console.WriteLine("Cannot fly to ({0}, {1}, {2}) as it is beyond the maximum range of 1000 km", newPoint.x, newPoint.y, newPoint.z);
                return;
            }

            double distance = Math.Sqrt(Math.Pow(newPoint.x - currentPosition.x, 2) + Math.Pow(newPoint.y - currentPosition.y, 2) + Math.Pow(newPoint.z - currentPosition.z, 2));
            int timeInAir = (int)(distance / speed);
            int hoverTime = timeInAir / 10;
            Console.WriteLine("Flying to ({0}, {1}, {2}) at speed {3} km/h for {4} minutes and hovering for 1 minute every 10 minutes of flight", newPoint.x, newPoint.y, newPoint.z, speed, timeInAir);
            currentPosition = newPoint;
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = Math.Sqrt(Math.Pow(newPoint.x - currentPosition.x, 2) + Math.Pow(newPoint.y - currentPosition.y, 2) + Math.Pow(newPoint.z - currentPosition.z, 2));
            int timeInAir = (int)(distance / speed);
            int hoverTime = timeInAir / 10;
            return timeInAir + hoverTime;
        }
    }
}
