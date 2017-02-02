namespace _5.Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Program that reads sequence of numbers and special bomb number with a certain power.
    /// It detonates every occurrence of the special bomb number and according to its power 
    /// his neighbors from left and right. Detonations are performed from left to right and 
    /// all detonated numbers disappear. Finally prints the sum of the remaining elements 
    /// in the sequence.
    public class Program
    {
        public static void Main()
        {
            /// Reads input sequence of number
            List<int> numList = Console.ReadLine().Trim()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            /// Reads bomb number value and its power
            List<int> bombNumber = Console.ReadLine().Trim()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            /// From 'bombNUmber' list takes:
            /// -> the number which will be detonated (a.k.a -> bombNumberValue)
            /// -> the power of the 'bombNumberValue'
            int bombNumberValue = bombNumber[0];
            int power = bombNumber[1];

            /// Loops over the input number list to search for numbers to destroy
            for (int i = 0; i < numList.Count; i++)
            {
                /// If a number in the list is equal to bombNumberValue
                if (numList[i] == bombNumberValue)
                {
                    int startIndex = i - power; /// According to bomb number power sets start index from which all numbers will be deleted
                    int removeRange = 2 * power + 1; /// According to bomb number power sets range to be deleted

                    /// Checks if 'startIndex' or 'removeRange' are out of list boundaries
                    /// If 'Yes' sets the limits to fit list lenght [0 -> nuList.Count - 1]
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex + removeRange > numList.Count)
                    {
                        removeRange = numList.Count - startIndex;
                    }

                    /// Removes the numbers in the list
                    numList.RemoveRange(startIndex, removeRange);

                    /// To check if there are other numbers for destruction sets the loop counter to '-1'
                    /// and loops again. The counter is set to '-1' to cope with the case when the next
                    /// number to be destroyed is on '0' position /2 5 9 5 1 -> 5 1/
                    i = -1;
                }
            }

            /// Calculate and print sum result
            int sumResult = 0;

            for (int i = 0; i < numList.Count; i++)
            {
                sumResult += numList[i];
            }

            Console.WriteLine(sumResult);
        }
    }
}
