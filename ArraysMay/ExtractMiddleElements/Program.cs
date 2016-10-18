using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] num = input.Split(' ').Select(Int32.Parse).ToArray();
            Console.Write("{ ");
            if (num.Length == 1) {               
                Console.Write("{0}", num[0]);                             
            }
            else  if (num.Length % 2 == 0) {
                Console.Write("{0}, {1}", num[num.Length / 2 - 1], num[num.Length / 2]);
            } else {
                Console.Write("{0}, {1}, {2}", num[num.Length / 2 - 1], num[num.Length / 2], num[num.Length / 2 + 1]);
            }
            Console.Write(" }");
            Console.WriteLine();
        }
    }
}
