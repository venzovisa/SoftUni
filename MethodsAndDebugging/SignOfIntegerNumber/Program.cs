using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void printSign(int num) {
            string message = "";

            if (num > 0) { message = "positive"; }
            else if (num == 0) { message = "zero"; }
            else {message = "negative";}

            Console.WriteLine("The number {0} is {1}.", num, message);
        }
        static void Main(string[] args)
        {
            printSign(int.Parse(Console.ReadLine()));
        }
    }
}
