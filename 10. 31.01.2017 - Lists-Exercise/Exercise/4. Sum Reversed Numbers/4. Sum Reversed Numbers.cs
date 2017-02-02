namespace _4.Sum_Reversed_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Write a program that reads sequence of numbers,
    /// reverses their digits, and prints their sum.
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> inputString = Console.ReadLine()
                                .Split(' ').Select(int.Parse)
                                .ToList();

            for (int i = 0; i < inputString.Count; i++)
            {
                int n = inputString[i];
                int left = n;
                int rev = 0;
                while (left > 0)
                {
                    int r = left % 10;
                    rev = rev * 10 + r;
                    left = left / 10;
                }

                inputString[i] = rev;
            }

            int result = 0;
            for (int i = 0; i < inputString.Count; i++)
            {
                result += inputString[i];
            }

            Console.WriteLine(result);
        }
    }
}
