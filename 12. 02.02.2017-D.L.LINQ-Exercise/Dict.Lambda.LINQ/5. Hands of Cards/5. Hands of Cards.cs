namespace _5.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var playersCardDict = new Dictionary<string, List<int>>(); /// Dictionary to contain players and their cards
            
            string input = Console.ReadLine();

            /// Loop while JOKER command is received
            while (input != "JOKER")
            {
                /// Split player from player card
                string[] inputArray = input.Split(':').ToArray();
                string playerName = inputArray[0];
                List<string> playerCards = inputArray[1].Trim()
                               .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                               .ToList();

                /// If not in dictionary adds current player
                if (!playersCardDict.ContainsKey(playerName))
                {
                    playersCardDict[playerName] = new List<int>();
                }

                /// Calculate value of each card and add to player list in dicionary
                foreach (var card in playerCards)
                {
                    int cardPower = CardPower(card.Substring(0, card.Length - 1));
                    int cardType = CardType(card.Substring(card.Length - 1, 1));
                    int currentCardSum = cardPower * cardType;

                    playersCardDict[playerName].Add(currentCardSum);
                }

                input = Console.ReadLine();
            }

            /// Print result
            foreach (var player in playersCardDict)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Distinct().Sum()}");
            }
        }

        public static int CardPower(string cardPower)
        {
            int cardPowerInt = 0;
            for (int i = 2; i <= 10; i++)
            {
                int tryParse = 0;
                if (int.TryParse(cardPower, out tryParse))
                {
                    cardPowerInt = int.Parse(cardPower);
                    break;
                }
            }

            switch (cardPower)
            {
                case "J":
                    {
                        cardPowerInt = 11;
                    }

                    break;

                case "Q":
                    {
                        cardPowerInt = 12;
                    }

                    break;

                case "K":
                    {
                        cardPowerInt = 13;
                    }

                    break;

                case "A":
                    {
                        cardPowerInt = 14;
                    }

                    break;
            }

            return cardPowerInt;
        }

        public static int CardType(string cardType)
        {
            int cardTypeInt = 0;

            switch (cardType)
            {
                case "S":
                    {
                        cardTypeInt = 4;
                    }

                    break;

                case "H":
                    {
                        cardTypeInt = 3;
                    }

                    break;

                case "D":
                    {
                        cardTypeInt = 2;
                    }

                    break;

                case "C":
                    {
                        cardTypeInt = 1;
                    }

                    break;        
            }

            return cardTypeInt;
        }
    }
}