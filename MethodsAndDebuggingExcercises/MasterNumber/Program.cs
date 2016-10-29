using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterNumber
{
    class Program
    {
        public static bool palindrome (int num){
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
                return true;
            } else return false;
        }
     
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPalindrome = false;
            //bool isDivisibleSumBy7 = false;
            bool hasEvenDigit = false;

            for (int i = 1; i < n; i++)
            {
                string num = i.ToString();
                isPalindrome = palindrome(i);
                int iTemp = i;
                int sum = 0;
                while (iTemp > 0) { 
                    if ((iTemp % 10) % 2 == 0) hasEvenDigit = true;
                    sum += iTemp % 10;
                    iTemp /= 10;
                }
                
                if ((sum % 7 == 0) && isPalindrome && hasEvenDigit)
                    Console.WriteLine(i);
                isPalindrome = false;
                hasEvenDigit = false;
            }
        }
    }
}
