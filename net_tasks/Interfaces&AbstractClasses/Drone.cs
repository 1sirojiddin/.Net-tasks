using System;

namespace Coordinate
{
    public class Drone : IFlyable                            //Class Drone
    {
        public void flyTo()                         //there is given infrmation about drone's properties
        {
            int speed = 349; int flightTime = 2160;   //30 minutes convert to hour
            int flightDistance = speed * flightTime / 1000;
            Console.WriteLine("Information about drone ");
            Console.WriteLine("Tape the given number to take an information");
            Console.WriteLine("1.Speed");
            Console.WriteLine("2.Flight time");
            Console.WriteLine("3.Flight distance");
            int z = Convert.ToInt32(Console.ReadLine());         //switch method that the guest  chooses which one is interesting
            switch (z)
            {
                case 1:
                    Console.WriteLine($"The drone's speed flight is : {speed}");
                    break;
                case 2:
                    Console.WriteLine($"The drone's flight time flight is : {fightTime}");
                    break;
                case 3:
                    Console.WriteLine($"The drone's speed flight is : {flightDistamce}");
                    break;
            }

        }
        public void getFlyTime(){}
    }
}
