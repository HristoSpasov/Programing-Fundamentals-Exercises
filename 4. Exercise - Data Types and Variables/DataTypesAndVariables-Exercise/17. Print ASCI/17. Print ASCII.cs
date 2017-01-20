using System;
//Print characters from ASCII table, using int values
//between given ranege (start and end char)
class Program
{
    static void Main(string[] args)
    {
        //Read start and end character integer value
        int startChar = int.Parse(Console.ReadLine());
        int endChar = int.Parse(Console.ReadLine());

        //Prints all characters in specified range
        for (char currentChar = (char)startChar; currentChar <= endChar; currentChar++)
        {
            Console.Write("{0} ", (char)currentChar);
        }

        Console.WriteLine();
    }
}