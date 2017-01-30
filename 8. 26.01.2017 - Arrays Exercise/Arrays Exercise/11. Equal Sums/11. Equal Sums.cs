namespace _11.Equal_Sums
{
    using System;
    using System.Linq;

    /// Checks if there is element for which
    /// the sum of the left numbers and right numbers
    /// are equal
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Trim()
                .Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            int index = int.MinValue;
            for (int i = 0; i < numArray.Length; i++)
            {
                /// Sum right elements
                for (int j = i + 1; j < numArray.Length; j++)
                {
                    rightSum += numArray[j];
                }

                /// Sum left elements
                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += numArray[k];
                }

                /// Compare left and right sums
                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            /// Print result
            if (index < 0)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
