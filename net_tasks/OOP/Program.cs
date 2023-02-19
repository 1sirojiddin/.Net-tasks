using System;

namespace CarPark
{
public class Program
{
    public static void Main()
    {
        #region ParametresOfVehicles
        CarPark vehicles = new CarPark();
        CarPark car = new PassengerCar(200, 222, "Camaro", "F213g232", 4, 4, 6, "Deutsche Production");
        CarPark truck = new Truck(300, 250, "Tractor", "Fdsf343242df", 4, 2, 5, "Russian Production");
        CarPark bus = new Bus(600, 250, "Mercedes", "Der34354fdsf", 4, 50, 4, "Deutsch Technology");
        CarPark scooter = new Scooter(20, 23, "Changan", "D34r35t4", 2, 1, 2, "Chinese Technology");
        #endregion
        Console.WriteLine("Verification");
        Console.WriteLine("The given parametres should be >0");
        #region NumberOfSeats
        Console.WriteLine(" Number of seats");
        if (car.NumberOfSeats > 0)
            Console.WriteLine($"Car: Accepted ");
        else
            Console.WriteLine("Car: Rejected");
        if (truck.NumberOfSeats > 0)
            Console.WriteLine($"Truck: Accepted");
        else
            Console.WriteLine("Truck: Rejected");
        if (bus.NumberOfSeats > 0)
            Console.WriteLine($"Bus: Accepted");
        else
            Console.WriteLine("Rejected");
        if (scooter.NumberOfSeats > 0)
            Console.WriteLine($"Scooter: Accepted");
        else
            Console.WriteLine("Scooter: Rejected");
        #endregion
        #region Wheels
        Console.WriteLine(" Wheels");
        if (car.Wheels > 0)
            Console.WriteLine($"Car: Accepted ");
        else
            Console.WriteLine("Car: Rejected");
        if (truck.Wheels > 0)
            Console.WriteLine($"Truck: Accepted");
        else
            Console.WriteLine("Truck: Rejected");
        if (bus.Wheels > 0)
            Console.WriteLine($"Bus: Accepted");
        else
            Console.WriteLine("Bus: Rejected");
        if (scooter.Wheels > 0)
            Console.WriteLine($"Scooter: Accepted");
        else
            Console.WriteLine("Scooter: Rejected");
        #endregion
        #region Power
        Console.WriteLine(" Power");
        if (car.Power > 0)
            Console.WriteLine($"Car: Accepted ");
        else
            Console.WriteLine("Car: Rejected");
        if (truck.Power > 0)
            Console.WriteLine($"Truck: Accepted");
        else
            Console.WriteLine("Truck: Rejected");
        if (bus.Wheels > 0)
            Console.WriteLine($"Bus: Accepted");
        else
            Console.WriteLine("Bus: Rejected");
        if (scooter.Power > 0)
            Console.WriteLine($"Scooter: Accepted");
        else
            Console.WriteLine("Scooter: Rejected");
        #endregion
        #region Volume
        Console.WriteLine(" Volume");
        if (car.Volume > 0)
            Console.WriteLine($"Car: Accepted ");
        else
            Console.WriteLine("Car: Rejected");
        if (truck.Volume > 0)
            Console.WriteLine($"Truck: Accepted");
        else
            Console.WriteLine("Truck: Rejected");
        if (bus.Volume > 0)
            Console.WriteLine($"Bus: Accepted");
        else
            Console.WriteLine("Bus: Rejected");
        if (scooter.Volume > 0)
            Console.WriteLine($"Scooter: Accepted");
        else
            Console.WriteLine("Scooter: Rejected");
        #endregion
        #region NumberOfGears
        Console.WriteLine(" Number of gears");
        if (car.NumberOfGears > 0)
            Console.WriteLine($"Car: Accepted ");
        else
            Console.WriteLine("Car: Rejected");
        if (truck.NumberOfGears > 0)
            Console.WriteLine($"Truck: Accepted");
        else
            Console.WriteLine("Truck: Rejected");
        if (bus.NumberOfGears > 0)
            Console.WriteLine($"Bus: Accepted");
        else
            Console.WriteLine("Bus: Rejected");
        if (scooter.NumberOfGears > 0)
            Console.WriteLine($"Scooter: Accepted");
        else
            Console.WriteLine("Scooter: Rejected");
        #endregion
        #region AllInformation
        vehicles.DefineTo();
        Console.WriteLine($" Vehicles | Power | Volume |  Type   | Serial Number | Wheels | Number of gears |    Manufacturer    |");
        Console.WriteLine("_______________________________________________________________________________________________________");
        Console.WriteLine($" Car      | {car.Power}   |  {car.Volume}   | {car.Type}  | {car.SerialNumber}      |    {car.Wheels}   |        {car.NumberOfGears}        | {car.Manufacturer}|");
        Console.WriteLine($" Truck    | {truck.Power}   |  {truck.Volume}   | {truck.Type} | {truck.SerialNumber}  |    {truck.Wheels}   |        {car.NumberOfGears}        | {truck.Manufacturer} |");
        Console.WriteLine($" Bus      | {bus.Power}   |  {bus.Volume}   | {bus.Type}| {bus.SerialNumber}  |    {bus.Wheels}   |        {car.NumberOfGears}        | {bus.Manufacturer} |");
        Console.WriteLine($" Scooter  | {scooter.Power}    |  {scooter.Volume}    | {scooter.Type} | {scooter.SerialNumber}      |    {scooter.Wheels}   |        {car.NumberOfGears}        | {scooter.Manufacturer} |");
        #endregion
        // if.. else.. it shows if number of seats > 0 is correct, if not " < 0" error
        Console.ReadLine();
    }
}
}


