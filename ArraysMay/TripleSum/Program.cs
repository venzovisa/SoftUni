using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            
            int[] num = input.Split(' ').Select(Int32.Parse).ToArray();         
            bool equal = false;
            for (int i = 0; i < num.Length; i++)
            {
                for (int y = 0; y < num.Length; y++)
                {
                    for (int z = 0; z < num.Length; z++)
                    {
                        if (num[i] + num[y] == num[z] && y > i)
                        {
                            Console.WriteLine("{0} + {1} == {2}", num[i], num[y], num[z]);
                            equal = true;
                        }
                    }
                }
            }
            if (equal == false) Console.WriteLine("No");
            
        }
    }
}
