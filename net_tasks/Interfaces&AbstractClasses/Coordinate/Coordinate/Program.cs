﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Coordinate2
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
            int num3 = 15;
            Console.WriteLine("The Bird flight speed is " + num3);
            Console.WriteLine("Press the enter to cross over next chapter");
            Console.ReadLine();

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
            Console.WriteLine("Choose the fly deestination ");
            Console.WriteLine("1. Amsterdam to London");
            Console.WriteLine("2. Italy to France");
        }
        public void GetFlyTime()
        {
            Console.WriteLine("Type a given number 1 or 2, and then press Enter");
            int num1 = 0;
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 1)
            {
                Console.WriteLine("You choose Italy to France, destination between them 928 km.");
                int x1 = 928 / 200;
                Console.WriteLine("Arrival time is " + x1 + " Hours");
            }
            else
            {
                Console.WriteLine("You choose Amsterdam to London, destination between them 357 km.");
                int x2 = 357 / 200;
                Console.WriteLine("Arrival time is " + x2 + " Hours");
            }
            Console.WriteLine();
        }
    }
    class Drone : IFlyable
    {
        public void FlyTo()
        {
            int speed = 349; int flight_time = 2160;   //30 minutes convert to hour
            int flight_distamce = speed * flight_time / 1000;
            Console.WriteLine("Information about drone ");
            Console.WriteLine("Tape the given number to take an information");
            Console.WriteLine("1.Speed");
            Console.WriteLine("2.Flight time");
            Console.WriteLine("3.Flight distance");
            int num2 = 0;
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (num2)
            {
                case 1:
                    Console.WriteLine("The drone's speed flight is : " + speed);
                    break;
                case 2:
                    Console.WriteLine("The drone's flight time flight is : " + flight_time);
                    break;
                case 3:
                    Console.WriteLine("The drone's speed flight is :" + flight_distamce);
                    break;
            }

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
            Bird mybird = new Bird(); //create a bird object
            mybird.FlyTo();
            mybird.GetFlyTime();
            AirPlane myairplane = new AirPlane(); //create a airplane object
            myairplane.FlyTo();
            myairplane.GetFlyTime();
            Console.WriteLine("To know about drone press the Enter");
            Console.ReadLine();
            Drone mydrone = new Drone(); //create a drone ojbject
            mydrone.FlyTo();
            mydrone.GetFlyTime();

            Console.ReadLine();
        }
    }
}