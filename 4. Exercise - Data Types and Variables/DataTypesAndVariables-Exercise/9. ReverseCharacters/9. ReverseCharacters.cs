using System;
//Revers order of characters
class Program
{
    static void Main(string[] args)
    {
        //Read data from console
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char thirdChar = char.Parse(Console.ReadLine());

        //Reverse characters and print
        Console.Write($"{thirdChar}{secondChar}{firstChar}");
        Console.WriteLine();
    }
}