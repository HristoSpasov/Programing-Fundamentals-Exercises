namespace _3.Last_K_Numbers_Sums_Sequence
{
    using System;

    /// Last K Numbers Sums Sequence
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] numberArray = new long[n];
            numberArray[0] = 1;
            
            for (int i = 1; i < numberArray.Length; i++)
            {
                for (int j = i - k; j < i; j++)
                {
                    if (j >= 0)
                    {
                        numberArray[i] += numberArray[j];
                    }
                    else
                    {
                        j = 0;
                        numberArray[i] += numberArray[j];
                    }     
                }
            }

            Console.WriteLine(string.Join(" ", numberArray));
        }
    }
}