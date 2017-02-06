namespace _1.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string inputCommand = Console.ReadLine();

            var phonebook = new SortedDictionary<string, string>();

            while (inputCommand != "END")
            {
                string[] inputCommandArgs = inputCommand.Split(' ').ToArray();
                switch (inputCommandArgs[0])
                {
                    case "A":
                        {
                            string name = inputCommandArgs[1];
                            string number = inputCommandArgs[2];

                            phonebook[name] = number;
                        }

                        break;

                    case "S":
                        {
                            string nameSearch = inputCommandArgs[1];

                            if (phonebook.ContainsKey(nameSearch))
                            {
                                foreach (var phone in phonebook)
                                {
                                    if (phone.Key == nameSearch)
                                    {
                                        Console.WriteLine($"{phone.Key} -> {phone.Value}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Contact {nameSearch} does not exist.");
                            }
                        }

                        break;

                    case "ListAll":
                        {
                            foreach (var record in phonebook)
                            {
                                Console.WriteLine($"{record.Key} -> {record.Value}");
                            }
                        }

                        break;
                }

                inputCommand = Console.ReadLine();
            }
        }
    }
}
