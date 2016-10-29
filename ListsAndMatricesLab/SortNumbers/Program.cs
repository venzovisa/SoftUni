using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> num = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            num.Sort();
            for (int i = 0; i < num.Count; i++)
            {
                Console.Write("{0} ", num[i]);
            }
        }
    }
}
