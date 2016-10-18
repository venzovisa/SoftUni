using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static int evenSum(int n)
        {
            int temp = 0;
            int sum = 0;
            while (n > 0)
            {
                temp = n % 10;
                n = n / 10;
                if (temp % 2 == 0) sum += temp;
            }
            return sum;
        }

        static int oddSum(int n)
        {
            int temp = 0;
            int sum = 0;
            while (n > 0)
            {
                temp = n % 10;
                n = n / 10;
                if (temp % 2 > 0) sum += temp;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            Console.WriteLine(evenSum(n) * oddSum(n));
        }
    }
}
