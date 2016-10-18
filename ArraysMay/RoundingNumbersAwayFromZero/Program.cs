using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math.Round(posValue, 1, MidpointRounding.AwayFromZero);
            string input = Console.ReadLine();
            double[] num = input.Split(' ').Select(Double.Parse).ToArray();
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("{0} => {1}", num[i], Math.Round(num[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
