namespace _1.RemNegativesReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a list of integers, remove all negative 
    /// numbers from it and print the remaining elements
    /// in reversed order. In case of no elements left 
    /// in the list, print “empty”.
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                                .Trim().Split(' ')
                                .Select(int.Parse)
                                .ToList();
            numList.RemoveAll(x => x < 0);
            numList.Reverse();
            if (numList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numList));
            }
        }
    }
}
