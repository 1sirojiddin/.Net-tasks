using System;

namespace InterfacesAndAbstractClaseses;
    public class Bird : IFlyable
    {
        private Coordinate currentPosition;
        private double speed;
        public Bird(double x, double y, double z)
        {
            currentPosition = new Coordinate(x, y, z);
            Random rnd = new Random();                  //Birds speed set randomly between 1 and 20
            speed = rnd.Next(0, 21);
        }
        public void FlyTo(Coordinate newPoint)
        {
            Console.WriteLine("Flying to ({0}, {1}, {2}) at speed {3} km/h", newPoint.x, newPoint.y, newPoint.z, speed);
            currentPosition = newPoint;
        }
        public double GetFlyTime()
        {
            double distance = Math.Sqrt(Math.Pow(currentPosition.x, 2) + Math.Pow(currentPosition.y, 2) + Math.Pow(currentPosition.z, 2));
            return distance / speed;
        }
    }
