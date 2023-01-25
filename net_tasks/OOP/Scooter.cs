using System;

namespace CarPark
{
    public class Scooter : CarPark
    {
    public Scooter(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
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
        Console.Write("Scooter      |");
        Console.WriteLine("");
        Console.WriteLine("");
    }
    }
}
