using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateTriangleArea
{
    class Program
    {
        static double area(double w, double h) {
            double a = w * h / 2;
            return a;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(area(width, height));
        }
    }
}
