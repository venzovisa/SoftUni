using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", num1);
            Console.WriteLine("b = {0}", num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", num1);
            Console.WriteLine("b = {0}", num2);
        }
    }
}
