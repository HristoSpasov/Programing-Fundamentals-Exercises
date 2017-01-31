namespace _6.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a list of integers and extract all square 
    /// numbers from it and print them in descending order. 
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                        .Trim().Split(' ').Select(int.Parse)
                        .ToList();

            numList.RemoveAll(x => Math.Sqrt(x) != (int)Math.Sqrt(x));
            numList.Sort();
            numList.Reverse();

            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
