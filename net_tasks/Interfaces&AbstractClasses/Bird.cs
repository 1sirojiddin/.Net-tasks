using System;

namespace Coordinate
{
    class Bird : IFlyable              //class Bird
    {
        public void FlyTo()
        {
            int Y = 15;                                                  // Bird's speed
            Console.WriteLine($"The Bird flight speed is {Y}");
            Console.WriteLine("Press the enter to cross over next chapter");
            Console.ReadLine();
        }
        public void GetFlyTime(){}
    }
}
