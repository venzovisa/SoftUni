using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split('|').ToArray();
            List<String> result = new List<String>();
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].Trim().Replace("  ", " ");
                result.Add(str[i]);                   
            }
            result.Reverse();
            foreach (String r in result) {
                Console.Write(r + " ");
            }
        }
    }
}
