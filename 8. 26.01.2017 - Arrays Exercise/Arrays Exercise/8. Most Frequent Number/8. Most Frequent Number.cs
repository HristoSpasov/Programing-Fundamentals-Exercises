namespace _8.Most_Frequent_Number
{
    using System;
    using System.Linq;

    /// Find the most frequent number in number array
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine()
                        .Split(' ').Select(int.Parse).ToArray();

            int currentValue = int.MinValue;
            int currentValueCount = 0;
            int maxValue = int.MinValue;
            int maxValueCount = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                currentValue = numberArray[i];
                for (int compare = 0; compare < numberArray.Length; compare++)
                {
                    if (numberArray[compare] == currentValue)
                    {
                        currentValueCount++;
                        if (currentValueCount > maxValueCount)
                        {
                            maxValueCount = currentValueCount;
                            maxValue = currentValue;
                        }
                    }
                }

                currentValueCount = 0;
            }

            Console.WriteLine($"{maxValue}");
        }
    }
}
