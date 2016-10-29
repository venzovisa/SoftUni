using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            num[0] = 1;
            for (int i = 0; i < n; i++)
            {
                int iSum = 0;
                if (i <= k) {
                    for (int x = 0; x <= i; x++)
                    {
                        iSum += num[x];
                    }
                    num[i] = iSum;
                }
                else
                {
                    for (int y = i; y >= i - k; y--)
                    {
                        iSum += num[y];
                    }
                    num[i] = iSum;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(num[i] + " ");
            }
            
        }
    }
}
