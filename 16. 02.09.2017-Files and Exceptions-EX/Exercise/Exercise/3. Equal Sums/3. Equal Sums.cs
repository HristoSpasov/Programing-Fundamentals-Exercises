namespace _3.Equal_Sums
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("./Input.txt");

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            foreach (var line in lines)
            {
                int[] currLine = line.Split().Select(int.Parse).ToArray();

                for (int i = 0; i < currLine.Length; i++)
                {
                    int currIndex = i;
                    int currIndexValue = currLine[i];
                    int leftSum = 0;
                    int rightSum = 0;

                    for (int j = 0; j < currIndex; j++)
                    {
                        leftSum += currLine[j];
                    }

                    for (int j = currIndex + 1; j < currLine.Length; j++)
                    {
                        rightSum += currLine[j];
                    }

                    if (leftSum == rightSum)
                    {
                        File.AppendAllText("./Output.txt", $"The sum of the numbers left and right from {currIndexValue.ToString()} at index {currIndex.ToString()} are equal. The sum is {rightSum}\r\n");
                        break;
                    }

                    if (i == currLine.Length - 1 && leftSum != rightSum)
                    {
                        File.AppendAllText("./Output.txt", $"no\r\n");
                    }
                }
            }
        }
    }
}
