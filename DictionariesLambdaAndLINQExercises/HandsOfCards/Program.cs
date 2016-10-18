using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOfCards
{
    public class Player {
       public  string name;
        public Dictionary <String, int> deck = new Dictionary <String, int>();
        public int cardsTotalValue;
    }
   
   public class Program
    {

       public static int calculateValues(String cardCodes) {
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

       public static void updatePlayer() { }

        public static void addPlayer(List<Player> players, String command) {
            char[] separator = {' ', ',', ':'};        
            String[] input = command.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();          
            List<String> cardCodes = input.Skip(1).Distinct().ToList();
            int playerIndex = 0;
            // check player existence
            bool hasEntry = false;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].name == input[0])
                { hasEntry = true;
                  playerIndex = i;
                  break; }
                else hasEntry = false;
            }

            if (!hasEntry)
            {// add new player
                Player newPlayer = new Player();
                
                newPlayer.name = input[0];

                int cardTotalValue = 0;
                int cardCurrentValue = 0;
                for (int i = 0; i < cardCodes.Count; i++)
                {                                    
                    cardCurrentValue = calculateValues(cardCodes[i]);
                    cardTotalValue += cardCurrentValue;
                    newPlayer.deck.Add(cardCodes[i], cardCurrentValue);
                }
                newPlayer.cardsTotalValue = cardTotalValue;
                players.Add(newPlayer);
            }// update player
            else {               
                for (int i = 0; i < cardCodes.Count; i++)
                {                 
                    if( !players[playerIndex].deck.ContainsKey(cardCodes[i])) {
                        int cardCurrentValue = calculateValues(cardCodes[i]);
                        players[playerIndex].deck.Add(cardCodes[i], cardCurrentValue);
                        players[playerIndex].cardsTotalValue += cardCurrentValue;
                    }
                }
            }
        }

        public static void printPlayers(List <Player> players) {
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("{0}: {1}", players[i].name, players[i].cardsTotalValue);
            }
        }

        public static void Main(string[] args)
        {           
            List <Player> players = new List <Player>();
            String command = Console.ReadLine();           
            while (command != "JOKER")
            {
                if (command == "JOKER") break;         
                addPlayer(players, command);
                command = Console.ReadLine();                
            };
            printPlayers(players);        
        }
    }
}
