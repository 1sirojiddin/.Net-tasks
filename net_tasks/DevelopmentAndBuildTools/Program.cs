using System;

namespace DevelopmentAndBuildTools
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter some symbols: ");
            int num = 0;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your choosen number is {num}");
        }
    }
}
