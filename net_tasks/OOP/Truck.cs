using System;

namespace CarPark
{
    public class Truck : CarPark
    {
        public Truck(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
        {
            power = modulPower;
            volume = modulVolume;
            type = modulType;
            serialNumber = modulSerialNumber;
            wheels = modulWheels;
            numberOfSeats = modulNumberOfSeats;
            numberOfGears = modulNumberOfGears;
            manufacturer = modulManufacturer;
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
