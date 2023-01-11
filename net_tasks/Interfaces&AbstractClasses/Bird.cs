using System;

namespace Coordinate
{
    class Bird : IFlyable              //class Bird
    {
        public void flyTo()
        {
            int speed = 15;                                                  // Bird's speed
            Console.WriteLine($"The bird flight speed is {speed}");
            Console.WriteLine("Press the enter to cross over next chapter");
            Console.ReadLine();
        }
        public void getFlyTime(){}
    }
}
