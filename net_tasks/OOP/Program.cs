using System;

namespace ProjectCar
{ 
    public class Program
    {
        public static void Main()
        {
            CarPark vehicles = new CarPark();
            CarPark car = new PassengerCar(200, 222, "Camaro", "F213g232", 4, 4, 6, "Deutsche Production");
            CarPark truck = new Truck(300, 250, "Tractor", "Fdsf343242df", 4, 2, 5, "Russian Production");
            CarPark bus = new Bus(600, 250, "Mercedes", "Der34354fdsf", 4, 50, 4, "Deutsch Technology");
            CarPark scooter = new Scooter(20, 23, "Changan", "D34r35t4", 2, 1, 2, "Chinese Technology");
            vehicles.DefineTo();
            car.DefineTo();
            Console.WriteLine($"Engine Details | Power:  {car.power} Volume: {car.volume} Type: {car.type} Serial Number: {car.serialNumber} Chassis | Wheels: {car.wheels}  Transmission |Number of gears: {car.numberOfGears} Manufacture: {car.manufacturer}");
            truck.DefineTo();
            Console.WriteLine($"Engine Details | Power: {truck.power} Volume: {truck.volume} Type: {truck.type} Serial Number: {truck.serialNumber} Chassis | Wheels: {truck.wheels}  Transmission | Number of gears: {truck.numberOfGears} Manufacture: {truck.manufacturer}");
            bus.DefineTo();
            Console.WriteLine($"Engine Details | Power: {bus.power} Volume: {bus.volume} Type: {bus.type} Serial Number: {bus.serialNumber} Chassis |Wheels: {bus.wheels}  Transmission | Number of gears: {bus.numberOfGears} Manufacture: {bus.manufacturer}");
            scooter.DefineTo();
            Console.WriteLine($"Engine Details | Power: {scooter.power} Volume: {scooter.volume} Type: {scooter.type} Serial Number: {scooter.serialNumber} Chassis |Wheels: {scooter.wheels}  Transmission | Number of gears: {scooter.numberOfGears} Manufacture: {scooter.manufacturer}");
            if (car.NumberOfSeats > 0)
            { Console.WriteLine($"Number of seats in car is {car.numberOfSeats} "); }
            else
            { Console.WriteLine("Error"); }
            if (truck.NumberOfSeats > 0)
            { Console.WriteLine($"Number of seats in truck is {truck.numberOfSeats}"); }
            else
            { Console.WriteLine("Error"); }
            if (bus.NumberOfSeats > 0)
            { Console.WriteLine($"Number of seats in bus is {bus.numberOfSeats}"); }
            else
            { Console.WriteLine("Error"); }
            if (scooter.NumberOfSeats > 0)
            { Console.WriteLine($"Number of seats in scooter is {scooter.numberOfSeats}"); }
            else
            { Console.WriteLine("Error"); }
           // if.. else.. it shows if number of seats > 0 is correct, if not " < 0" error
            Console.ReadLine();
        }
    }
}


