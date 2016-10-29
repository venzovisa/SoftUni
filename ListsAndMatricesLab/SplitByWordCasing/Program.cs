using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[ str = Console.ReadLine().Split(new Char[] { ',', '\\', '\n', ':', ';', '.', '(', ')', '\"', '\'', '\\','/', '[', ']', ' '}).ToArray();
            string str = Console.ReadLine();
           List<string> lowerCase = new List<string>();
           List<string> upperCase = new List<string>();
           List<string> mixedCase = new List<string>();
           string upper = @"\b[A-Z0-9]{2,}\b";
           string mixed = @"[A-Z][a-z]{1,}[A-Z][a-z]{1,}|\d|[A-Z]\b#|[A-Z][a-z]{1,}";
           string lower = @"\b[a-z0-9]{2,}\b";
           foreach (Match match in Regex.Matches(str, upper))
           {
               upperCase.Add(match.Value);
           }

           foreach (Match match in Regex.Matches(str, mixed))
           {
               mixedCase.Add(match.Value);
           }

           foreach (Match match in Regex.Matches(str, lower))
           {
               lowerCase.Add(match.Value);
           }
                  
            Console.Write("Lower-case: ");
            for (int i = 0; i < lowerCase.Count; i++)
            {
                Console.Write("{0}, ", lowerCase[i]); 
            }
            Console.WriteLine();

            Console.Write("Mixed-case: ");
            for (int i = 0; i < mixedCase.Count; i++)
            {
                Console.Write("{0}, ", mixedCase[i]);
            }
            Console.WriteLine();

            Console.Write("Upper-case: ");
            for (int i = 0; i < upperCase.Count; i++)
            {
                Console.Write("{0}, ", upperCase[i]);
            }
            Console.WriteLine();
        }
    }
}