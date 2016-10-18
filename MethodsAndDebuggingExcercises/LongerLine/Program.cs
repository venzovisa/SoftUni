using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongerLine
{
    class Line
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;       
    }

    class Program
    {

        static double length(Line line)
        {
            double a, b, c;
            a = line.x1 - line.x2;
            b = line.y1 - line.y2;
            c = (double)Math.Sqrt(a * a + b * b);
            return c;
        }

        static void Main(string[] args)
        {
            Line line1 = new Line();
            Line line2 = new Line();           

            line1.x1 = int.Parse(Console.ReadLine());
            line1.y1 = int.Parse(Console.ReadLine());
            line1.x2 = int.Parse(Console.ReadLine());
            line1.y2 = int.Parse(Console.ReadLine());
          
            line2.x1 = int.Parse(Console.ReadLine());
            line2.y1 = int.Parse(Console.ReadLine());
            line2.x2 = int.Parse(Console.ReadLine());
            line2.y2 = int.Parse(Console.ReadLine());

            if (length(line1) > length(line2))
            {
                double first = (double)Math.Sqrt(Math.Pow(line1.x1, 2) + Math.Pow(line1.y1, 2));
                double second = (double)Math.Sqrt(Math.Pow(line1.x2, 2) + Math.Pow(line1.y2, 2)); 
                if (first > second)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})",
                        line1.x2, line1.y2, line1.x1, line1.y1);
                }
                else if (second > first)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})",
                        line1.x1, line1.y1, line1.x2, line1.y2);
                }
                else {
                    Console.WriteLine("({0}, {1})({2}, {3})",
                       line1.x1, line1.y1, line1.x2, line1.y2);
                }
            }
            else if (length(line1) < length(line2))
            {
                double first = (double)Math.Sqrt(Math.Pow(line2.x1, 2) + Math.Pow(line2.y1, 2));
                double second = (double)Math.Sqrt(Math.Pow(line2.x2, 2) + Math.Pow(line2.y2, 2)); 
                if (first > second)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})",
                        line2.x2, line2.y2, line2.x1, line2.y1);
                }
                else if (second > first)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})",
                        line2.x1, line2.y1, line2.x2, line2.y2);
                }
                else {
                    Console.WriteLine("({0}, {1})({2}, {3})",
                       line2.x1, line2.y1, line2.x2, line1.y2);
                }
            }
            else {

                double first = (double)Math.Sqrt(Math.Pow(line1.x1, 2) + Math.Pow(line1.y1, 2));
                double second = (double)Math.Sqrt(Math.Pow(line1.x2, 2) + Math.Pow(line1.y2, 2)); 
                if (first > second)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})",
                        line1.x2, line1.y2, line1.x1, line1.y1);
                }
                else if (second > first)
                {
                    Console.WriteLine("({0},{1})({2},{3})",
                        line1.x1, line1.y1, line1.x2, line1.y2);
                } else {
                    Console.WriteLine("({0}, {1})({2}, {3})",
                       line1.x1, line1.y1, line1.x2, line1.y2);
                }
            }
        }
    }
}
