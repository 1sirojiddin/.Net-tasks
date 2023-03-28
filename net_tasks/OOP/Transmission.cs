using System;


namespace CarPark
{
public class Transmission : Vehicle
{
    private short numberOfGears;
    private string manufacturer;
    public short NumberOfGears { get { return numberOfGears; } set { numberOfGears = value; } }
    public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
    public Transmission(short modulNumberOfGears, string modulManufacturer)
    {
        NumberOfGears = modulNumberOfGears;
        Manufacturer = modulManufacturer;
    }
}
}
