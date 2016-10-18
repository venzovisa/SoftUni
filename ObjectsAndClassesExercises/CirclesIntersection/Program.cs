using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CirclesIntersection
{
    public class Circle {
        public int radius, x, y;
    }
    public class Program
    {
        static double dist(Circle c1, Circle c2)
        {
            double a, b, c;
            a = c1.x - c2.x;
            b = c1.y - c2.y;
            c = Math.Sqrt(a * a + b * b);
            return c;
        }

        public static void intersect(Circle c1, Circle c2){
            if (dist(c1, c2) <= c1.radius + c2.radius)
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }
        }


        public static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle();
            int[] input = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            c1.x = input[0];
            c1.y = input[1];
            c1.radius = input[2];
            input = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            c2.x = input[0];
            c2.y = input[1];
            c2.radius = input[2];
            intersect(c1, c2);
        }
    }
}
