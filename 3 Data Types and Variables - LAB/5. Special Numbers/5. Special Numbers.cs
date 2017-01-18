using System;
//This code prints all numbers from 1 to n.
//If the sum of the number digits are equal to 5,7 or 11, 
//the output is 'number' -> True.
//Else the output is 'number' -> False
class Program
{
    static void Main(string[] args)
    {
        int upperRangeNumber = int.Parse(Console.ReadLine()); // The max nummber for the 'for' loop

        //Loops along all numbers
        for (int currentNumber = 1; currentNumber <= upperRangeNumber; currentNumber++)
        {
            int sumNumberDigits = 0; //Sets initial sum of digits to zerp for every number
            int tmpNumber = currentNumber; //Assign temporary number equal to current number
            
            //Divides and sums the digits of every number
            do
            {
                sumNumberDigits += tmpNumber % 10;
                tmpNumber = tmpNumber / 10;  
            } while (tmpNumber != 0);

            //Prints result on console, according to 'sumNumberDigits' variable
            if (sumNumberDigits == 5 || sumNumberDigits == 7 || sumNumberDigits == 11)
            {
                Console.WriteLine($"{currentNumber} -> True");
            }
            else
            {
                Console.WriteLine($"{currentNumber} -> False");
            }
        }
    }
}
