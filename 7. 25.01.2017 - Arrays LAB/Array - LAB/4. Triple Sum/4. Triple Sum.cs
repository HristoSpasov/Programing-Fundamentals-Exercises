namespace _4.Triple_Sum
{
    using System;
    using System.Linq;

    /// Program to read an array of integers and find 
    /// all triples of elements a, b and c, such that 
    /// a + b == c (where a stays left from b). 
    /// Print “No” if no such triples exist.
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Trim()
                        .Split(' ').Select(int.Parse)
                        .ToArray();

            int resultCounter = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                int a = numArray[i];
                for (int j = 0; j < numArray.Length; j++)
                {
                    if (j > i)
                    {
                        int b = numArray[j];

                        for (int k = 0; k < numArray.Length; k++)
                        {
                            if (a + b == numArray[k])
                            {
                                Console.WriteLine($"{a} + {b} == {numArray[k]}");
                                resultCounter++;
                                break;
                            }
                        }
                    }
                }  
            }

            if (resultCounter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
