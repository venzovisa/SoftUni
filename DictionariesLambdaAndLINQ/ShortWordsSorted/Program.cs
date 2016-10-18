using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = new char[]{'.' , ':' , ';' , '(' , ')',  '[' , ']', ',' ,'"', '\'', '\\', '/' , '!', '?', ' ' };
            List <string> list = Console.ReadLine()
                .ToLower()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .ToList();                  
            list = list.Where(a => a.Length < 5).OrderBy(a => a).Distinct().ToList();
            Console.WriteLine(string.Join(", ", list));
            

        }   
    }
}
