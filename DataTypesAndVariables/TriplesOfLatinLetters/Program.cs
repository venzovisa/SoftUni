using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char x = 'a'; x < n + 'a'; x++)
            {
                for (char y ='a'; y < n + 'a'; y++)
                {
                    for (char z = 'a'; z < n + 'a'; z++)
                    {                     
                        Console.WriteLine($"{x}{y}{z}");
                    }
                }
            }
        }
    }
}
