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
        
        
        public short NumberOfGears;
        public string Manufacturer;
        public virtual void cartechniques()
        {
            Console.WriteLine("THE DETAILS OF DIFFERENT TYPES OF VEHICLES");
        }

    }
    public class PassengerCar : CarPark // child
    {
        public PassengerCar(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, short modulNumberOfGears, string modulManufacturer) 
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;


                }
        public override void cartechniques()
        {
            Console.WriteLine("Detail information about Passenger Car");
        }
    }
    public class Truck : CarPark     // child
    {
        public Truck(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }
        public override void cartechniques()
        {
            Console.WriteLine("Detail information about Truck");
        }
    }
    public class Bus : CarPark             //child
    {
        public Bus(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }

        public override void cartechniques()
        {
            Console.WriteLine("Detail information about Bus");
        }
    }
   public class Scooter : CarPark       //child
    {
        public Scooter(short modulPower, byte modulVolume, string modulType, string modulSerialNumber, byte modulWheels, short modulNumberOfGears, string modulManufacturer)
        {
            Power = modulPower;
            Volume = modulVolume;
            Type = modulType;
            SerialNumber = modulSerialNumber;
            Wheels = modulWheels;
            NumberOfGears = modulNumberOfGears;
            Manufacturer = modulManufacturer;

        }
        public override void cartechniques()
        {
            Console.WriteLine("Detail information about Scooter");
        }
    }

   public class Program
    {
        static void Main(string[] args)
        {
            Car_Park Vehicles= new Car_Park();
            Car_Park cars = new Passenger_Car(200, 222, "camaro", "f213g232", 4, 4, "deutsche production");
            Car_Park truck = new Truck(300, 250, "Tractor", "fdsf343242df", 4, 4, "Russian Production" );
            Car_Park bus = new Bus(600, 250, "Mercedes", "der34354fdsf", 4, 4, "Deutsch technology");
            Car_Park scooter = new Scooter(20, 23, "Changan", "d34r35t4", 2, 2, "Chinese technology");

            Vehicles.cartechniques();
           
            
            
            cars.cartechniques();
            Console.WriteLine("Engine Details/ Power: " + cars.Power + " Volume: " + cars.Volume + " Type: " + cars.Type + " Serial Number: " + cars.SerialNumber + " Chassis/ Wheels: " + cars.Wheels + " Transmission/ Number of gears: " + cars.NumberOfGears + " Manufacture: " + cars.Manufacturer);
            truck.cartechniques();
            Console.WriteLine("Engine Details/ Power: " + truck.Power + " Volume: " + truck.Volume + " Type: " + truck.Type + " Serial Number: " + truck.SerialNumber + " Chassis/ Wheels: " + truck.Wheels + " Transmission/ Number of gears: " + truck.NumberOfGears + " Manufacture: " + truck.Manufacturer);
            bus.cartechniques();
            Console.WriteLine("Engine Details/ Power: " + bus.Power + " Volume: " + bus.Volume + " Type: " + bus.Type + " Serial Number: " + bus.SerialNumber + "Chassis/ Wheels: " + bus.Wheels +" Transmission/ Number of gears: " + bus.NumberOfGears + " Manufacture: " + bus.Manufacturer);
            scooter.cartechniques();
            Console.WriteLine("Engine Details/ Power: " + scooter.Power + " Volume: " + scooter.Volume + " Type: " + scooter.Type + " Serial Number: " + scooter.SerialNumber + " Chassis/ Wheels: " + scooter.Wheels + " Transmission/ Number of gears: " + scooter.NumberOfGears + " Manufacture: " + scooter.Manufacturer);

            Console.ReadLine();
        }
    }

}


