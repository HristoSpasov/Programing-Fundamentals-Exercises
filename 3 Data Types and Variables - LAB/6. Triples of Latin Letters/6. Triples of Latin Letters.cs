using System;
//The code generates all triplets with small letters from
//'a', to dinamically assigned letter 
class Program
{
    static void Main(string[] args)
    {
        int letterRange = int.Parse(Console.ReadLine()); //Assign letter range
        char lastLetter = (char) ('a' + letterRange) ; //Calculate last character

        //For loop
        for (char firstChar = 'a'; firstChar < lastLetter; firstChar++)
        {
            for (char secondChar = 'a'; secondChar < lastLetter; secondChar++)
            {
                for (char thirdChar = 'a'; thirdChar < lastLetter; thirdChar++)
                {
                    Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");  //Print result
                }
            }
        }

    }
}
