using System;
//Assaign variables and print employee data
class Program
{
    static void Main(string[] args)
    {
        //Assign variables
        string firstName = "Amanda";
        string lastName = "Jonson";
        byte age = 27;
        char gender = 'f';
        long personalID = 8306112507;
        int uniqueNumber = 27563571;

        //Print data
        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {personalID}");
        Console.WriteLine($"Unique Employee number: {uniqueNumber}");
    }
}