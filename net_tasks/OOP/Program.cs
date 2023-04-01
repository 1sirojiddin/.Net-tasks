using System;

namespace CarPark
{

public class Program
{
public static void Main()
{
    Vehicle vehicle = new Vehicle();
    vehicle.DefineTo();
    vehicle.TestAmount();
    PassengerCar passengerCar = new PassengerCar();
    passengerCar.DefineTo();
    Truck truck = new Truck();
    truck.DefineTo();
    Bus bus = new Bus();
    bus.DefineTo();
    Scooter scooter = new Scooter();
    scooter.DefineTo();
    passengerCar.TestAmount();
    truck.TestAmount();
    bus.TestAmount();
    scooter.TestAmount();
    Console.ReadLine();
}
}
}


