using System;

//Swap two integer variables vaalues
class Program
{
    static void Main(string[] args)
    {
        //Assaign two integers with some values
        int firstNumber = 5;
        int secondNumber = 10;

        //Print result before swap
        Console.WriteLine("Before:");
        Console.WriteLine($"a = {firstNumber}");
        Console.WriteLine($"b = {secondNumber}");
        
        //Swap variables values and print on console
        Console.WriteLine("After:");
        firstNumber = firstNumber + secondNumber;
        secondNumber = firstNumber - secondNumber;
        firstNumber = firstNumber - secondNumber;
        Console.WriteLine($"a = {firstNumber}");
        Console.WriteLine($"b = {secondNumber}");
    }
}