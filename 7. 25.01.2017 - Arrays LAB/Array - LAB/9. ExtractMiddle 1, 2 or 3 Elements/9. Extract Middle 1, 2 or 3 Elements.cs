namespace _9.ExtractMiddle_1__2_or_3_Elements
{
    using System;
    using System.Linq;

    /// Program that reads an array of integers 
    /// (space separated values) and prints the 
    /// middle elements 
    /// -> if array has one element print one element
    /// -> if array has even elements print 2 elements
    /// -> if array has odd elements print 3 elements
    /// in the following format // { element }
    public class Program
    {
        public static void Main()
        {
            int[] numArray = Console.ReadLine()
                        .Trim().Split(' ')
                        .Select(int.Parse).ToArray();

            if (numArray.Length == 1)
            {
                Console.WriteLine("{" + " " + numArray[0] + " " + "}");
            }
            else if (numArray.Length % 2 == 0)
            {
                int[] evenNumArray = new int[2];
                for (int i = 0; i < evenNumArray.Length; i++)
                {
                    evenNumArray[i] = numArray[(numArray.Length / 2) - (1 - i)];
                }

                Console.WriteLine("{ " + string.Join(", ", evenNumArray) + " }");
            }
            else
            {
                int[] oddNumArray = new int[3];
                for (int i = 0; i < oddNumArray.Length; i++)
                {
                    oddNumArray[i] = numArray[(numArray.Length / 2) - (1 - i)];
                }

                Console.WriteLine("{ " + string.Join(", ", oddNumArray) + " }");
            }
        }
    }
}
