using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int iTemp = i;
                while (iTemp > 0)
                {
                    sum += iTemp % 10;
                    iTemp = iTemp / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine(i + " -> True");
                }
                else { Console.WriteLine(i + " -> False"); }
            }
        }
    }
}
