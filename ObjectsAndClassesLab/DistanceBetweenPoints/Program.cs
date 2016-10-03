using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistanceBetweenPoints
{
    class Point {         
       public int x;
       public int y;                
    }

    class Program
    {
        static double dist(Point p1, Point p2) {
            double a, b, c;
            a = p1.x - p2.x;
            b = p1.y - p2.y;
            c = Math.Sqrt(a * a + b * b);
            return c;
        }
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();            
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            p1.x = input[0];
            p1.y = input[1];
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            p2.x = input[0];
            p2.y = input[1];
            Console.WriteLine("{0:f3}", dist(p1, p2));
        }
    }
}
