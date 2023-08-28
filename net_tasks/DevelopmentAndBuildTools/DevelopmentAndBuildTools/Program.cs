using System;

namespace DevelopmentAndBuildTools
{
public class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("Enter a sequence of symbols:");
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Empty input. Please provide a sequence of symbols.");
        return;
    }
    int maxConsecutive = 1;
    int currentConsecutive = 1;
    for (int i = 1; i < input.Length; i++)
    {
        if (input[i] != input[i - 1])
        {
            currentConsecutive = 1;
        }
        else
        {
            currentConsecutive++;
            maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
        }
    }
    Console.WriteLine($"Maximum consecutive unequal characters for \"{input}\" is: {maxConsecutive}");
    Console.ReadLine();
}
}
}
