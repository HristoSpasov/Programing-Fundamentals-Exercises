namespace _6.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    /// Write a program that finds the longest sequence of equal 
    /// elements in an array of integers. If several longest 
    /// sequences exist, print the leftmost one.
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] stringArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxSequence = 1;
            int currentSequence = 1;
            int startSequence = 0;
            int currentStartSequence = 0;

            for (int i = 0; i < stringArray.Length - 1; i++)
            {
                if (stringArray[i] == stringArray[i + 1])
                {
                    currentSequence++;
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        startSequence = currentStartSequence;
                    }
                }
                else
                {
                    currentStartSequence = i + 1;
                    currentSequence = 1;
                }
            }

            int[] resultChar = new int[maxSequence];
            for (int i = 0; i < resultChar.Length; i++)
            {
                resultChar[i] = stringArray[startSequence + i];
            }

            string result = string.Join(" ", resultChar);
            Console.WriteLine(result);
        }
    }
}
