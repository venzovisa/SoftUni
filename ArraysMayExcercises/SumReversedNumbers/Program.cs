﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumReversedNumbers
{
    public class Program
    {
        public static string reverse(string str){
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
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(reverse(input[i]));
            }
            Console.WriteLine(sum);
        }
    }
}
