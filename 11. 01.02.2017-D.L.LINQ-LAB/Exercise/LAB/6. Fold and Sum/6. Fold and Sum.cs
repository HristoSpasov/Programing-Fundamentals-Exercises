namespace _6.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read an array of 4*k integers, fold it
    /// like shown below, and print the sum of
    /// the upper and lower rows (2*k integers)
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int arrayModule = inputArray.Length / 4;

            int[] firstRowFirstPart = inputArray
                .Take(arrayModule)
                .Reverse()
                .ToArray();

            int[] firstRowSecondPart = inputArray
                .Reverse()
                .Take(arrayModule)
                .ToArray();

            int[] firstRow = firstRowFirstPart
                .Concat(firstRowSecondPart)
                .ToArray();

            int[] secondRow = inputArray
                .Skip(arrayModule)
                .Take(2 * arrayModule)
                .ToArray();

            int[] sumArrays = firstRow
                .Zip(secondRow, (x, y) => x + y)
                .ToArray();

            Console.WriteLine(string.Join(" ", sumArrays));
        }
    }
}
