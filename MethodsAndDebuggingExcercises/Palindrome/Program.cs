using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = num;
            int rev = 0;
            while (num > 0)
            {
                int dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }
            if (n == rev)
            {
                Console.WriteLine("palindrome");
            }
            else { Console.WriteLine("its not"); }
        }
    }
}
