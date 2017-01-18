using System;
//This code reads first name, last name and age and
//prints text in the following format:
//"Hello, {firstName} {lastName}. You are {age} years old."
class Program
{
    static void Main(string[] args)
    {
        string firstName = Console.ReadLine(); //Input first name
        string lastName = Console.ReadLine(); //Input last name
        string age = Console.ReadLine(); //Input age
        Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old."); // Print result
    }
}
