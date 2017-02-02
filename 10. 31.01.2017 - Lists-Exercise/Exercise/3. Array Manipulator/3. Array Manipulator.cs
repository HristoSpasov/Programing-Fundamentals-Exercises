namespace _3.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Program that reads an array of integers from 
    /// the console and set of commands and executes 
    /// them over the array.
    public class Program
    {
        public static void Main()
        {
            /// Read and parse input integers in list
            List<int> numList = Console.ReadLine().Trim()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

            /// Read command with operations to do
            string commandInput = Console.ReadLine();

            /// Loop over while command print is received
            while (commandInput != "print")
            {
                string[] commands = commandInput.Trim().Split(' '); // Split command

                /// Switch between cases based on input command list first string
                switch (commands[0])
                {
                    case "add":
                        {
                            int listIndex = int.Parse(commands[1]);
                            int listElement = int.Parse(commands[2]);
                            numList.Insert(listIndex, listElement);

                            break;
                        }

                    case "addMany":
                        {
                            int insertIndex = int.Parse(commands[1]);
                            List<int> manyElements = new List<int>();
                            for (int i = 2; i < commands.Length; i++)
                            {
                                manyElements.Add(int.Parse(commands[i]));
                            }

                            numList.InsertRange(insertIndex, manyElements);

                            break;
                        }

                    case "contains":
                        {
                            int containsNummber = int.Parse(commands[1]);
                            if (numList.Contains(containsNummber))
                            {
                                for (int i = 0; i < numList.Count; i++)
                                {
                                    if (containsNummber == numList[i])
                                    {
                                        Console.WriteLine(i);
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("-1");
                            }

                            break;
                        }

                    case "remove":
                        {
                            int removeIndex = int.Parse(commands[1]);
                            numList.RemoveAt(removeIndex);

                            break;
                        }

                    case "shift":
                        {
                            int shiftPositions = int.Parse(commands[1]);

                            /// Reduce number of rotations if shifts are more than list lenght
                            if (shiftPositions > numList.Count)
                            {
                                shiftPositions = shiftPositions % numList.Count;
                            }

                            for (int i = 0; i < shiftPositions; i++)
                            {
                                int firstNum = numList[0]; /// Set to '0' to save every time na number in first position

                                for (int j = 0; j < numList.Count - 1; j++)
                                {
                                    numList[j] = numList[j + 1];
                                }

                                numList[numList.Count - 1] = firstNum;
                            }

                            break;
                        }

                    case "sumPairs":
                        {
                            if (numList.Count % 2 != 0)
                            {
                                int lastNum = numList[numList.Count - 1];
                                numList.RemoveAt(numList.Count - 1);

                                for (int i = 0; i < numList.Count; i += 2)
                                {
                                    numList[i] += numList[i + 1];
                                    numList[i + 1] = int.MinValue;
                                }

                                numList.RemoveAll(x => x == int.MinValue);
                                numList.Add(lastNum);
                            }
                            else
                            {
                                for (int i = 0; i < numList.Count; i += 2)
                                {
                                    numList[i] += numList[i + 1];
                                    numList[i + 1] = int.MinValue;
                                }

                                numList.RemoveAll(x => x == int.MinValue);
                            }

                            break;
                        }
                }

                /// Read next command
                commandInput = Console.ReadLine();
            }

            /// Print result
            Console.WriteLine($"[{string.Join(", ", numList)}]");
        }
    }
}
