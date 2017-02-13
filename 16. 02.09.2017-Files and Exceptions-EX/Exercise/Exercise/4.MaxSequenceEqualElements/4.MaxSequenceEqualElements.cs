namespace _4.MaxSequenceEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("./Input.txt");

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            foreach (var line in input)
            {
                int[] currLine = line.Split().Select(int.Parse).ToArray();

                int currIndex = 0;
                int currLenght = 1;
                int bestStartIndex = 0;
                int bestLenght = 1;

                for (int i = 0; i < currLine.Length - 1; i++)
                {
                    currIndex = i;

                    if (currLine[i] == currLine[i + 1])
                    {
                        currLenght++;

                        if (currLenght > bestLenght && i + 1 == currLine.Length - 1)
                        {
                            bestLenght = currLenght;
                            bestStartIndex = currIndex - bestLenght + 2;
                        }
                    }
                    else
                    {
                        if (currLenght > bestLenght)
                        {
                            bestLenght = currLenght;
                            bestStartIndex = currIndex - bestLenght + 1;
                        }

                        currLenght = 1;
                    }
                }

                List<int> currLineBestSequence = new List<int>();

                for (int j = bestStartIndex; j < bestStartIndex + bestLenght; j++)
                {
                    currLineBestSequence.Add(currLine[j]);
                }

                File.AppendAllText("./Output.txt", $"Max sequence of elements starts at index {bestStartIndex} and has lenght {bestLenght}. The sequence is {string.Join(" ", currLineBestSequence)}!\r\n");
            }
        }
    }
}
