namespace _7.Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;

    /// Calculate prime numbers in given range
    public class Program
    {
        public static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primesInRange = FindPrimesInRange(startNum, endNum);

            Console.WriteLine(string.Join(", ", primesInRange));
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            for (int currNum = startNum; currNum <= endNum; currNum++)
            {
                if (IsPrime(currNum))
                {
                    primes.Add(currNum);
                }
            }

            return primes;
        } 

        public static bool IsPrime(int n )
        {
            bool isPrime = true;

            if (n == 0 || n == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
