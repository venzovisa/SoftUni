using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinMaxSumAverage
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
			{
                arr[i] = int.Parse(Console.ReadLine());	 
			}
            Console.WriteLine("Sum = {0}", arr.Sum());
            Console.WriteLine("Min = {0}", arr.Min());
            Console.WriteLine("Max = {0}", arr.Max());
            Console.WriteLine("Average = {0}", arr.Average());
        }
    }
}
