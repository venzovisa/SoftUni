using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || 
                input == 'e' || 
                input == 'i' || 
                input == 'o' || 
                input == 'u' ||
                input == 'y') 
            {
                    Console.WriteLine("vowel");
            }
            else if ((input >= '0') && ('9' >= input))
            {
                Console.WriteLine("digit");
            } else {
                 Console.WriteLine("other");
            }
        }
    }
}
