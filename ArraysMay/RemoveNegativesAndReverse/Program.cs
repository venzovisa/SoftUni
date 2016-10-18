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
            string input = Console.ReadLine();
            int[] num = input.Split(' ').Select(Int32.Parse).ToArray();
            List<int> list = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= 0) list.Add(num[i]);
            }
            if (list.Count > 0)
            {
                list.Reverse();
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + " ");
                }
            }
            else {
                Console.WriteLine("empty");
            }
            

        }
    }
}
