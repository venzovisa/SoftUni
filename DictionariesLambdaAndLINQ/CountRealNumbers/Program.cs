using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List <double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var li in list) {
                if (counts.ContainsKey(li)) {
                    counts[li]++;}
                    else counts[li] = 1;                
            }

            foreach (var count in counts) {
                Console.WriteLine("{0} -> {1}", count.Key, count.Value);
            }
        }
    }
}
