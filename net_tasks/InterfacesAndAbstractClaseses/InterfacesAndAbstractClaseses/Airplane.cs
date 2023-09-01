using System;

namespace InterfacesAndAbstractClaseses;
    public class Airplane : IFlyable
    {
        private Coordinate currentPosition;
        private double speed;
        public Airplane(double x, double y, double z)
        {
            currentPosition = new Coordinate(x, y, z);
            speed = 200;
        }
        public void FlyTo(Coordinate newPoint)
        {
            double distance = Math.Sqrt(Math.Pow(newPoint.x - currentPosition.x, 2) + Math.Pow(newPoint.y - currentPosition.y, 2) + Math.Pow(newPoint.z - currentPosition.z, 2));
            int speedBoost = (int)(distance / 10) * 10;
            speed += speedBoost;
            Console.WriteLine("Flying to ({0}, {1}, {2}) at speed {3} km/h", newPoint.x, newPoint.y, newPoint.z, speed);
            currentPosition = newPoint;
        }
        public double GetFlyTime()
        {
            double distance = Math.Sqrt(Math.Pow(currentPosition.x, 2) + Math.Pow(currentPosition.y, 2) + Math.Pow(currentPosition.z, 2));
            return distance / speed;
        }
    }