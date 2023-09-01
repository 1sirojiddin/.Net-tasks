using System;

namespace InterfacesAndAbstractClaseses;
    public class Program
    {
        public static void Main(string[] args)
        {
            Bird bird = new Bird(0, 0, 0);
            bird.FlyTo(new Coordinate(10, 20, 30));
            Console.WriteLine("Fly time: {0} hours", bird.GetFlyTime());

            Airplane airplane = new Airplane(0, 0, 0);
            airplane.FlyTo(new Coordinate(100, 200, 300));
            Console.WriteLine("Fly time: {0} hours", airplane.GetFlyTime());

            Drone drone = new Drone(0, 0, 0);
            drone.FlyTo(new Coordinate(500, 800, 1000));
            Console.WriteLine("Fly time: {0} hours", drone.GetFlyTime());
            Console.ReadLine();
        }
    }