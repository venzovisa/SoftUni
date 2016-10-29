using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrabskoUnleashed
{
    public class Place {
        public String placeName;
        public Dictionary<String, int> singer = new Dictionary<String, int>();
        public int totalMoney;
    }
    public class Program
    {
        
        public static void Main(string[] args)
        {
            List<Place> places = new List<Place>();
            char[] delimiter = {' '};
            String singerName = "";
            String placeName = "";
                     
            String[] input = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End") {
                int money = 0;
                int numCheck = 0;
                // Ceca @
                if (input.Length > 3 && input[1][0] == '@')
                {
                    // Ceca @SunnyBeach 28 3500
                    if (Int32.TryParse(input[2], out numCheck))
                    {
                        singerName = input[0];
                        placeName = input[1].Remove(0, 1);
                        money = int.Parse(input[2]) * int.Parse(input[3]);
                    }
                    else if (int.TryParse( input[3], out numCheck))
                    {
                        // Ceca @Sunny Beach 28 3500
                        singerName = input[0];
                        placeName = input[1].Remove(0, 1) + " " + input[2];
                        money = int.Parse(input[3]) * int.Parse(input[4]);
                    }
                    else
                    {
                        // Ceca @Sunny Beach Varna 28 3500
                        singerName = input[0];
                        placeName = input[1].Remove(0, 1) + " " + input[2] + " " + input[3];
                        money = int.Parse(input[4]) * int.Parse(input[5]);
                    }
                } 
                else if (input.Length > 3 && input[2][0] == '@')
                {
                    // Lepa Brena @SunnyBeach 25 3500
                    if (Int32.TryParse(input[3], out numCheck))
                    {
                        singerName = input[0] + " " + input[1];
                        placeName = input[2].Remove(0, 1);
                        money = int.Parse(input[3]) * int.Parse(input[4]);
                    }
                    else if (int.TryParse(input[4], out numCheck))
                    {
                        // Lepa Brena @Sunny Beach 25 3500
                        singerName = input[0] + " " + input[1];
                        placeName = input[2].Remove(0, 1) + " " + input[3];
                        money = int.Parse(input[4]) * int.Parse(input[5]);
                    }
                    else {
                        // Lepa Brena @Sunny Beach Varna 25 3500
                        singerName = input[0] + " " + input[1];
                        placeName = input[2].Remove(0, 1) + " " + input[3] + " " + input[4];
                        money = int.Parse(input[5]) * int.Parse(input[6]);
                    }
                }
                else if (input.Length > 3 && input[3][0] == '@')
                {
                    // Lepa Brena Varna @Sunny 25 3500
                    if (Int32.TryParse(input[4], out numCheck))
                    {
                        singerName = input[0] + " " + input[1] + " " + input[2];
                        placeName = input[3].Remove(0, 1);
                        money = int.Parse(input[4]) * int.Parse(input[5]);
                    }
                    else if (int.TryParse(input[5], out numCheck))
                    {
                        // Lepa Brena Varna @Sunny Beach 25 3500
                        singerName = input[0] + " " + input[1] + " " + input[2];
                        placeName = input[3].Remove(0, 1) + " " + input[4];
                        money = int.Parse(input[5]) * int.Parse(input[6]);
                    }
                    else
                    {
                        // Lepa Brena Varna @Sunny Beach Varna 25 3500
                        singerName = input[0] + " " + input[1] + " " + input[2];
                        placeName = input[3].Remove(0, 1) + " " + input[4] + " " + input[5];
                        money = int.Parse(input[6]) * int.Parse(input[7]);
                    }
                }   
                               

                bool hasPlace = false;
                int placeIndex = 0;
                Place newPlace = new Place();
                             
                // check place
                for (int i = 0; i < places.Count; i++)
                {                   
                    if (places[i].placeName == placeName) {
                        hasPlace = true; placeIndex = i;  break;  
                    }
                }
                // add place
                if (!hasPlace) {
                    newPlace.placeName = placeName;
                    newPlace.singer.Add(singerName, money);
                    places.Add(newPlace); }
                // add singer
                else
                {
                    if (!places[placeIndex].singer.ContainsKey(singerName))
                    { places[placeIndex].singer.Add(singerName, money); }
                    else { places[placeIndex].singer[singerName] += money; }
                }

                input = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            } // while        

            // sort singer
            for (int i = 0; i < places.Count; i++)
            {
                places[i].singer = places[i].singer
                    .OrderByDescending(a => a.Value)
                    .ToDictionary(a => a.Key, a => a.Value);
            }

            // print result
            for (int p = 0; p < places.Count; p++)
            {
                Console.WriteLine(places[p].placeName);
                for (int s = 0; s < places[p].singer.Count; s++)
                {
                    Console.WriteLine("#  {0} -> {1}", 
                        places[p].singer.ElementAt(s).Key,
                        places[p].singer.ElementAt(s).Value);
                }
            }
        }
    }
}
