using System;

class Program
{
    static void Main(string[] args)
    {
        string stringNumber = Console.ReadLine();
        try
        {
            long number = long.Parse(stringNumber);

            bool fitInSbyte = false;
            bool fitInByte = false;
            bool fitInShort = false;
            bool fitInUShort = false;
            bool fitInInt = false;
            bool fitInUInt = false;
            bool fitInLong = false;

            if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                fitInSbyte = true;
            }
            if (number >= byte.MinValue && number <= byte.MaxValue)
            {
                fitInByte = true;
            }
            if (number >= short.MinValue && number <= short.MaxValue)
            {
                fitInShort = true;
            }
            if (number >= ushort.MinValue && number <= ushort.MaxValue)
            {
                fitInUShort = true;
            }
            if (number >= int.MinValue && number <= int.MaxValue)
            {
                fitInInt = true;
            }
            if (number >= uint.MinValue && number <= uint.MaxValue)
            {
                fitInUInt = true;
            }
            if (number >= long.MinValue && number <= long.MaxValue)
            {
                fitInLong = true;
            }

            Console.WriteLine($"{number} can fit in:");

            if (fitInSbyte == true)
            {
                Console.WriteLine("* sbyte");
            }
            if (fitInByte == true)
            {
                Console.WriteLine("* byte");
            }
            if (fitInShort == true)
            {
                Console.WriteLine("* short");
            }
            if (fitInUShort == true)
            {
                Console.WriteLine("* ushort");
            }
            if (fitInInt == true)
            {
                Console.WriteLine("* int");
            }
            if (fitInUInt == true)
            {
                Console.WriteLine("* uint");
            }
            if (fitInLong == true)
            {
                Console.WriteLine("* long");
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"{stringNumber} can't fit in any type"); 
        }  
    }       
}           
            