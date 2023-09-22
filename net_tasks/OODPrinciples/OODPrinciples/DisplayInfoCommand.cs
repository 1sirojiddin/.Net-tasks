namespace OODPrinciples;
    public class DisplayInfoCommand : ICommand
    {
        public void Execute()
        {
            Console.Write("Enter a command (count types, count all, average price, average price type, exit): ");
            string command = Console.ReadLine();

            switch (command.ToLower())
            {
                case "count types":
                    int countTypes = CarInventory.Instance.Cars.Select(c => c.Brand).Distinct().Count();
                    Console.WriteLine($"Number of car brands: {countTypes}");
                    break;

                case "count all":
                    int countAll = CarInventory.Instance.Cars.Sum(c => c.Quantity);
                    Console.WriteLine($"Total number of cars: {countAll}");
                    break;

                case "average price":
                    decimal averagePrice = CarInventory.Instance.Cars.Average(c => c.CostPerUnit);
                    Console.WriteLine($"Average cost of cars: {averagePrice:C}");
                    break;

                case "average price type":
                    Console.Write("Enter brand to calculate the average price: ");
                    string brand = Console.ReadLine();
                    decimal averagePriceByBrand = CarInventory.Instance.Cars
                        .Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                        .Average(c => c.CostPerUnit);
                    Console.WriteLine($"Average cost of {brand} cars: {averagePriceByBrand:C}");
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }

