namespace _9.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            /// Make two dictionaries for both usefull and junk materials
            var usefullMaterials = new Dictionary<string, int>();
            var junkMaterials = new Dictionary<string, int>();
            
            /// Loop until some of the main materials reaches 250
            bool breakFlag = false;
            while (!breakFlag)
            {
                string[] inputArr = Console.ReadLine().ToLower().Split().ToArray();
                
                for (int i = 0; i < inputArr.Length; i += 2)
                {
                    int materialQuantity = int.Parse(inputArr[i]);
                    string materialName = inputArr[i + 1];

                    if (materialName == "fragments" ||
                        materialName == "shards" ||
                        materialName == "motes")
                    {
                        if (!usefullMaterials.ContainsKey(materialName))
                        {
                            usefullMaterials[materialName] = materialQuantity;
                        }
                        else
                        {
                            usefullMaterials[materialName] += materialQuantity;
                        }

                        if (usefullMaterials[materialName] >= 250)
                        {
                            switch (materialName)
                            {
                                case "shards":
                                    {
                                        Console.WriteLine("Shadowmourne obtained!");
                                    }

                                    break;

                                case "fragments":
                                    {
                                        Console.WriteLine("Valanyr obtained!");
                                    }

                                    break;

                                case "motes":
                                    {
                                        Console.WriteLine("Dragonwrath obtained!");
                                    }

                                    break;
                            }

                            usefullMaterials[materialName] -= 250;
                            breakFlag = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(materialName))
                        {
                            junkMaterials[materialName] = materialQuantity;
                        }
                        else
                        {
                            junkMaterials[materialName] += materialQuantity;
                        }
                    }
                }
            }

            /// Check if some of the main materials are missing in the dictionary
            if (!usefullMaterials.ContainsKey("fragments"))
            {
                usefullMaterials["fragments"] = 0;
            }

            if (!usefullMaterials.ContainsKey("shards"))
            {
                usefullMaterials["shards"] = 0;
            }

            if (!usefullMaterials.ContainsKey("motes"))
            {
                usefullMaterials["motes"] = 0;
            }

            /// Print result
            foreach (var record in usefullMaterials.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{record.Key}: {record.Value}");
            }

            foreach (var record in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{record.Key}: {record.Value}");
            }
        }
    }
}
