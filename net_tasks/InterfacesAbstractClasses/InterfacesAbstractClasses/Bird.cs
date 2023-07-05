using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractClasses
{
    class Bird : IFlyable
    {
        private Coordinate currentPosition;
        private double speed;

        public Bird(double x, double y, double z)
        {
            currentPosition = new Coordinate(x, y, z);
            Random rnd = new Random();
            speed = rnd.Next(0, 21);
        }

        public void FlyTo(Coordinate newPoint)
        {
            Console.WriteLine("Flying to ({0}, {1}, {2}) at speed {3} km/h", newPoint.x, newPoint.y, newPoint.z, speed);
            currentPosition = newPoint;
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = Math.Sqrt(Math.Pow(newPoint.x - currentPosition.x, 2) + Math.Pow(newPoint.y - currentPosition.y, 2) + Math.Pow(newPoint.z - currentPosition.z, 2));
            return distance / speed;
        }
    }
}
