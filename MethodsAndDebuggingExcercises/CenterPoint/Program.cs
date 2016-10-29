using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenterPoint
{
    class Line
    {
        public int x;
        public int y;
            
    }
    class Program
    {
        static double length(Line line)
        {
            double a, b, c;
            a = 0 - line.x;
            b = 0 - line.y;
            c = (double)Math.Sqrt(a * a + b * b);
            return c;
        }

        static void Main(string[] args)
        {
            Line line1 = new Line();
            Line line2 = new Line();

            line1.x = int.Parse(Console.ReadLine());
            line1.y = int.Parse(Console.ReadLine());           
            line2.x = int.Parse(Console.ReadLine());
            line2.y = int.Parse(Console.ReadLine());
           
            if (length(line1) > length(line2))
            {
                Console.WriteLine("({0}, {1})", line2.x, line2.y);
            }
            else if (length(line1) <= length(line2)) { Console.WriteLine("({0}, {1})", line1.x, line1.y); }
          
        } 
    }
}
