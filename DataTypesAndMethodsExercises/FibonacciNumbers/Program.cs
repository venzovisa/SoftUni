using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace FibonacciNumbers
{
    class Program
    {
        static List<BigInteger> fib(int n) { 
            List <BigInteger> list = new List<BigInteger>();
            if (n == 0) { Console.WriteLine(1); }
            else if (n == 1) { Console.WriteLine(1); }
            else
            {
                {
                    BigInteger first = 0;
                    BigInteger second = 1;
                    BigInteger third = 0;
                    for (int i = 0; i < n; i++)
                    {
                        third = first + second;
                        list.Add(third);
                        first = second;
                        second = third;
                    }
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BigInteger> list2 = fib(n);
            /*for (int i = 0; i < list2.Count; i++ )
            {
                Console.Write(list2[i] + " ");
            }*/
            if (n > 1)
            Console.Write(list2.Last());
        }
    }
}
