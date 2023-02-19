using System;

namespace ProjectCarXmlTransform
{
public class Union
{
    private string _modelVehicle;
    private int _power;
    private string _type;
    private short _volume;
    private short _wheels;
    private string _serialNumber;
    private string _manufacturer;
    private string _numberOfGears;
    public string ModelVehicle { get { return _modelVehicle; } set { _modelVehicle = value; } }
    public int Power { get { return _power; } set { _power = value; } }
    public string Type { get { return _type; } set { _type = value; } }
    public short Volume { get { return _volume; } set { _volume = value; } }
    public short Wheels { get { return _wheels; } set { _wheels = value; } }
    public string SerialNumber { get { return _serialNumber; } set { _serialNumber = value; } }
    public string Manufacturer { get { return _manufacturer; } set { _manufacturer = value; } }
    public string NumberOfGears { get { return _numberOfGears; } set { _numberOfGears = value; } }  
}
