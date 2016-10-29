using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryFarming
{
    public class Program
    {
       
 
        public static void Main(string[] args)
        {
            String[] input = Console.ReadLine().ToLower().Split();
            Dictionary<String, int> materials = new Dictionary<String, int>();
            Dictionary<String, int> junk = new Dictionary<String, int>();
            materials.Add("motes", 0);
            materials.Add("shards", 0);
            materials.Add("fragments", 0);

            while (input[0] != "")
            {                               
                // add materials
                for (int s = 1; s < input.Length; s++)
                    {
                        if (s % 2 != 0) {
                            String material = input[s];
                            // add to junk
                            if (material != "shards" &&
                                material != "motes" &&
                                material != "fragments") {
                                    if (!junk.ContainsKey(material))
                                    { junk.Add(material, 0); } 
                            }
                            // add to materials
                            else 
                            {
                                if (!materials.ContainsKey(material))
                                { materials.Add(material, 0);} 
                            }                             
                        }                                                            
                    }
                // add quantity
                for (int s = 0; s < input.Length - 1; s++)
                    {
                        if (s % 2 == 0)
                        {
                            String quantity = input[s];
                            String inputNext = input[s + 1];
                            // add quantity to junk
                            if ((inputNext != "shards") &&
                                (inputNext != "motes") &&
                                (inputNext != "fragments") )
                            {
                                    if (junk.ContainsKey(input[s + 1]))
                                    { junk[input[s + 1]] += int.Parse(quantity); }
                            }

                            // add quantity to materials
                            else
                            {
                                bool has250 = false;
                                if (materials.ContainsKey(input[s + 1]))
                                { materials[input[s + 1]] += int.Parse(quantity);

                                
                                for (int i = 0; i < materials.Count; i++)
                                {

                                    if (materials.ElementAt(i).Key == "shards" &&
                                        materials.ElementAt(i).Value >= 250
                                        )
                                    {
                                        Console.WriteLine("Shadowmourne obtained!");
                                        materials["shards"] -= 250; has250 = true; break;
                                    }
                                    else

                                        if (materials.ElementAt(i).Key == "fragments" &&
                                            materials.ElementAt(i).Value >= 250)
                                        {
                                            Console.WriteLine("Valanyr obtained!");
                                            materials["fragments"] -= 250; has250 = true; break;
                                        }
                                        else

                                            if (materials.ElementAt(i).Key == "motes" &&
                                                materials.ElementAt(i).Value >= 250)
                                            {
                                                Console.WriteLine("Dragonwrath obtained!");
                                                materials["motes"] -= 250; has250 = true; break;
                                            }
                                            else has250 = false;
                                }           
                                }
                                if (has250) { input[0] = ""; break; }
                            }
                        }
                    }
                if (input[0] != "")
                input = Console.ReadLine().ToLower().Split(); 
           }         

             materials = materials.OrderByDescending(a => a.Value)
                                  .ThenBy(a => a.Key)
                                  .ToDictionary(a => a.Key, a => a.Value);

            foreach (var item in materials)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }

            junk = junk.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var item in junk)
            {
                if (item.Value != 0)
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}
