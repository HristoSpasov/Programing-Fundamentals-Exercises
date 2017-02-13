namespace _1.MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// Program that finds the most frequent number in a
    /// given sequence of numbers. 
    public class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("./Input.txt");
            List<int> mostFrequentNumber = new List<int>();

            int currNumberValue = int.MinValue;
            int currNumberCount = 1;
            int currMaxNumberValue = int.MinValue;
            int currMaxNumberCount = 1;

            foreach (var line in input)
            {
                List<int> currLine = new List<int>();

                currLine = line.Split().Select(int.Parse).OrderBy(x => x).ToList();

                for (int i = 0; i < currLine.Count - 1; i++)
                {
                    currNumberValue = currLine[i];
                    if (currNumberValue == currLine[i + 1])
                    {
                        currNumberCount++;
                    }

                    if (currNumberCount > currMaxNumberCount)
                    {
                        currMaxNumberCount = currNumberCount;
                        currMaxNumberValue = currNumberValue;
                        currNumberCount = 0;
                    }
                }

                mostFrequentNumber.Add(currMaxNumberValue);
            }

            string result = string.Empty;

            for (int i = 0; i < mostFrequentNumber.Count; i++)
            {
                result += $"On line {i + 1} most frequent number is {mostFrequentNumber[i]}\r\n";
            }

            File.WriteAllText("./Output.txt", result);
        }
    }
}
