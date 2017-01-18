using System;
// Fix code 
class Program
{
    static void Main(string[] args)
    {
        int maxNumber = int.Parse(Console.ReadLine()); //Input maximum number to check
        
        //Loop around all numbers from 1 to maxNumber
        for (int currentNumber = 1; currentNumber <= maxNumber; currentNumber++)
        {
            int digitSum = 0; //Assign sum of current number to 0;
            int tmpNum = currentNumber; //Use temporary number equal to current number to calculate digits

            //Loop around temporary number and sum its' characters while the number becomes zero
            while (tmpNum > 0)
            {
                digitSum += tmpNum % 10;
                tmpNum = tmpNum / 10;
            }
            
            //According to digitSum result, output true or false
            bool trueOrFalse = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);
            Console.WriteLine($"{currentNumber} -> {trueOrFalse}"); 
        }
    }
}