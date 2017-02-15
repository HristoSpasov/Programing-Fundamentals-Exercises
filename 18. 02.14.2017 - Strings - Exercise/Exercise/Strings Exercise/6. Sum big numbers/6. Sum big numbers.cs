namespace _6.Sum_big_numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            /// Read input numbers as string;
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            /// If strings have different lenght adds '0's in front of the shortest
            if (first.Length > second.Length)
            {
                while (second.Length != first.Length)
                {
                    second = 0 + second;
                }
            }
            else if (first.Length < second.Length)
            {
                while (second.Length != first.Length)
                {
                    first = 0 + first;
                }
            }

            /// String to hold result
            string result = string.Empty;

            /// Parse and sum number by number
            int numToAppend = 0;
            int numPart = 0;

            for (int i = 0; i < first.Length; i++)
            {
                int currSum = int.Parse(first[first.Length - 1 - i].ToString()) + int.Parse(second[first.Length - 1 - i].ToString()) + numPart;
                numPart = 0;
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

                result = numToAppend.ToString() + result;
                numToAppend = 0;
            }

            if (numPart > 0)
            {
                result = numPart.ToString() + result;
            }

            /// Print result string
            result = result.TrimStart('0');
            Console.WriteLine(result);
        }
    }
}
