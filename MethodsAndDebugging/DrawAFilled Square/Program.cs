using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawAFilledSquare
{
    class Program
    {
        static void dashes(int n) {
            Console.Write(new string('-', n * 2));
            Console.WriteLine();
        }
        static void middle(int n) {
            if (n % 2 == 0) {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(new string('-', 1));
                    for (int x = 0; x < n - 1; x++)
                    {
                        Console.Write("\\/");
                    }
                    Console.Write(new string('-', 1));
                    Console.WriteLine();
                }        
            }
            else {
                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    Console.Write(new string('-', 1));
                    for (int x = 0; x < n - 1; x++)
                    {
                        Console.Write("\\/");
                    }
                    Console.Write(new string('-', 1));
                    Console.WriteLine();
                }        
            }
               
        }
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            dashes(n);
            middle(n);
            dashes(n);
        }
    }
}
