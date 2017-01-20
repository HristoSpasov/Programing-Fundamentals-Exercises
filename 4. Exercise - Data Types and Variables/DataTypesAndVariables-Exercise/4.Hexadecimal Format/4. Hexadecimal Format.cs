using System;
//Hexadecimal format practice
class Program
{
    static void Main(string[] args)
    {
        //Assign variables
        string numberHexa = Console.ReadLine();
        int numberDesimal = Convert.ToInt32(numberHexa, 16);

        //Print result
        Console.WriteLine($"{numberDesimal}");
    }
}