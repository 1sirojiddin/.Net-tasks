using NetCollection;
using System.Xml.Linq;

namespace NetCollection;
    public class Program
    {
        public static void Main(string[] args)
        {
            var vehicles = new List<Vehicle> {
        new Truck {
            Brend = "Ford",
            Model = "F-150",
            EngineCapacity = 3.5,
            Transmission = "Automatic",
            EngineType = "V6",
            SerialNumber = "12345",
            PowerRating = 250
        },
        new Car {
            Brend = "Tesla",
            Model = "Model S",
            EngineCapacity = 0,
            Transmission = "Electric",
            IsElectric = true,
        },
        new Bus {
            Brend = "Volvo",
            Model = "7700",
            EngineCapacity = 7.7,
            Transmission = "Automatic",
            EngineType = "Diesel",
            SerialNumber = "67890",
            PowerRating = 300
        },
        new Scooter {
                    Brend = "Honda",
                    Model = "PCX",
                    EngineCapacity = 0.125,
                    Transmission = "Automatic",
                    TopSpeed = 90
                } };

            // All information about all vehicles an engine capacity of which is more than 1.5 liters
            var highCapacityVehiclesXml = new XElement("Vehicles",
                from vehicle in vehicles
                where vehicle.EngineCapacity > 1.5
                select vehicle.ToXml());

            // Engine type, serial number and power rating for all buses and trucks
            var engineInfoXmlBus = new XElement("EngineInfo",
                from vehicle in vehicles
                where vehicle is Bus
                select new XElement("Engine",
                    new XElement("EngineType", ((Bus)vehicle).EngineType),
                    new XElement("SerialNumber", ((Bus)vehicle).SerialNumber),
                    new XElement("PowerRating", ((Bus)vehicle).PowerRating)
                )
            );
            // Engine type, serial number and power rating for all buses and trucks
            var engineInfoXmlTruck = new XElement("EngineInfo",
                from vehicle in vehicles
                where vehicle is Truck
                select new XElement("Engine",
                    new XElement("EngineType", ((Truck)vehicle).EngineType),
                    new XElement("SerialNumber", ((Truck)vehicle).SerialNumber),
                    new XElement("PowerRating", ((Truck)vehicle).PowerRating)
                )
            );
            // All information about all vehicles, grouped by transmission type
            var groupedVehiclesXml = new XElement("Vehicles",
                from vehicle in vehicles
                group vehicle by vehicle.Transmission into transmissionGroup
                select new XElement("Group",
                    new XAttribute("Transmission", transmissionGroup.Key),
                    from groupedVehicle in transmissionGroup
                    select groupedVehicle.ToXml()
                )
            );
            // Write the XML data to a file
            var highCapacityVehiclesFile = new FileStream("highCapacityVehicles.xml", FileMode.Create);
            highCapacityVehiclesXml.Save(highCapacityVehiclesFile);
            var engineInfoXmlBusFile = new FileStream("engineInfoXmlBus.xml", FileMode.Create);
            engineInfoXmlBus.Save(engineInfoXmlBusFile);
            var engineInfoXmlTruckFile = new FileStream("engineInfoXmlTruck.xml", FileMode.Create);
            engineInfoXmlTruck.Save(engineInfoXmlTruckFile);
            var groupedVehiclesXmlFile = new FileStream("groupedVehiclesXml.xml", FileMode.Create);
            groupedVehiclesXml.Save(groupedVehiclesXmlFile);

        }
    }