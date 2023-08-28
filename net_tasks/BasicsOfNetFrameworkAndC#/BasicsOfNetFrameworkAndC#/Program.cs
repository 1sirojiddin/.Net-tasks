using System;

namespace BasicsOfNetFrameworkAndC_
{
public class Program
{
public static void Main(string[] args)
{
    Console.Write("Enter an integer in decimal: ");
    int decimalNumber = int.Parse(Console.ReadLine());
    Console.Write("Enter the new base (2 to 20): ");
    int newBase = int.Parse(Console.ReadLine());
    try
    {
        string convertedNumber = ConvertToBase(decimalNumber, newBase);
        Console.WriteLine($"Converted number in base {newBase}: {convertedNumber}");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.ReadLine();
}
static string ConvertToBase(int decimalNumber, int newBase)
{
    if (newBase < 2 || newBase > 20)
    {
        throw new ArgumentOutOfRangeException("newBase", "Base must be between 2 and 20.");
    }
    string convertedNumber = "";
    while (decimalNumber > 0)
    {
        int remainder = decimalNumber % newBase;
        char digit = remainder < 10 ? (char)('0' + remainder) : (char)('A' + remainder - 10);
        convertedNumber = digit + convertedNumber;
        decimalNumber /= newBase;
    }
    return convertedNumber;
}
}
}
