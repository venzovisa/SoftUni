using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EqualSums
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            bool equalCheck = false;
            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int l = 0; l < i; l++)
                {
                    leftSum += input[l];
                }

                for (int r = i + 1; r < input.Length; r++)
                {
                    rightSum += input[r];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    equalCheck = true;
                }              
            }
            if (equalCheck == false) { Console.WriteLine("no"); }
        }
    }
}
