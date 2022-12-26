using System;

namespace Project_Car
{
    public class CarPark              // parent
    {
        public short Power;
        public byte Volume;
        public string Type;
        public string SerialNumber;
        public byte Wheels;
        public int NumberOfSeats;
        public short NumberOfGears;
        public string Manufacturer;
        public virtual void CarTechniques()
        {
            Console.WriteLine("THE DETAILS OF DIFFERENT TYPES OF VEHICLES");
        }

    }
    public class PassengerCar : CarPark // child
    {
        public PassengerCar(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfSeats = modulNumberOfSeats;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;


        }
        public override void CarTechniques()
        {
            Console.Write("Passenger Car|");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
    public class Truck : CarPark     // child
    {
        public Truck(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfSeats = modulNumberOfSeats;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }
        public override void CarTechniques()
        {
            Console.Write("Truck        |");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
    public class Bus : CarPark             //child
    {
        public Bus(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfSeats = modulNumberOfSeats;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }

        public override void CarTechniques()
        {
            Console.Write("Bus          |");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
    public class Scooter : CarPark       //child
    {
        public Scooter(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, int modulNumberOfSeats, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfSeats = modulNumberOfSeats;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }
        public override void CarTechniques()
        {
            Console.Write("Scooter      |");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }

    class Program
    {
        static void Main()
        {
            CarPark vehicles = new CarPark();
            CarPark cars = new PassengerCar(200, 222, "camaro", "f213g232", 4, 4, 6, "deutsche production");
            CarPark truck = new Truck(300, 250, "Tractor", "fdsf343242df", 4, 2, 5, "Russian Production");
            CarPark bus = new Bus(600, 250, "Mercedes", "der34354fdsf", 4, 50, 4, "Deutsch technology");
            CarPark scooter = new Scooter(20, 23, "Changan", "d34r35t4", 2, 1, 2, "Chinese technology");



            vehicles.CarTechniques();



            cars.CarTechniques();
            Console.WriteLine($"Engine Details | Power:  {cars.Power} Volume: {cars.Volume} Type: {cars.Type} Serial Number: {cars.SerialNumber} Chassis | Wheels: {cars.Wheels}  Transmission |Number of gears: {cars.NumberOfGears} Manufacture: {cars.Manufacturer}");
            truck.CarTechniques();
            Console.WriteLine($"Engine Details | Power: {truck.Power} Volume: {truck.Volume} Type: {truck.Type} Serial Number: {truck.SerialNumber} Chassis | Wheels: {truck.Wheels}  Transmission | Number of gears: {truck.NumberOfGears} Manufacture: {truck.Manufacturer}");
            bus.CarTechniques();
            Console.WriteLine($"Engine Details | Power: {bus.Power} Volume: {bus.Volume} Type: {bus.Type} Serial Number: {bus.SerialNumber} Chassis |Wheels: {bus.Wheels}  Transmission | Number of gears: {bus.NumberOfGears} Manufacture: {bus.Manufacturer}");
            scooter.CarTechniques();
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
                                                        -// if.. else.. it shows if number of seats > 0 is correct, if not " < 0" error
            Console.ReadLine();
        }
    }
}


