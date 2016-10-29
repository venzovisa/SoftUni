using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double diff = Math.Abs(num1 - num2);
            double eps = 0.000001;
            if (eps > diff) { Console.WriteLine("True"); } 
            else { Console.WriteLine("False"); }
        }
    }
}
