using System;

namespace Coordinate
{
    interface IFlyable
    {
        void FlyTo();    
        void GetFlyTime();
    }
    class Bird : IFlyable
    {
        public void FlyTo()
        {
            Console.WriteLine("Flight destination: Amsterdam to Italy");
            
        }
        public void GetFlyTime()
        {
            Console.WriteLine();
        }
    }
    class AirPlane : IFlyable
    {
        public void FlyTo()
        {
            Console.WriteLine();
        }
        public void GetFlyTime()
        {
            Console.WriteLine();
        }
    }
    class Drone : IFlyable
    {
        public void FlyTo()
        {
            Console.WriteLine();
        }
        public void GetFlyTime()
        {
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

