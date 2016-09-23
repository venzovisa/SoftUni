using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] num = Console.ReadLine().ToCharArray();

            int right = num.Length - 1;
            for (int i = 0; i < num.Length / 2; i++)
            {
                char temp = num[i];
                num[i] = num[right];
                num[right] = temp;
                right--;
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
            }
            
        }
    }
}
