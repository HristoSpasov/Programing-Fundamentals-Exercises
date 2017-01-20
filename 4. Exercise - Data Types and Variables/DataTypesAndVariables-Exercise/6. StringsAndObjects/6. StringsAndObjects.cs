using System;
//Strings and Objects
class Program
{
    static void Main(string[] args)
    {
        string firstString = "Hello"; //Assign first string
        string secondString = "World"; //Assign second string
        object concatenate = firstString + ' ' + secondString; //Concatenate strings on oject variable
        string resultString = Convert.ToString(concatenate); //Cast object variable to string
        
        //Print result string
        Console.WriteLine(resultString);
    }
}