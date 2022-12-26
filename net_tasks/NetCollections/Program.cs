using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectCarXmlTransform
{
    Public class PassengerCar
    {
        public string ModelVehicle { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public int Volume { get; set; }
        public int Wheels { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string NumberOfGears { get; set; }

    }
    Public class Truck
    {
        public string ModelVehicle { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public int Volume { get; set; }
        public int Wheels { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string NumberOfGears { get; set; }
    }
    Public class Bus
    {
        public string ModelVehicle { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public int Volume { get; set; }
        public int Wheels { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string NumberOfGears { get; set; }
    }
    Public class Scooter
    {
        public string ModelVehicle { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public int Volume { get; set; }
        public int Wheels { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string NumberOfGears { get; set; }
    }

    Public class XMLTransform
    {
        static void Main()
        {
            // Create the data source by using a collection initializer.
            // The Student class was defined previously in this topic.
            List<PassengerCar> car = new List<PassengerCar>()
            {
                new PassengerCar {ModelVehicle="Cadillac CT4 2022", Power=325, Type="Luxury sports sedan", Wheels=4,  Volume=90, SerialNumber="N0460056",NumberOfGears="Twin turbo, six speed", Manufacturer="GeneralMotors" },
            };
            List<Truck> truck = new List<Truck>()
            {
                new Truck {ModelVehicle="Actros 2640LS", Power=400, Type="Integral Power Steering", Wheels=10,  Volume=90, SerialNumber="N0460056",NumberOfGears="Twin turbo, six speed", Manufacturer="GeneralMotors"}
            };
            List<Bus> bus = new List<Bus>()
            {
                new Bus{ModelVehicle="eCitaro", Power=490, Type="Voith automatic transmission", Wheels=4,  Volume=96, SerialNumber="WEB63960113221075",NumberOfGears="five different 16-speed gearbox", Manufacturer="Mercedes-Benz"}
            };
            List<Scooter> scooter = new List<Scooter>()
            {
                new Scooter{ModelVehicle="Apollo city", Power=500, Type="electric scooter", Wheels=2,  Volume=48, SerialNumber="City2101101",NumberOfGears="14.5 Max.speed", Manufacturer="Electric Scooter Factory"}
            };
            // Create the query.
            var CarsToXml = new XElement("Root",

                from PassengerCar in car
                select new XElement("PassengerCarDetails",
                            new XElement("ModerVehicle", PassengerCar.ModelVehicle),
                            new XElement("Power", PassengerCar.Power),
                            new XElement("Type", PassengerCar.Type),
                            new XElement("Wheels", PassengerCar.Wheels),
                            new XElement("Volume", PassengerCar.Volume),
                            new XElement("SerialNumber", PassengerCar.SerialNumber),
                            new XElement("Manufacturer", PassengerCar.Manufacturer)
                            ),
                 from Truck in truck
                 select new XElement("TruckCarDetails",
                             new XElement("ModerVehicle", Truck.ModelVehicle),
                             new XElement("Power", Truck.Power),
                             new XElement("Type", Truck.Type),
                             new XElement("Wheels", Truck.Wheels),
                             new XElement("Volume", Truck.Volume),
                             new XElement("SerialNumber", Truck.SerialNumber),
                             new XElement("Manufacturer", Truck.Manufacturer)
                             ),
                 from Bus in bus
                 select new XElement("BusCarDetails",
                             new XElement("ModerVehicle", Bus.ModelVehicle),
                             new XElement("Power", Bus.Power),
                             new XElement("Type", Bus.Type),
                             new XElement("Wheels", Bus.Wheels),
                             new XElement("Volume", Bus.Volume),
                             new XElement("SerialNumber", Bus.SerialNumber),
                             new XElement("Manufacturer", Bus.Manufacturer)
                             ),
                 from Scooter in scooter
                 select new XElement("ScooterCarDetails",
                             new XElement("ModerVehicle", Scooter.ModelVehicle),
                             new XElement("Power", Scooter.Power),
                             new XElement("Type", Scooter.Type),
                             new XElement("Wheels", Scooter.Wheels),
                             new XElement("Volume", Scooter.Volume),
                             new XElement("SerialNumber", Scooter.SerialNumber),
                             new XElement("Manufacturer", Scooter.Manufacturer)
                             )
                 
                               
                ) ;
            Console.WriteLine(CarsToXml);
            Console.ReadLine();
        }
    }
}
