using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();           
            int mostFrequent = int.MinValue;
            int mostCounter = int.MinValue;

                for (int i = 0; i < num.Length; i++)
                {
                    int temp = 0;
                    for (int x = 0; x < num.Length; x++)
                    {
                        if (num[i] == num[x])
                        {
                            temp++;
                        }
                        else 
                        {
                            if (temp > mostCounter) {
                                mostCounter = temp;
                                mostFrequent = num[i];
                            }                           
                            temp = 0;                                                           
                        }
                    }
                }

                if (mostFrequent > 0 || mostCounter > 0)
                {
                    for (int i = 0; i < mostCounter; i++)
                    {
                        Console.Write(mostFrequent + " ");
                    }
                }
                else {
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.Write(num[i] + " ");
                    }
                }                                              
        }
    }
}