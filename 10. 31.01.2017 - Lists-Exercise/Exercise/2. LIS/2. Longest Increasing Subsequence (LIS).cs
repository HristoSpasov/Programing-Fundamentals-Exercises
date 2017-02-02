namespace _2.LIS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a list of integers and find the longest 
    /// increasing subsequence (LIS). If several such
    /// exist, print the leftmost.
    public class Program
    {
        public static void Main()
        {
            List<int> numList = Console.ReadLine()
                             .Split(' ')
                             .Select(int.Parse)
                             .ToList();

            //numList.Add(int.MinValue);

            int currentLIS = 1;
            int currentNumberID = 0;
            int bestLIS = 1;
            int bestStartID = 0;

            for (int i = 0; i < numList.Count - 1; i++)
            {
                currentNumberID = i;
                currentLIS = 1;
                for (int j = 0; j < numList.Count; j++)
                {
                    int currentCompareNumber = numList[j];
                    if (numList[j] > numList[i] && j > i)
                    {
                        currentLIS++;
                        if (currentLIS > bestLIS)
                        {
                            bestLIS = currentLIS;
                            bestStartID = currentNumberID;
                        }
                    }
                }    
            }
        }
    }
}
