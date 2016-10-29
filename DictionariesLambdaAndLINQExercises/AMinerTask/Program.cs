using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List <String> input = new List<String>();
            String command = Console.ReadLine();
            
            while (command != "stop") {
                if (command == "stop") break;
                input.Add(command);                            
                command = Console.ReadLine();
                };
                                
                Dictionary<string, int> resources = new Dictionary<string, int>();
                List<string> key = new List<string>();
                List<string> value = new List<string>();
                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 == 0) key.Add(input[i]);
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 == 1) value.Add(input[i]);
                }
                for (int i = 0; i < key.Count; i++)
                {
                    if (resources.ContainsKey(key[i])) { resources[key[i]] += int.Parse(value[i]); }
                    else { resources.Add(key[i], int.Parse(value[i])); }
                }
                foreach (var item in resources)
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
            }            
        }
    }

