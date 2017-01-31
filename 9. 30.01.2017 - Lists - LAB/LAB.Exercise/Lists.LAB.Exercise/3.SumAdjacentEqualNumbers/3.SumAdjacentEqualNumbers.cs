namespace _3.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Program to sum all adjacent equal numbers in
    /// a list of decimal numbers, starting from 
    /// left to right.
    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> numList = Console.ReadLine()
                            .Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(double.Parse).ToList();
            bool hasAdjacentEqual = true;
            int numListInitialLenght = numList.Count;
            int numListCurrentLenght = numList.Count;
            do
            {
                for (int i = 0; i < numList.Count - 1; i++)
                {
                    if (numList[i] == numList[i + 1])
                    {
                        numList[i] += numList[i + 1];
                        numList.RemoveAt(i + 1);
                        numListCurrentLenght = numList.Count;
                        break;
                    }
                }

                if (numListCurrentLenght < numListInitialLenght)
                {
                    numListInitialLenght = numListCurrentLenght;
                }
                else
                {
                    hasAdjacentEqual = false;
                }
            }
            while (hasAdjacentEqual == true);

            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
