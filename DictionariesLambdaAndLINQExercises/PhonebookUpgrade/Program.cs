using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhonebookUpgrade
{

    public class Program
    {
        static void add(String[] input, SortedDictionary<string, string> contacts)
        {
            if (contacts.ContainsKey(input[1])) { contacts[input[1]] = input[2]; }
            else contacts.Add(input[1], input[2]);         
        }

        static void search(String[] input, SortedDictionary<string, string> contacts)
        {
            bool isExist = false;
            foreach (var entry in contacts)
            {
                if (entry.Key == input[1])
                {
                    Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
                    isExist = true;
                }
            }
            if (!isExist) Console.WriteLine("Contact {0} does not exist.", input[1]);
        }

        static void listAll(SortedDictionary<string, string> contacts) {
            foreach (var item in contacts)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        public static void Main()
        {
            SortedDictionary<string, string> contacts = new SortedDictionary<string, string>();
            String[] input = Console.ReadLine().Split(' ').ToArray();
            string command = input[0].ToLower();
            while (command != "end")
            {
                switch (command)
                {
                    case "a":
                        {
                            add(input, contacts);   
                            break;
                        }
                    case "s":
                        {
                            search(input, contacts);                           
                            break;
                        }
                    case "listall": { listAll(contacts); break; }
                }
                input = Console.ReadLine().Split();
                command = input[0].ToLower();
            }
        }
    }
}
