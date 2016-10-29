using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosestTwoPoints
{
    class Point {
        public int x;
        public int y;
    }
    class Program
    {
        // distance between two points
        static double dist(Point p1, Point p2)
        {
            double a, b, c;
            a = p1.x - p2.x;
            b = p1.y - p2.y;
            c = Math.Sqrt(a * a + b * b);
            return c;
        }

        static double closestPoints(Point[] aP, Point[] cP) { 
            double minDistance = double.MaxValue;
          
            // compare distance between every two points
            for (int i = 0; i < aP.Length; i++)
			{
                for (int x = 0; x < aP.Length; x++)
                {
                    double tempDistance = dist(aP[i], aP[x]);
                    if ( tempDistance < minDistance && i != x )
                    {
                        cP[0] = aP[i];
                        cP[1] = aP[x];                        
                        minDistance = tempDistance;
                    }                   	
                }            		 
			}
            return minDistance;         
        }
        
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Point[] aPoints = new Point[num];// all points
            Point[] cPoints = new Point[3]; // closest points
            // assign values
            for (int i = 0; i < num; i++)
            {
                Point newCoords = new Point();
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                newCoords.x = input[0];
                newCoords.y = input[1];
                aPoints[i] = newCoords;
            }
            // print closest points and their distance
            Console.WriteLine("{0:f3}", closestPoints(aPoints, cPoints));
            Console.WriteLine("({0}, {1})", cPoints[0].x, cPoints[0].y);
            Console.WriteLine("({0}, {1})", cPoints[1].x, cPoints[1].y);                       
        }
    }
}
