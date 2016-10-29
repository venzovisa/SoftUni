using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
         List<double> num = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

           while (num.Count > 1)
           {
               for (int i = 1; i < num.Count; i++)
               {
                   if (num[i] == num[i - 1])
                   {
                       num.Insert(i - 1, num[i] + num[i-1]);
                       num.RemoveRange(i, 2);
                   }
               }
               
              if (num.Count == 2 && (num[0] != num[1])) break;
           }
           for (int i = 0; i < num.Count; i++)
           {
               Console.WriteLine("{0}", num[i]);
           }
        }
    }
}
