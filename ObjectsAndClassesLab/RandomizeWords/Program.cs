using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, str.Length);
                string tempIndex = str[i];    
                str[i] = str[randomIndex];
                str[randomIndex] = tempIndex;
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            
        }
    }
}
