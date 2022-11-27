using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Car_Park
{
    
    class PassengerCar 
    {
        public List<int> Power { get; set; }
        public List<int> Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public List<int> Wheels { get; set; }
        public string NumberOfGears { get; set; }
        public string Manfacturer { get; set; }
         
    }
    
    class XMLTransform
    {
        static void Main()
        {
            List<PassengerCar> Cadillac = new List<PassengerCar>()
            {
              new PassengerCar{Power = new List<int>() { 325}, Volume = new List<int>{ 5 }, Type = "Luxury Sport Sedan", SerialNumber = "N0460056",Wheels = new List<int>{4 }, NumberOfGears = "Twin turbo, six speed", Manfacturer = "GEneral Motors" }
            };
            var CadillacTOXML = new XElement("Root",
                from PassengerCar in Cadillac
                let power = string.Join("", PassengerCar.Power)
                let Volume = string.Join("", PassengerCar.Volume)
                let Wheels = string.Join("", PassengerCar.Wheels)
                

                select new XElement("",
                                new XElement(power),
                                new XElement(Volume),
                                new XElement(PassengerCar.Type),
                                new XElement(PassengerCar.SerialNumber),
                                new XElement(Wheels),
                                new XElement(PassengerCar.NumberOfGears),
                                new XElement(PassengerCar.Manfacturer)
                                )
                );    //End root
            Console.WriteLine(CadillacTOXML);
            Console.WriteLine("press the enter");
            Console.ReadLine();
        }
    }

}
