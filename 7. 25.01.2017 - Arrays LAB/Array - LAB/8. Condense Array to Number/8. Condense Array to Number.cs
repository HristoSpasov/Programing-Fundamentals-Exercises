namespace _8.Condense_Array_to_Number
{
    using System;
    using System.Linq;

    /// Program to read an array of integers and 
    /// condense them by summing adjacent couples of
    /// elements until a single integer is obtained.
    public class Program
    {
        public static void Main()
        {
            int[] numArray = Console.ReadLine()
                            .Trim().Split(' ')
                            .Select(int.Parse)
                            .ToArray();

            while (numArray.Length > 1)
            {
                int[] condenseArray = new int[numArray.Length - 1];
                for (int i = 0; i < numArray.Length - 1; i++)
                {
                    condenseArray[i] = numArray[i] + numArray[i + 1];
                    numArray[i] = condenseArray[i];
                }

                numArray = condenseArray;
            }

            Console.WriteLine(string.Join(string.Empty, numArray));
        }
    }
}
