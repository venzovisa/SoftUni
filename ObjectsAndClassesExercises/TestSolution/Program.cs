using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] data = "Ani Kirilova | ani88@abv.bg | 27-May-2016".Split('|');
            string format = "dd-MMM-yyyy";
            string date = data[2].Trim();           
            DateTime studentDate = DateTime.ParseExact(date, format, null);
            Console.WriteLine("{0}", studentDate.ToString("dd-MMM-yyyy"));
        }
    }
}
