using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathPower
{
    class Program
    {
        static double power(double b, double p) {
            double pVal = Math.Pow(b, p);
            return pVal;
        }
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine(power(b, p));
        }
    }
}
