using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayManipulator
{
    public class Program
    {

        public static void add(List<int> list, string[] input)
        {
            int i = int.Parse(input[1]);
            int v = int.Parse(input[2]);
            list.Insert(i, v);
        }
        public static void addmany(List<int> list, string[] input)
        {
            for (int i = input.Length - 1; i > 2; i--)
            {
                int index = int.Parse(input[1]);
                int value = int.Parse(input[i]);
                list.Insert(index, value);
            }
        }
        public static int contains(List<int> list, string[] input)
        {
            return list.IndexOf(int.Parse(input[1]));
        }
        public static void remove(List<int> list, string[] input)
        {
            list.RemoveAt(int.Parse(input[1]));
        }
        public static void shift()
        {

        }
        public static void sumpairs() { }

        public static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
           
            string command = input[0];
            while (!command.Equals("print")) {
            switch (command) {
                case "add": { add(list, input);  break; }
                case "addmany": { addmany(list, input); break; }
                case "contains": { contains(list, input); break; }
                case "remove": { remove(list, input); break; }
                case "shift": { break; }
                case "sumpairs": { break; }
              }
            input = Console.ReadLine().ToLower().Split(' ').ToArray();
            
            }
           
            foreach (var li in list)
            {
                Console.WriteLine(li + " ");
            }      
        }        
    }
}
