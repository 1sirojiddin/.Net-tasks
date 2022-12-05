using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectCarXmlTranformation
{
    class PassengerCar
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
    class Truck
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
    class Bus
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
    class Scooter
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

        class XMLTransform
        {
            static void Main()
            {
                // Create the data source by using a collection initializer.
                // The Student class was defined previously in this topic.
                List<PassengerCar> cars = new List<PassengerCar>()
            {
                new PassengerCar {ModelVehicle="Cadillac CT4 2022", Power=325, Type="Luxury sports sedan", Wheels=4,  Volume=5, SerialNumber="N0460056",NumberOfGears="Twin turbo, six speed", Manufacturer="GeneralMotors" },
            };
            List<Truck> trucks = new List<Truck>()
            {
                new Truck {ModelVehicle="Actros 2640LS", Power=325, Type="Luxury sports sedan", Wheels=4,  Volume=5, SerialNumber="N0460056",NumberOfGears="Twin turbo, six speed", Manufacturer="GeneralMotors"}
            };
            List<Bus> buses = new List<Bus>()
            {
                new Bus{ModelVehicle="Cadillac CT4 2022", Power=325, Type="Luxury sports sedan", Wheels=4,  Volume=5, SerialNumber="N0460056",NumberOfGears="Twin turbo, six speed", Manufacturer="GeneralMotors"}
            };
            List<Scooter> scooters = new List<Scooter>()
            {
                new Scooter{ModelVehicle="Cadillac CT4 2022", Power=325, Type="Luxury sports sedan", Wheels=4,  Volume=5, SerialNumber="N0460056",NumberOfGears="Twin turbo, six speed", Manufacturer="GeneralMotors"}
            };
            // Create the query.
            var carsToXML = new XElement("Root",
                from PassengerCar in cars
               
               
                from Scooter in scooters
                select new XElement("Passenger_Car_details",
                            new XElement("PowerVehicle", PassengerCar.ModelVehicle),
                            new XElement("Power", PassengerCar.Power),
                            new XElement("Type", PassengerCar.Type),
                            new XElement("Wheels", PassengerCar.Wheels),
                            new XElement("Volume", PassengerCar.Volume),
                            new XElement("SerialNumber", PassengerCar.SerialNumber),
                            new XElement("Manufacturer", PassengerCar.Manufacturer)


                        ) ,// end "PassengerCar"

                 from Truck in trucks
                 select new XElement("TruckDetails",
                            new XElement("PowerVehicle", Truck.ModelVehicle),
                            new XElement("Power", Truck.Power),
                            new XElement("Type", Truck.Type),
                            new XElement("Wheels", Truck.Wheels),
                            new XElement("Volume", Truck.Volume),
                            new XElement("SerialNumber", Truck.SerialNumber),
                            new XElement("Manufacturer", Truck.Manufacturer)

                    ),
                  from Bus in buses
                  select new XElement("BusDetails",
                            new XElement("PowerVehicle", Bus.ModelVehicle),
                            new XElement("Power", Bus.Power),
                            new XElement("Type", Bus.Type),
                            new XElement("Wheels", Bus.Wheels),
                            new XElement("Volume", Bus.Volume),
                            new XElement("SerialNumber", Bus.SerialNumber),
                            new XElement("Manufacturer", Bus.Manufacturer)
                            ),
                  from Scooter in scooters
                  select new XElement("ScooterDetails",
                           new XElement("PowerVehicle", Scooter.ModelVehicle),
                           new XElement("Power", Scooter.Power),
                           new XElement("Type", Scooter.Type),
                           new XElement("Wheels", Scooter.Wheels),
                           new XElement("Volume", Scooter.Volume),
                           new XElement("SerialNumber", Scooter.SerialNumber),
                           new XElement("Manufacturer", Scooter.Manufacturer)
                           )
                ) ; // end "Root"

                // Execute the query.
                Console.WriteLine(carsToXML);
                

                // Keep the console open in debug mode.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    

}
