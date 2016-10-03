using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(num);
            int max = 1;
            int prev = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (prev == num[i]) { max++; }
                else {
                    Console.WriteLine("{0} -> {1}", prev, max);
                    prev = num[i];
                    max = 1;
                }
            }
            Console.WriteLine("{0} -> {1}", prev, max);
        }
    }
}