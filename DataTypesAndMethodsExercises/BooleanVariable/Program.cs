using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = Convert.ToBoolean(Console.ReadLine());
            if (input) { Console.WriteLine("Yes"); } else {
                Console.WriteLine("No");
            }
            
        }
    }
}
