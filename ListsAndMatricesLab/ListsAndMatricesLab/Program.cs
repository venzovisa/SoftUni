using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            List<int> result = new List<int>();
            foreach (int n in num) {
                if (n > 0)
                {
                    result.Add(n);
                }
            }

            result.Reverse();

            if (result.Count == 0) {
                Console.WriteLine("empty");
            }
            else {
                foreach (int r in result)
                {
                    Console.Write(r + " ");
                }
            }            
        }
    }
}
