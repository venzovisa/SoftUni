using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            //int k = int.Parse(Console.ReadLine());
            int[] sum = new int[n.Length];
            int leftCounter = n.Length / 4 - 1;
            int rightCounter = n.Length / 4;
            //Console.WriteLine(n[leftCounter]);
            //Console.WriteLine(n[rightCounter]);
            int sumCounter = 0;
            for (int i = 0; i < n.Length / 4; i++)
            {
                sum[sumCounter] += n[leftCounter] + n[rightCounter];
                sumCounter++;
                leftCounter--;
                rightCounter++;                
            }            
            leftCounter = n.Length - 1;
            rightCounter = n.Length / 2;
            for (int i = n.Length / 2; i < n.Length; i++)
            {
                sum[sumCounter] += n[leftCounter] + n[rightCounter];
                sumCounter++;
                leftCounter--;
                rightCounter++; 
            }
            
            for (int i = 0; i < n.Length / 2; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }
    }
}
