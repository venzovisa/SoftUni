using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var row1 = list.Take(list.Count / 4)
                          .Reverse()
                          .Concat(list
                            .Skip(list.Count / 2 + list.Count / 4)
                            .Reverse()).ToList();
            var row2 = list
                .Skip(list.Count / 4)
                .Take(list.Count / 2).ToList();
            List<int> sum = new List<int>();
            for (int i = 0; i < row1.Count; i++)
            {
                sum.Add(row1[i] + row2[i]);
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
