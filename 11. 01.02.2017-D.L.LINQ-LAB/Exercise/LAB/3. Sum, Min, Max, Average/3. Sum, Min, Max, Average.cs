namespace _3.Sum__Min__Max__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Program to read n integers and print 
    /// their sum, min, max, first, last and average values.
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());       
            }

            int sumArray = inputArray.Sum();
            int minArray = inputArray.Min();
            int maxArray = inputArray.Max();
            double averageArray = inputArray.Average();

            Console.WriteLine($"Sum = {sumArray}");
            Console.WriteLine($"Min = {minArray}");
            Console.WriteLine($"Max = {maxArray}");
            Console.WriteLine($"Average = {averageArray}");
        }
    }
}
