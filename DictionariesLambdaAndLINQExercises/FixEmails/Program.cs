using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> input = new List<String>();
            String command = Console.ReadLine();

            while (command != "stop")
            {
                if (command == "stop") break;
                input.Add(command);
                command = Console.ReadLine();
            };

            Dictionary<string, string> resources = new Dictionary<string, string>();
            List<string> key = new List<string>();
            List<string> value = new List<string>();
            // get key
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 0) key.Add(input[i]);
            }
            // get value
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 1) value.Add(input[i]);
            }
            // add key-value pairs to dictionary
            for (int i = 0; i < key.Count; i++)
            {
                if (resources.ContainsKey(key[i])) { resources[key[i]] = value[i]; }
                else { resources.Add(key[i], value[i]); }
            }

            // delete uk and us suffix entries
            for (int i = 0; i < key.Count; i++)
            {
                if (resources[key[i]].EndsWith("uk") ||
                    resources[key[i]].EndsWith("us"))
                {
                    resources.Remove(key[i]);
                }
            }

            // print result
            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
