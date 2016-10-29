using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().ToLower().Split(' ').Select(int.Parse).ToList();
            list = list.OrderByDescending(x => x).Take(3).ToList();
            foreach (var item in list)
            {
                Console.Write(item + " ");   
            }
        }
    }
}
