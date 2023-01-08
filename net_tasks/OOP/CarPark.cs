using System;

namespace CarPark
{
    public class CarPark
    {
        public short Power;
        public byte Volume;
        public string Type;
        public string SerialNumber;
        public byte Wheels;
        public int NumberOfSeats;
        public short NumberOfGears;
        public string Manufacturer;
        public virtual void DefineTo()
        {
            Console.WriteLine("The details of different types of vehicles");
            Console.WriteLine("");
        }
    }
}
