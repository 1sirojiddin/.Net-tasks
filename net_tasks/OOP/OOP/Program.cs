using System;

namespace OOP
{

public class Program
{
public static void Main()
{
    var car = new PassengerCar
    {
        Model = "Toyota Camry",
        Year = 2021,
        Engine = new Engine { Power = 200, Volume = 2, Type = "Petrol", SerialNumber = "123456" },
        Chassis = new Chassis { WheelsNumber = 4, Number = 12345, PermissibleLoad = 500 },
        Transmission = new Transmission { Type = "Automatic", NumberOfGears = 8, Manufacturer = "Toyota" },
        NumberOfSeats = 5
    };
    Console.WriteLine("Passenger Car:");
    Console.WriteLine($"Model: {car.Model}");
    Console.WriteLine($"Year: {car.Year}");
    Console.WriteLine($"Engine Power: {car.Engine.Power}");
    Console.WriteLine($"Engine Volume: {car.Engine.Volume}");
    Console.WriteLine($"Engine Type: {car.Engine.Type}");
    Console.WriteLine($"Engine Serial Number: {car.Engine.SerialNumber}");
    Console.WriteLine($"Chassis Wheels Number: {car.Chassis.WheelsNumber}");
    Console.WriteLine($"Chassis Number: {car.Chassis.Number}");
    Console.WriteLine($"Chassis Permissible Load: {car.Chassis.PermissibleLoad}");
    Console.WriteLine($"Transmission Type: {car.Transmission.Type}");
    Console.WriteLine($"Transmission Number of Gears: {car.Transmission.NumberOfGears}");
    Console.WriteLine($"Transmission Manufacturer: {car.Transmission.Manufacturer}");
    Console.WriteLine($"Number of Seats: {car.NumberOfSeats}");
    Console.WriteLine();
    var truck = new Truck
    {
        Model = "Ford F-150",
        Year = 2022,
        Engine = new Engine { Power = 400, Volume = 5, Type = "Diesel", SerialNumber = "654321" },
        Chassis = new Chassis { WheelsNumber = 6, Number = 54321, PermissibleLoad = 1000 },
        Transmission = new Transmission { Type = "Automatic", NumberOfGears = 10, Manufacturer = "Ford" },
        CargoCapacity = 3000
    };
    Console.WriteLine("Truck:");
    Console.WriteLine($"Model: {truck.Model}");
    Console.WriteLine($"Year: {truck.Year}");
    Console.WriteLine($"Engine Power: {truck.Engine.Power}");
    Console.WriteLine($"Engine Volume: {truck.Engine.Volume}");
    Console.WriteLine($"Engine Type: {truck.Engine.Type}");
    Console.WriteLine($"Engine Serial Number: {truck.Engine.SerialNumber}");
    Console.WriteLine($"Chassis Wheels Number: {truck.Chassis.WheelsNumber}");
    Console.WriteLine($"Chassis Number: {truck.Chassis.Number}");
    Console.WriteLine($"Chassis Permissible Load: {truck.Chassis.PermissibleLoad}");
    Console.WriteLine($"Transmission Type: {truck.Transmission.Type}");
    Console.WriteLine($"Transmission Number of Gears: {truck.Transmission.NumberOfGears}");
    Console.WriteLine($"Transmission Manufacturer: {truck.Transmission.Manufacturer}");
    Console.WriteLine($"Cargo Capacity: {truck.CargoCapacity}");
    Console.WriteLine();
    var bus = new Bus
    {
        Model = "Mercedes-Benz Sprinter",
        Year = 2020,
        Engine = new Engine { Power = 170, Volume = 2, Type = "Diesel", SerialNumber = "987654" },
        Chassis = new Chassis { WheelsNumber = 4, Number = 24680, PermissibleLoad = 1500 },
        Transmission = new Transmission { Type = "Automatic", NumberOfGears = 7, Manufacturer = "Mercedes" },
        NumberOfPassengers = 20
    };
    Console.WriteLine("Bus:");
    Console.WriteLine($"Model: {bus.Model}");
    Console.WriteLine($"Year: {bus.Year}");
    Console.WriteLine($"Engine Power: {bus.Engine.Power}");
    Console.WriteLine($"Engine Volume: {bus.Engine.Volume}");
    Console.WriteLine($"Engine Type: {bus.Engine.Type}");
    Console.WriteLine($"Engine Serial Number: {bus.Engine.SerialNumber}");
    Console.WriteLine($"Chassis Wheels Number: {bus.Chassis.WheelsNumber}");
    Console.WriteLine($"Chassis Number: {bus.Chassis.Number}");
    Console.WriteLine($"Chassis Permissible Load: {bus.Chassis.PermissibleLoad}");
    Console.WriteLine($"Transmission Type: {bus.Transmission.Type}");
    Console.WriteLine($"Transmission Number of Gears: {bus.Transmission.NumberOfGears}");
    Console.WriteLine($"Transmission Manufacturer: {bus.Transmission.Manufacturer}");
    Console.WriteLine($"Number of Passengers: {bus.NumberOfPassengers}");
    Console.WriteLine();
    var scooter = new Scooter
    {
        Model = "Vespa Primavera",
        Year = 2021,
        Engine = new Engine { Power = 12, Volume = 1, Type = "Petrol", SerialNumber = "13579" },
        Chassis = new Chassis { WheelsNumber = 2, Number = 97531, PermissibleLoad = 150 },
        Transmission = new Transmission { Type = "Automatic", NumberOfGears = 1, Manufacturer = "Vespa" },
        MaxSpeed = 80
    };
    Console.WriteLine("Scooter:");
    Console.WriteLine($"Model: {scooter.Model}");
    Console.WriteLine($"Year: {scooter.Year}");
    Console.WriteLine($"Engine Power: {scooter.Engine.Power}");
    Console.WriteLine($"Engine Volume: {scooter.Engine.Volume}");
    Console.WriteLine($"Engine Type: {scooter.Engine.Type}");
    Console.WriteLine($"Engine Serial Number: {scooter.Engine.SerialNumber}");
    Console.WriteLine($"Chassis Wheels Number: {scooter.Chassis.WheelsNumber}");
    Console.WriteLine($"Chassis Number: {scooter.Chassis.Number}");
    Console.WriteLine($"Chassis Permissible Load: {scooter.Chassis.PermissibleLoad}");
    Console.WriteLine($"Transmission Type: {scooter.Transmission.Type}");
    Console.WriteLine($"Transmission Number of Gears: {scooter.Transmission.NumberOfGears}");
    Console.WriteLine($"Transmission Manufacturer: {scooter.Transmission.Manufacturer}");
    Console.WriteLine($"Max Speed: {scooter.MaxSpeed}");
    Console.WriteLine();
    Console.ReadLine();
}
}
}


