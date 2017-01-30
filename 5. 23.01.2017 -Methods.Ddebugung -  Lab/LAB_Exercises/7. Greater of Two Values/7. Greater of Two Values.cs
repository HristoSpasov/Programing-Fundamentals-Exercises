namespace _7.Greater_of_Two_Values
{
    using System;

    /// Compare two values of same type int/char/string
    public class Program
    {
        public static void Main()
        {
            string inputDataType = Console.ReadLine();
            if (inputDataType == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                GetMax(firstNumber, secondNumber);
                int result = GetMax(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (inputDataType == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                GetMax(firstChar, secondChar);
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                GetMax(firstString, secondString);
                string result = GetMax(firstString, secondString);
                Console.WriteLine(result);
            }    
        }

        public static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

        public static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
        
        public static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) > 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
