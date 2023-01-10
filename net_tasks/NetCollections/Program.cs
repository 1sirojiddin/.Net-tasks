using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using ProjectCarXmlTransform;

namespace ProjectCarXmlTransform
{
        class XMLTransform
        {
            public static void Main()
            {
                List<PassengerCar> car = new List<PassengerCar>()
            {
                new PassengerCar {modelVehicle="Cadillac CT4 2022", power=325, type="Luxury sports sedan", wheels=4,  volume=90, serialNumber="N0460056",numberOfGears="Twin turbo, six speed", manufacturer="GeneralMotors" },
            };
                List<Truck> truck = new List<Truck>()
            {
                new Truck {modelVehicle="Actros 2640LS", power=400, type="Integral power Steering", wheels=10,  volume=90, serialNumber="N0460056",numberOfGears="Twin turbo, six speed", manufacturer="GeneralMotors"}
            };
                List<Bus> bus = new List<Bus>()
            {
                new Bus{modelVehicle="eCitaro", power=490, type="Voith automatic transmission", wheels=4,  volume=96, serialNumber="WEB63960113221075",numberOfGears="five different 16-speed gearbox", manufacturer="Mercedes-Benz"}
            };
                List<Scooter> scooter = new List<Scooter>()
            {
                new Scooter{modelVehicle="Apollo city", power=500, type="electric scooter", wheels=2,  volume=48, serialNumber="City2101101",numberOfGears="14.5 Max.speed", manufacturer="Electric Scooter Factory"}
            };
                // Create the query.
                var carsToXml = new XElement("Root",
                    from PassengerCar in car
                    select new XElement("PassengerCarDetails",
                                new XElement("ModelVehicle", PassengerCar.modelVehicle),
                                new XElement("power", PassengerCar.power),
                                new XElement("type", PassengerCar.type),
                                new XElement("wheels", PassengerCar.wheels),
                                new XElement("volume", PassengerCar.volume),
                                new XElement("serialNumber", PassengerCar.serialNumber),
                                new XElement("manufacturer", PassengerCar.manufacturer)
                                ),
                     from Truck in truck
                     select new XElement("TruckCarDetails",
                                 new XElement("ModelVehicle", Truck.modelVehicle),
                                 new XElement("power", Truck.power),
                                 new XElement("type", Truck.type),
                                 new XElement("wheels", Truck.wheels),
                                 new XElement("volume", Truck.volume),
                                 new XElement("serialNumber", Truck.serialNumber),
                                 new XElement("manufacturer", Truck.manufacturer)
                                 ),
                     from Bus in bus
                     select new XElement("BusCarDetails",
                                 new XElement("ModelVehicle", Bus.modelVehicle),
                                 new XElement("power", Bus.power),
                                 new XElement("type", Bus.type),
                                 new XElement("wheels", Bus.wheels),
                                 new XElement("volume", Bus.volume),
                                 new XElement("serialNumber", Bus.serialNumber),
                                 new XElement("manufacturer", Bus.manufacturer)
                                 ),
                     from Scooter in scooter
                     select new XElement("ScooterCarDetails",
                                 new XElement("ModelVehicle", Scooter.modelVehicle),
                                 new XElement("power", Scooter.power),
                                 new XElement("type", Scooter.type),
                                 new XElement("wheels", Scooter.wheels),
                                 new XElement("volume", Scooter.volume),
                                 new XElement("serialNumber", Scooter.serialNumber),
                                 new XElement("manufacturer", Scooter.manufacturer)
                                 )
                    );
                Console.WriteLine(carsToXml);
                Console.ReadLine();
            }
        }
}
