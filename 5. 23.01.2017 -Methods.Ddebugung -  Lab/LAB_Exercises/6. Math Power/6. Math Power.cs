namespace _6.Math_Power
{
    using System;

    /// Raise number to specified power
    public class Program
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double resultNumber = ResultNumber(number, power);
            Console.WriteLine(resultNumber);
        }

        public static double ResultNumber(double inputNumber, double inputPower)
        {
            double result = inputNumber;

            for (int i = 1; i < inputPower; i++)
            {
                result *= inputNumber;
            }

            return result;
        }
    }
}
