namespace OODPrinciples;
    public class AddCarCommand : ICommand
    {
        public void Execute()
        {
            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter cost of one unit: ");
            decimal costPerUnit = decimal.Parse(Console.ReadLine());

            Car car = new Car(brand, model, quantity, costPerUnit);
            CarInventory.Instance.Cars.Add(car);
        }
    }
