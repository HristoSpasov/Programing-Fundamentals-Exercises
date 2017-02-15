namespace _1.FromBase_10ToBase_N
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger targetBase = input[0];
            BigInteger numberToConvert = input[1];

            string convertedNumber = string.Empty;

            while (numberToConvert > 0)
            {
                convertedNumber = (numberToConvert % targetBase).ToString() + convertedNumber;
                numberToConvert = numberToConvert / targetBase;
            }

            Console.WriteLine(convertedNumber);
        }
    }
}
