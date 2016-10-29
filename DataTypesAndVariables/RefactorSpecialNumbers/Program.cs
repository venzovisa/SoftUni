using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0; int temp = 0; bool check = false;
            for (int i = 1; i <= number; i++)
            {
                temp = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
            }
            check = (total == 5) || (total == 7) || (total == 11);
            Console.WriteLine("{0} -> {1}", temp, check );
            total = 0;
            i = temp;
}

        }
    }
}
