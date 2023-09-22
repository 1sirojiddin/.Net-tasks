using OODPrinciples;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Car Inventory Management System");
            Console.WriteLine("Enter a command (add, display, exit): ");
            string input = Console.ReadLine();

            ICommand command = null;

            switch (input.ToLower())
            {
                case "add":
                    command = new AddCarCommand();
                    break;

                case "display":
                    command = new DisplayInfoCommand();
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }

            if (command != null)
            {
                command.Execute();
            }
        }
    }
}
