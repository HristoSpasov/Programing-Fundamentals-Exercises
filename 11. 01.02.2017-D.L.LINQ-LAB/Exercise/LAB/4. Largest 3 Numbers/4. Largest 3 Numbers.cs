namespace _4.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a list of real numbers and print largest 3 of them.
    /// If less than 3 numbers exit, print all of them.
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var resultList = new List<int>();
            if (numArray.Length > 3)
            {
                resultList = numArray
                    .OrderByDescending(n => n)
                    .Take(3)
                    .ToList();
            }
            else
            {
                resultList = numArray
                    .OrderByDescending(n => n)
                    .ToList();
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
