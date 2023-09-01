using System;

namespace OOP;
    public class Bus
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }
        public int NumberOfPassengers { get; set; }
    }

