using System;

namespace CarPark
{
   class PassengerCar : CarPark
    {
        public PassengerCar(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
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
            Console.WriteLine("Passenger Car|");
             Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
