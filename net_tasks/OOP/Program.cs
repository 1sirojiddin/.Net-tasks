using System;
using CarPark; 

namespace ProjectCar
{ 
    class Program
    {
        public static void Main()
        {
            CarPark vehicles = new CarPark();
            CarPark car = new PassengerCar(200, 222, "camaro", "f213g232", 4, 4, 6, "deutsche production");
            CarPark truck = new Truck(300, 250, "Tractor", "fdsf343242df", 4, 2, 5, "Russian Production");
            CarPark bus = new Bus(600, 250, "Mercedes", "der34354fdsf", 4, 50, 4, "Deutsch technology");
            CarPark scooter = new Scooter(20, 23, "Changan", "d34r35t4", 2, 1, 2, "Chinese technology");
            vehicles.DefineTo();
            cars.DefineTo();
            Console.WriteLine($"Engine Details | Power:  {cars.Power} Volume: {cars.Volume} Type: {cars.Type} Serial Number: {cars.SerialNumber} Chassis | Wheels: {cars.Wheels}  Transmission |Number of gears: {cars.NumberOfGears} Manufacture: {cars.Manufacturer}");
            truck.DefineTo();
            Console.WriteLine($"Engine Details | Power: {truck.Power} Volume: {truck.Volume} Type: {truck.Type} Serial Number: {truck.SerialNumber} Chassis | Wheels: {truck.Wheels}  Transmission | Number of gears: {truck.NumberOfGears} Manufacture: {truck.Manufacturer}");
            bus.DefineTo();
            Console.WriteLine($"Engine Details | Power: {bus.Power} Volume: {bus.Volume} Type: {bus.Type} Serial Number: {bus.SerialNumber} Chassis |Wheels: {bus.Wheels}  Transmission | Number of gears: {bus.NumberOfGears} Manufacture: {bus.Manufacturer}");
            scooter.DefineTo();
            Console.WriteLine($"Engine Details | Power: {scooter.Power} Volume: {scooter.Volume} Type: {scooter.Type} Serial Number: {scooter.SerialNumber} Chassis |Wheels: {scooter.Wheels}  Transmission | Number of gears: {scooter.NumberOfGears} Manufacture: {scooter.Manufacturer}");
            if (cars.NumberOfSeats > 0)
            { Console.WriteLine($"Number of seats in car is {cars.NumberOfSeats} "); }
            else
            { Console.WriteLine("Error"); }
            if (truck.NumberOfSeats > 0)
            { Console.WriteLine($"Number of seats in truck is {truck.NumberOfSeats}"); }
            else
            { Console.WriteLine("Error"); }
            if (bus.NumberOfSeats > 0)
            { Console.WriteLine($"Number of seats in bus is {bus.NumberOfSeats}"); }
            else
            { Console.WriteLine("Error"); }
            if (scooter.NumberOfSeats > 0)
            { Console.WriteLine($"Number of seats in scooter is {scooter.NumberOfSeats}"); }
            else
            { Console.WriteLine("Error"); }
           // if.. else.. it shows if number of seats > 0 is correct, if not " < 0" error
            Console.ReadLine();
        }
    }
}


