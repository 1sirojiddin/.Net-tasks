namespace OODPrinciples;
    public class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Quantity { get; }
        public decimal CostPerUnit { get; }

        public Car(string brand, string model, int quantity, decimal costPerUnit)
        {
            Brand = brand;
            Model = model;
            Quantity = quantity;
            CostPerUnit = costPerUnit;
        }
    }

   