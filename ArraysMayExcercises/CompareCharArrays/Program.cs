using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] str2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (str1.Length == str2.Length)
            {
                if (str1[0] > str2[0])
                {
                    for (int i = 0; i < str2.Length; i++) { Console.Write(str2[i]); }
                    Console.WriteLine();
                    for (int i = 0; i < str1.Length; i++) { Console.Write(str1[i]); }
                }
                else
                {
                    for (int i = 0; i < str1.Length; i++) { Console.Write(str1[i]); }
                    Console.WriteLine();
                    for (int i = 0; i < str2.Length; i++) { Console.Write(str2[i]); }
                }
            }
            else if (str1[0] == str2[0]){
                if (str1.Length < str2.Length)
                {
                    for (int i = 0; i < str1.Length; i++) { Console.Write(str1[i]); }
                    Console.WriteLine();
                    for (int i = 0; i < str2.Length; i++) { Console.Write(str2[i]); }
                }
                else {
                    for (int i = 0; i < str2.Length; i++) { Console.Write(str2[i]); }
                    Console.WriteLine();
                    for (int i = 0; i < str1.Length; i++) { Console.Write(str1[i]); }
                }
            }
            Console.WriteLine();
        }
    }
}
