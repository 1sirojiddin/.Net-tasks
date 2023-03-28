using System;


namespace CarPark
{
public class Chassis : Vehicle
{
    private byte wheels;
    private int numberOfSeats;
    public byte Wheels { get { return wheels; } set { wheels = value; } }
    public int NumberOfSeats { get { return numberOfSeats; } set { numberOfSeats = value; } }
    public Chassis(byte modulWheels, int modulNumberOfSeats)
    {
        Wheels = modulWheels;
        NumberOfSeats = modulNumberOfSeats;
    }
}
}
