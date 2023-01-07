using System;

namespace DevelopmentAndBuildTools
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter some symbols: ");
<<<<<<< HEAD
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The End");
=======
            int num = 0;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your choosen number is {num}");
>>>>>>> c65b5bf070c40fe9990f50668682c2b9b82e98d5
        }
    }
}
