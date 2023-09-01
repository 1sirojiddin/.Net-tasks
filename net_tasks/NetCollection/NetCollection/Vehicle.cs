using System;
using System.Xml.Linq;

namespace NetCollection;
    public class Vehicle
    {
        public string Brend { get; set; }
        public string Model { get; set; }
        public double EngineCapacity { get; set; }
        public string Transmission { get; set; }
        public virtual XElement ToXml()
        {
            return new XElement("Vehicle",
                new XElement("Brend", Brend),
                new XElement("Model", Model),
                new XElement("EngineCapacity", EngineCapacity),
                new XElement("Transmission", Transmission)
            );
        }
    }

