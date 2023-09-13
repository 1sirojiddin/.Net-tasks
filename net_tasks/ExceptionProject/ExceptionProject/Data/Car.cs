using ExceptionProject.Exceptions;

namespace ExceptionProject.Data
{
    public class Car : Vehicle
    {
            public bool IsElectric { get; set; }

            public Car(string brand, string model, double engineCapacity, string transmission, bool isElectric)
            {
                if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model))
                {
                    throw new InitializationException("Unable to initialize car model.");
                }

                Brend = brand;
                Model = model;
                EngineCapacity = engineCapacity;
                Transmission = transmission;
                IsElectric = isElectric;
            }
       
    }
}
