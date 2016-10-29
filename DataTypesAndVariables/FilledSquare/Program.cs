using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilledSquare
{
    class Program
    {
        static void PrintHeaderRow(int n) {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int x = 0; x < n - 1; x++)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
            
        }

        static void PrintFooterRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintFooterRow(n);
        }
    }
}
