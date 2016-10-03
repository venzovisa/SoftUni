using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int equal = int.Parse(Console.ReadLine());

            int equalCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int x = 0; x < input.Length; x++)
                {
                    if (input[i] - input[x] == equal)
                    {
                        equalCount++;                     
                    }
                }               
            }           
                Console.WriteLine(equalCount);            
        }
    }
}
