using System;


namespace experiment2
{
    class AirPlane : IFlyable           //Class Airplane
                                          // create a system that the guest chooses destination  
    {
        public void FlyTo()
        {
            Console.WriteLine("Choose the fly deestination ");
            Console.WriteLine("1. Amsterdam to London");                // first destination
            Console.WriteLine("2. Italy to France");                    // second destination
        }
        public void GetFlyTime()
        {
            Console.WriteLine("Type a given number 1 or 2, and then press Enter");      //technique is created to choose
            int X = Convert.ToInt32(Console.ReadLine());
            if (X > 1)
            {
                Console.WriteLine("You choose Italy to France, destination between them 928 km.");  // destination distance is given 
                int XOne = 928 / 200;
                Console.WriteLine($"Arrival time is {XOne} Hours");          // arrival time is given               
            else
            {
                Console.WriteLine("You choose Amsterdam to London, destination between them 357 km.");      //the same method like upstairs
                int XTwo = 357 / 200;
                Console.WriteLine($"Arrival time is {XTwo} Hours");                  //in this place i can use switch method, however i use it to understand how it works
            }
            Console.WriteLine();
        }
    }
}
