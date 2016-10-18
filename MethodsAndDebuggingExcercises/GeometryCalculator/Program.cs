using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryCalculator
{
    public class Figures
    {
        static double triangle() {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return (double)(side * height / 2);
        }
        static double square() {
            double side = double.Parse(Console.ReadLine());
            return (double)(side * side);
        }
        static double rectangle() {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return (double)(width * height);
        }
        static double circle() { 
            double radius = double.Parse(Console.ReadLine());
            return (double)(Math.PI * Math.Pow(radius, 2)); }
        public static void Main()
        {           
            string command = Console.ReadLine().ToLower();
            switch (command)
            {
                case "triangle": { Console.WriteLine("{0:f2}", triangle()); break; }
                case "square": { Console.WriteLine("{0:f2}", square()); break; };
                case "rectangle": { Console.WriteLine("{0:f2}", rectangle()); break; };
                case "circle": { Console.WriteLine("{0:f2}", circle()); break; };
                default: { Console.WriteLine("Error"); break; }
            }
        }
    }
}
