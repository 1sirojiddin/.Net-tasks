using System;

namespace Project_Car
{
    class Car_Park              // parent
    {
        public short power;
        public byte Volume;
        public string type;
        public string serial_number;
        public byte wheels;
        public short permissible_load;
        
        public short number_of_gears;
        public string manufacturer;
        public virtual void cartechniques()
        {
            Console.WriteLine("THE DETAILS OF DIFFERENT TYPES OF VEHICLES");
        }

    }
    class Passenger_Car : Car_Park // child
    {
        public Passenger_Car(short modelpower, byte modulVolume, string modultype, string modulserial_number, byte modulwheels, short modulnumber_of_gears, string modulmanufacturer) 
        {
            power = modelpower;
            Volume = modulVolume;
            type = modultype;
            serial_number = modulserial_number;
            wheels = modulwheels;
            number_of_gears = modulnumber_of_gears;
            manufacturer = modulmanufacturer;


                }
        public override void cartechniques()
        {
            Console.WriteLine("Detail information about Passenger Car");
        }
    }
    class Truck : Car_Park     // child
    {
        public Truck(short modelpower, byte modulVolume, string modultype, string modulserial_number, byte modulwheels, short modulnumber_of_gears, string modulmanufacturer)
        {
            power = modelpower;
            Volume = modulVolume;
            type = modultype;
            serial_number = modulserial_number;
            wheels = modulwheels;
            number_of_gears = modulnumber_of_gears;
            manufacturer = modulmanufacturer;

        }
        public override void cartechniques()
        {
            Console.WriteLine("Detail information about Truck");
        }
    }
    class Bus : Car_Park             //child
    {
        public Bus(short modelpower, byte modulVolume, string modultype, string modulserial_number, byte modulwheels, short modulnumber_of_gears, string modulmanufacturer)
        {
            power = modelpower;
            Volume = modulVolume;
            type = modultype;
            serial_number = modulserial_number;
            wheels = modulwheels;
            number_of_gears = modulnumber_of_gears;
            manufacturer = modulmanufacturer;

        }

        public override void cartechniques()
        {
            Console.WriteLine("Detail information about Bus");
        }
    }
    class Scooter : Car_Park       //child
    {
        public Scooter(short modelpower, byte modulVolume, string modultype, string modulserial_number, byte modulwheels, short modulnumber_of_gears, string modulmanufacturer)
        {
            power = modelpower;
            Volume = modulVolume;
            type = modultype;
            serial_number = modulserial_number;
            wheels = modulwheels;
            number_of_gears = modulnumber_of_gears;
            manufacturer = modulmanufacturer;

        }
        public override void cartechniques()
        {
            Console.WriteLine("Detail information about Scooter");
        }
    }

    class Program
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
            Console.WriteLine("Engine Details/ Power: " + cars.power + " Volume: " + cars.Volume + " Type: " + cars.type + " Serial Number: " + cars.serial_number + " Chassis/ Wheels: " + cars.wheels + " Permissible load: " + cars.permissible_load + " Transmission/ Number of gears: " + cars.number_of_gears + " Manufacture: " + cars.manufacturer);
            truck.cartechniques();
            Console.WriteLine("Engine Details/ Power: " + truck.power + " Volume: " + truck.Volume + " Type: " + truck.type + " Serial Number: " + truck.serial_number + " Chassis/ Wheels: " + truck.wheels + " Permissible load: " + truck.permissible_load + " Transmission/ Number of gears: " + truck.number_of_gears + " Manufacture: " + truck.manufacturer);
            bus.cartechniques();
            Console.WriteLine("Engine Details/ Power: " + bus.power + " Volume: " + bus.Volume + " Type: " + bus.type + " Serial Number: " + bus.serial_number + "Chassis/ Wheels: " + bus.wheels + " Permissible load: " + bus.permissible_load + " Transmission/ Number of gears: " + bus.number_of_gears + " Manufacture: " + bus.manufacturer);
            scooter.cartechniques();
            Console.WriteLine("Engine Details/ Power: " + scooter.power + " Volume: " + scooter.Volume + " Type: " + scooter.type + " Serial Number: " + scooter.serial_number + " Chassis/ Wheels: " + scooter.wheels + " Permissible load: " + scooter.permissible_load + " Transmission/ Number of gears: " + scooter.number_of_gears + " Manufacture: " + scooter.manufacturer);

            Console.ReadLine();
        }
    }

}


