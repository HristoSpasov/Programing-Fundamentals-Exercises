using System;
//convert a decimal number to hexadecimal and binary 
class Program
{
    static void Main(string[] args)
    {
        //read input data
        int inputNumberDecimal = int.Parse(Console.ReadLine());

        //Convert to hexadecimal and to binary
        string inputNumberHexa = Convert.ToString(inputNumberDecimal, 16).ToUpper();
        string inputNumberBinary = Convert.ToString(inputNumberDecimal, 2);

        //Print number in hexadecimal and binary
        Console.WriteLine(inputNumberHexa);
        Console.WriteLine(inputNumberBinary);
    }
}