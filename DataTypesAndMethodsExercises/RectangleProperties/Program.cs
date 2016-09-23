using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double diagonal = Math.Sqrt(a * a + b * b);
            Console.WriteLine(a * 2 + 2 * b);
            Console.WriteLine(a * b);
            Console.WriteLine(diagonal);
        }
    }
}
