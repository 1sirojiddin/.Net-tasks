using System;
using System.Xml.Linq;

namespace NetCollection;
    public class Bus : Vehicle
    {
        public string EngineType { get; set; }
        public string SerialNumber { get; set; }
        public int PowerRating { get; set; }
        public override XElement ToXml()
        {
            var xml = base.ToXml();
            xml.Add(new XElement("EngineType", EngineType));
            xml.Add(new XElement("SerialNumber", SerialNumber));
            xml.Add(new XElement("PowerRating", PowerRating));
            return xml;
        }
    }