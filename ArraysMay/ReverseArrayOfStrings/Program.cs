using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] str = input.Split();

            int right = str.Length - 1;
            for (int i = 0; i < str.Length / 2; i++)
            {
                string temp = str[i];
                str[i] = str[right];
                str[right] = temp;
                right--;
            }

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }
    }
}
