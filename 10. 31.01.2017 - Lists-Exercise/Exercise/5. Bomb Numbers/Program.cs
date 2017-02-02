namespace _5.Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numList = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            List<int> bombNumber = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            int bombNumberValue = bombNumber[0];
            int power = bombNumber[1];

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] == bombNumberValue)
                {
                    for (int j = i - power; j <= i + power; j++)
                    {
                        if (i - power < 0)
                        {
                            j = 0;
                        }
                        if (i + power > numList.Count)
                        {
                            while (numList.Count <= i + power)
                            {
                                numList.Add(int.MinValue);
                            }
                        }

                        numList[j] = int.MinValue;
                    }
                }
            }
            List<int> resultList = numList.FindAll(x => x != int.MinValue);

            int resultSum = 0;
            for (int i = 0; i < resultList.Count; i++)
            {
                resultSum += resultList[i];
            }

            Console.WriteLine(resultSum);
        }
    }
}
