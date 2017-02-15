namespace _2.FromBase_NToBase_10
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            BigInteger numberBase = BigInteger.Parse(input[0]);
            string numberToBeConverted = input[1];

            BigInteger result = 0;

            for (int i = 0; i < numberToBeConverted.Length; i++)
            {
                BigInteger currDigit = (BigInteger)(BigInteger.Parse(numberToBeConverted[numberToBeConverted.Length - i - 1].ToString()) * BigInteger.Pow(numberBase, i));
                result += currDigit;
            }

            Console.WriteLine(result);
        }
    }
}
