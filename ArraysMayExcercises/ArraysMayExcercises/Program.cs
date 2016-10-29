using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestCommonEnd
{
    class Program

    {

        static int findMax(string[] str1, string[] str2, int limit) {
            int equalCount = 0;
            int max = 0;
            for (int i = 0; i < limit; i++)
            {
                if (str1[i] == str2[i])
                {
                    equalCount++;
                    if (equalCount > max) max = equalCount;
                }
                else
                {
                    equalCount = 0;
                }
            }
            equalCount = 0;
            
            return max;
        }

        static void reverse(string[] str) {
            int right = str.Length - 1;
            for (int i = 0; i < str.Length / 2; i++)
            {
                string temp = str[i];
                str[i] = str[right];
                str[right] = temp;
                right--;
            }
        }


        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ').ToArray();
            string[] str2 = Console.ReadLine().Split(' ').ToArray();
            int limit = Math.Min(str1.Length, str2.Length);           
            int maxLeft = findMax(str1, str2, limit);
            reverse(str1); reverse(str2);
            int maxRight = findMax(str1, str2, limit);
            Console.WriteLine(Math.Max(maxLeft, maxRight));
      
        }
    }
}
