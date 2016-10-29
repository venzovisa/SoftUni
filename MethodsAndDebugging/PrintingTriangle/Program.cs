using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string first = "";
            // first part
            for (int i = 1; i <= n; i++)
            {
                first = first + i.ToString() + " ";
                Console.WriteLine(first); 
            }

            for (int i = n - 1; i > 0; i--)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
