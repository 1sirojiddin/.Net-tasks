using System;

namespace CarPark
{   
    class Bus : CarPark
    {
            public Bus(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
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
                Console.WriteLine("Bus          |");
                Console.WriteLine("");
                Console.WriteLine("");
            }
    }
}
