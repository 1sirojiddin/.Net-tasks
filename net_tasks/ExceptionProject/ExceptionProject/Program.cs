using ExceptionProject.Data;
using ExceptionProject.Exceptions;


public class Program
{
    public static void Main(string[] args)
    {
        var vehicles = new List<Vehicle>();

        try
        {
            // Attempt to add a car
            var car = new Car("Tesla", "Model S", 0, "Electric", true);
            vehicles.Add(car);

            // Attempt to update a car (replace by ID)
            var carToUpdate = vehicles.FirstOrDefault(v => v.Brend == "Tesla" && v.Model == "Model S");
            if (carToUpdate != null)
            {
                // Update car details
                carToUpdate.EngineCapacity = 2.0;
            }
            else
            {
                throw new UpdateAutoException("Unable to update car. Car not found.");
            }
            // Attempt to remove a car (by ID)
            var carToRemove = vehicles.FirstOrDefault(v => v.Brend == "Tesla" && v.Model == "Model S");
            if (carToRemove != null)
            {
                vehicles.Remove(carToRemove);
            }
            else
            {
                throw new RemoveAutoException("Unable to remove car. Car not found.");
            }
        }
        catch (InitializationException ex)
        {
            Console.WriteLine($"Initialization Exception: {ex.Message}");
        }
        catch (AddException ex)
        {
            Console.WriteLine($"Add Exception: {ex.Message}");
        }
        catch (UpdateAutoException ex)
        {
            Console.WriteLine($"Update Exception: {ex.Message}");
        }
        catch (RemoveAutoException ex)
        {
            Console.WriteLine($"Remove Exception: {ex.Message}");
        }
    }
}

