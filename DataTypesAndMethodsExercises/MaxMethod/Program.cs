using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxMethod
{
    class Program
    {
        static int getMax(int a, int b) {
            if (a > b) { return a; }
            else { return b; }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine(getMax(getMax(a, b), c));
        }
    }
}
