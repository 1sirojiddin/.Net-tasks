using System;

namespace CarPark
{
public class CarPark
{
    private short _power;
    private byte _volume;
    private string _type;
    private string _serialNumber;
    private byte _wheels;
    private int _numberOfSeats;
    private short _numberOfGears;
    private string _manufacturer;
    public short Power { get { return _power; } set { _power = value; } }
    public byte Volume { get { return _volume; } set { _volume = value; } }
    public string Type { get { return _type; } set { _type = value; } }
    public string SerialNumber { get { return _serialNumber; } set { _serialNumber = value; } }
    public byte Wheels { get { return _wheels; } set { _wheels = value; } }
    public short NumberOfGears { get { return _numberOfGears; } set { _numberOfGears = value; } }
    public int NumberOfSeats { get { return _numberOfSeats; } set { _numberOfSeats = value; } }
    public string Manufacturer { get { return _manufacturer; } set { _manufacturer = value; } }
    public virtual void DefineTo()
    {
        Console.WriteLine("                  The details of different types of vehicles");
        Console.WriteLine("");
    }
}
}
