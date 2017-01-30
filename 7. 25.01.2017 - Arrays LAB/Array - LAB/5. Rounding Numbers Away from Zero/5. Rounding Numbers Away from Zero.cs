namespace _5.Rounding_Numbers_Away_from_Zero
{
    using System;
    using System.Linq;

    /// Program to read an array of real numbers 
    /// (space separated values), round them to the nearest 
    /// integer in “away from 0” style and print the output 
    /// as in the examples below.
    public class Program
    {
        public static void Main()
        {
            double[] numArray = Console.ReadLine().Trim()
                            .Split(' ').Select(double.Parse)
                            .ToArray();

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine($"{numArray[i]} => {Math.Round(numArray[i], 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
