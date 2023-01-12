using System;

namespace CarPark
{   
    class Bus : CarPark
    {
            public Bus(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
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
                Console.WriteLine("Bus          |");
                Console.WriteLine("");
                Console.WriteLine("");
            }
    }
}
