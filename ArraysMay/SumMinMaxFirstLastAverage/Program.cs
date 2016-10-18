using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumMinMaxFirstLastAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int sum = 0, min = int.MaxValue, max = int.MinValue, first = 0, last = 0; 
            double avr = 0.0;

            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sum += num[i];
                if (num[i] < min) min = num[i];
                if (num[i] > max) max = num[i];               
            }

            first = num[0];
            last = num[n - 1];
            avr = ((double)sum / n) * (double)1.0;
            Console.WriteLine("Sum = {0}\nMin = {1}\nMax = {2}\nFirst = {3}\nLast = {4}\nAverage = {5}", 
                sum, min, max, first, last, avr);
        }
    }
}
