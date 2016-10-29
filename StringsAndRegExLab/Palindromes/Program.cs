using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    class Program
    {
        public static string reverse(string str)
        {
            char[] arr = str.ToArray();
            int right = str.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[right];
                arr[right] = temp;
                right--;
            }
            string returnVal = "";
            for (int i = 0; i < arr.Length; i++)
            {
                returnVal += arr[i];
            }

            return returnVal;
        }
        public static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(new char[]{' ', ',','.', '?','!'}, 
                 StringSplitOptions.RemoveEmptyEntries).ToList();
            text = text.Distinct().OrderBy(a => a).ToList();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i] == reverse(text[i])) {
                    result.Append(text[i] + ", ");
                }               
            }
            result.Remove(result.Length - 2, 1);
            Console.WriteLine(result);
        }       
    }
}
