using System;
//Practice boolean variables
class Program
{
    static void Main(string[] args)
    {
        //Read input string
        string trueOrFalseString = Console.ReadLine(); ;
        
        //Convert to boolean
        bool trueOrFalseBool = (Convert.ToBoolean(trueOrFalseString));

        //Result
        Console.WriteLine(trueOrFalseBool ? "Yes" : "No");
    }
}