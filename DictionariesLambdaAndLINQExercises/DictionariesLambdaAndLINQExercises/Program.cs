using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phonebook
{
    
    public class Program
    {
        /*static void add(List<string> input, Dictionary<string, string> contacts) {
            contacts.Add(input[1], input[2]);           
        }
    
        static void search(List<string> input, Dictionary<string, string> contacts)
        {
            bool isExist = false;
            foreach (var entry in contacts)
            {
                if (contacts.ContainsKey(input[1])) {
                    Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
                }
            }
            if (!isExist) Console.WriteLine("Contacts {0} does not exist.", input[1]);
        }*/
    
       public  static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();         
            String[] input = Console.ReadLine().Split(' ').ToArray();                
            string command = input[0].ToLower();
            while (command != "end") { 
                switch (command) {
                    case "a": { 
                        //add(input, contacts); 
                        if (contacts.ContainsKey(input[1])) { contacts[input[1]] = input[2]; } 
                        else contacts.Add(input[1], input[2]);
                        break; }
                    case "s": {

                        //search(input, contacts); 
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
                        break; }
            }
                input = Console.ReadLine().Split();
                command = input[0].ToLower();
            }     
        }
    }
}
