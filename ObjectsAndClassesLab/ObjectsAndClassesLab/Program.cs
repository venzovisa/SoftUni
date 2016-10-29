using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();          
            int[] splitDate = date.Split('-').Select(int.Parse).ToArray();
            DateTime dt = new DateTime(splitDate[2], splitDate[1], splitDate[0]);
            Console.WriteLine(dt.DayOfWeek);
        }
    }
}
