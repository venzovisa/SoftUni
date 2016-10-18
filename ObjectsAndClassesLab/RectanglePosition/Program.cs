using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectanglePosition
{
    public class Rectangle {
        public int top, left, width, height, bottom, right;
    }    

    public class Program
    {
        public static void isInside(Rectangle r1, Rectangle r2)
        {
            r1.right = r1.left + r1.width;
            r1.bottom = r1.top + r1.height;
            r2.right = r2.left + r2.width;
            r2.bottom = r2.top + r2.height;
            if ((r1.left >= r2.left) &&
                (r1.right <= r2.right) &&
                (r1.top <= r2.top) &&
                (r1.bottom <= r2.bottom)) { 
                Console.WriteLine("Inside");
            }
            else { Console.WriteLine("Not inside"); }           
        }

        public static void readRect(Rectangle r1, Rectangle r2)
        {            
            int[] input = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            r1.left = input[0];
            r1.top = input[1];
            r1.width = input[2];
            r1.height = input[3];
            input = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            r2.left = input[0];
            r2.top = input[1];
            r2.width = input[2];
            r2.height = input[3];           
        }

        public static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            readRect(r1, r2);
            isInside(r1, r2);
        }
    }
}
