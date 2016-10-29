using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] word = Console.ReadLine().ToCharArray();
            for (int w = 0; w < word.Length; w++)
            {
                for (int a = 0; a < alphabet.Length; a++)
                {
                    if (alphabet[a] == word[w]) { Console.WriteLine("{0} -> {1}", alphabet[a], a); }
                }
            }
            Console.WriteLine();
        }
    }
}
