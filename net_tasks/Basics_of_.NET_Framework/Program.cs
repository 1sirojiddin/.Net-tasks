using System;

namespace IntegerInDecimal
{
    class Program
    {                                   //Basically, I do not understand the ex., however i used two ways
        static void Main()
        {
            //decimal num = Convert.ToDecimal(Console.ReadLine());        //first way takes int to decimal and shows in the command line
            //Console.WriteLine($"Your written number is {num}");
           
            Console.WriteLine("Write the number with comma. Example, 12,1");        // second way takes decimal and shows in the command line
            float numSecond = float.Parse(Console.ReadLine());
            Console.WriteLine($"Your written decimal number is {numSecond} ");
        }
    }
}
