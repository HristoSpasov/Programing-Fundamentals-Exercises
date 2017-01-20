using System;
//Compare floats
class Program
{
    static void Main(string[] args)
    {
        //Assign variables
        decimal epsilon = 0.000001M;
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal secondNumber = decimal.Parse(Console.ReadLine());
     
        //Checks and outputs result
        bool isEqual = false;
        if (Math.Abs(firstNumber - secondNumber) < epsilon)
        {
            isEqual = true;
        }
        Console.WriteLine(isEqual);
    }
}