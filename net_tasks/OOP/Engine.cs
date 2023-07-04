using System;


namespace CarPark
{

public class Engine : Vehicle
{
    private short power;
    private byte volume;
    private string type;
    private string serialNumber;
    public short Power { get { return power; } set { power = value; } }
    public byte Volume { get { return volume; } set { volume = value; } }
    public string Type { get { return type; } set { type = value; } }
    public string SerialNumber { get { return serialNumber; } set { serialNumber = value; } }
    public Engine(short modulPower, byte modulVolume, string modulType, string modulSerialNumber)
    {
        Power = modulPower;
        Volume = modulVolume;
        Type = modulType;
        SerialNumber = modulSerialNumber;
    }
}
}
