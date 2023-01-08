using System;

namespace experiment
{
    class Truck : CarPark
    {
        public Truck(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfSeats = modulNumberOfSeats;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;
        }
        public override void DefineTo()
        {
            Console.WriteLine("");
            Console.WriteLine("Truck        |");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
