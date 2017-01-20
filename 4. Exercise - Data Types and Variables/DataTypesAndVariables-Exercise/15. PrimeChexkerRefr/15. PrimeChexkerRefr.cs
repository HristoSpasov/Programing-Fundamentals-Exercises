using System;
//Fast Prime Checker - Refactor
class Program
{
    static void Main(string[] args)
    {
        //Input the largest number
        int maxNumber= int.Parse(Console.ReadLine());

        //isPrime Check
        for (int currentNumber = 2; currentNumber <= maxNumber; currentNumber++)
        {
            bool isPrime = true;
            for (int divider = 2; divider <= Math.Sqrt(currentNumber); divider++)
            {
                if (currentNumber % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            //Output
            Console.WriteLine($"{currentNumber} -> {isPrime}");
        }
   }
}