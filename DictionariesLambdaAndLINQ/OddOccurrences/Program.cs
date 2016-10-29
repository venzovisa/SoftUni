using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var li in list)
            {
                if (counts.ContainsKey(li))
                {
                    counts[li]++;
                }
                else counts[li] = 1;
            }

            List<string> odd = new List<string>();
            foreach (var count in counts)
            {
                if (count.Value % 2 == 1 ) odd.Add(count.Key);
            }


            for (int i = 0; i < odd.Count; i++ )
            {
                Console.Write(odd[i]);
                if (i != odd.Count - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
