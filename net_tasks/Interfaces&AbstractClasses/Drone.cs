using System;

namespace Coordinate
{
    class Drone : IFlyable                            //Class Drone
    {
        public void FlyTo()                         //there is given infrmation about drone's properties
        {
            int Speed = 349; int FlightTime = 2160;   //30 minutes convert to hour
            int FlightDistamce =Speed * FlightTime / 1000;
            Console.WriteLine("Information about drone ");
            Console.WriteLine("Tape the given number to take an information");
            Console.WriteLine("1.Speed");
            Console.WriteLine("2.Flight time");
            Console.WriteLine("3.Flight distance");
            int Z = Convert.ToInt32(Console.ReadLine());         //switch method that the guest  chooses which one is interesting
            switch (Z)
            {
                case 1:
                    Console.WriteLine($"The drone's speed flight is : {Speed}");
                    break;
                case 2:
                    Console.WriteLine($"The drone's flight time flight is : {FlightTime}");
                    break;
                case 3:
                    Console.WriteLine($"The drone's speed flight is : {FlightDistamce}");
                    break;
            }

        }
        public void GetFlyTime(){}
    }
}
