using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOfCards2
{
    public class Program
    {
        public static int calculateValues(String cardCodes)
        {
            int cardCodeLeft = 0;
            int cardCodeRight = 0;

            if (cardCodes.Length == 3)
            {
                cardCodeLeft += 10;
                switch (cardCodes[2].ToString())
                {
                    case "S": { cardCodeRight += 4; break; }
                    case "H": { cardCodeRight += 3; break; }
                    case "D": { cardCodeRight += 2; break; }
                    case "C": { cardCodeRight += 1; break; }
                }
            }
            else
            {
                switch (cardCodes[0].ToString())
                {
                    case "2": { cardCodeLeft += 2; break; }
                    case "3": { cardCodeLeft += 3; break; }
                    case "4": { cardCodeLeft += 4; break; }
                    case "5": { cardCodeLeft += 5; break; }
                    case "6": { cardCodeLeft += 6; break; }
                    case "7": { cardCodeLeft += 7; break; }
                    case "8": { cardCodeLeft += 8; break; }
                    case "9": { cardCodeLeft += 9; break; }
                    case "10": { cardCodeLeft += 10; break; }
                    case "J": { cardCodeLeft += 11; break; }
                    case "Q": { cardCodeLeft += 12; break; }
                    case "K": { cardCodeLeft += 13; break; }
                    case "A": { cardCodeLeft += 14; break; }
                }

                switch (cardCodes[1].ToString())
                {
                    case "S": { cardCodeRight += 4; break; }
                    case "H": { cardCodeRight += 3; break; }
                    case "D": { cardCodeRight += 2; break; }
                    case "C": { cardCodeRight += 1; break; }
                }
            }

            int cardValueCurrent = cardCodeLeft * cardCodeRight;
            return cardValueCurrent;
        }

        public static void distinctValues(List<String> cardCodes)
        {
            for (int i = 0; i < cardCodes.Count; i++)
            {

                for (int y = 0; y < cardCodes.Count; y++)
                {

                    if ((cardCodes[i] == cardCodes[y]) && (y != i))
                    {
                        Console.WriteLine("delete");
                        cardCodes.RemoveAt(i); break;

                    }
                }
            }
        }


        public static void Main(string[] args)
        {
            Dictionary<String, List<int>> players = new Dictionary<String, List<int>>();

            char[] separator = { ' ', ',', ':' };

            //String command = Console.ReadLine();
            String[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<String> cardCodes = input.Skip(1).Distinct().ToList();
            distinctValues(cardCodes);
            cardCodes.Clear();
            while (input[0] != "JOKER")
            {
                List<int> tempValues = new List<int>();
                for (int i = 1; i < input.Length; i++)
                {
                    tempValues.Add(calculateValues(input[i]));
                }
                if (!players.ContainsKey(input[0]))
                { players.Add(input[0], tempValues); }
                else
                {

                    for (int i = 0; i < tempValues.Count; i++)
                    {
                        if (!players[input[0]].Contains(tempValues[i]))
                        {
                            players[input[0]].Add(tempValues[i]);
                        }
                    }
                }

                //addPlayer(players, command);
                //command = Console.ReadLine();
                input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                cardCodes.Clear();
                cardCodes = input.Skip(1).Distinct().ToList();
                distinctValues(cardCodes);
            };

            // print players
            foreach (var item in players)
            {
                Console.Write(item.Key + ": ");
                int total = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    total += item.Value[i];
                }
                Console.Write(total);
                Console.WriteLine();
            }
        }
    }
}
