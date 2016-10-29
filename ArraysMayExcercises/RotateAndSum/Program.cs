using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[n.Length];
            for (int i = 0; i < k; i++)
            {
                int xLast = n[n.Length - 1];              
                for (int x = n.Length - 1; x > 0 ; x--)
                {
                    sum[x] += n[x-1];
                    n[x] = n[x-1];
                    
                }                
                n[0] = xLast;
                sum[0] += n[0];
            }
            for (int i = 0; i <= n.Length- 1 ; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }
    }
}
