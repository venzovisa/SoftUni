using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreaterOfTwoValues
{
    class Program
    {
        static int getMax(int a, int b) {
            return Math.Max(a, b);
        }

        static double getMax(double a, double b)
        {
            return Math.Max(a, b);
        }

        static string getMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0) { return a; }
            else return b;
        }

        static char getMax(char a, char b)
        {
            if ((int)a > (int)b) { return a; }
            else return b;
        }

        static void Main(string[] args)
        {
            string typeCheck = Console.ReadLine();
            if (typeCheck == "int") {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(getMax(a, b));
            }
            else if (typeCheck == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(getMax(a, b));
            }
            else if (typeCheck == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(getMax(a, b));
            }
            else if (typeCheck == "double")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(getMax(a, b));
            }                        
        }
    }
}
