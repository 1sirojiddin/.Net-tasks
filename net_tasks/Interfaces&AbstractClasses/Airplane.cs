using System;


namespace Coordinate
{
    public class AirPlane : IFlyable           //Class Airplane
                                          // create a system that the guest chooses destination  
    {
        public void flyTo()
        {
            Console.WriteLine("Choose the fly deestination ");
            Console.WriteLine("1. Amsterdam to London");                // first destination
            Console.WriteLine("2. Italy to France");                    // second destination
        }
        public void getFlyTime()
        {
            Console.WriteLine("Type a given number 1 or 2, and then press Enter");      //technique is created to choose
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 1)
            {
                Console.WriteLine("You choose Italy to France, destination between them 928 km.");  // destination distance is given 
                int numberOne = 928 / 200;
                Console.WriteLine($"Arrival time is {numberOne} Hours");          // arrival time is given
            }
            else
            {
                Console.WriteLine("You choose Amsterdam to London, destination between them 357 km.");      //the same method like upstairs
                int numberTwo = 357 / 200;
                Console.WriteLine($"Arrival time is {numberTwo} Hours");
            }
            Console.WriteLine();
        }
    }
}
