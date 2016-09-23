using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloName
{
    class Program
    {
        static string helloName(string name) {
            return "Hello, " + name + "!";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(helloName(Console.ReadLine()));
        }
    }
}
