using System;
//Check if entered symbol is digit, vowel or other
//and reports
class Program
{
    static void Main(string[] args)
    {
        //Read input data
        char inputChar = char.Parse(Console.ReadLine());

        //Setting boolean variables for the vowels and digits
        bool isDigit = false;
        bool isVowel = false;

        //Output
        if (isDigit = "0123456789".IndexOf(inputChar) >= 0)
        {
            Console.WriteLine("digit");
        }
        else if (isVowel = "aeiouAEIOU".IndexOf(inputChar) >= 0)
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}