using System;

namespace InterfacesAndAbstractClaseses;
    public class Drone : IFlyable
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
            double distance = Math.Sqrt(Math.Pow(newPoint.x - currentPosition.x, 2) +
                Math.Pow(newPoint.y - currentPosition.y, 2) +
                Math.Pow(newPoint.z - currentPosition.z, 2));
            int timeInAir = (int)(distance / speed);
            int hoverTime = timeInAir / 10;
            if (distance > 1000)
            {
                Console.WriteLine("Flying to ({0}, {1}, {2}) at speed {3} km/h for {4} minutes and hovering for 1 minute every 10 minutes of flight and " +
                    "can't flight as it is beyond the maximum range of 1000 m", newPoint.x, newPoint.y, newPoint.z, speed, timeInAir);
            }
            currentPosition = newPoint;
        }
        public double GetFlyTime()
        {
            double distance = Math.Sqrt(Math.Pow(currentPosition.x, 2) + Math.Pow(currentPosition.y, 2) + Math.Pow(currentPosition.z, 2));
            return distance;
        }
    }