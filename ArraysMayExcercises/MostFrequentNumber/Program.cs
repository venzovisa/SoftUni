using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int mostFrequent = 0;
            int mostCounter = 0;
            int mostIndex = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int temp = 0;
                for (int x = 0; x < num.Length; x++)
                {
                    if (num[i] == num[x]) temp++;
                }
                if (temp > mostCounter)
                {
                    mostFrequent = num[i];
                    mostCounter = temp;
                    mostIndex = i;
                }
                else if (temp == mostCounter){
                    mostFrequent = num[Math.Min(mostIndex, i)];
                    mostIndex = Math.Min(mostIndex, i);
                }
            }
            Console.WriteLine(mostFrequent);
        }
    }
}
