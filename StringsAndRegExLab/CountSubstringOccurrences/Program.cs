using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i < text.Length - word.Length; i++)
            {
                if (text.Substring(i, word.Length) == word){
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
