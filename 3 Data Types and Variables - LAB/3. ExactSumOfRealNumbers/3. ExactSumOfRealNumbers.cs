using System;
//This code:
//1. Reads how many numbers will be summed
//2. Calculates sum and prints the sum
class Program
{
    static void Main(string[] args)
    {
        int numbersToSum = int.Parse(Console.ReadLine()); //Reads how many numbers to sum
        decimal finalSumOfNumbers = 0m; //Sets initial sum to zero

        //Calculates the final sum
        for (int numberToSumID = 0; numberToSumID < numbersToSum; numberToSumID++)
        {
            decimal currentNumberToSum = decimal.Parse(Console.ReadLine());
            finalSumOfNumbers += currentNumberToSum;
        }

        Console.WriteLine(finalSumOfNumbers); //Prints final sum value
    }
}

