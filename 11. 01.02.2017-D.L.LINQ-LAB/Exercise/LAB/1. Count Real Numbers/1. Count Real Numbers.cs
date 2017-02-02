namespace _1.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a list of real numbers and print them 
    /// in ascending order along with their number 
    /// of occurrences.
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputList = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n))
                .ToList();

            var numCountDict = new SortedDictionary<double, int>();

            foreach (var num in inputList)
            {
                if (!numCountDict.ContainsKey(num))
                {
                    numCountDict[num] = 0;
                }

                numCountDict[num]++;
            }

            foreach (var record in numCountDict)
            {
                Console.WriteLine($"{record.Key} -> {record.Value}");
            }
        }
    }
}
