using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            int right = n-1;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = num[i];
                num[i] = num[right];
                num[right] = temp;
                right--;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(num[i] + " ");
            }
            
        }
    }
}
