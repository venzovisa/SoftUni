using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] num = input.Split(' ').Select(Int32.Parse).ToArray();
            Console.WriteLine(num[0]);
           /* string input2 = Console.ReadLine();
            int[] num2 = input2.Split(' ').Select(Int32.Parse).ToArray();
            int limit = Math.Max(num.Length, num2.Length);
            int[] sum = new int[limit];
            for (int i = 0; i < limit; i++)
            {              
                sum[i] = num[i % num.Length] + num2[i % num2.Length];
            }

            for (int i = 0; i < limit; i++)
            {
                Console.Write(sum[i] + " ");  
            }*/
        }
    }
}
