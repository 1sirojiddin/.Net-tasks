using System;

namespace CarPark
{
   public class CarPark
   {
      public short power;
      public byte volume;
      public string type;
      public string serialNumber;
      public byte wheels;
      public int numberOfSeats;
      public short numberOfGears;
      public string manufacturer;
      public virtual void DefineTo()
      {
          Console.WriteLine("The details of different types of vehicles");
          Console.WriteLine("");
      }
   }
}
