using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeclaringAndInvokingMethods
{
    class Program
    {
        static void header() {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void body() {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void footer() {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        static void blankCash() {
            header();
            body();
            footer();
        }

        static void Main(string[] args)
        {
            blankCash();
        }
    }
}
