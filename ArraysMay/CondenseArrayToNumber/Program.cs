using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] num = input.Split(' ').Select(Int32.Parse).ToArray();
            
            int sum = 0;
            if (num.Length == 1) {
                Console.WriteLine(num[0]);
            }
            else {
                while (num.Length > 1) {
                    int[] condensed = new int[num.Length - 1];
                    for (int i = 0; i < num.Length - 1; i++)
                    {
                        condensed[i] = num[i] + num[i + 1];
                    }
                    num = condensed;
                }
                
                for (int i = 0; i < num.Length; i++)
                {
                    sum += num[i];
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
