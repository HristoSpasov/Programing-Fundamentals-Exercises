using System;
//Assign appropriate variable types to the numbers and print on console
class Program
{
    static void Main(string[] args)
    {
        //Assign variable types
        sbyte firstNumber = -100;
        byte secondNumber = 128;
        short thirdNumber = -3540;
        ushort fourthNumber = 64876;
        uint fifthNumber = 2147483648;
        long sixthNumber = -1141583228;
        long seventhNumber = -1223372036854775808;

        //Print all integers on console
        Console.WriteLine($"{firstNumber}\n{secondNumber}\n{thirdNumber}\n{fourthNumber}\n{fifthNumber}\n{sixthNumber}\n{seventhNumber}");
    }
}