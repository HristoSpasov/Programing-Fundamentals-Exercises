namespace _7.Multiply_Big_Number
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());

            string result = string.Empty;

            int numToAppend = 0;
            int numPart = 0;

            for (int i = 0; i < first.Length; i++)
            {
                numToAppend = 0;

                int currSum = int.Parse(first[first.Length - 1 - i].ToString()) * second + numPart;

                if (currSum > 9)
                {
                    numToAppend = currSum % 10;
                    numPart = currSum / 10;
                }
                else
                {
                    numToAppend = currSum;
                    numPart = 0;
                }

                result = numToAppend + result;
            }

            if (numPart > 0)
            {
                result = numPart + result;
            }

            result = result.TrimStart('0'); // ?!?!
            if (second == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(result);
            }           
        }
    }
}