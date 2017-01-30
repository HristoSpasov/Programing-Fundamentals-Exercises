namespace _10.Pairs_by_Difference
{
    using System;
    using System.Linq;

    /// Program that counts the number of pairs in given array which 
    /// difference is equal to given number 
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Trim()
                        .Split(' ').Select(int.Parse)
                        .ToArray();
            int difference = int.Parse(Console.ReadLine());

            int elementsCount = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                int currentNumber = numArray[i];
                for (int j = i; j < numArray.Length; j++)
                {
                    if (Math.Abs(numArray[i] - numArray[j]) == difference)
                    {
                        elementsCount++;
                    }
                }
            }

            Console.WriteLine(elementsCount);
        }
    }
}
