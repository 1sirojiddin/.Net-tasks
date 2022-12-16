using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerindecimal
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
        public virtual void Cartechniques()
        {
            Console.WriteLine("THE DETAILS OF DIFFERENT TYPES OF VEHICLES");
        }

    }
    public class PassengerCar : CarPark // child
    {
        public PassengerCar(short modulPower, byte modulVolume, string modulType, int modulNumberOfSeats, string modulSerialNumber, byte modulWheels, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            NumberOfSeats = modulNumberOfSeats;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;
            


        }
        public override void Cartechniques()
        {
            Console.WriteLine("Detail information about Passenger Car");
        }
    }
    public class Truck : CarPark     // child
    {
        public Truck(short modulPower, byte modulVolume, string modulType, int modulNumberOfSeats, string modulSerialNumber, byte modulWheels, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            NumberOfSeats = modulNumberOfSeats;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }
        public override void Cartechniques()
        {
            Console.WriteLine("Detail information about Truck");
        }
    }
    public class Bus : CarPark             //child
    {
        public Bus(short modulPower, byte modulVolume, string modulType, int modulNumberOfSeats, string modulSerialNumber, byte modulWheels, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            NumberOfSeats = modulNumberOfSeats;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }

        public override void Cartechniques()
        {
            Console.WriteLine("Detail information about Bus");
        }
    }
    public class Scooter : CarPark       //child
    {
        public Scooter(short modulPower, byte modulVolume, string modulType, int modulNumberOfSeats, string modulSerialNumber, byte modulWheels, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            NumberOfSeats = modulNumberOfSeats;
            //if (Console.ReadLine() == "0") endapp = true;
     
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }
        public override void Cartechniques()
        {
            Console.WriteLine("Detail information about Scooter");

        }
    }

    public class Program
    {
        static void Main()
        {
            CarPark Vehicles = new CarPark();
            CarPark cars = new PassengerCar(200, 222, "camaro", 4, "f213g232", 4, 4, "deutsche production");
            CarPark truck = new Truck(300, 250, "Tractor", 2, "fdsf343242df", 4, 4, "Russian Production");
            CarPark bus = new Bus(600, 250, "Mercedes", 50, "der34354fdsf", 4, 4, "Deutsch technology");
            CarPark scooter = new Scooter(20, 23, "Changan", 1, "d34r35t4", 2, 2, "Chinese technology");
            


            Vehicles.Cartechniques();

            cars.Cartechniques();
            Console.WriteLine("Engine Details/ Power: " + cars.Power + " Volume: " + cars.Volume + " Type: " + cars.Type + " Serial Number: " + cars.SerialNumber + " Chassis/ Wheels: " + cars.Wheels + " Transmission/ Number of gears: " + cars.NumberOfGears + " Manufacture: " + cars.Manufacturer);
            truck.Cartechniques();
            Console.WriteLine("Engine Details/ Power: " + truck.Power + " Volume: " + truck.Volume + " Type: " + truck.Type + " Serial Number: " + truck.SerialNumber + " Chassis/ Wheels: " + truck.Wheels + " Transmission/ Number of gears: " + truck.NumberOfGears + " Manufacture: " + truck.Manufacturer);
            bus.Cartechniques();
            Console.WriteLine("Engine Details/ Power: " + bus.Power + " Volume: " + bus.Volume + " Type: " + bus.Type + " Serial Number: " + bus.SerialNumber + "Chassis/ Wheels: " + bus.Wheels + " Transmission/ Number of gears: " + bus.NumberOfGears + " Manufacture: " + bus.Manufacturer);
            scooter.Cartechniques();
            Console.WriteLine("Engine Details/ Power: " + scooter.Power + " Volume: " + scooter.Volume + " Type: " + scooter.Type + " Serial Number: " + scooter.SerialNumber + " Chassis/ Wheels: " + scooter.Wheels + " Transmission/ Number of gears: " + scooter.NumberOfGears + " Manufacture: " + scooter.Manufacturer);
            
            Console.ReadLine();
        }
    }

}
