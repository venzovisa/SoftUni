using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubeProperties
{
    public class Cube
    {
        static double face(double a) { return (double)a * Math.Sqrt(2); }
        static double volume(double a) { return (double)Math.Pow(a, 3); }
        static double space(double a) { return (double)a * Math.Sqrt(3); }
        static double area(double a) { return (double)(6 * Math.Pow(a, 2)); }
       public  static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            string command= Console.ReadLine().ToLower();
            switch (command) {
                case "face": { Console.WriteLine("{0:f2}", face(n)); break; }
                case "space": { Console.WriteLine("{0:f2}", space(n)); break; };
                case "volume": { Console.WriteLine("{0:f2}", volume(n)); break; };
                case "area": { Console.WriteLine("{0:f2}", area(n)); break; };
                default: { Console.WriteLine("Error"); break; }
            }
        }
    }
}
