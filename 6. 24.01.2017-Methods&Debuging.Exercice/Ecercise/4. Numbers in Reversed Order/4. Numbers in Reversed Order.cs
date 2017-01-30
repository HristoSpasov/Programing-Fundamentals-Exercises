namespace _4.Numbers_in_Reversed_Order
{
    using System;

    /// Write a method that prints
    /// the digits of a given decimal number
    /// in a reversed order.
    public class Program
    {
        public static void Main()
        {
            double inputNumber = double.Parse(Console.ReadLine());
            ReverceNumber(inputNumber);
            string revercedNumber = ReverceNumber(inputNumber);

            Console.WriteLine(revercedNumber);
        }

        public static string ReverceNumber(double inputNumberDecimal)
        {
            string inputNumberString = inputNumberDecimal.ToString();
            char[] inputNumberArray = inputNumberString.ToCharArray();
            Array.Reverse(inputNumberArray);
            return new string(inputNumberArray);
        }
    }
}
